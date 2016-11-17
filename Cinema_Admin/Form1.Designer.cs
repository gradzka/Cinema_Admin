namespace Cinema_Admin
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.title_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title_label.ForeColor = System.Drawing.Color.Transparent;
            this.title_label.Location = new System.Drawing.Point(167, 8);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(70, 14);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "LOGOWANIE";
            // 
            // login_label
            // 
            this.login_label.BackColor = System.Drawing.Color.White;
            this.login_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.login_label.ForeColor = System.Drawing.Color.Black;
            this.login_label.Location = new System.Drawing.Point(61, 27);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(46, 22);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "LOGIN";
            this.login_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_label
            // 
            this.password_label.BackColor = System.Drawing.Color.White;
            this.password_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.password_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.password_label.Location = new System.Drawing.Point(61, 55);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(46, 22);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "HASŁO";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(116, 27);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(100, 22);
            this.login_textBox.TabIndex = 3;
            this.login_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_login_textBox_KeyDown);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(116, 55);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(100, 22);
            this.password_textBox.TabIndex = 4;
            this.password_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_login_textBox_KeyDown);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_button.Location = new System.Drawing.Point(141, 84);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "ZALOGUJ";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.login_label);
            this.groupBox1.Controls.Add(this.login_button);
            this.groupBox1.Controls.Add(this.login_textBox);
            this.groupBox1.Controls.Add(this.password_textBox);
            this.groupBox1.Controls.Add(this.password_label);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(6, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MAŁE KINO";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(239, 148);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Administratora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

