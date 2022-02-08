
namespace Cinema_System
{
    partial class FormAddReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddReview));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.richTextBox1.Location = new System.Drawing.Point(37, 102);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(440, 283);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Co sądzisz o filmie?";
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("LuzSans-Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tworzenie recenzji";
            // 
            // comboBoxRate
            // 
            this.comboBoxRate.BackColor = System.Drawing.Color.Black;
            this.comboBoxRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRate.Font = new System.Drawing.Font("LuzSans-Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRate.ForeColor = System.Drawing.Color.Firebrick;
            this.comboBoxRate.FormattingEnabled = true;
            this.comboBoxRate.Location = new System.Drawing.Point(424, 62);
            this.comboBoxRate.Name = "comboBoxRate";
            this.comboBoxRate.Size = new System.Drawing.Size(53, 34);
            this.comboBoxRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("LuzSans-Book", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(331, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ocena:";
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Transparent;
            this.buttonSend.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("LuzSans-Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSend.Location = new System.Drawing.Point(37, 396);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(130, 42);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Prześlij";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // FormAddReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinema_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tworzenie recenzji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSend;
    }
}