namespace RCTShop
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.usernamee = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.TEL = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_TEL = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.Register_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernamee
            // 
            this.usernamee.AutoSize = true;
            this.usernamee.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamee.Location = new System.Drawing.Point(90, 28);
            this.usernamee.Name = "usernamee";
            this.usernamee.Size = new System.Drawing.Size(104, 25);
            this.usernamee.TabIndex = 1;
            this.usernamee.Text = "username\t";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(90, 107);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(99, 25);
            this.password.TabIndex = 2;
            this.password.Text = "password";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(90, 186);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(64, 25);
            this.name.TabIndex = 4;
            this.name.Text = "name\t";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.Location = new System.Drawing.Point(90, 262);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(94, 25);
            this.surname.TabIndex = 5;
            this.surname.Text = "surname";
            this.surname.Click += new System.EventHandler(this.surname_Click);
            // 
            // TEL
            // 
            this.TEL.AutoSize = true;
            this.TEL.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEL.Location = new System.Drawing.Point(90, 344);
            this.TEL.Name = "TEL";
            this.TEL.Size = new System.Drawing.Size(60, 25);
            this.TEL.TabIndex = 6;
            this.TEL.Text = "TEL";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(90, 422);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(82, 25);
            this.address.TabIndex = 7;
            this.address.Text = "address";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(94, 54);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(443, 34);
            this.textBox_username.TabIndex = 8;
            this.textBox_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_username_KeyPress);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(94, 141);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(443, 34);
            this.textBox_password.TabIndex = 9;
            this.textBox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_password_KeyPress);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(94, 212);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(443, 34);
            this.textBox_name.TabIndex = 10;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            this.textBox_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_name_KeyPress);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_surname.Location = new System.Drawing.Point(94, 288);
            this.textBox_surname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(443, 34);
            this.textBox_surname.TabIndex = 11;
            this.textBox_surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_surname_KeyPress);
            // 
            // textBox_TEL
            // 
            this.textBox_TEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TEL.Location = new System.Drawing.Point(94, 370);
            this.textBox_TEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TEL.Name = "textBox_TEL";
            this.textBox_TEL.Size = new System.Drawing.Size(443, 34);
            this.textBox_TEL.TabIndex = 12;
            this.textBox_TEL.TextChanged += new System.EventHandler(this.textBox_TEL_TextChanged);
            this.textBox_TEL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TEL_KeyPress);
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(94, 448);
            this.textBox_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(443, 34);
            this.textBox_address.TabIndex = 13;
            // 
            // Register_btn
            // 
            this.Register_btn.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_btn.Location = new System.Drawing.Point(442, 514);
            this.Register_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(153, 62);
            this.Register_btn.TabIndex = 14;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = true;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(44, 514);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(153, 62);
            this.Exit_btn.TabIndex = 15;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(647, 595);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_TEL);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.address);
            this.Controls.Add(this.TEL);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usernamee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamee;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label TEL;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_TEL;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.Button Exit_btn;
    }
}