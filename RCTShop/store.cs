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
    public partial class store : Form
    {
        
        public store()
        {
            InitializeComponent();
        }
        private void dataGridViewshow()
        {

            MySqlConnection conn_ = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=rachatashop;");
            DataSet ds = new DataSet();
            conn_.Open();

            MySqlCommand cmd_;
            cmd_ = conn_.CreateCommand();
            cmd_.CommandText = "SELECT * FROM `stock`";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd_);
            adapter.Fill(ds);
            conn_.Close();
            dataGridView1.DataSource = ds.Tables[0];

          
            ds = new DataSet();
            conn_.Open();

            
            cmd_ = conn_.CreateCommand();
            cmd_.CommandText = $"SELECT * FROM `history` WHERE username = '{register.FiveRachata}' and status = 0";

            adapter = new MySqlDataAdapter(cmd_);
            adapter.Fill(ds);
            conn_.Close();
            dataGridView2.DataSource = ds.Tables[0];
        }
        string id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {  //เป็นการเช็คข้อมูลในตารางดาต้ากริดวิว เมื่อกดแถวไหนข้อมูลแถวนั้นก็จะเด้งขึ้นมา
            dataGridView1.CurrentRow.Selected = true;
            id = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
             nametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            pricetextBox.Text= dataGridView1.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
            pictureBox1.LoadAsync(dataGridView1.Rows[e.RowIndex].Cells["picture"].FormattedValue.ToString());

        }

        private void store_Shown(object sender, EventArgs e)
        {
            dataGridViewshow();
        }
        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=rachatashop;";
        string sql;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader reader;
        int balances;
        private void Addtocart_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                sql = $"SELECT * FROM stock WHERE id = '{id}' ";
                con = new MySqlConnection(conn);
                cmd = new MySqlCommand(sql, con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                { //select from stock มาละเช็คว่าเหลือสินค้าเท่าไร ละนำสินค้าที่มีมาลบกับสินค้าที่เราเลือก
                    balances = reader.GetInt32("amount") - Convert.ToInt32(numericUpDown1.Value);
                    if (balances >= 0)
                    {   //update ละเซตจำนวนของที่เหลือ
                        sql = $"UPDATE `stock` SET `amount` = '{balances}' WHERE id = '{id}'";
                        con = new MySqlConnection(conn);
                        cmd = new MySqlCommand(sql, con);
                        con.Open();
                        int rows1_ = cmd.ExecuteNonQuery();
                        con.Close();
                              //insertข้อมูลที่เราสั่งเข้าไปใน history
                        sql = $"INSERT INTO `history` (`username`, `name`, `amount`, `price`, `date`, `status`,`size`) " +
                            $"VALUES ('{register.FiveRachata}', '{nametextBox.Text}', " +
                            $"'{Convert.ToInt32(numericUpDown1.Value)}', " +
                            $"'{Convert.ToInt32(numericUpDown1.Value)* Convert.ToInt32(pricetextBox.Text)}', " +
                            $"'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '0','{comboBox1.Text}');";
                        con = new MySqlConnection(conn);
                        cmd = new MySqlCommand(sql, con);
                        con.Open();
                        int rows4 = cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("เพิ่มลงในตะกร้า");
                        dataGridViewshow();
                    }
                    else
                    {
                        MessageBox.Show("หมด");
                    }
                }
                
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true;
            id = dataGridView2.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
        }

        private void repair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                sql = $"DELETE FROM history WHERE id = '{id}'";
                con = new MySqlConnection(conn);
                cmd = new MySqlCommand(sql, con);
                con.Open();
                int rows1_ = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DELETE");
                dataGridViewshow();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        private void pay_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            sql = $"UPDATE `history` SET `status` = '1' WHERE username = '{register.FiveRachata}' and status = 0";
            con = new MySqlConnection(conn);
            cmd = new MySqlCommand(sql, con);
            con.Open();
            int rows1_ = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATE");
            dataGridViewshow();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("RCTShop", new Font("TH SarabunPSK", 20, FontStyle.Bold), Brushes.Black, new Point(268, 40));
            e.Graphics.DrawString("วันที่   " + System.DateTime.Now.ToString("dd/MM/yyyy "), new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(570, 128));
            e.Graphics.DrawString("เวลา   " + System.DateTime.Now.ToString("HH : mm : ss น."), new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(571, 145));
            e.Graphics.DrawString("    เบอร์ติดต่อ 0616315367  ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(45, 110));
            e.Graphics.DrawString("     พพ 1309903044963", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(45, 140));

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(0, 150));
            e.Graphics.DrawString("ชื่อสินค้า", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(30, 170));
            e.Graphics.DrawString("จำนวน", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(650, 170));
            e.Graphics.DrawString("ราคา", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(740, 170));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(0, 200));
            string sql6 = $"SELECT * FROM `history` WHERE username = '{register.FiveRachata}' and status = 0";
            MySqlConnection conn6 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=rachatashop;");
            MySqlCommand cmd6 = new MySqlCommand(sql6, conn6);
            conn6.Open();
            MySqlDataReader reader6 = cmd6.ExecuteReader();
            int y = 250, จำนวนน = 0, ราคาา = 0;
            while (reader6.Read())
            {
                e.Graphics.DrawString(reader6.GetString(2), new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(30, y));
                e.Graphics.DrawString(reader6.GetString(3), new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(650, y));
                e.Graphics.DrawString(reader6.GetString(4), new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(740, y));
                y += 25;
                จำนวนน += reader6.GetInt32(3);
                ราคาา += reader6.GetInt32(4);
            }


            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(0, y + 20));
            e.Graphics.DrawString("รวมทั้งสิ้น    " + จำนวนน + "   บาท", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(312, y +45));
            e.Graphics.DrawString("จ่ายเงิน      " + ราคาา + "    บาท", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(312, ((y - 10) + 45) + 45));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(0, ((((y - 10) + 45) + 45) + 45) + 10));
            e.Graphics.DrawString(" ขอบคุณที่ใช้บริการครับผม 😊 😊 ", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(275, ((((y + 10) + 45) + 45) + 45) + 10));
            e.Graphics.DrawImage(new Bitmap(@"D:\งาน\QR code.png"), new Point(550 + -40, 180 + 560));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }
    }
}
   








