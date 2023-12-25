namespace Tyuiu.KorneevaEA.Sprint7.Project.V1
{
    partial class FormForUser
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
            this.labelIntro_KEA = new System.Windows.Forms.Label();
            this.labelOpening_KEA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIntro_KEA
            // 
            this.labelIntro_KEA.AutoSize = true;
            this.labelIntro_KEA.Location = new System.Drawing.Point(12, 24);
            this.labelIntro_KEA.Name = "labelIntro_KEA";
            this.labelIntro_KEA.Size = new System.Drawing.Size(540, 13);
            this.labelIntro_KEA.TabIndex = 0;
            this.labelIntro_KEA.Text = "Данный проект создан для чтения, редактирования и сортировки данных о авторемонтн" +
    "ых мастерских.";
            // 
            // labelOpening_KEA
            // 
            this.labelOpening_KEA.AutoSize = true;
            this.labelOpening_KEA.Location = new System.Drawing.Point(12, 80);
            this.labelOpening_KEA.Name = "labelOpening_KEA";
            this.labelOpening_KEA.Size = new System.Drawing.Size(0, 13);
            this.labelOpening_KEA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Раздел \"Добавить автомастерскую\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Входные данные";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.ShunanovKE.Sprint7.Project.V1.Properties.Resources.Снимок_экрана_2023_12_25_215426;
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 143);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 624);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOpening_KEA);
            this.Controls.Add(this.labelIntro_KEA);
            this.Name = "FormForUser";
            this.Text = "Руководство пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIntro_KEA;
        private System.Windows.Forms.Label labelOpening_KEA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}