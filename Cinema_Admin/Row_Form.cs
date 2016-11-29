using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace Cinema_Admin
{
    public partial class Row_Form : Form
    {
        /* 1 - MOVIES
         * 2 - PROGRAM
         * 3 - HALLS
         * 4 - SEATS
         * 5 - USERS
         * 6 - TICKETS
         * 7 - RESERVATIONS
         * 8 - RES_DETAILS
         */
        int active_table; // 0 - 9
        int insert_or_update; //0 - insert, 1 - update
        int how_many_columns;
        DataGridViewCellCollection row_to_edit; //dane w krotce z bazy danych, tabela pol w krotce
        List<Label> labels = new List<Label>();
        List<TextBox> textboxes = new List<TextBox>();
        List<ComboBox> comboboxes = new List<ComboBox>();
        List<DateTimePicker> datetimepickers = new List<DateTimePicker>();
        CheckBox checkbox = null;

        public Row_Form(int table, int option, DataGridViewCellCollection row)
        {
            this.DialogResult = DialogResult.Cancel;
            active_table = table;
            insert_or_update = option;
            row_to_edit = row;
            InitializeComponent();
            switch (active_table)
            {
                case 1: case 5: case 6: 
                    Init_Row_Form(1); //1 - number of foreign keys in MOVIES, PROGRAM etc.
                    break;
                case 2: case 8:
                    Init_Row_Form(3);
                    break;  
                case 4:
                    Init_Row_Form(2);
                    break;
                case 9:
                    Init_Row_Form(0);
                    break;
                default:
                    {
                        //Error! Fault with button numeration in Row_Form.cs
                        MessageBox.Show("Błąd aplikacji", "Error#1");
                        break;
                    }
            }
        }
        public void Init_Row_Form(int number_of_foreign_keys)
        {
            string[] names_of_columns = null;

            switch (active_table)
            {
                case 1:
                    names_of_columns = typeof(MOVIES).GetProperties().Select(ColumnHeader => ColumnHeader.Name).ToArray();//nazwy kolumn do labeli
                    this.Text = "MOVIES";//tytul okienka, jak nazwa tabeli
                    break;
                case 2:
                    names_of_columns = typeof(PROGRAM).GetProperties().Select(ColumnHeader => ColumnHeader.Name).ToArray();
                    this.Text = "PROGRAMS";
                    break;
                case 4:
                    names_of_columns = typeof(SEATS).GetProperties().Select(ColumnHeader => ColumnHeader.Name).ToArray();
                    this.Text = "SEATS";
                    break;
                case 5:
                    names_of_columns = typeof(USERS).GetProperties().Select(ColumnHeader => ColumnHeader.Name).ToArray();
                    this.Text = "USERS";
                    break;
                case 6:
                    names_of_columns = typeof(TICKETS).GetProperties().Select(ColumnHeader => ColumnHeader.Name).ToArray();
                    this.Text = "TICKETS";
                    break;
                case 8:
                    names_of_columns = typeof(RESERVATIONS_DETAILS).GetProperties().Select(ColumnHeader => ColumnHeader.Name).ToArray();
                    this.Text = "RESERVATIONS_DETAILS";
                    break;
                case 9:
                    names_of_columns = typeof(ADMINS).GetProperties().Select(ColumnHeader => ColumnHeader.Name).ToArray();
                    this.Text = "ADMINS";
                    break;

                default:
                    {
                        //Error! Fault with button numeration in Row_Form.cs
                        MessageBox.Show("Błąd aplikacji", "Error#2");
                        break;
                    }
            }
            //Tworzenie labeli, wywolana metoda od kolorowania labeli, tworzenie texboxow, comboboxow i checkboxa
            //"Error!" + " names_of_columns is null!"
            if (names_of_columns == null) { MessageBox.Show("Błąd aplikacji", "Error#3"); }
            else
            {
                how_many_columns = names_of_columns.Length - number_of_foreign_keys;

                Label label = null;
                TextBox textbox = null;

                for (int i = 0; i < how_many_columns; i++)
                {
                    label = new Label();
                    label.Size = new System.Drawing.Size(101, 13);
                    label.TabIndex = i;
                    label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    paint_necessary_labels(label, i);

                    label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    label.Location = new System.Drawing.Point(29, 20 + 25 * i);
                    label.Text = names_of_columns[i]; //set names of columns
                    labels.Add(label);
                    this.Controls.Add(label);

                    textbox = new TextBox();

                    if ((active_table == 2 || active_table == 6) && i == 0)
                    {
                        textbox.Enabled = false;
                    }
                    if ((active_table == 9 && (i == 6 || i == 7)))
                    {
                        textbox.Enabled = false;
                    }

                    //Combobox replace TexBox
                    create_comboboxes_date_time_pickers(textbox, i);

                    textbox.Size = new System.Drawing.Size(120, 20);
                    textbox.TabIndex = i + 12;
                    textbox.Location = new System.Drawing.Point(141, 17 + 25 * i);
                    textboxes.Add(textbox);
                    this.Controls.Add(textbox);
                }

                Cancel_button.Location = new System.Drawing.Point(70, labels[labels.Count - 1].Location.Y + 30);
                OK_button.Location = new System.Drawing.Point(160, labels[labels.Count - 1].Location.Y + 30);
                this.ClientSize = new System.Drawing.Size(310, labels[labels.Count - 1].Location.Y + 70);
            }

        }
        public void create_comboboxes_date_time_pickers(TextBox textbox, int i)
        {
            if (active_table == 1) //DODAJ
            {
                if (i == 4) { create_combobox_range(textbox, i, new string[] { "0", "7", "12", "15", "18" }, "0"); }
                if (i == 3) { create_DateTimePicker(textbox, i, "HH:mm"); }
                if (i == 5) { create_DateTimePicker(textbox, i, "dd/MM/yyyy"); }
            }

            if (active_table == 2) //PROGRAM
            {
                if (i==1) { create_DateTimePicker(textbox, i, "dd/MM/yyyy"); }
                if (i == 2) { create_DateTimePicker(textbox, i, "HH:mm"); }
                if (i == 3) //ID_HALLS
                {
                    create_combobox_entieties(textbox, i);
                }
                if (i == 4) //ID_MOVIE
                {
                    create_combobox_entieties(textbox, i);
                }
                if (i == 5) //2D_3D
                {
                    create_combobox_range(textbox, i, new string[] { "2D", "3D" }, "2D");
                }
                if (i == 6)
                {
                    create_combobox_range(textbox, i, new string[] { "", "Napisy", "Dubbing" }, "");
                }
            }

            if (active_table == 4)//SEATS
            {
                if (i == 1) //ID_HALLS
                {
                    create_combobox_entieties(textbox, i);
                }
                if (i == 2) //VIP
                {
                    textbox.Visible = false;
                    checkbox = new CheckBox();
                    checkbox.Size = new System.Drawing.Size(120, 20);
                    checkbox.TabIndex = i + 12;
                    checkbox.Location = new System.Drawing.Point(141, 17 + 25 * i);
                    this.Controls.Add(checkbox);
                }
            }

            if (active_table == 8) //RES_DETAILS
            {
                if (i == 2) //ID_TICKET
                {
                    create_combobox_entieties(textbox, i);
                }
            }
        }
        public void create_combobox_range(TextBox textbox, int i, object[] addRange, string text)
        {
            textbox.Visible = false;
            ComboBox combobox = new ComboBox();
            combobox.Items.AddRange(addRange);
            combobox.Size = new System.Drawing.Size(120, 20);
            combobox.TabIndex = i + 12;
            combobox.Location = new System.Drawing.Point(141, 17 + 25 * i);
            combobox.Text = text;
            combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboboxes.Add(combobox);
            this.Controls.Add(combobox);
        }
        public void create_DateTimePicker(TextBox textbox, int i, string format)
        {
            textbox.Visible = false;
            DateTimePicker datetimepicker = new DateTimePicker();
            datetimepicker.Format = DateTimePickerFormat.Custom;
            datetimepicker.CustomFormat = format;
            if (format=="HH:mm")
            {
                datetimepicker.ShowUpDown = true;
                datetimepicker.Value = DateTime.Parse("2016-11-29 00:00");
            }
            else if (active_table==2)
            {
                datetimepicker.MinDate = DateTime.Now;
            }
            datetimepicker.Size = new System.Drawing.Size(120, 20);
            datetimepicker.TabIndex = i + 12;
            datetimepicker.Location= new System.Drawing.Point(141, 17 + 25 * i);
            datetimepickers.Add(datetimepicker);
            this.Controls.Add(datetimepicker);
        }

        public void create_combobox_entieties(TextBox textbox, int i)
        {
            textbox.Visible = false;
            ComboBox combobox = new ComboBox();
            using (var C_Entities = new CinemaEntities())
            {
                List<string> itemsList = new List<string>();

                if (i == 1 || i == 3) //ID_HALLS
                {
                    foreach (var item in C_Entities.HALLS.ToList())
                    {
                        itemsList.Add(item.ID_HALL);
                    }
                }
                else if (i == 2) //VIP
                {
                    foreach (var item in C_Entities.TICKETS.ToList())
                    {
                        itemsList.Add(item.ID_TICKET.ToString());
                    }
                }
                else if (i == 4) //ID_MOVIE
                {
                    foreach (var item in C_Entities.MOVIES.ToList())
                    {
                        itemsList.Add(item.ID_MOVIE);
                    }

                }
                combobox.DataSource = itemsList;
            }
            combobox.Size = new System.Drawing.Size(120, 20);
            combobox.TabIndex = i + 12;
            combobox.Location = new System.Drawing.Point(141, 17 + 25 * i);
            combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboboxes.Add(combobox);
            this.Controls.Add(combobox);
        }
        public void paint_necessary_labels(Label label, int i) //funkcja maluje te labele, obok ktorych textboxy musza byc uzupelnione
        {
            /* active table wskazuje na tabele
             * i wskazuje na i-ta kolumne
             */
            if ((active_table == 1 && (i == 0 || i == 1))
                || (active_table == 4 && (i == 0))
                || (active_table == 5 && (i>0 && i < 6))
                || (active_table == 6 && i > 0)
                || (active_table == 9 && (i < 6)))
            {
                label.ForeColor = System.Drawing.Color.Salmon;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.White;
            }
        }
        private void Row_Form_Load(object sender, EventArgs e) //blokada texboxow, uzupelnianie kontrolek
        {
            if (insert_or_update == 1) //SQL UPDATE <=> EDYTUJ
            {
                for (int i = 0; i < labels.Count; i++)
                {
                    // wylacz mozliwosc edycji
                    if (i == 0) //dla kazdej 0. kolumny tabel
                    {
                        if (active_table != 2) //tabela users, ID_login
                        {
                            textboxes[i].Enabled = false;
                        }
                    }
                    if (active_table == 5 && i == 6) //USERS -> LAST_LOGIN
                    {
                        textboxes[i].Enabled = false;
                    }
                    if (active_table == 8 && i == 1) //dla tabeli res_details i 1. kolumny //RES_DETAILS - > ID_RESERBATION
                    {
                        textboxes[i].Enabled = false;
                    }

                    if (row_to_edit[i].Value != null)
                    {
                        //Combobox - EDYTUJ                    
                        if (active_table == 1 && i == 3) //MOVIE -> GENRE
                        {
                            datetimepickers[0].Text = row_to_edit[i].Value.ToString();
                        }
                        else if (active_table == 1 && i == 4) //MOVIE -> RUNTIME
                        {
                            comboboxes[0].Text = row_to_edit[i].Value.ToString();  //---> sprawdzic, czy nie ma w bazie 
                        }
                        else if (active_table == 1 && i == 5) //MOVIE -> RATING
                        { 
                            datetimepickers[1].Value = DateTime.Parse(row_to_edit[i].Value.ToString());
                        }

                        else if (active_table == 2 && i == 1) //PROGRAM -> ID_PROGRAM
                        {
                            datetimepickers[0].Value = DateTime.Parse(row_to_edit[i].Value.ToString());
                        }
                        else if (active_table == 2 && i == 2) //PROGRAM -> DATE
                        {
                            datetimepickers[1].Text = row_to_edit[i].Value.ToString();
                        }
                        else if (active_table == 2 && i == 3) //PROGRAM -> TIME
                        {
                            comboboxes[0].Text = row_to_edit[i].Value.ToString();
                        }
                        else if (active_table == 2 && i == 4) //PROGRAM -> ID_HALL
                        {
                            comboboxes[1].Text = row_to_edit[i].Value.ToString();
                        }
                        else if (active_table == 2 && i == 5) //PROGRAM -> C2D_3D
                        {
                            comboboxes[2].Text = row_to_edit[i].Value.ToString();
                        }
                        else if (active_table == 2 && i == 6) //PROGRAM -> VERSION
                        {
                            comboboxes[3].Text = row_to_edit[i].Value.ToString();
                        }

                        else if (active_table == 4 && i == 1) //SEATS -> ID_HALL
                        {
                            comboboxes[0].Text = row_to_edit[i].Value.ToString();
                        }
                        else if (active_table == 4 && i == 2) //SEATS -> VIP
                        {
                            checkbox.Checked = row_to_edit[i].Value.Equals(true) ? true : false;
                        }
                        else if (active_table == 8 && i == 2) //RES_DETAILS -> ID_TICKET
                        {
                            comboboxes[0].Text = row_to_edit[i].Value.ToString();
                        }
                        else
                        {
                            textboxes[i].Text = row_to_edit[i].Value.ToString();
                        }
                    }
                }
            }
        }     
        public bool check_necessary_data()
        {
            for (int i = 0; i < how_many_columns; i++)
            {
                if ((active_table == 1 && (i == 0 || i == 1))
                  || (active_table == 4 && (i == 0))
                  || (active_table == 5 && (i > 0 && i < 6))
                  || (active_table == 6 && i > 0)
                  || (active_table == 9 && (i < 6)))
                {
                    if (textboxes[i].Text == "")
                    {
                        MessageBox.Show("Przynajmniej jedno z wymaganych pól w tabeli " + this.Text + " jest puste!", "Uwaga");
                        return false;
                    }
                }
            }
            return true;
        }
        public bool insert_row()
        {
            using (var C_Entities = new CinemaEntities())
            {
                if (active_table == 1) //MOVIES
                {
                    var newRow = new MOVIES();
                    newRow.ID_MOVIE = textboxes[0].Text;
                    newRow.TITLE = textboxes[1].Text;
                    newRow.GENRE = textboxes[2].Text;
                    newRow.RUNTIME = TimeSpan.Parse(datetimepickers[0].Text);
                    newRow.RATING = byte.Parse(comboboxes[0].Text);
                    newRow.RELEASE_DATE = datetimepickers[1].Value;
                    newRow.DIRECTION = textboxes[6].Text;
                    newRow.SCREENPLAY = textboxes[7].Text;
                    newRow.STARRING = textboxes[8].Text;
                    newRow.IMAGE = textboxes[9].Text;
                    newRow.TRAILER = textboxes[10].Text;
                    newRow.SYNOPSIS = textboxes[11].Text;
                    
                    C_Entities.MOVIES.Add(newRow);
                }
                else if (active_table == 2) //PROGRAM
                {
                    var newRow = new PROGRAM();
                    newRow.DATE = datetimepickers[0].Value;
                    newRow.TIME = TimeSpan.Parse(datetimepickers[1].Text);
                    newRow.ID_HALL = comboboxes[0].Text;
                    newRow.ID_MOVIE = comboboxes[1].Text;
                    newRow.C2D_3D = comboboxes[2].Text;
                    newRow.VERSION = comboboxes[3].Text;
                    
                    C_Entities.PROGRAM.Add(newRow);
                }
                else if (active_table == 4) //SEATS
                {
                    var newRow = new SEATS();
                    newRow.ID_SEAT = textboxes[0].Text;
                    newRow.ID_HALL = comboboxes[0].Text;
                    newRow.VIP = bool.Parse(textboxes[2].Text);
                    
                    C_Entities.SEATS.Add(newRow);
                }
                else if (active_table == 6) //TICKETS
                {
                    var newRow = new TICKETS();
                    newRow.TYPE = textboxes[1].Text;
                    newRow.PRICE_2D = decimal.Parse(textboxes[2].Text);
                    newRow.PRICE_3D = decimal.Parse(textboxes[3].Text);

                    C_Entities.TICKETS.Add(newRow);
                }
                else if (active_table == 9) //ADMINS
                {
                    var newRow = new ADMINS();
                    newRow.ADMIN_LOGIN = textboxes[0].Text;
                    newRow.PASSWORD = textboxes[1].Text;
                    newRow.NAME = textboxes[2].Text;
                    newRow.SURNAME = textboxes[3].Text;
                    newRow.E_MAIL = textboxes[4].Text;
                    newRow.TELEPHONE = textboxes[5].Text;

                    C_Entities.ADMINS.Add(newRow);
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd aplikacji", "Error#7");
                    return false;
                }
                try
                {
                    C_Entities.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    MessageBox.Show("Wystąpił błąd podczas dodawania danych!", "Error#6");
                    return false;
                }
            }
            this.DialogResult = DialogResult.OK;
            return true;
        }
        public bool update_row()
        {
            dynamic editRow = null;
            if (active_table == 1) //MOVIES
            {
                // MOVIES editRow;
                using (var C_Entities = new CinemaEntities())
                {
                    string primary_key = row_to_edit[0].Value.ToString();//pobranie klucza glownego z krotki -> row_to_edit ->pole w klasie
                    editRow = C_Entities.MOVIES.Where(movie => movie.ID_MOVIE == primary_key).First(); //edit row -> cala krotka, gdzie klucz glowny, to primary_key
                }

                if (editRow != null)
                {
                    editRow.TITLE = textboxes[1].Text;
                    editRow.GENRE = textboxes[2].Text;
                    editRow.RUNTIME = TimeSpan.Parse(datetimepickers[0].Text);
                    editRow.RATING = byte.Parse(comboboxes[0].Text);
                    editRow.RELEASE_DATE = datetimepickers[1].Value;
                    editRow.DIRECTION = textboxes[6].Text;
                    editRow.SCREENPLAY = textboxes[7].Text;
                    editRow.STARRING = textboxes[8].Text;
                    editRow.IMAGE = textboxes[9].Text;
                    editRow.TRAILER = textboxes[10].Text;
                    editRow.SYNOPSIS = textboxes[11].Text;
                }
            }
            else if (active_table == 2) //PROGRAM
            {
                //PROGRAM editRow;
                using (var C_Entities = new CinemaEntities())
                {
                    short primary_key = short.Parse(row_to_edit[0].Value.ToString());
                    editRow = C_Entities.PROGRAM.Where(program => program.ID_PROGRAM == primary_key).First();
                }

                if (editRow != null)
                {
                    editRow.DATE = datetimepickers[0].Value;
                    editRow.TIME = TimeSpan.Parse(datetimepickers[1].Text);
                    editRow.ID_HALL = comboboxes[0].Text;
                    editRow.ID_MOVIE = comboboxes[1].Text;
                    editRow.C2D_3D = comboboxes[2].Text;
                    editRow.VERSION = comboboxes[3].Text;
                }
            }
            else if (active_table == 4) //SEATS
            {
                //SEATS editRow;
                using (var C_Entities = new CinemaEntities())
                {
                    string primary_key = row_to_edit[0].Value.ToString();
                    editRow = C_Entities.SEATS.Where(seats => seats.ID_SEAT == primary_key).First();
                }

                if (editRow != null)
                {
                    editRow.ID_HALL = comboboxes[0].Text;
                    editRow.VIP = bool.Parse(textboxes[2].Text);
                }
            }
            else if (active_table == 5) //USERS
            {
                //USERS editRow;
                using (var C_Entities = new CinemaEntities())
                {
                    string primary_key = row_to_edit[0].Value.ToString();
                    editRow = C_Entities.USERS.Where(users => users.USER_LOGIN == primary_key).First();
                }

                if (editRow != null)
                {
                    editRow.PASSWORD = textboxes[1].Text;
                    editRow.NAME = textboxes[2].Text;
                    editRow.SURNAME = textboxes[3].Text;
                    editRow.E_MAIL = textboxes[4].Text;
                    editRow.TELEPHONE = textboxes[5].Text;
                }
            }
            else if (active_table == 6) //TICKETS
            {
                //TICKETS editRow;
                using (var C_Entities = new CinemaEntities())
                {
                    byte primary_key = byte.Parse(row_to_edit[0].Value.ToString());
                    editRow = C_Entities.TICKETS.Where(ticket => ticket.ID_TICKET == primary_key).First();
                }

                if (editRow != null)
                {
                    editRow.TYPE = textboxes[1].Text;
                    editRow.PRICE_2D = decimal.Parse(textboxes[2].Text);
                    editRow.PRICE_3D = decimal.Parse(textboxes[3].Text);
                }
            }
            else if (active_table == 8) //RES_DETAILS
            {
                //RESERVATIONS_DETAILS editRow;
                using (var C_Entities = new CinemaEntities())
                {
                    //short primary_key_1 = short.Parse(textboxes[0].Text);
                    short primary_key_1 = short.Parse(row_to_edit[0].Value.ToString());
                    string primary_key_2 = row_to_edit[1].Value.ToString();

                    editRow = C_Entities.RESERVATIONS_DETAILS.Where(
                        res_details => res_details.ID_RESERVATION == primary_key_1
                        && res_details.ID_SEAT == primary_key_2).First();


                   // MessageBox.Show(primary_key_1.ToString() + " " + primary_key_2);
                }

                if (editRow != null)
                {
                    editRow.ID_TICKET = byte.Parse(textboxes[2].Text);
                }
            }
            else if (active_table == 9) //ADMINS
            {
                //ADMINS editRow;
                using (var C_Entities = new CinemaEntities())
                {
                    string primary_key = row_to_edit[0].Value.ToString();
                    editRow = C_Entities.ADMINS.Where(admin => admin.ADMIN_LOGIN == primary_key).First();
                }

                if (editRow != null)
                {
                    editRow.PASSWORD = textboxes[1].Text;
                    editRow.NAME = textboxes[2].Text;
                    editRow.SURNAME = textboxes[3].Text;
                    editRow.E_MAIL = textboxes[4].Text;
                    editRow.TELEPHONE = textboxes[5].Text;
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd aplikacji", "Error#4");
                return false;
            }
            try
            {
                using (var C_Entities = new CinemaEntities())
                {
                    C_Entities.Entry(editRow).State = System.Data.Entity.EntityState.Modified;
                    C_Entities.SaveChanges();
                }
            }
            catch(DbUpdateConcurrencyException)
            {
                MessageBox.Show("Wystąpił błąd podczas aktualizowania danych!", "Error#5");
                return false;
            }

            this.DialogResult = DialogResult.OK;
            return true;

        }
        private void OK_button_Click(object sender, EventArgs e)
        {
            if(check_necessary_data()==false) //sprawdzenie, czy administrator wypelnil wszystkie wymagane textBoxy edycja/dodanie
            {
                return; //jesli, ktores z pol jest niewypelnione wyjdz z procedury obslugi przycisku 'OK'
            }

            if (insert_or_update==0) //wybrana opcja dodania krotki do bazy danych
            {
                if (insert_row() == true)
                {
                    MessageBox.Show("Poprawnie dodano dane!", "Dodawanie danych");
                    this.Close();
                }
            }
            else if (insert_or_update == 1) //wybrana opcja edycji krotki w bazie danych
            {
                if(update_row()==true)
                {
                    MessageBox.Show("Poprawnie zaktualizowano dane!","Edycja danych");
                    this.Close();
                }
            }

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
