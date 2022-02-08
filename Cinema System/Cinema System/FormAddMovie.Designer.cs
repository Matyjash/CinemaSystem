
namespace Cinema_System
{
    partial class FormAddMovie
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxDirectorFirstName = new System.Windows.Forms.TextBox();
            this.textBoxDirectorLastName = new System.Windows.Forms.TextBox();
            this.buttonAddToMovies = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("LuzSans-Book", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.labelTitle.Location = new System.Drawing.Point(90, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(247, 39);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Dodawanie filmu";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTitle.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitle.Location = new System.Drawing.Point(48, 119);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(327, 29);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.Text = "Tytuł filmu";
            this.textBoxTitle.Enter += new System.EventHandler(this.textBoxTitle_Enter);
            this.textBoxTitle.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGenre.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxGenre.Location = new System.Drawing.Point(48, 167);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(327, 29);
            this.textBoxGenre.TabIndex = 2;
            this.textBoxGenre.Text = "Gatunek";
            this.textBoxGenre.Enter += new System.EventHandler(this.textBoxGenre_Enter);
            this.textBoxGenre.Leave += new System.EventHandler(this.textBoxGenre_Leave);
            // 
            // textBoxDirectorFirstName
            // 
            this.textBoxDirectorFirstName.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxDirectorFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDirectorFirstName.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDirectorFirstName.Location = new System.Drawing.Point(48, 215);
            this.textBoxDirectorFirstName.Name = "textBoxDirectorFirstName";
            this.textBoxDirectorFirstName.Size = new System.Drawing.Size(155, 29);
            this.textBoxDirectorFirstName.TabIndex = 3;
            this.textBoxDirectorFirstName.Text = "Imię reżysera";
            this.textBoxDirectorFirstName.Enter += new System.EventHandler(this.textBoxDirectorFirstName_Enter);
            this.textBoxDirectorFirstName.Leave += new System.EventHandler(this.textBoxDirectorFirstName_Leave);
            // 
            // textBoxDirectorLastName
            // 
            this.textBoxDirectorLastName.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxDirectorLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDirectorLastName.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDirectorLastName.Location = new System.Drawing.Point(220, 215);
            this.textBoxDirectorLastName.Name = "textBoxDirectorLastName";
            this.textBoxDirectorLastName.Size = new System.Drawing.Size(155, 29);
            this.textBoxDirectorLastName.TabIndex = 4;
            this.textBoxDirectorLastName.Text = "Nazwisko reżysera";
            this.textBoxDirectorLastName.Enter += new System.EventHandler(this.textBoxDirectorLastName_Enter);
            this.textBoxDirectorLastName.Leave += new System.EventHandler(this.textBoxDirectorLastName_Leave);
            // 
            // buttonAddToMovies
            // 
            this.buttonAddToMovies.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddToMovies.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonAddToMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddToMovies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonAddToMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToMovies.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddToMovies.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAddToMovies.Location = new System.Drawing.Point(134, 350);
            this.buttonAddToMovies.Name = "buttonAddToMovies";
            this.buttonAddToMovies.Size = new System.Drawing.Size(150, 49);
            this.buttonAddToMovies.TabIndex = 7;
            this.buttonAddToMovies.Text = "Dodaj";
            this.buttonAddToMovies.UseVisualStyleBackColor = false;
            this.buttonAddToMovies.Click += new System.EventHandler(this.buttonAddToMovies_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.Firebrick;
            this.labelDate.Location = new System.Drawing.Point(48, 266);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(121, 22);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Data premiery";
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYear.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxYear.Location = new System.Drawing.Point(48, 303);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(77, 29);
            this.textBoxYear.TabIndex = 9;
            this.textBoxYear.Text = "YYYY";
            this.textBoxYear.Enter += new System.EventHandler(this.textBoxYear_Enter);
            this.textBoxYear.Leave += new System.EventHandler(this.textBoxYear_Leave);
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMonth.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxMonth.Location = new System.Drawing.Point(134, 303);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(49, 29);
            this.textBoxMonth.TabIndex = 10;
            this.textBoxMonth.Text = "MM";
            this.textBoxMonth.Enter += new System.EventHandler(this.textBoxMonth_Enter);
            this.textBoxMonth.Leave += new System.EventHandler(this.textBoxMonth_Leave);
            // 
            // textBoxDay
            // 
            this.textBoxDay.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDay.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDay.Location = new System.Drawing.Point(189, 303);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(49, 29);
            this.textBoxDay.TabIndex = 11;
            this.textBoxDay.Text = "DD";
            this.textBoxDay.Enter += new System.EventHandler(this.textBoxDay_Enter);
            this.textBoxDay.Leave += new System.EventHandler(this.textBoxDay_Leave);
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.AutoSize = true;
            this.labelMovieTitle.Font = new System.Drawing.Font("LuzSans-Book", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMovieTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.labelMovieTitle.Location = new System.Drawing.Point(90, 77);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(0, 39);
            this.labelMovieTitle.TabIndex = 12;
            // 
            // FormAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.labelMovieTitle);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonAddToMovies);
            this.Controls.Add(this.textBoxDirectorLastName);
            this.Controls.Add(this.textBoxDirectorFirstName);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie filmu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxDirectorFirstName;
        private System.Windows.Forms.TextBox textBoxDirectorLastName;
        private System.Windows.Forms.Button buttonAddToMovies;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.Label labelMovieTitle;
    }
}