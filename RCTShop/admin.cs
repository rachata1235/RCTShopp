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
    public partial class admin : Form
    {//ประกาศตัวแปรโดยดึงข้อมูลจากดาต้าเบส
        private MySqlConnection DatabaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rachatashop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        
        }

        private void ShowEquiment(string sql)
        {//เป็นการดึงข้อมูลจากดาต้าเบสมาใส่ในดาต้ากริดวิว

            MySqlConnection conn = DatabaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();

            cmd.CommandText = sql;



            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        public admin()
        {
            InitializeComponent();
        }


        private void admin_Load(object sender, EventArgs e)
        {
            ShowEquiment("SELECT * FROM stock");
            
        }

        int EditId;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                login log = new login();
                log.Show();
            }
        }

        private void admin_Shown(object sender, EventArgs e)
        {
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void History_Click(object sender, EventArgs e)
        {
            this.Hide();
            History log = new History();
            log.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {    //เป็นการ insert ข้อมูลเข้าสต๊อคสินค้า
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && lab_path.Text != "")
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rachatashop;";
                MySqlConnection conn = new MySqlConnection(connectionString);
                String sql = "INSERT INTO stock (name,price,amount,picture) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + lab_path.Text.Replace("\\","\\\\") + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("เพิ่มสินค้าเรียบร้อยแล้ว");
                    ShowEquiment("SELECT * FROM stock");
                }

            }
        }
        //name like คือชื่อที่คล้ายกับอักษรที่เรากรอก
        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShowEquiment("SELECT * FROM stock WHERE name Like '" + "%" + Search.Text + "%" + "'");
        }

        private void Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)| *.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)    /*เป็นที่ที่เราคลิ๊กเพื่อเปิดโฟลเดอร์รูปภาพ ตามประเภทต่างๆของไฟล์ภาพ*/
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                lab_path.Text = open.FileName;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {    //เป็นการแก้ไขชื่อ จำนวน ราคา 
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rachatashop;";
                MySqlConnection conn = new MySqlConnection(connectionString);
                String sql = "UPDATE stock SET picture='"+ lab_path.Text.Replace("\\", "\\\\") + "',name = '" + textBox1.Text + "',price = '" + textBox2.Text + "',amount = '" + textBox3.Text + "' WHERE id = '" + EditId + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("แก้ไขสินค้าเรียบร้อยแล้ว");
                    ShowEquiment("SELECT * FROM stock");
                }

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rachatashop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            String sql = "DELETE FROM stock WHERE id = '" + EditId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("ลบสินค้าเรียบร้อยแล้ว");
                ShowEquiment("SELECT * FROM stock");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {   //เป็นการเช็คข้อมูลในตารางดาต้ากริดวิว เมื่อกดแถวไหนข้อมูลแถวนั้นก็จะเด้งขึ้นมา
                dataGridView1.CurrentRow.Selected = true;
                int selectedRow = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["id"].FormattedValue.ToString());
                string name = dataGridView1.Rows[selectedRow].Cells["name"].FormattedValue.ToString();
                int price = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["price"].FormattedValue.ToString());
                int amount = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["amount"].FormattedValue.ToString());
                pictureBox1.LoadAsync(dataGridView1.Rows[e.RowIndex].Cells["picture"].FormattedValue.ToString());

                EditId = id;
                textBox1.Text = name;
                textBox2.Text = price.ToString();
                textBox3.Text = amount.ToString();
            }
            catch
            {

            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
