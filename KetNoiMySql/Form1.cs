using MySql.Data.MySqlClient;
using System.Data;

namespace KetNoiMySql
{
    public partial class Form1 : Form
    {
        string constr;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            constr = "server=localhost;user=root;password=1111;database=" + txt_dbname.Text + ";port=3306;";
            conn = new MySqlConnection(constr);
            conn.Open();
            cmd = new MySqlCommand("select * from customer", conn);
            adt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            conn.Open();
            cmd = new MySqlCommand("select * from customer", conn);
            adt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddFrom addFrom = new AddFrom();
            addFrom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}