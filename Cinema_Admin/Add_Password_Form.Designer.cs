namespace Cinema_Admin
{
    partial class Add_Password_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Password_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.g_b_new_pass = new System.Windows.Forms.GroupBox();
            this.b_confirm_2 = new System.Windows.Forms.Button();
            this.t_password_2 = new System.Windows.Forms.TextBox();
            this.t_password_3 = new System.Windows.Forms.TextBox();
            this.g_b_new_pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(58, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "WPROWADZENIE HASŁA";
            // 
            // g_b_new_pass
            // 
            this.g_b_new_pass.Controls.Add(this.b_confirm_2);
            this.g_b_new_pass.Controls.Add(this.t_password_2);
            this.g_b_new_pass.Controls.Add(this.t_password_3);
            this.g_b_new_pass.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.g_b_new_pass.ForeColor = System.Drawing.SystemColors.Control;
            this.g_b_new_pass.Location = new System.Drawing.Point(9, 41);
            this.g_b_new_pass.Name = "g_b_new_pass";
            this.g_b_new_pass.Size = new System.Drawing.Size(177, 129);
            this.g_b_new_pass.TabIndex = 4;
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
            // t_password_2
            // 
            this.t_password_2.Location = new System.Drawing.Point(67, 38);
            this.t_password_2.Name = "t_password_2";
            this.t_password_2.PasswordChar = '*';
            this.t_password_2.Size = new System.Drawing.Size(100, 22);
            this.t_password_2.TabIndex = 3;
            // 
            // t_password_3
            // 
            this.t_password_3.Location = new System.Drawing.Point(67, 66);
            this.t_password_3.Name = "t_password_3";
            this.t_password_3.PasswordChar = '*';
            this.t_password_3.Size = new System.Drawing.Size(100, 22);
            this.t_password_3.TabIndex = 0;
            // 
            // Add_Password_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(196, 179);
            this.Controls.Add(this.g_b_new_pass);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Password_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Password_Form";
            this.g_b_new_pass.ResumeLayout(false);
            this.g_b_new_pass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox g_b_new_pass;
        private System.Windows.Forms.Button b_confirm_2;
        private System.Windows.Forms.TextBox t_password_2;
        private System.Windows.Forms.TextBox t_password_3;
    }
}