namespace VPPROJECT
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.Button();
            this.TempOrder = new System.Windows.Forms.DataGridView();
            this.Grid_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button13 = new System.Windows.Forms.Button();
            this.TotalBillBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempOrder)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Controls.Add(this.TempOrder);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.TotalBillBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 467);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Red;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(453, 354);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 29);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // TempOrder
            // 
            this.TempOrder.AllowUserToAddRows = false;
            this.TempOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TempOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grid_Quantity,
            this.Grid_ID,
            this.Grid_Name,
            this.Grid_Price,
            this.Grid_Total});
            this.TempOrder.Location = new System.Drawing.Point(4, 100);
            this.TempOrder.Name = "TempOrder";
            this.TempOrder.Size = new System.Drawing.Size(540, 238);
            this.TempOrder.TabIndex = 5;
            // 
            // Grid_Quantity
            // 
            this.Grid_Quantity.HeaderText = "Quantity";
            this.Grid_Quantity.Name = "Grid_Quantity";
            // 
            // Grid_ID
            // 
            this.Grid_ID.HeaderText = "Product_ID";
            this.Grid_ID.Name = "Grid_ID";
            // 
            // Grid_Name
            // 
            this.Grid_Name.HeaderText = "Product_Name";
            this.Grid_Name.Name = "Grid_Name";
            // 
            // Grid_Price
            // 
            this.Grid_Price.HeaderText = "Product_Price";
            this.Grid_Price.Name = "Grid_Price";
            // 
            // Grid_Total
            // 
            this.Grid_Total.HeaderText = "Total_Price";
            this.Grid_Total.Name = "Grid_Total";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(244, 403);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 31);
            this.button13.TabIndex = 4;
            this.button13.Text = "Submit";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Load_Data);
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.Location = new System.Drawing.Point(89, 405);
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(100, 20);
            this.TotalBillBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(580, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 354);
            this.panel2.TabIndex = 1;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(326, 248);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 43);
            this.button12.TabIndex = 11;
            this.button12.Text = "Juice";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Load);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(180, 248);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 43);
            this.button11.TabIndex = 10;
            this.button11.Text = "Drink";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Load);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(50, 248);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 43);
            this.button10.TabIndex = 9;
            this.button10.Text = "Water Bottle";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Load);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(326, 176);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 45);
            this.button9.TabIndex = 8;
            this.button9.Text = "Soup";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Load);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(180, 176);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "Chaat";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Load);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(50, 176);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "Biryani";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Load);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(326, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 46);
            this.button6.TabIndex = 5;
            this.button6.Text = "Tikka";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Load);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(180, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cone Samosa";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Load);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(50, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Chicken Bun";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Load);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(326, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Plain Bun";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Load);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(180, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Veg Roll";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Load);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(51, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chimi Changa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSalesToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.updateProductToolStripMenuItem,
            this.deleteSalesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 6;
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
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.All_Sales);
            // 
            // bestSellerToolStripMenuItem
            // 
            this.bestSellerToolStripMenuItem.Name = "bestSellerToolStripMenuItem";
            this.bestSellerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.bestSellerToolStripMenuItem.Text = "All Queries ";
            this.bestSellerToolStripMenuItem.Click += new System.EventHandler(this.Query_Form);
            // 
            // updateProductToolStripMenuItem
            // 
            this.updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            this.updateProductToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.updateProductToolStripMenuItem.Text = "Update Product";
            this.updateProductToolStripMenuItem.Click += new System.EventHandler(this.Update_Product);
            // 
            // deleteSalesToolStripMenuItem
            // 
            this.deleteSalesToolStripMenuItem.Name = "deleteSalesToolStripMenuItem";
            this.deleteSalesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.deleteSalesToolStripMenuItem.Text = "Delete Sales";
            this.deleteSalesToolStripMenuItem.Click += new System.EventHandler(this.Delete_Sale_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 467);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox TotalBillBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView TempOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Total;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestSellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ToolStripMenuItem deleteSalesToolStripMenuItem;
    }
}

