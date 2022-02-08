
namespace Cinema_System
{
    partial class FormReviews
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReviews));
            this.dataGridViewReviews = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonAddReview = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.labelAvg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReviews
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Firebrick;
            this.dataGridViewReviews.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReviews.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewReviews.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewReviews.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReviews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReviews.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReviews.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReviews.EnableHeadersVisualStyles = false;
            this.dataGridViewReviews.GridColor = System.Drawing.Color.Firebrick;
            this.dataGridViewReviews.Location = new System.Drawing.Point(33, 86);
            this.dataGridViewReviews.Name = "dataGridViewReviews";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReviews.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReviews.RowHeadersVisible = false;
            this.dataGridViewReviews.RowTemplate.Height = 25;
            this.dataGridViewReviews.ShowCellToolTips = false;
            this.dataGridViewReviews.Size = new System.Drawing.Size(734, 316);
            this.dataGridViewReviews.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("LuzSans-Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recenzje filmu:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("LuzSans-Book", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.labelTitle.Location = new System.Drawing.Point(53, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(157, 33);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Nazwa filmu";
            // 
            // buttonAddReview
            // 
            this.buttonAddReview.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddReview.BackgroundImage = global::Cinema_System.Properties.Resources.button;
            this.buttonAddReview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddReview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonAddReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddReview.Font = new System.Drawing.Font("LuzSans-Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddReview.Location = new System.Drawing.Point(53, 408);
            this.buttonAddReview.Name = "buttonAddReview";
            this.buttonAddReview.Size = new System.Drawing.Size(120, 33);
            this.buttonAddReview.TabIndex = 3;
            this.buttonAddReview.Text = "Dodaj";
            this.buttonAddReview.UseVisualStyleBackColor = false;
            this.buttonAddReview.Click += new System.EventHandler(this.buttonAddReview_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("LuzSans-Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.Color.Firebrick;
            this.label.Location = new System.Drawing.Point(479, 41);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(144, 26);
            this.label.TabIndex = 4;
            this.label.Text = "Średnia ocen: ";
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.BackColor = System.Drawing.Color.Transparent;
            this.labelAvg.Font = new System.Drawing.Font("LuzSans-Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAvg.ForeColor = System.Drawing.Color.Firebrick;
            this.labelAvg.Location = new System.Drawing.Point(611, 41);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(25, 26);
            this.labelAvg.TabIndex = 5;
            this.labelAvg.Text = "0";
            // 
            // FormReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinema_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAvg);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonAddReview);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReviews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recenzje";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReviews;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonAddReview;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelAvg;
    }
}