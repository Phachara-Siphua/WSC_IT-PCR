namespace ABCD
{
    partial class Product_management
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Active_Pro = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProductName_Pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost_Pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action_Pro = new System.Windows.Forms.DataGridViewLinkColumn();
            this.obj_Pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Size = new System.Drawing.Size(1190, 623);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 22);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Active_Pro,
            this.ProductName_Pro,
            this.Category_Pro,
            this.Price_Pro,
            this.Cost_Pro,
            this.Action_Pro,
            this.obj_Pro});
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 571);
            this.dataGridView1.TabIndex = 1;
            // 
            // Active_Pro
            // 
            this.Active_Pro.HeaderText = "Active";
            this.Active_Pro.Name = "Active_Pro";
            this.Active_Pro.ReadOnly = true;
            this.Active_Pro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Active_Pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProductName_Pro
            // 
            this.ProductName_Pro.HeaderText = "ProductName";
            this.ProductName_Pro.Name = "ProductName_Pro";
            this.ProductName_Pro.ReadOnly = true;
            // 
            // Category_Pro
            // 
            this.Category_Pro.HeaderText = "Category";
            this.Category_Pro.Name = "Category_Pro";
            this.Category_Pro.ReadOnly = true;
            // 
            // Price_Pro
            // 
            this.Price_Pro.HeaderText = "Price";
            this.Price_Pro.Name = "Price_Pro";
            this.Price_Pro.ReadOnly = true;
            // 
            // Cost_Pro
            // 
            this.Cost_Pro.HeaderText = "Cost";
            this.Cost_Pro.Name = "Cost_Pro";
            this.Cost_Pro.ReadOnly = true;
            // 
            // Action_Pro
            // 
            this.Action_Pro.HeaderText = "Action";
            this.Action_Pro.Name = "Action_Pro";
            this.Action_Pro.ReadOnly = true;
            this.Action_Pro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action_Pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // obj_Pro
            // 
            this.obj_Pro.HeaderText = "obj_Pro";
            this.obj_Pro.Name = "obj_Pro";
            this.obj_Pro.ReadOnly = true;
            this.obj_Pro.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1006, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add new product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Product_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 623);
            this.Name = "Product_management";
            this.Text = "Product management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active_Pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName_Pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost_Pro;
        private System.Windows.Forms.DataGridViewLinkColumn Action_Pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn obj_Pro;
    }
}