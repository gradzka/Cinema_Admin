using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Cinema_Admin
{
    public partial class Add_Password_Form : Form
    {
        DataGridViewCellCollection edit_row;
        TextBox t_b_pass;

        public Add_Password_Form(DataGridViewCellCollection row, TextBox t_b_pass)
        {
            InitializeComponent();
            edit_row = row;
            this.t_b_pass = t_b_pass;
        }

        private void b_confirm_2_Click(object sender, EventArgs e)
        {
            if (t_password_2.Text == "")
            {
                MessageBox.Show("Nie uzupełniono wymaganego pola z nowym hasłem!");
            }
            else if (t_password_2.Text == "")
            {
                MessageBox.Show("Nie uzupełniono wymaganego pola z nowym hasłem!");
            }
            else if (t_password_2.Text != t_password_3.Text)
            {
                MessageBox.Show("Podane hasła nie są zgodne!");
            }
            else if (t_password_2.Text == t_password_3.Text)
            {
                byte[] bytes_new_pass = Encoding.Default.GetBytes(t_password_3.Text);
                using (var sha1 = SHA1.Create())
                {
                    byte[] sha1_new_pass = sha1.ComputeHash(bytes_new_pass);
                    string s_sha1_user_pass = Encoding.Default.GetString(sha1_new_pass); //nowe haslo -> sha1

                    t_b_pass.Text = s_sha1_user_pass;
                    // this.DialogResult = DialogResult.OK;

                    this.Close();
                }
            }

        }
    }
}
