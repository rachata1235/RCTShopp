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
    public partial class register : Form
    {

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rachatashop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public register()
        {
            InitializeComponent();
        }

        private bool checkusername(string username)
        {//เป็นการลูปเพื่อเช็คว่ามียูสเซอร์นั้นแล้วหรือยัง ถ้ามียูสเซอร์เนมแล้วจะ return true
            string sql = "SELECT * FROM register";
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=rachatashop;");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (reader.Read())
            {
                list.Add(reader.GetString("username"));
            }

            foreach (string i in list)
            {
                if (i == username)
                {
                    return true;
                }
            }

            conn.Close();

            return false;
        }
        private void surname_Click(object sender, EventArgs e)
        {

        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "" || textBox_name.Text == "" || textBox_surname.Text == "" || textBox_TEL.Text == "" || textBox_address.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }
            else
            {    //จากบรรทัดที่ 52
                if (checkusername(textBox_username.Text) == false)
                {
                    if (textBox_TEL.Text.Length == 10)
                    {//เป็นการนำข้อมูลที่กรอกไปใส่ในตารางรีจิสเตอร์
                        MySqlConnection conn = databaseConnection();
                        String sql = "INSERT INTO register (username,password,name,surname,TEL,address) VALUES('" + textBox_username.Text + "','" + textBox_password.Text + "','" + textBox_name.Text + "','" + textBox_surname.Text + "','" + textBox_TEL.Text + "','" + textBox_address.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        conn.Open();

                        int rows = cmd.ExecuteNonQuery();

                        conn.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show("ลงทะเบียนสำเร็จ");
                        }
                        this.Hide();
                        login log = new login();
                        log.Show();
                    }
                    else
                    {
                        MessageBox.Show("กรุณาใส่เบอร์โทรให้ครบ 10 ตัว");
                    }
                }
                else
                {
                    MessageBox.Show("กรุณาใช้ชื่ออื่น");
                }
            }

        }
        public static string FiveRachata = "rachata1235";

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void textBox_TEL_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TEL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_TEL.Text.Length == 10)
            {

            }
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_username_KeyPress(object sender, KeyPressEventArgs e)
        {//กรอกได้แค่ภาษาอังกฤษ
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {//กรอกไม่ได้แค่ภาษาไทย
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
    
}
