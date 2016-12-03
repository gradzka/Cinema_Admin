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
    public partial class Password_Form : Form
    {
        DataGridViewCellCollection edit_row;
        TextBox t_b_pass;
        public Password_Form(DataGridViewCellCollection row, TextBox t_b_pass)
        {
            InitializeComponent();
            edit_row = row;
            this.t_b_pass = t_b_pass;
        }

        private void b_confirm_1_Click(object sender, EventArgs e)
        {
            if (t_password_1.Text == "")
            {
                MessageBox.Show("Nie uzupełniono wymaganego pola z aktualnym hasłem!");
            }
            else if (t_password_1.Text != "")
            {
                using (var container = new CinemaEntities())
                {
                    string s_sha1_pass_in_the_base = edit_row[1].Value.ToString(); //haslo z bazy z wybranej krotki -> sha1
                    //MessageBox.Show(s_sha1_pass_in_the_base);

                    byte[] bytes_user_pass = Encoding.Default.GetBytes(t_password_1.Text);//haslo z bazy w bajtach
                    using (var sha1 = SHA1.Create())
                    {
                        byte[] sha1_user_pass = sha1.ComputeHash(bytes_user_pass);
                        string s_sha1_user_pass = Encoding.Default.GetString(sha1_user_pass); //haslo z bazy -> sha1


                        if (s_sha1_pass_in_the_base == s_sha1_user_pass)
                        {
                            t_password_2.Enabled = true;
                            t_password_3.Enabled = true;
                            MessageBox.Show("Proszę wprowadzić nowe hasło");
                        }
                        else
                        {
                            MessageBox.Show("Podane aktualne hasło jest nieprawidłowe!");
                        }

                    }

                }

            }
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
