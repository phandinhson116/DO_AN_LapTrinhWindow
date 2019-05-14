namespace App_QLBanHangSieuThiMini.GUI.GUI_FormNhanVien
{
    partial class GUI_HoaDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(406, 478);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(481, 176);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(381, 478);
            this.dataGridView2.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(186, 36);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 22);
            this.txtMaHD.TabIndex = 2;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(186, 64);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 22);
            this.txtMaKH.TabIndex = 3;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(186, 92);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(100, 22);
            this.txtMaHH.TabIndex = 4;
            this.txtMaHH.TextChanged += new System.EventHandler(this.txtMaHH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Hàng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(787, 36);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(181, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hóa Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(577, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chi Tiết Hóa Đơn";
            // 
            // GUI_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUI_HoaDon";
            this.Size = new System.Drawing.Size(900, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
