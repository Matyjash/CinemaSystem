
namespace Cinema_System
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.buttonProgramme = new System.Windows.Forms.Button();
            this.buttonMovies = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonBuyTicket = new System.Windows.Forms.Button();
            this.buttonCheckHall = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonReviews = new System.Windows.Forms.Button();
            this.buttonGetTickets = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToResizeColumns = false;
            this.dataGridViewMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMain.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMain.ColumnHeadersHeight = 25;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMain.EnableHeadersVisualStyles = false;
            this.dataGridViewMain.GridColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("LuzSans-Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridViewMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridViewMain.RowTemplate.Height = 25;
            this.dataGridViewMain.Size = new System.Drawing.Size(909, 262);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // buttonProgramme
            // 
            this.buttonProgramme.BackColor = System.Drawing.Color.Transparent;
            this.buttonProgramme.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonProgramme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProgramme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonProgramme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProgramme.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonProgramme.Location = new System.Drawing.Point(947, 141);
            this.buttonProgramme.Name = "buttonProgramme";
            this.buttonProgramme.Size = new System.Drawing.Size(116, 37);
            this.buttonProgramme.TabIndex = 2;
            this.buttonProgramme.Text = "Repertuar";
            this.buttonProgramme.UseVisualStyleBackColor = false;
            this.buttonProgramme.Click += new System.EventHandler(this.buttonProgramme_Click);
            // 
            // buttonMovies
            // 
            this.buttonMovies.BackColor = System.Drawing.Color.Transparent;
            this.buttonMovies.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMovies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovies.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMovies.Location = new System.Drawing.Point(947, 184);
            this.buttonMovies.Name = "buttonMovies";
            this.buttonMovies.Size = new System.Drawing.Size(116, 37);
            this.buttonMovies.TabIndex = 3;
            this.buttonMovies.Text = "Filmy";
            this.buttonMovies.UseVisualStyleBackColor = false;
            this.buttonMovies.Click += new System.EventHandler(this.buttonMovies_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(12, 599);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(116, 37);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(956, 517);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 37);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(956, 560);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(116, 37);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(956, 603);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(116, 37);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonBuyTicket
            // 
            this.buttonBuyTicket.BackColor = System.Drawing.Color.Transparent;
            this.buttonBuyTicket.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonBuyTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBuyTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonBuyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuyTicket.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBuyTicket.Location = new System.Drawing.Point(354, 599);
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(116, 37);
            this.buttonBuyTicket.TabIndex = 8;
            this.buttonBuyTicket.Text = "Kup bilet";
            this.buttonBuyTicket.UseVisualStyleBackColor = false;
            this.buttonBuyTicket.Visible = false;
            this.buttonBuyTicket.Click += new System.EventHandler(this.buttonBuyTicket_Click);
            // 
            // buttonCheckHall
            // 
            this.buttonCheckHall.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheckHall.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonCheckHall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCheckHall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonCheckHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckHall.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCheckHall.Location = new System.Drawing.Point(598, 599);
            this.buttonCheckHall.Name = "buttonCheckHall";
            this.buttonCheckHall.Size = new System.Drawing.Size(116, 37);
            this.buttonCheckHall.TabIndex = 9;
            this.buttonCheckHall.Text = "Stan sali";
            this.buttonCheckHall.UseVisualStyleBackColor = false;
            this.buttonCheckHall.Visible = false;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegister.Location = new System.Drawing.Point(146, 599);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(116, 37);
            this.buttonRegister.TabIndex = 10;
            this.buttonRegister.Text = "Rejestracja";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(937, 65);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(135, 29);
            this.textBoxSearch.TabIndex = 11;
            this.textBoxSearch.Text = "Szukaj...";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // buttonReviews
            // 
            this.buttonReviews.BackColor = System.Drawing.Color.Transparent;
            this.buttonReviews.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonReviews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReviews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReviews.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReviews.Location = new System.Drawing.Point(720, 599);
            this.buttonReviews.Name = "buttonReviews";
            this.buttonReviews.Size = new System.Drawing.Size(116, 37);
            this.buttonReviews.TabIndex = 12;
            this.buttonReviews.Text = "Recenzje";
            this.buttonReviews.UseVisualStyleBackColor = false;
            this.buttonReviews.Visible = false;
            this.buttonReviews.Click += new System.EventHandler(this.buttonReviews_Click);
            // 
            // buttonGetTickets
            // 
            this.buttonGetTickets.BackColor = System.Drawing.Color.Transparent;
            this.buttonGetTickets.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonGetTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGetTickets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonGetTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetTickets.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGetTickets.Location = new System.Drawing.Point(476, 599);
            this.buttonGetTickets.Name = "buttonGetTickets";
            this.buttonGetTickets.Size = new System.Drawing.Size(116, 37);
            this.buttonGetTickets.TabIndex = 13;
            this.buttonGetTickets.Text = "Moje bilety";
            this.buttonGetTickets.UseVisualStyleBackColor = false;
            this.buttonGetTickets.Visible = false;
            this.buttonGetTickets.Click += new System.EventHandler(this.buttonGetTickets_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.buttonGetTickets);
            this.Controls.Add(this.buttonReviews);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonCheckHall);
            this.Controls.Add(this.buttonBuyTicket);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonMovies);
            this.Controls.Add(this.buttonProgramme);
            this.Controls.Add(this.dataGridViewMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonProgramme;
        private System.Windows.Forms.Button buttonMovies;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonBuyTicket;
        private System.Windows.Forms.Button buttonCheckHall;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonReviews;
        private System.Windows.Forms.Button buttonGetTickets;
    }
}

