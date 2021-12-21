
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
            this.textBoxReleaseDate = new System.Windows.Forms.TextBox();
            this.buttonAddToMovies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("LuzSans-Book", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.labelTitle.Location = new System.Drawing.Point(105, 27);
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
            // 
            // textBoxReleaseDate
            // 
            this.textBoxReleaseDate.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReleaseDate.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxReleaseDate.Location = new System.Drawing.Point(48, 267);
            this.textBoxReleaseDate.Name = "textBoxReleaseDate";
            this.textBoxReleaseDate.Size = new System.Drawing.Size(327, 29);
            this.textBoxReleaseDate.TabIndex = 5;
            this.textBoxReleaseDate.Text = "Data premiery (YYYY-MM-DD)";
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
            this.buttonAddToMovies.Location = new System.Drawing.Point(141, 328);
            this.buttonAddToMovies.Name = "buttonAddToMovies";
            this.buttonAddToMovies.Size = new System.Drawing.Size(150, 49);
            this.buttonAddToMovies.TabIndex = 7;
            this.buttonAddToMovies.Text = "Dodaj";
            this.buttonAddToMovies.UseVisualStyleBackColor = false;
            // 
            // FormAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.buttonAddToMovies);
            this.Controls.Add(this.textBoxReleaseDate);
            this.Controls.Add(this.textBoxDirectorLastName);
            this.Controls.Add(this.textBoxDirectorFirstName);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddMovie";
            this.Text = "FormAddMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxDirectorFirstName;
        private System.Windows.Forms.TextBox textBoxDirectorLastName;
        private System.Windows.Forms.TextBox textBoxReleaseDate;
        private System.Windows.Forms.Button buttonAddToMovies;
    }
}