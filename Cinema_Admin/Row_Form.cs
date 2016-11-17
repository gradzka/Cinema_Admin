﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        DataGridViewSelectedRowCollection row_to_edit;
        List<Label> labels = new List<Label>();
        List<TextBox> textboxes = new List<TextBox>();
        List<ComboBox> comboboxes = new List<ComboBox>();
        CheckBox checkbox = null;

        public Row_Form(int table, int option, DataGridViewSelectedRowCollection row)
        {
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
                case 3: case 4:
                    Init_Row_Form(2);
                    break;
                case 9:
                    Init_Row_Form(0);
                    break;
                default:
                    {
                        MessageBox.Show("Error! Fault with button numeration in Row_Form.cs");
                        break;
                    }
            }
        }
        public void paint_necessary_labels(Label label, int i) //funkcja maluje te labele, obok ktorych textboxy musza byc uzupelnione
        {
            /* active table wskazuje na tabele
             * i wskazuje na i-ta kolumne
             */
            if ((active_table == 1 && (i == 0 || i == 1 || i == 3))
                || (active_table == 2 && (i == 1 || i == 2))
                || (active_table == 3)
                || (active_table == 4 && (i == 0))
                || (active_table == 5 && (i > 0 && i < 6))
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

        public void create_combobox_range(TextBox textbox, int i, object []addRange, string text)
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
        public void create_combobox_entieties(TextBox textbox, int i)
        {
            textbox.Visible = false;
            ComboBox combobox = new ComboBox();
            using (var C_Entities = new CinemaEntities())
            {
                List<string> itemsList = new List<string>();

                if (i == 1) //ID_HALLS
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
                else if (i == 3) //ID_HALLS
                {
                    foreach (var item in C_Entities.HALLS.ToList())
                    {
                        itemsList.Add(item.ID_HALL);
                    }
                }
                else if (i==4) //ID_MOVIE
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
        public void create_comboboxes(TextBox textbox, int i)
        {
            if (active_table == 1 && i == 4) //DODAJ
            {
                create_combobox_range(textbox, i, new string[] { "0", "7", "12", "15", "18" }, "0");
            }

            if (active_table == 2) //PROGRAM
            {
                if (i == 3) //ID_HALLS
                {
                    create_combobox_entieties(textbox,i);
                }
                if (i == 4) //ID_MOVIE
                {
                    create_combobox_entieties(textbox,i);
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
        public void Init_Row_Form(int number_of_foreign_keys)
        {
            string[] names_of_columns = null;
            
            switch (active_table)
            {
                case 1:
                    names_of_columns = typeof(MOVIES).GetProperties().Select(ColumnHeader => ColumnHeader.Name).ToArray();
                    this.Text = "MOVIES";
                    break;
                case 2:
                    names_of_columns = typeof(PROGRAM).GetProperties().Select(ColumnHeader => ColumnHeader.Name).ToArray();
                    this.Text = "PROGRAMS";
                    break;
                case 3:
                    names_of_columns = typeof(HALLS).GetProperties().Select(ColumnHeader => ColumnHeader.Name).ToArray();
                    this.Text = "HALLS";
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
                MessageBox.Show("Error! Fault with button numeration in Row_Form.cs");
                break;
            }
        }
            //Tworzenie labeli, wywolana metoda od kolorowania labeli, tworzenie texboxow, comboboxow i checkboxa
            if (names_of_columns == null) { MessageBox.Show("Error!" + " names_of_columns is null!"); }
            else
            {
                int how_many_columns = names_of_columns.Length - number_of_foreign_keys;

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
                  
                    if ((active_table==2 || active_table==6)&& i==0)
                    {
                        textbox.Enabled = false;
                    }
                    if ((active_table==9 && (i==6 || i==7)))
                    {
                        textbox.Enabled = false;
                    }
                    
                    //Combobox replace TexBox
                    create_comboboxes(textbox, i);

                    textbox.Size = new System.Drawing.Size(120, 20);
                    textbox.TabIndex = i + 12;
                    textbox.Location = new System.Drawing.Point(141, 17 + 25 * i);
                    textboxes.Add(textbox);
                    this.Controls.Add(textbox);
                }
               
                Cancel_button.Location = new System.Drawing.Point(70, labels[labels.Count-1].Location.Y+30);
                OK_button.Location = new System.Drawing.Point(160, labels[labels.Count - 1].Location.Y + 30);
                this.ClientSize = new System.Drawing.Size(310, labels[labels.Count - 1].Location.Y + 70);
            }
         
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if(textboxes[0].Text=="")
            {
                MessageBox.Show("EMPTY");
            }
            
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Row_Form_Load(object sender, EventArgs e)
        {
            if (insert_or_update == 1) //SQL UPDATE <=> EDYTUJ
            {
                for (int i = 0; i < labels.Count; i++)
                {
                    // wylacz mozliwosc edycji
                    if (i == 0) //dla kazdej 0. kolumny tabel
                    {
                        if (active_table != 2 || active_table != 5 || active_table!=9) //tabela users, ID_login
                        {
                            textboxes[i].Enabled = false;
                        }
                    }
                    if (active_table==5 && i==6)
                    {
                        textboxes[i].Enabled = false;
                    }
                    if (active_table == 8 && i == 1) //dla tabeli res_details i 1. kolumny
                    {
                        textboxes[i].Enabled = false;
                    }

                    if (row_to_edit[0].Cells[i].Value != null)
                    {
                        //Combobox - EDYTUJ
                        if (active_table == 1 && i == 4) //MOVIE -> RATING
                        {
                            comboboxes[0].Text = row_to_edit[0].Cells[i].Value.ToString();
                        }
                        else if (active_table == 2 && i == 3) //PROGRAM -> VERSION
                        {
                            comboboxes[0].Text = row_to_edit[0].Cells[i].Value.ToString();
                        }
                        else if (active_table == 2 && i == 4) //PROGRAM -> VERSION
                        {
                            comboboxes[1].Text = row_to_edit[0].Cells[i].Value.ToString();
                        }
                        else if (active_table == 2 && i == 5) //PROGRAM -> C2D_3D
                        {
                            comboboxes[2].Text = row_to_edit[0].Cells[i].Value.ToString();
                        }
                        else if (active_table == 2 && i == 6) //PROGRAM -> VERSION
                        {
                            comboboxes[3].Text = row_to_edit[0].Cells[i].Value.ToString();
                        }

                        else if (active_table == 4 && i == 1) //SEATS -> ID_HALL
                        {
                            comboboxes[0].Text = row_to_edit[0].Cells[i].Value.ToString();
                        }
                        else if (active_table == 4 && i == 2) //SEATS -> VIP
                        {
                            checkbox.Checked = row_to_edit[0].Cells[i].Value.Equals(true) ? true : false;
                        }
                        else if (active_table == 8 && i == 2) //RES_DETAILS -> ID_TICKET
                        {
                            comboboxes[0].Text = row_to_edit[0].Cells[i].Value.ToString();
                        }
                        else
                        {
                            textboxes[i].Text = row_to_edit[0].Cells[i].Value.ToString();
                        }
                    }
                }
            }
        }
    }
}