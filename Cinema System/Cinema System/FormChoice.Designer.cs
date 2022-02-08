
namespace Cinema_System
{
    partial class FormChoice
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
            this.buttonMovie = new System.Windows.Forms.Button();
            this.buttonScreening = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMovie
            // 
            this.buttonMovie.BackColor = System.Drawing.Color.Transparent;
            this.buttonMovie.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovie.Font = new System.Drawing.Font("LuzSans-Book", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMovie.Location = new System.Drawing.Point(41, 90);
            this.buttonMovie.Name = "buttonMovie";
            this.buttonMovie.Size = new System.Drawing.Size(175, 69);
            this.buttonMovie.TabIndex = 0;
            this.buttonMovie.Text = "Film";
            this.buttonMovie.UseVisualStyleBackColor = false;
            this.buttonMovie.Click += new System.EventHandler(this.buttonMovie_Click);
            // 
            // buttonScreening
            // 
            this.buttonScreening.BackColor = System.Drawing.Color.Transparent;
            this.buttonScreening.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonScreening.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonScreening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScreening.Font = new System.Drawing.Font("LuzSans-Book", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonScreening.Location = new System.Drawing.Point(252, 90);
            this.buttonScreening.Name = "buttonScreening";
            this.buttonScreening.Size = new System.Drawing.Size(175, 69);
            this.buttonScreening.TabIndex = 1;
            this.buttonScreening.Text = "Seans";
            this.buttonScreening.UseVisualStyleBackColor = false;
            this.buttonScreening.Click += new System.EventHandler(this.buttonScreening_Click);
            // 
            // FormChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(452, 269);
            this.Controls.Add(this.buttonScreening);
            this.Controls.Add(this.buttonMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wybór";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMovie;
        private System.Windows.Forms.Button buttonScreening;
    }
}