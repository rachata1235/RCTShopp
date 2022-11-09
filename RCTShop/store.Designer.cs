namespace RCTShop
{
    partial class store
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(store));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.repair = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Addtocart = new System.Windows.Forms.Button();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(485, 377);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // repair
            // 
            this.repair.BackColor = System.Drawing.Color.Transparent;
            this.repair.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repair.Location = new System.Drawing.Point(721, 614);
            this.repair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repair.Name = "repair";
            this.repair.Size = new System.Drawing.Size(136, 49);
            this.repair.TabIndex = 5;
            this.repair.Text = "Delete";
            this.repair.UseVisualStyleBackColor = false;
            this.repair.Click += new System.EventHandler(this.repair_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(30, 736);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(117, 43);
            this.back.TabIndex = 6;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.Color.Transparent;
            this.pay.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.Location = new System.Drawing.Point(816, 692);
            this.pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(128, 48);
            this.pay.TabIndex = 8;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = false;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.date.Location = new System.Drawing.Point(11, 7);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(54, 20);
            this.date.TabIndex = 9;
            this.date.Text = "DATE";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.time.Location = new System.Drawing.Point(123, 7);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(48, 20);
            this.time.TabIndex = 10;
            this.time.Text = "TIME";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(721, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(525, 79);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(715, 215);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Addtocart
            // 
            this.Addtocart.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addtocart.Location = new System.Drawing.Point(924, 614);
            this.Addtocart.Name = "Addtocart";
            this.Addtocart.Size = new System.Drawing.Size(130, 49);
            this.Addtocart.TabIndex = 13;
            this.Addtocart.Text = "Add to cart";
            this.Addtocart.UseVisualStyleBackColor = true;
            this.Addtocart.Click += new System.EventHandler(this.Addtocart_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nametextBox.Location = new System.Drawing.Point(159, 28);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 22);
            this.nametextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Price";
            // 
            // pricetextBox
            // 
            this.pricetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricetextBox.Location = new System.Drawing.Point(159, 68);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(100, 22);
            this.pricetextBox.TabIndex = 17;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(33, 113);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(106, 23);
            this.Quantity.TabIndex = 18;
            this.Quantity.Text = "Quantity";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(150, 113);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Size";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.comboBox1.Location = new System.Drawing.Point(150, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "S";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nametextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.pricetextBox);
            this.panel1.Location = new System.Drawing.Point(82, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 227);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(33, 28);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 23);
            this.lbName.TabIndex = 22;
            this.lbName.Text = "Name";
            // 
            // store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1252, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Addtocart);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.back);
            this.Controls.Add(this.repair);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "store";
            this.Shown += new System.EventHandler(this.store_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button repair;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Addtocart;
       
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbName;
    }
}