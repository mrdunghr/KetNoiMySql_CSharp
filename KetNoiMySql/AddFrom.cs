using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetNoiMySql
{
    public partial class AddFrom : Form
    {
        public AddFrom()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string authen = txt_authenType.Text;

            DateTime currentTime = DateTime.Now;
            string time = currentTime.ToString("yyyy-MM-dd HH:mm:ss");

            string email = txt_Email.Text;

            bool enabled = checkBoxEnabled.Checked;

            string money = txt_Money.Text;
            string pass = txt_Password.Text;
            string phone = txt_Phone.Text;
            string user = txt_Username.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập tên và email.");
                return;
            }
            // Chuỗi kết nối
            string constr = "server=localhost;user=root;password=1111;database=mulan_auto;port=3306;";

            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                conn.Open();

                // Chuỗi SQL để thêm dữ liệu vào cơ sở dữ liệu
                string insertSql = "INSERT INTO customer (authentication_type, created_time, email, enabled, money, otp, password, phone, username) " +
                    "VALUES (@authen, @time, @email, @enabled, @money, '', @pass, @phone, @user)";
                using (MySqlCommand cmd = new MySqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@authen", authen);
                    cmd.Parameters.AddWithValue("@time", time);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@enabled", enabled);
                    cmd.Parameters.AddWithValue("@money", money);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@user", user);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dữ liệu đã được thêm thành công.");
                        this.Close(); // Đóng form sau khi thêm thành công
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm dữ liệu.");
                    }
                }
                conn.Close();
            }
        }
    }
}
