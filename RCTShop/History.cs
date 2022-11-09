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


namespace RCTShop
{
    public partial class History : Form
    {
    
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rachatashop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showdataGridView1()
        {   //เป็นการดึงข้อมูลจากดาต้าเบสมาใส่ในดาต้ากริดวิว
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM history";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        public History()
        {
            InitializeComponent();
            showdataGridView1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin log = new admin();
            log.Show();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void history_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //วันที่เวลา
        {
            textBox2.Text = "0";
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            //เป็นการหาวันที่เวลาที่ซื้อขายจาก from  history 
            cmd.CommandText = ($"SELECT * FROM history WHERE date >= '{dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")}' AND date <= '{dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss")}'");
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                MySqlConnection conn2 = databaseConnection();
                conn2.Open();
                MySqlCommand cmd2;
                cmd2 = conn2.CreateCommand(); // เอาราคา ในระหว่างวันนั้นๆที่เราเลือกในปฏิทินมารวมกัน
                //เอายอดขายระหว่างวันที่ที่เราเลือกมาคำนวณราคายอดขายทั้งหมด
                cmd2.CommandText = ($"SELECT * FROM history WHERE date >= '{dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")}' AND date <= '{dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss")}'");
                MySqlDataReader dr2 = cmd2.ExecuteReader();
                int x = 0;
                while (dr2.Read())
                {
                    x += dr2.GetInt32(4);
                    // จะ select ข้อมูล history จากช่องที่ 4 ในดาต้าเบสมาและเพิ่มเข้าไปในตัวแปร x และจะวนลูปในช่วงเวลาที่เราเลือกและนำไปเซตใน textbox2
                }
                conn2.Close();
                textBox2.Text = x.ToString();
            }


            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void History_Shown(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
