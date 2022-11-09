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
    public partial class login : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=rachatashop;");
        public login()
        {
            InitializeComponent();
        }
        public static int aaaaaa;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            register log = new register();
            log.Show();
            this.Hide();
        }

        private bool check(string username, string password)
        {
            conn.Close();
            //ตรวจสอบจากregisterว่ามีusernameที่เราจะเช็คไหมและจะดึงข้อมูลรหัสผ่านมาว่าตรงตามที่เรากรอกไหม
            string sql = "SELECT * FROM register WHERE username = '" + username + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            string pw = "";
            while (reader.Read())
            {
                pw = reader.GetString("password");
            }

            if (pw == password)
            {
                return true;
            }

            conn.Close();
            return false;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }
            else
            {
                string adminUser = "Rachata1235";
                string adminPw = "0616315367";
                if (textBoxUsername.Text == adminUser && textBoxPassword.Text == adminPw)
                {
                    this.Hide();
                    admin log = new admin();
                    log.Show();
                }
                else
                {
                    if (check(textBoxUsername.Text, textBoxPassword.Text))
                    {

                        if (check(textBoxUsername.Text, textBoxPassword.Text))
                        {
                            MessageBox.Show("ยืนยันสำเร็จ");
                            store log = new store();
                            log.Show();
                            this.Hide();
                            register.FiveRachata = textBoxUsername.Text;
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบผู้ใช้");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบผู้ใช้");
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}
