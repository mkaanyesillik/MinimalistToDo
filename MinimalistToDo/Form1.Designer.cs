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
            this.btnGizle = new System.Windows.Forms.Button();
            this.tmrStartPosition = new System.Windows.Forms.Timer(this.components);
            this.tmrGizle = new System.Windows.Forms.Timer(this.components);
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGizle
            // 
            this.btnGizle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGizle.AutoEllipsis = true;
            this.btnGizle.Location = new System.Drawing.Point(0, 220);
            this.btnGizle.MaximumSize = new System.Drawing.Size(60, 60);
            this.btnGizle.Name = "btnGizle";
            this.btnGizle.Size = new System.Drawing.Size(60, 23);
            this.btnGizle.TabIndex = 0;
            this.btnGizle.Text = "Gizle";
            this.btnGizle.UseVisualStyleBackColor = true;
            this.btnGizle.Click += new System.EventHandler(this.btnGizle_Click);
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
            this.btnGorevEkle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGorevEkle.Location = new System.Drawing.Point(46, 308);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(355, 39);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.GridColor = System.Drawing.Color.Beige;
            this.dataGridView1.Location = new System.Drawing.Point(66, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(322, 245);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 4000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(46, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seçili Satırı Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinimalToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGorevEkle);
            this.Controls.Add(this.btnGizle);
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

        private System.Windows.Forms.Button btnGizle;
        private System.Windows.Forms.Timer tmrStartPosition;
        private System.Windows.Forms.Timer tmrGizle;
        private System.Windows.Forms.Button btnGorevEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Button button1;
    }
}

