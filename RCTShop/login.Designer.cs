namespace RCTShop
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 218);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(461, 299);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Username.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(154, 252);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(118, 29);
            this.Username.TabIndex = 2;
            this.Username.Text = "username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(150, 295);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(351, 30);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxPassword.Location = new System.Drawing.Point(159, 393);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(342, 30);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Password.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(155, 356);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(99, 25);
            this.Password.TabIndex = 6;
            this.Password.Text = "password";
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(359, 444);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(141, 50);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Location = new System.Drawing.Point(150, 444);
            this.register_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(141, 50);
            this.register_btn.TabIndex = 8;
            this.register_btn.Text = "register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(647, 595);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button register_btn;
    }
}

