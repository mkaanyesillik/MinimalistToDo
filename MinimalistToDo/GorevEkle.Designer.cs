namespace MinimalistToDo
{
    partial class GorevEkle
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
            this.txtGorevAdi = new System.Windows.Forms.TextBox();
            this.txtTahminiTamamlama = new System.Windows.Forms.TextBox();
            this.txtGorevAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGorevAdi
            // 
            this.txtGorevAdi.Location = new System.Drawing.Point(199, 10);
            this.txtGorevAdi.Name = "txtGorevAdi";
            this.txtGorevAdi.Size = new System.Drawing.Size(589, 20);
            this.txtGorevAdi.TabIndex = 0;
            // 
            // txtTahminiTamamlama
            // 
            this.txtTahminiTamamlama.Location = new System.Drawing.Point(199, 171);
            this.txtTahminiTamamlama.Name = "txtTahminiTamamlama";
            this.txtTahminiTamamlama.Size = new System.Drawing.Size(589, 20);
            this.txtTahminiTamamlama.TabIndex = 4;
            // 
            // txtGorevAciklama
            // 
            this.txtGorevAciklama.Location = new System.Drawing.Point(199, 43);
            this.txtGorevAciklama.Multiline = true;
            this.txtGorevAciklama.Name = "txtGorevAciklama";
            this.txtGorevAciklama.Size = new System.Drawing.Size(589, 119);
            this.txtGorevAciklama.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Görev Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Görev Açıklama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Görev Tahmini Tamamlama Zamanı :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(199, 197);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 36);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(345, 197);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(140, 36);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // GorevEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGorevAciklama);
            this.Controls.Add(this.txtTahminiTamamlama);
            this.Controls.Add(this.txtGorevAdi);
            this.Name = "GorevEkle";
            this.Text = "GorevEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGorevAdi;
        private System.Windows.Forms.TextBox txtTahminiTamamlama;
        private System.Windows.Forms.TextBox txtGorevAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
    }
}