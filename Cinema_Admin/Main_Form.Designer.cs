namespace Cinema_Admin
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.l_active_table = new System.Windows.Forms.Label();
            this.b_add_tuple = new System.Windows.Forms.Button();
            this.b_delete_tuple = new System.Windows.Forms.Button();
            this.b_modify_tuple = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TableGridView = new System.Windows.Forms.DataGridView();
            this.b_logout = new System.Windows.Forms.Button();
            this.b_admin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_res_details = new System.Windows.Forms.Button();
            this.b_reservations = new System.Windows.Forms.Button();
            this.b_tickets = new System.Windows.Forms.Button();
            this.b_users = new System.Windows.Forms.Button();
            this.b_seats = new System.Windows.Forms.Button();
            this.b_halls = new System.Windows.Forms.Button();
            this.b_program = new System.Windows.Forms.Button();
            this.b_movies = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_active_table
            // 
            this.l_active_table.BackColor = System.Drawing.Color.Transparent;
            this.l_active_table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_active_table.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_active_table.ForeColor = System.Drawing.Color.White;
            this.l_active_table.Location = new System.Drawing.Point(299, 301);
            this.l_active_table.Name = "l_active_table";
            this.l_active_table.Size = new System.Drawing.Size(291, 19);
            this.l_active_table.TabIndex = 11;
            this.l_active_table.Text = "Aktywna tabela: FILMY";
            this.l_active_table.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // b_add_tuple
            // 
            this.b_add_tuple.BackColor = System.Drawing.SystemColors.Highlight;
            this.b_add_tuple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add_tuple.Location = new System.Drawing.Point(23, 19);
            this.b_add_tuple.Name = "b_add_tuple";
            this.b_add_tuple.Size = new System.Drawing.Size(80, 25);
            this.b_add_tuple.TabIndex = 12;
            this.b_add_tuple.Text = "DODAJ";
            this.b_add_tuple.UseVisualStyleBackColor = false;
            this.b_add_tuple.Click += new System.EventHandler(this.b_add_tuple_Click);
            // 
            // b_delete_tuple
            // 
            this.b_delete_tuple.BackColor = System.Drawing.SystemColors.Highlight;
            this.b_delete_tuple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_delete_tuple.Location = new System.Drawing.Point(189, 19);
            this.b_delete_tuple.Name = "b_delete_tuple";
            this.b_delete_tuple.Size = new System.Drawing.Size(80, 25);
            this.b_delete_tuple.TabIndex = 13;
            this.b_delete_tuple.Text = "USUŃ";
            this.b_delete_tuple.UseVisualStyleBackColor = false;
            this.b_delete_tuple.Click += new System.EventHandler(this.b_delete_tuple_Click);
            // 
            // b_modify_tuple
            // 
            this.b_modify_tuple.BackColor = System.Drawing.SystemColors.Highlight;
            this.b_modify_tuple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_modify_tuple.Location = new System.Drawing.Point(106, 19);
            this.b_modify_tuple.Name = "b_modify_tuple";
            this.b_modify_tuple.Size = new System.Drawing.Size(80, 25);
            this.b_modify_tuple.TabIndex = 14;
            this.b_modify_tuple.Text = "EDYTUJ";
            this.b_modify_tuple.UseVisualStyleBackColor = false;
            this.b_modify_tuple.Click += new System.EventHandler(this.b_modify_tuple_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_add_tuple);
            this.groupBox1.Controls.Add(this.b_delete_tuple);
            this.groupBox1.Controls.Add(this.b_modify_tuple);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(299, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 55);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERACJE NA TABELACH";
            // 
            // TableGridView
            // 
            this.TableGridView.AllowUserToOrderColumns = true;
            this.TableGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.TableGridView.Location = new System.Drawing.Point(194, 12);
            this.TableGridView.MultiSelect = false;
            this.TableGridView.Name = "TableGridView";
            this.TableGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableGridView.Size = new System.Drawing.Size(505, 276);
            this.TableGridView.TabIndex = 16;
            // 
            // b_logout
            // 
            this.b_logout.BackColor = System.Drawing.Color.Salmon;
            this.b_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_logout.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_logout.Location = new System.Drawing.Point(619, 342);
            this.b_logout.Name = "b_logout";
            this.b_logout.Size = new System.Drawing.Size(80, 25);
            this.b_logout.TabIndex = 17;
            this.b_logout.Text = "WYLOGUJ";
            this.b_logout.UseVisualStyleBackColor = false;
            this.b_logout.Click += new System.EventHandler(this.b_logout_Click);
            // 
            // b_admin
            // 
            this.b_admin.BackColor = System.Drawing.SystemColors.GrayText;
            this.b_admin.BackgroundImage = global::Cinema_Admin.Properties.Resources.admin;
            this.b_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_admin.Location = new System.Drawing.Point(182, 304);
            this.b_admin.Name = "b_admin";
            this.b_admin.Size = new System.Drawing.Size(85, 75);
            this.b_admin.TabIndex = 18;
            this.b_admin.UseVisualStyleBackColor = false;
            this.b_admin.Click += new System.EventHandler(this.b_admin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema_Admin.Properties.Resources.kino_title;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // b_res_details
            // 
            this.b_res_details.BackColor = System.Drawing.SystemColors.GrayText;
            this.b_res_details.BackgroundImage = global::Cinema_Admin.Properties.Resources.movie_script;
            this.b_res_details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_res_details.Location = new System.Drawing.Point(97, 304);
            this.b_res_details.Name = "b_res_details";
            this.b_res_details.Size = new System.Drawing.Size(85, 75);
            this.b_res_details.TabIndex = 9;
            this.b_res_details.UseVisualStyleBackColor = false;
            this.b_res_details.Click += new System.EventHandler(this.b_res_details_Click);
            // 
            // b_reservations
            // 
            this.b_reservations.BackColor = System.Drawing.SystemColors.GrayText;
            this.b_reservations.BackgroundImage = global::Cinema_Admin.Properties.Resources.cinema_ticket_window;
            this.b_reservations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_reservations.Location = new System.Drawing.Point(97, 229);
            this.b_reservations.Name = "b_reservations";
            this.b_reservations.Size = new System.Drawing.Size(85, 75);
            this.b_reservations.TabIndex = 8;
            this.b_reservations.UseVisualStyleBackColor = false;
            this.b_reservations.Click += new System.EventHandler(this.b_reservations_Click);
            // 
            // b_tickets
            // 
            this.b_tickets.BackColor = System.Drawing.SystemColors.GrayText;
            this.b_tickets.BackgroundImage = global::Cinema_Admin.Properties.Resources.two_tickets;
            this.b_tickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_tickets.Location = new System.Drawing.Point(97, 154);
            this.b_tickets.Name = "b_tickets";
            this.b_tickets.Size = new System.Drawing.Size(85, 75);
            this.b_tickets.TabIndex = 7;
            this.b_tickets.UseVisualStyleBackColor = false;
            this.b_tickets.Click += new System.EventHandler(this.b_tickets_Click);
            // 
            // b_users
            // 
            this.b_users.BackColor = System.Drawing.SystemColors.GrayText;
            this.b_users.BackgroundImage = global::Cinema_Admin.Properties.Resources.boy_with_3d_spectacles_at_cinema;
            this.b_users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_users.Location = new System.Drawing.Point(97, 79);
            this.b_users.Name = "b_users";
            this.b_users.Size = new System.Drawing.Size(85, 75);
            this.b_users.TabIndex = 6;
            this.b_users.UseVisualStyleBackColor = false;
            this.b_users.Click += new System.EventHandler(this.b_users_Click);
            // 
            // b_seats
            // 
            this.b_seats.BackColor = System.Drawing.SystemColors.GrayText;
            this.b_seats.BackgroundImage = global::Cinema_Admin.Properties.Resources.armchair;
            this.b_seats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_seats.Location = new System.Drawing.Point(12, 304);
            this.b_seats.Name = "b_seats";
            this.b_seats.Size = new System.Drawing.Size(85, 75);
            this.b_seats.TabIndex = 5;
            this.b_seats.UseVisualStyleBackColor = false;
            this.b_seats.Click += new System.EventHandler(this.b_seats_Click);
            // 
            // b_halls
            // 
            this.b_halls.BackColor = System.Drawing.SystemColors.GrayText;
            this.b_halls.BackgroundImage = global::Cinema_Admin.Properties.Resources.people_watching_a_movie;
            this.b_halls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_halls.Location = new System.Drawing.Point(12, 229);
            this.b_halls.Name = "b_halls";
            this.b_halls.Size = new System.Drawing.Size(85, 75);
            this.b_halls.TabIndex = 4;
            this.b_halls.UseVisualStyleBackColor = false;
            this.b_halls.Click += new System.EventHandler(this.b_halls_Click);
            // 
            // b_program
            // 
            this.b_program.BackColor = System.Drawing.SystemColors.GrayText;
            this.b_program.BackgroundImage = global::Cinema_Admin.Properties.Resources.projector_screen;
            this.b_program.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_program.Location = new System.Drawing.Point(12, 154);
            this.b_program.Name = "b_program";
            this.b_program.Size = new System.Drawing.Size(85, 75);
            this.b_program.TabIndex = 3;
            this.b_program.UseVisualStyleBackColor = false;
            this.b_program.Click += new System.EventHandler(this.b_program_Click);
            // 
            // b_movies
            // 
            this.b_movies.BackColor = System.Drawing.SystemColors.Highlight;
            this.b_movies.BackgroundImage = global::Cinema_Admin.Properties.Resources.cinema_clapper_;
            this.b_movies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_movies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_movies.ForeColor = System.Drawing.Color.White;
            this.b_movies.Location = new System.Drawing.Point(12, 79);
            this.b_movies.Name = "b_movies";
            this.b_movies.Size = new System.Drawing.Size(85, 75);
            this.b_movies.TabIndex = 2;
            this.b_movies.Tag = "FILMY";
            this.b_movies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_movies.UseVisualStyleBackColor = false;
            this.b_movies.Click += new System.EventHandler(this.b_movies_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(711, 390);
            this.Controls.Add(this.b_admin);
            this.Controls.Add(this.b_logout);
            this.Controls.Add(this.TableGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.l_active_table);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_res_details);
            this.Controls.Add(this.b_reservations);
            this.Controls.Add(this.b_tickets);
            this.Controls.Add(this.b_users);
            this.Controls.Add(this.b_seats);
            this.Controls.Add(this.b_halls);
            this.Controls.Add(this.b_program);
            this.Controls.Add(this.b_movies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PANEL ADMINISTRATORA";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button b_movies;
        private System.Windows.Forms.Button b_program;
        private System.Windows.Forms.Button b_halls;
        private System.Windows.Forms.Button b_seats;
        private System.Windows.Forms.Button b_users;
        private System.Windows.Forms.Button b_tickets;
        private System.Windows.Forms.Button b_reservations;
        private System.Windows.Forms.Button b_res_details;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_active_table;
        private System.Windows.Forms.Button b_add_tuple;
        private System.Windows.Forms.Button b_delete_tuple;
        private System.Windows.Forms.Button b_modify_tuple;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TableGridView;
        private System.Windows.Forms.Button b_logout;
        private System.Windows.Forms.Button b_admin;
    }
}