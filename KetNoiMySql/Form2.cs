using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KetNoiMySql
{
    public partial class Form2 : Form
    {
        string constr;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adt;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            constr = "server=localhost;user=root;password=1111;database=" + txt_dbname.Text + ";port=3306;";
            conn = new MySqlConnection(constr);
            conn.Open();
            cmd = new MySqlCommand("select * from key_gen", conn);
            adt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
