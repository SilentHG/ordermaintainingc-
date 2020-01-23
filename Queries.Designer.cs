namespace VPPROJECT
{
    partial class Queries
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
            this.label1 = new System.Windows.Forms.Label();
            this.Rank_Grid = new System.Windows.Forms.DataGridView();
            this.Grid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Total_Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.Current_Month_Button = new System.Windows.Forms.Button();
            this.Sales_Count_Month = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Rank_Grid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Best To Worst Selling Products";
            // 
            // Rank_Grid
            // 
            this.Rank_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rank_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grid_Name,
            this.Grid_Total_Sales});
            this.Rank_Grid.Location = new System.Drawing.Point(35, 84);
            this.Rank_Grid.Name = "Rank_Grid";
            this.Rank_Grid.Size = new System.Drawing.Size(240, 394);
            this.Rank_Grid.TabIndex = 1;
            // 
            // Grid_Name
            // 
            this.Grid_Name.HeaderText = "Product_Name";
            this.Grid_Name.Name = "Grid_Name";
            // 
            // Grid_Total_Sales
            // 
            this.Grid_Total_Sales.HeaderText = "Total_Sales";
            this.Grid_Total_Sales.Name = "Grid_Total_Sales";
            // 
            // Rank_Button
            // 
            this.Rank_Button.BackColor = System.Drawing.Color.Aqua;
            this.Rank_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rank_Button.Location = new System.Drawing.Point(200, 47);
            this.Rank_Button.Name = "Rank_Button";
            this.Rank_Button.Size = new System.Drawing.Size(75, 23);
            this.Rank_Button.TabIndex = 2;
            this.Rank_Button.Text = "View";
            this.Rank_Button.UseVisualStyleBackColor = false;
            this.Rank_Button.Click += new System.EventHandler(this.Rank_Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSalesToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.productToolStripMenuItem,
            this.deleteSalesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewSalesToolStripMenuItem
            // 
            this.viewSalesToolStripMenuItem.Name = "viewSalesToolStripMenuItem";
            this.viewSalesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.viewSalesToolStripMenuItem.Text = "Order Screen";
            this.viewSalesToolStripMenuItem.Click += new System.EventHandler(this.Main_Menu);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestSellerToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.Sales_Load);
            // 
            // bestSellerToolStripMenuItem
            // 
            this.bestSellerToolStripMenuItem.Name = "bestSellerToolStripMenuItem";
            this.bestSellerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.bestSellerToolStripMenuItem.Text = "All Queries ";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.productToolStripMenuItem.Text = "Update Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.Update_Product);
            // 
            // deleteSalesToolStripMenuItem
            // 
            this.deleteSalesToolStripMenuItem.Name = "deleteSalesToolStripMenuItem";
            this.deleteSalesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.deleteSalesToolStripMenuItem.Text = "Delete Sales";
            this.deleteSalesToolStripMenuItem.Click += new System.EventHandler(this.Delete_Sales);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total Items Sold in Current Month";
            // 
            // Current_Month_Button
            // 
            this.Current_Month_Button.BackColor = System.Drawing.Color.Aqua;
            this.Current_Month_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Current_Month_Button.Location = new System.Drawing.Point(552, 47);
            this.Current_Month_Button.Name = "Current_Month_Button";
            this.Current_Month_Button.Size = new System.Drawing.Size(75, 23);
            this.Current_Month_Button.TabIndex = 11;
            this.Current_Month_Button.Text = "View";
            this.Current_Month_Button.UseVisualStyleBackColor = false;
            this.Current_Month_Button.Click += new System.EventHandler(this.Current_Month_Button_Click);
            // 
            // Sales_Count_Month
            // 
            this.Sales_Count_Month.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sales_Count_Month.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales_Count_Month.Location = new System.Drawing.Point(443, 93);
            this.Sales_Count_Month.Name = "Sales_Count_Month";
            this.Sales_Count_Month.Size = new System.Drawing.Size(70, 22);
            this.Sales_Count_Month.TabIndex = 12;
            // 
            // Queries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(661, 523);
            this.Controls.Add(this.Sales_Count_Month);
            this.Controls.Add(this.Current_Month_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Rank_Button);
            this.Controls.Add(this.Rank_Grid);
            this.Controls.Add(this.label1);
            this.Name = "Queries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queries";
            ((System.ComponentModel.ISupportInitialize)(this.Rank_Grid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Rank_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Total_Sales;
        private System.Windows.Forms.Button Rank_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestSellerToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Current_Month_Button;
        private System.Windows.Forms.TextBox Sales_Count_Month;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSalesToolStripMenuItem;
    }
}