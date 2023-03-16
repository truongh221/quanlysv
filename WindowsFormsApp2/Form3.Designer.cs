namespace WindowsFormsApp2
{
    partial class Form3
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
            this.lstNuoc = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView_SV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SV)).BeginInit();
            this.SuspendLayout();
            // 
            // lstNuoc
            // 
            this.lstNuoc.FormattingEnabled = true;
            this.lstNuoc.ItemHeight = 16;
            this.lstNuoc.Location = new System.Drawing.Point(23, 51);
            this.lstNuoc.Name = "lstNuoc";
            this.lstNuoc.Size = new System.Drawing.Size(209, 84);
            this.lstNuoc.TabIndex = 0;
            this.lstNuoc.SelectedIndexChanged += new System.EventHandler(this.lstNuoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách các nước";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNuoc
            // 
            this.txtNuoc.Location = new System.Drawing.Point(25, 195);
            this.txtNuoc.Name = "txtNuoc";
            this.txtNuoc.Size = new System.Drawing.Size(100, 22);
            this.txtNuoc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nước được chọn";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(468, 20);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(312, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // dataGridView_SV
            // 
            this.dataGridView_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SV.Location = new System.Drawing.Point(312, 67);
            this.dataGridView_SV.Name = "dataGridView_SV";
            this.dataGridView_SV.RowHeadersWidth = 51;
            this.dataGridView_SV.RowTemplate.Height = 24;
            this.dataGridView_SV.Size = new System.Drawing.Size(397, 150);
            this.dataGridView_SV.TabIndex = 7;
            this.dataGridView_SV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SV_CellContentClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_SV);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNuoc);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView_SV;
    }
}