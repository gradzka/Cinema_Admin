using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Admin
{
    static class Program_Main
    {
        static public bool form_change = false;
        static public bool close = false;
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
            
            while (close==false)
            {
                close = true;
                if (form_change == false)
                {
                    Application.Run(new Login_Form());
                }
                
                if (form_change == true)
                {
                    Application.Run(new Main_Form());
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
