namespace MinimalistToDo
{
    partial class MinimalToDo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmrStartPosition = new System.Windows.Forms.Timer(this.components);
            this.tmrGizle = new System.Windows.Forms.Timer(this.components);
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnGizleGoser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrStartPosition
            // 
            this.tmrStartPosition.Interval = 1;
            this.tmrStartPosition.Tick += new System.EventHandler(this.tmrStartPosition_Tick);
            // 
            // tmrGizle
            // 
            this.tmrGizle.Interval = 1;
            this.tmrGizle.Tick += new System.EventHandler(this.tmrGizle_Tick);
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGorevEkle.Location = new System.Drawing.Point(74, 508);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(520, 39);
            this.btnGorevEkle.TabIndex = 1;
            this.btnGorevEkle.Text = "Görev Ekle";
            this.btnGorevEkle.UseVisualStyleBackColor = true;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Beige;
            this.dataGridView1.Location = new System.Drawing.Point(20, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(575, 454);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 1;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(75, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(520, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seçili Satırı Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGizleGoser
            // 
            this.btnGizleGoser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGizleGoser.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnGizleGoser.Font = new System.Drawing.Font("Noto Serif Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGizleGoser.Location = new System.Drawing.Point(0, 199);
            this.btnGizleGoser.Name = "btnGizleGoser";
            this.btnGizleGoser.Size = new System.Drawing.Size(20, 348);
            this.btnGizleGoser.TabIndex = 4;
            this.btnGizleGoser.Text = "Gizle/Göster";
            this.btnGizleGoser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGizleGoser.Click += new System.EventHandler(this.btnGizle_Click);
            this.btnGizleGoser.MouseHover += new System.EventHandler(this.btnGizle_MouseHover);
            // 
            // MinimalToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.btnGizleGoser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGorevEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MinimalToDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.MinimalToDo_Activated);
            this.Load += new System.EventHandler(this.MinimalToDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrStartPosition;
        private System.Windows.Forms.Timer tmrGizle;
        private System.Windows.Forms.Button btnGorevEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label btnGizleGoser;
    }
}

