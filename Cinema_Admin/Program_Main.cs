using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Admin
{
    static class Program_Main
    {
        static public string login = "";
        static public string password = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login_Form login_form = new Login_Form();
            Main_Form main_form = new Main_Form();
            DialogResult dialog_result = DialogResult.No;

            while (dialog_result!= DialogResult.Cancel)
            {
                if (dialog_result == DialogResult.No) //jezeli jest niezalogowany
                {
                    login_form = new Login_Form();
                    dialog_result = login_form.ShowDialog();
                }

                if (dialog_result == DialogResult.Yes)
                {
                    main_form = new Main_Form();
                    dialog_result = main_form.ShowDialog();
                }

                using (var container = new CinemaEntities())
                {
                    var number_of_admins = container.ADMINS.Where(a => a.ADMIN_LOGIN == login && a.PASSWORD == password);
                    number_of_admins.First().LAST_LOGOUT = DateTime.Now;
                    container.SaveChanges();
                }
            }
        }
    }
}
