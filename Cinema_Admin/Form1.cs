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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        public bool check_login_check_password()
        {
            using (var container = new CinemaEntities())
            {
                byte[] admin_password = Encoding.Default.GetBytes(password_textBox.Text); //pobrana wartosc z pola login_textBox w byte

                //utworzenie skrotu od pobranego hasla (SHA_1)
                using (var sha1 = SHA1.Create())
                {
                    byte[] admin_password_sha1 = sha1.ComputeHash(admin_password);  //Convert the input byte to a byte array and compute the hash.
                    string s_admin_password_sha1 = Encoding.Default.GetString(admin_password_sha1);

                    var number_of_admins = container.ADMINS.Where(a => a.ADMIN_LOGIN == login_textBox.Text && a.PASSWORD == s_admin_password_sha1);

                    if (number_of_admins.Count() == 0) return false;
                    Program_Main.login = login_textBox.Text;
                    Program_Main.password = password_textBox.Text;

                    number_of_admins.First().LAST_LOGIN = DateTime.Now;
                    container.SaveChanges();
                }
            }
            return true;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (check_login_check_password())
            {
                //Cinema_Admin.Program_Main.form_change = true;
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
                MessageBox.Show("Podano błędne dane logowania!", "Błąd logowania");
        }

        private void password_login_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (check_login_check_password())
                {
                    //Cinema_Admin.Program_Main.form_change = true;
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                    MessageBox.Show("Podano błędne dane logowania!", "Błąd logowania");
            }
        }
    }

}