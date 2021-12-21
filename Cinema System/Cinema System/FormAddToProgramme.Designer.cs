
namespace Cinema_System
{
    partial class FormAddToProgramme
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
            this.buttonAddToMovies = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxHallId = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.buttonAddToMovies.Location = new System.Drawing.Point(147, 280);
            this.buttonAddToMovies.Name = "buttonAddToMovies";
            this.buttonAddToMovies.Size = new System.Drawing.Size(150, 49);
            this.buttonAddToMovies.TabIndex = 14;
            this.buttonAddToMovies.Text = "Dodaj";
            this.buttonAddToMovies.UseVisualStyleBackColor = false;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTitle.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitle.Location = new System.Drawing.Point(48, 84);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(327, 29);
            this.textBoxTitle.TabIndex = 9;
            this.textBoxTitle.Text = "Tytuł filmu";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("LuzSans-Book", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.labelTitle.Location = new System.Drawing.Point(80, 26);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(275, 39);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Dodawanie seansu";
            // 
            // textBoxHallId
            // 
            this.textBoxHallId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxHallId.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxHallId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHallId.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxHallId.Location = new System.Drawing.Point(48, 225);
            this.textBoxHallId.Name = "textBoxHallId";
            this.textBoxHallId.Size = new System.Drawing.Size(89, 29);
            this.textBoxHallId.TabIndex = 15;
            this.textBoxHallId.Text = "ID sali";
            // 
            // textBoxYear
            // 
            this.textBoxYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxYear.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYear.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxYear.Location = new System.Drawing.Point(48, 162);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(66, 29);
            this.textBoxYear.TabIndex = 16;
            this.textBoxYear.Text = "YYYY";
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.BackColor = System.Drawing.Color.Firebrick;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(120, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 29);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "MM";
            // 
            // textBox3
            // 
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox3.BackColor = System.Drawing.Color.Firebrick;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(182, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 29);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "DD";
            // 
            // textBox4
            // 
            this.textBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox4.BackColor = System.Drawing.Color.Firebrick;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(258, 162);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 29);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "hh";
            // 
            // textBox5
            // 
            this.textBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox5.BackColor = System.Drawing.Color.Firebrick;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(319, 162);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(56, 29);
            this.textBox5.TabIndex = 20;
            this.textBox5.Text = "mm";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.Firebrick;
            this.labelDate.Location = new System.Drawing.Point(48, 131);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(104, 22);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "Data seansu";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.Firebrick;
            this.labelTime.Location = new System.Drawing.Point(258, 131);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(77, 22);
            this.labelTime.TabIndex = 22;
            this.labelTime.Text = "Godzina";
            // 
            // FormAddToProgramme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 355);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxHallId);
            this.Controls.Add(this.buttonAddToMovies);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormAddToProgramme";
            this.Text = "FormAddToProgramme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddToMovies;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxHallId;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
    }
}