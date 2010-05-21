namespace QLKS_DichVu.UI
{
    partial class ServiceOrderForm
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
            this.roomIDTextBox = new System.Windows.Forms.TextBox();
            this.serviceOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.searchServiceOrderButton = new System.Windows.Forms.Button();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addServiceOrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serviceOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // roomIDTextBox
            // 
            this.roomIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIDTextBox.Location = new System.Drawing.Point(137, 21);
            this.roomIDTextBox.Name = "roomIDTextBox";
            this.roomIDTextBox.Size = new System.Drawing.Size(211, 26);
            this.roomIDTextBox.TabIndex = 0;
            this.roomIDTextBox.Text = "PH0001";
            this.roomIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // serviceOrderDataGridView
            // 
            this.serviceOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceOrderDataGridView.Location = new System.Drawing.Point(12, 60);
            this.serviceOrderDataGridView.Name = "serviceOrderDataGridView";
            this.serviceOrderDataGridView.Size = new System.Drawing.Size(500, 209);
            this.serviceOrderDataGridView.TabIndex = 2;
            // 
            // searchServiceOrderButton
            // 
            this.searchServiceOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchServiceOrderButton.Location = new System.Drawing.Point(366, 14);
            this.searchServiceOrderButton.Name = "searchServiceOrderButton";
            this.searchServiceOrderButton.Size = new System.Drawing.Size(119, 40);
            this.searchServiceOrderButton.TabIndex = 3;
            this.searchServiceOrderButton.Text = "Tìm";
            this.searchServiceOrderButton.UseVisualStyleBackColor = true;
            this.searchServiceOrderButton.Click += new System.EventHandler(this.searchServiceOrderButton_Click);
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(137, 275);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(211, 28);
            this.serviceComboBox.TabIndex = 4;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(137, 309);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(211, 26);
            this.quantityNumericUpDown.TabIndex = 5;
            // 
            // addServiceOrderButton
            // 
            this.addServiceOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServiceOrderButton.Location = new System.Drawing.Point(175, 341);
            this.addServiceOrderButton.Name = "addServiceOrderButton";
            this.addServiceOrderButton.Size = new System.Drawing.Size(173, 37);
            this.addServiceOrderButton.TabIndex = 6;
            this.addServiceOrderButton.Text = "Thêm";
            this.addServiceOrderButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số phòng";
            // 
            // ServiceOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(524, 390);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addServiceOrderButton);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.serviceComboBox);
            this.Controls.Add(this.searchServiceOrderButton);
            this.Controls.Add(this.serviceOrderDataGridView);
            this.Controls.Add(this.roomIDTextBox);
            this.Name = "ServiceOrderForm";
            this.Text = "ServiceOrderForm";
            this.Load += new System.EventHandler(this.ServiceOrderForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceOrderForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.serviceOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomIDTextBox;
        private System.Windows.Forms.DataGridView serviceOrderDataGridView;
        private System.Windows.Forms.Button searchServiceOrderButton;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Button addServiceOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}