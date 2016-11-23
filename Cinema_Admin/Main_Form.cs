using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace Cinema_Admin
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {   
            InitializeComponent();          
        }

        /* Oznaczenia buttonow: b_actibe
         * 1 - b_movies
         * 2 - b_program
         * 3 - b_halls
         * 4 - b_seats
         * 5 - b_users
         * 6 - b_tickets
         * 7 - b_reservations
         * 8 - b_res_details
         */
        int b_active = 1; //highlighted button (1 - 9) - nr buttona, domyslnie button nr 1

        void b_inactive_colour() //kolor szary - button nieaktywny, kolor niebieski - aktywny
        {
            switch (b_active)
            {
                case 1:
                    this.b_movies.BackColor = System.Drawing.SystemColors.GrayText;
                    break;
                case 2:
                    this.b_program.BackColor = System.Drawing.SystemColors.GrayText;
                    break;
                case 3:
                    this.b_halls.BackColor = System.Drawing.SystemColors.GrayText;
                    break;
                case 4:
                    this.b_seats.BackColor = System.Drawing.SystemColors.GrayText;
                    break;
                case 5:
                    this.b_users.BackColor = System.Drawing.SystemColors.GrayText;
                    break;
                case 6:
                    this.b_tickets.BackColor = System.Drawing.SystemColors.GrayText;
                    break;
                case 7:
                    this.b_reservations.BackColor = System.Drawing.SystemColors.GrayText;
                    break;
                case 8:
                    this.b_res_details.BackColor = System.Drawing.SystemColors.GrayText;
                    break;
                case 9:
                    this.b_admin.BackColor = System.Drawing.SystemColors.GrayText;
                    break;
                default:
                    MessageBox.Show("Żądanie obsłużenia nieistniejącej kontrolki! Błąd zmiany koloru.");
                    break;
            }
        }
        void active_inactive_colour_operation_button(bool add, bool modify, string table_name) //
        {
            l_active_table.Text = "Aktywna tabela: " + table_name;

            //Enabled or Disabled buttons
            if (b_modify_tuple.Enabled != modify)
            {
                b_modify_tuple.Enabled = modify;
            }
            if (b_add_tuple.Enabled != add)
            {
                b_add_tuple.Enabled = add;
            }

            //Change colours od Enabled or Disabled buttons
            if (modify == false) // button must be grey
            {
                if (b_modify_tuple.BackColor != System.Drawing.SystemColors.GrayText)
                b_modify_tuple.BackColor = System.Drawing.SystemColors.GrayText;
            }
            else if (modify==true)
            {
                if (b_modify_tuple.BackColor != System.Drawing.SystemColors.Highlight)
                    b_modify_tuple.BackColor = System.Drawing.SystemColors.Highlight;
            }

            if(add == false) // button must be grey
            {
                if (b_add_tuple.BackColor != System.Drawing.SystemColors.GrayText)
                    b_add_tuple.BackColor = System.Drawing.SystemColors.GrayText;
            }
            else if (add==true)
            {
                if (b_add_tuple.BackColor != System.Drawing.SystemColors.Highlight)
                    b_add_tuple.BackColor = System.Drawing.SystemColors.Highlight;
            }
        }
        public void TableGridView_fill(int b_active)
        {
            switch (b_active)
            {
                case 1:
                    {
                        using (var C_Entities = new CinemaEntities())
                        {
                            var movies = from movie in C_Entities.MOVIES
                                         select new
                                         {
                                             movie.ID_MOVIE,
                                             movie.TITLE,
                                             movie.GENRE,
                                             movie.RUNTIME,
                                             movie.RATING,
                                             movie.RELEASE_DATE,
                                             movie.DIRECTION,
                                             movie.SCREENPLAY,
                                             movie.STARRING,
                                             movie.IMAGE,
                                             movie.TRAILER,
                                             movie.SYNOPSIS
                                         };
                            TableGridView.DataSource = movies.ToList();
                        }
                    }
                    break;
                case 2:
                    {
                        using (var C_Entities = new CinemaEntities())
                        {
                            var program = from prog in C_Entities.PROGRAM
                                          select new
                                          {
                                              prog.ID_PROGRAM,
                                              prog.DATE,
                                              prog.TIME,
                                              prog.ID_HALL,
                                              prog.ID_MOVIE,
                                              prog.C2D_3D,
                                              prog.VERSION
                                          };
                            TableGridView.DataSource = program.ToList();
                        }
                    }
                    break;
                case 3:
                    {
                        using (var C_Entities = new CinemaEntities())
                        {
                            var halls = from hall in C_Entities.HALLS
                                        select new
                                        {
                                            hall.ID_HALL,
                                            hall.SEATS
                                        };
                            TableGridView.DataSource = halls.ToList();
                        }
                    }
                    break;
                case 4:
                    {
                        using (var C_Entities = new CinemaEntities())
                        {
                            var seats = from seat in C_Entities.SEATS
                                        select new
                                        {
                                            seat.ID_SEAT,
                                            seat.ID_HALL,
                                            seat.VIP
                                        };
                            TableGridView.DataSource = seats.ToList();
                        }
                    }
                    break;
                case 5:
                    using (var C_Entities = new CinemaEntities())
                    {
                        var users = from user in C_Entities.USERS
                                    select new
                                    {
                                        user.USER_LOGIN,
                                        user.PASSWORD,
                                        user.NAME,
                                        user.SURNAME,
                                        user.E_MAIL,
                                        user.TELEPHONE,
                                        user.LAST_LOGIN
                                    };
                        TableGridView.DataSource = users.ToList();
                    }
                    break;
                case 6:
                    {
                        using (var C_Entities = new CinemaEntities())
                        {
                            var tickets = from ticket in C_Entities.TICKETS
                                          select new
                                          {
                                              ticket.ID_TICKET,
                                              ticket.TYPE,
                                              ticket.PRICE_2D,
                                              ticket.PRICE_3D
                                          };
                            TableGridView.DataSource = tickets.ToList();
                        }
                    }
                    break;
                case 7:
                    {
                        using (var C_Entities = new CinemaEntities())
                        {
                            var reservations = from reservation in C_Entities.RESERVATIONS
                                               select new
                                               {
                                                   reservation.ID_RESERVATION,
                                                   reservation.ID_PROGRAM,
                                                   reservation.USER_LOGIN
                                               };
                            TableGridView.DataSource = reservations.ToList();
                        }
                    }
                    break;
                case 8:
                    {
                        using (var C_Entities = new CinemaEntities())
                        {
                            var details = from detail in C_Entities.RESERVATIONS_DETAILS
                                          select new
                                          {
                                              detail.ID_RESERVATION,
                                              detail.ID_SEAT,
                                              detail.ID_TICKET,
                                          };
                            TableGridView.DataSource = details.ToList();
                        }
                    }
                    break;
                case 9:
                    {
                        using (var C_Entities = new CinemaEntities())
                        {
                            var admins = from admin in C_Entities.ADMINS
                                         select new
                                         {
                                             admin.ADMIN_LOGIN,
                                             admin.PASSWORD,
                                             admin.NAME,
                                             admin.SURNAME,
                                             admin.E_MAIL,
                                             admin.TELEPHONE,
                                             admin.LAST_LOGIN,
                                             admin.LAST_LOGOUT
                                         };
                            TableGridView.DataSource = admins.ToList();
                        }
                    }
                    break;
                default:
                    { MessageBox.Show("Żądanie wypełnienia TableGridView danymi z nieistniającej tabeli!"); }
                    break;
            }
        }
        private void b_movies_Click(object sender, EventArgs e)
        {
            if (b_active != 1)
            {
                b_inactive_colour();
                this.b_movies.BackColor = System.Drawing.SystemColors.Highlight;
                b_active = 1;
                active_inactive_colour_operation_button(true, true, "FILMY");

                TableGridView_fill(b_active);

            }   

        }
        
        private void b_program_Click(object sender, EventArgs e)
        {
            if (b_active != 2)
            {
                b_inactive_colour();
                this.b_program.BackColor = System.Drawing.SystemColors.Highlight;
                b_active = 2;
                active_inactive_colour_operation_button(true, true, "PROGRAM");

                TableGridView_fill(b_active);
            }        
        }

        private void b_halls_Click(object sender, EventArgs e)
        {
            if (b_active != 3)
            {
                b_inactive_colour();
                this.b_halls.BackColor = System.Drawing.SystemColors.Highlight;
                b_active = 3;
                active_inactive_colour_operation_button(false, false, "SALE");

                TableGridView_fill(b_active);
            }
        }

        private void b_seats_Click(object sender, EventArgs e)
        {
            if (b_active != 4)
            {
                b_inactive_colour();
                this.b_seats.BackColor = System.Drawing.SystemColors.Highlight;
                b_active = 4;
                active_inactive_colour_operation_button(true, true, "MIEJSCA");

                TableGridView_fill(b_active);
            }
        }

        private void b_users_Click(object sender, EventArgs e)
        {
            if (b_active != 5)
            {
                b_inactive_colour();
                this.b_users.BackColor = System.Drawing.SystemColors.Highlight;
                b_active = 5;
                active_inactive_colour_operation_button(false, true, "UŻYTKOWNICY");

                TableGridView_fill(b_active);
            }
        }

        private void b_tickets_Click(object sender, EventArgs e)
        {
            if (b_active != 6)
            {
                b_inactive_colour();
                this.b_tickets.BackColor = System.Drawing.SystemColors.Highlight;
                b_active = 6;
                active_inactive_colour_operation_button(true, true, "BILETY");

                TableGridView_fill(b_active);
            }
        }

        private void b_reservations_Click(object sender, EventArgs e)
        {
            if (b_active != 7)
            {
                b_inactive_colour();
                this.b_reservations.BackColor = System.Drawing.SystemColors.Highlight;
                b_active = 7;
                active_inactive_colour_operation_button(false, false, "REZERWACJE");

                TableGridView_fill(b_active);
            }
        }

        private void b_res_details_Click(object sender, EventArgs e)
        {
            if (b_active != 8)
            {
                b_inactive_colour();
                this.b_res_details.BackColor = System.Drawing.SystemColors.Highlight;
                b_active = 8;
                active_inactive_colour_operation_button(false, true, "SZCZEGÓŁY REZERWACJI");

                TableGridView_fill(b_active);
            }
        }
        private void b_admin_Click(object sender, EventArgs e)
        {
            if (b_active != 9)
            {
                b_inactive_colour();
                this.b_admin.BackColor = System.Drawing.SystemColors.Highlight;
                b_active = 9;
                active_inactive_colour_operation_button(true, true, "ADMINISTRATORZY");

                TableGridView_fill(b_active);
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            using (var C_Entities = new CinemaEntities())
            {
                var movies = from movie in C_Entities.MOVIES
                             select new
                             {
                                 movie.ID_MOVIE,
                                 movie.TITLE,
                                 movie.GENRE,
                                 movie.RUNTIME,
                                 movie.RATING,
                                 movie.RELEASE_DATE,
                                 movie.DIRECTION,
                                 movie.SCREENPLAY,
                                 movie.STARRING,
                                 movie.IMAGE,
                                 movie.TRAILER,
                                 movie.SYNOPSIS
                             };
                TableGridView.DataSource = movies.ToList();
            }
        }
       

        private void b_add_tuple_Click(object sender, EventArgs e)
        {
            if (b_active > 9 || b_active < 1)
            {
                MessageBox.Show("Error! Fault with button numeration in Main_Form.cs");
            }
            else
            {
                Row_Form row_form = new Row_Form(b_active, 0, null);
                row_form.ShowDialog();

            }
        }

        private void b_modify_tuple_Click(object sender, EventArgs e)
        {
            if (b_active > 9 || b_active < 1)
            {
                MessageBox.Show("Error! Fault with button numeration in Main_Form.cs");
            }
            else
            {
                Row_Form row_form = new Row_Form(b_active, 1, TableGridView.SelectedRows[0].Cells); //tabela, 1 - kliknieto EDYTUJ, wybrana krotka do edycji
                DialogResult dialog_result = row_form.ShowDialog();
                if (dialog_result == DialogResult.OK) //Cancel -> x, anuluj
                {
                    TableGridView_fill(b_active);
                }
            }
        }

        private void b_delete_tuple_Click(object sender, EventArgs e)
        {
            //do dokonczenia
        }      

        private void b_logout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }   
    }
}
