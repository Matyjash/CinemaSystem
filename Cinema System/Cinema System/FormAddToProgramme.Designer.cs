
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
            this.buttonAddScreening = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxHallId = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddScreening
            // 
            this.buttonAddScreening.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddScreening.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonAddScreening.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddScreening.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonAddScreening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddScreening.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddScreening.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAddScreening.Location = new System.Drawing.Point(147, 280);
            this.buttonAddScreening.Name = "buttonAddScreening";
            this.buttonAddScreening.Size = new System.Drawing.Size(150, 49);
            this.buttonAddScreening.TabIndex = 14;
            this.buttonAddScreening.Text = "Dodaj";
            this.buttonAddScreening.UseVisualStyleBackColor = false;
            this.buttonAddScreening.Click += new System.EventHandler(this.buttonAddScreening_Click);
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
            this.textBoxTitle.Text = "Tytuł";
            this.textBoxTitle.Enter += new System.EventHandler(this.textBoxTitle_Enter);
            this.textBoxTitle.Leave += new System.EventHandler(this.textBoxTitle_Leave);
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
            this.textBoxHallId.Enter += new System.EventHandler(this.textBoxHallId_Enter);
            this.textBoxHallId.Leave += new System.EventHandler(this.textBoxHallId_Leave);
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
            this.textBoxYear.Enter += new System.EventHandler(this.textBoxYear_Enter);
            this.textBoxYear.Leave += new System.EventHandler(this.textBoxYear_Leave);
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxMonth.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMonth.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxMonth.Location = new System.Drawing.Point(120, 162);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(56, 29);
            this.textBoxMonth.TabIndex = 17;
            this.textBoxMonth.Text = "MM";
            this.textBoxMonth.Enter += new System.EventHandler(this.textBoxMonth_Enter);
            this.textBoxMonth.Leave += new System.EventHandler(this.textBoxMonth_Leave);
            // 
            // textBoxDay
            // 
            this.textBoxDay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxDay.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDay.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDay.Location = new System.Drawing.Point(182, 162);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(56, 29);
            this.textBoxDay.TabIndex = 18;
            this.textBoxDay.Text = "DD";
            this.textBoxDay.Enter += new System.EventHandler(this.textBoxDay_Enter);
            this.textBoxDay.Leave += new System.EventHandler(this.textBoxDay_Leave);
            // 
            // textBoxHour
            // 
            this.textBoxHour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxHour.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHour.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxHour.Location = new System.Drawing.Point(258, 162);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(56, 29);
            this.textBoxHour.TabIndex = 19;
            this.textBoxHour.Text = "hh";
            this.textBoxHour.Enter += new System.EventHandler(this.textBoxHour_Enter);
            this.textBoxHour.Leave += new System.EventHandler(this.textBoxHour_Leave);
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxMinutes.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMinutes.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxMinutes.Location = new System.Drawing.Point(319, 162);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(56, 29);
            this.textBoxMinutes.TabIndex = 20;
            this.textBoxMinutes.Text = "mm";
            this.textBoxMinutes.Enter += new System.EventHandler(this.textBoxMinutes_Enter);
            this.textBoxMinutes.Leave += new System.EventHandler(this.textBoxMinutes_Leave);
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
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxHallId);
            this.Controls.Add(this.buttonAddScreening);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddToProgramme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie seansu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddScreening;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxHallId;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
    }
}