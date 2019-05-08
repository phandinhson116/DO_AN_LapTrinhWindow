namespace App_QLBanHangSieuThiMini
{
    partial class FormManager
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
            this.plManager = new System.Windows.Forms.Panel();
            this.lblSort = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblChart = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbSold = new System.Windows.Forms.RadioButton();
            this.rbWarehouse = new System.Windows.Forms.RadioButton();
            this.rbEmployees = new System.Windows.Forms.RadioButton();
            this.plManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // plManager
            // 
            this.plManager.Controls.Add(this.lblSort);
            this.plManager.Controls.Add(this.comboBox1);
            this.plManager.Controls.Add(this.lblChart);
            this.plManager.Controls.Add(this.dataGridView1);
            this.plManager.Controls.Add(this.rbSold);
            this.plManager.Controls.Add(this.rbWarehouse);
            this.plManager.Controls.Add(this.rbEmployees);
            this.plManager.Location = new System.Drawing.Point(16, 46);
            this.plManager.Margin = new System.Windows.Forms.Padding(4);
            this.plManager.Name = "plManager";
            this.plManager.Size = new System.Drawing.Size(1035, 493);
            this.plManager.TabIndex = 0;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(23, 278);
            this.lblSort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(117, 20);
            this.lblSort.TabIndex = 6;
            this.lblSort.Text = "Sắp Xếp Theo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 206);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // lblChart
            // 
            this.lblChart.AutoSize = true;
            this.lblChart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChart.Location = new System.Drawing.Point(23, 181);
            this.lblChart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(82, 20);
            this.lblChart.TabIndex = 4;
            this.lblChart.Text = "BIỂU ĐỒ:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(832, 469);
            this.dataGridView1.TabIndex = 3;
            // 
            // rbSold
            // 
            this.rbSold.AutoSize = true;
            this.rbSold.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSold.Location = new System.Drawing.Point(16, 116);
            this.rbSold.Margin = new System.Windows.Forms.Padding(4);
            this.rbSold.Name = "rbSold";
            this.rbSold.Size = new System.Drawing.Size(85, 24);
            this.rbSold.TabIndex = 2;
            this.rbSold.TabStop = true;
            this.rbSold.Text = "Đã Bán";
            this.rbSold.UseVisualStyleBackColor = false;
            // 
            // rbWarehouse
            // 
            this.rbWarehouse.AutoSize = true;
            this.rbWarehouse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWarehouse.Location = new System.Drawing.Point(16, 84);
            this.rbWarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.rbWarehouse.Name = "rbWarehouse";
            this.rbWarehouse.Size = new System.Drawing.Size(150, 24);
            this.rbWarehouse.TabIndex = 1;
            this.rbWarehouse.TabStop = true;
            this.rbWarehouse.Text = "Hàng Trong Kho";
            this.rbWarehouse.UseVisualStyleBackColor = false;
            // 
            // rbEmployees
            // 
            this.rbEmployees.AutoSize = true;
            this.rbEmployees.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmployees.Location = new System.Drawing.Point(16, 52);
            this.rbEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmployees.Name = "rbEmployees";
            this.rbEmployees.Size = new System.Drawing.Size(106, 24);
            this.rbEmployees.TabIndex = 0;
            this.rbEmployees.TabStop = true;
            this.rbEmployees.Text = "Nhân Viên";
            this.rbEmployees.UseVisualStyleBackColor = false;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.plManager);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManager";
            this.Text = "Quản lý";
            this.plManager.ResumeLayout(false);
            this.plManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plManager;
        private System.Windows.Forms.RadioButton rbWarehouse;
        private System.Windows.Forms.RadioButton rbEmployees;
        private System.Windows.Forms.RadioButton rbSold;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblChart;
    }
}