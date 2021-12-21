
namespace Cinema_System
{
    partial class FormAddChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddChoice));
            this.buttonAddFilm = new System.Windows.Forms.Button();
            this.buttonAddToProgramme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddFilm
            // 
            resources.ApplyResources(this.buttonAddFilm, "buttonAddFilm");
            this.buttonAddFilm.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddFilm.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonAddFilm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonAddFilm.Name = "buttonAddFilm";
            this.buttonAddFilm.UseVisualStyleBackColor = false;
            this.buttonAddFilm.Click += new System.EventHandler(this.buttonAddFilm_Click);
            // 
            // buttonAddToProgramme
            // 
            resources.ApplyResources(this.buttonAddToProgramme, "buttonAddToProgramme");
            this.buttonAddToProgramme.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddToProgramme.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonAddToProgramme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonAddToProgramme.Name = "buttonAddToProgramme";
            this.buttonAddToProgramme.UseVisualStyleBackColor = false;
            this.buttonAddToProgramme.Click += new System.EventHandler(this.buttonAddToProgramme_Click);
            // 
            // FormAddChoice
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.buttonAddToProgramme);
            this.Controls.Add(this.buttonAddFilm);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddChoice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddFilm;
        private System.Windows.Forms.Button buttonAddToProgramme;
    }
}