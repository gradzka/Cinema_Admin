namespace Cinema_Admin
{
    partial class Password_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password_Form));
            this.g_b_old_pass = new System.Windows.Forms.GroupBox();
            this.b_confirm_1 = new System.Windows.Forms.Button();
            this.t_password_2 = new System.Windows.Forms.TextBox();
            this.t_password_1 = new System.Windows.Forms.TextBox();
            this.g_b_new_pass = new System.Windows.Forms.GroupBox();
            this.b_confirm_2 = new System.Windows.Forms.Button();
            this.t_password_3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.g_b_old_pass.SuspendLayout();
            this.g_b_new_pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // g_b_old_pass
            // 
            this.g_b_old_pass.Controls.Add(this.b_confirm_1);
            this.g_b_old_pass.Controls.Add(this.t_password_1);
            this.g_b_old_pass.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.g_b_old_pass.ForeColor = System.Drawing.SystemColors.Control;
            this.g_b_old_pass.Location = new System.Drawing.Point(7, 36);
            this.g_b_old_pass.Name = "g_b_old_pass";
            this.g_b_old_pass.Size = new System.Drawing.Size(177, 94);
            this.g_b_old_pass.TabIndex = 0;
            this.g_b_old_pass.TabStop = false;
            this.g_b_old_pass.Text = "WPROWADŹ AKTUALNE HASŁO";
            // 
            // b_confirm_1
            // 
            this.b_confirm_1.BackColor = System.Drawing.SystemColors.Highlight;
            this.b_confirm_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.b_confirm_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_confirm_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_confirm_1.Location = new System.Drawing.Point(83, 63);
            this.b_confirm_1.Name = "b_confirm_1";
            this.b_confirm_1.Size = new System.Drawing.Size(84, 23);
            this.b_confirm_1.TabIndex = 4;
            this.b_confirm_1.Text = "ZATWIERDŹ";
            this.b_confirm_1.UseVisualStyleBackColor = false;
            this.b_confirm_1.Click += new System.EventHandler(this.b_confirm_1_Click);
            // 
            // t_password_2
            // 
            this.t_password_2.Enabled = false;
            this.t_password_2.Location = new System.Drawing.Point(67, 66);
            this.t_password_2.Name = "t_password_2";
            this.t_password_2.PasswordChar = '*';
            this.t_password_2.Size = new System.Drawing.Size(100, 22);
            this.t_password_2.TabIndex = 3;
            // 
            // t_password_1
            // 
            this.t_password_1.Location = new System.Drawing.Point(67, 34);
            this.t_password_1.Name = "t_password_1";
            this.t_password_1.PasswordChar = '*';
            this.t_password_1.Size = new System.Drawing.Size(100, 22);
            this.t_password_1.TabIndex = 2;
            // 
            // g_b_new_pass
            // 
            this.g_b_new_pass.Controls.Add(this.b_confirm_2);
            this.g_b_new_pass.Controls.Add(this.t_password_2);
            this.g_b_new_pass.Controls.Add(this.t_password_3);
            this.g_b_new_pass.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.g_b_new_pass.ForeColor = System.Drawing.SystemColors.Control;
            this.g_b_new_pass.Location = new System.Drawing.Point(7, 136);
            this.g_b_new_pass.Name = "g_b_new_pass";
            this.g_b_new_pass.Size = new System.Drawing.Size(177, 129);
            this.g_b_new_pass.TabIndex = 1;
            this.g_b_new_pass.TabStop = false;
            this.g_b_new_pass.Text = "WPROWADŹ NOWE HASŁO DWUKROTNIE";
            // 
            // b_confirm_2
            // 
            this.b_confirm_2.BackColor = System.Drawing.SystemColors.Highlight;
            this.b_confirm_2.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.b_confirm_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_confirm_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_confirm_2.Location = new System.Drawing.Point(83, 95);
            this.b_confirm_2.Name = "b_confirm_2";
            this.b_confirm_2.Size = new System.Drawing.Size(84, 23);
            this.b_confirm_2.TabIndex = 5;
            this.b_confirm_2.Text = "ZATWIERDŹ";
            this.b_confirm_2.UseVisualStyleBackColor = false;
            this.b_confirm_2.Click += new System.EventHandler(this.b_confirm_2_Click);
            // 
            // t_password_3
            // 
            this.t_password_3.Enabled = false;
            this.t_password_3.Location = new System.Drawing.Point(67, 38);
            this.t_password_3.Name = "t_password_3";
            this.t_password_3.PasswordChar = '*';
            this.t_password_3.Size = new System.Drawing.Size(100, 22);
            this.t_password_3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(98, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "ZMIANA HASŁA";
            // 
            // Password_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(192, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.g_b_new_pass);
            this.Controls.Add(this.g_b_old_pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Password_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password_Form";
            this.g_b_old_pass.ResumeLayout(false);
            this.g_b_old_pass.PerformLayout();
            this.g_b_new_pass.ResumeLayout(false);
            this.g_b_new_pass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox g_b_old_pass;
        private System.Windows.Forms.GroupBox g_b_new_pass;
        private System.Windows.Forms.TextBox t_password_1;
        private System.Windows.Forms.TextBox t_password_2;
        private System.Windows.Forms.Button b_confirm_1;
        private System.Windows.Forms.Button b_confirm_2;
        private System.Windows.Forms.TextBox t_password_3;
        private System.Windows.Forms.Label label1;
    }
}