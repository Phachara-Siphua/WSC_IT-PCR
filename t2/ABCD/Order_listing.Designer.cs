namespace ABCD
{
    partial class Order_listing
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Order_ID_Or = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name_Or = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Or = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Amount_Or = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Or = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Detail_Or = new System.Windows.Forms.DataGridViewLinkColumn();
            this.obj_Or = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Size = new System.Drawing.Size(1190, 623);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1006, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add new product";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_ID_Or,
            this.Customer_Name_Or,
            this.Date_Or,
            this.Total_Amount_Or,
            this.Status_Or,
            this.Order_Detail_Or,
            this.obj_Or});
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 571);
            this.dataGridView1.TabIndex = 4;
            // 
            // Order_ID_Or
            // 
            this.Order_ID_Or.HeaderText = "Order ID";
            this.Order_ID_Or.Name = "Order_ID_Or";
            this.Order_ID_Or.ReadOnly = true;
            // 
            // Customer_Name_Or
            // 
            this.Customer_Name_Or.HeaderText = "Customer Name";
            this.Customer_Name_Or.Name = "Customer_Name_Or";
            this.Customer_Name_Or.ReadOnly = true;
            // 
            // Date_Or
            // 
            this.Date_Or.HeaderText = "Date";
            this.Date_Or.Name = "Date_Or";
            this.Date_Or.ReadOnly = true;
            // 
            // Total_Amount_Or
            // 
            this.Total_Amount_Or.HeaderText = "Total Amount";
            this.Total_Amount_Or.Name = "Total_Amount_Or";
            this.Total_Amount_Or.ReadOnly = true;
            // 
            // Status_Or
            // 
            this.Status_Or.HeaderText = "Status";
            this.Status_Or.Name = "Status_Or";
            this.Status_Or.ReadOnly = true;
            // 
            // Order_Detail_Or
            // 
            this.Order_Detail_Or.HeaderText = "Order Detail";
            this.Order_Detail_Or.Name = "Order_Detail_Or";
            this.Order_Detail_Or.ReadOnly = true;
            this.Order_Detail_Or.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Order_Detail_Or.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // obj_Or
            // 
            this.obj_Or.HeaderText = "obj_Or";
            this.obj_Or.Name = "obj_Or";
            this.obj_Or.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Order_listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 623);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Order_listing";
            this.Text = "Order listing";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ID_Or;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name_Or;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Or;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Amount_Or;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Or;
        private System.Windows.Forms.DataGridViewLinkColumn Order_Detail_Or;
        private System.Windows.Forms.DataGridViewTextBoxColumn obj_Or;
    }
}