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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbSold = new System.Windows.Forms.RadioButton();
            this.rbWarehouse = new System.Windows.Forms.RadioButton();
            this.rbEmployees = new System.Windows.Forms.RadioButton();
            this.lblChart = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
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
            this.plManager.Location = new System.Drawing.Point(12, 12);
            this.plManager.Name = "plManager";
            this.plManager.Size = new System.Drawing.Size(776, 426);
            this.plManager.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(149, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(624, 420);
            this.dataGridView1.TabIndex = 3;
            // 
            // rbSold
            // 
            this.rbSold.AutoSize = true;
            this.rbSold.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSold.Location = new System.Drawing.Point(12, 57);
            this.rbSold.Name = "rbSold";
            this.rbSold.Size = new System.Drawing.Size(73, 21);
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
            this.rbWarehouse.Location = new System.Drawing.Point(12, 30);
            this.rbWarehouse.Name = "rbWarehouse";
            this.rbWarehouse.Size = new System.Drawing.Size(131, 21);
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
            this.rbEmployees.Location = new System.Drawing.Point(12, 3);
            this.rbEmployees.Name = "rbEmployees";
            this.rbEmployees.Size = new System.Drawing.Size(92, 21);
            this.rbEmployees.TabIndex = 0;
            this.rbEmployees.TabStop = true;
            this.rbEmployees.Text = "Nhân Viên";
            this.rbEmployees.UseVisualStyleBackColor = false;
            // 
            // lblChart
            // 
            this.lblChart.AutoSize = true;
            this.lblChart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChart.Location = new System.Drawing.Point(17, 147);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(68, 17);
            this.lblChart.TabIndex = 4;
            this.lblChart.Text = "BIỂU ĐỒ:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(17, 226);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(103, 17);
            this.lblSort.TabIndex = 6;
            this.lblSort.Text = "Sắp Xếp Theo:";
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plManager);
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