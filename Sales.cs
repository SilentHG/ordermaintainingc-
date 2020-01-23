using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VPPROJECT
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        

        private void Sales_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            String ConnectionString = "server=DESKTOP-VQFCIJ2;database=Project;UID=sa;password=1234";
            Details ProductDetails = new Details();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Sale_ID,Sale_Time,Product_ID,Product_Name,Product_Price,Product_Quantity,Product_Total FROM [Project].[dbo].[Sales] order by Sale_ID;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductDetails.SaleID = reader.GetInt32(0);
                        ProductDetails.SaleTime = reader.GetDateTime(1);
                        ProductDetails.ID = reader.GetInt32(2);
                        ProductDetails.Name = reader.GetString(3);
                        ProductDetails.Price = reader.GetInt32(4);
                        ProductDetails.Quantity = reader.GetInt32(5);
                        ProductDetails.Total = reader.GetInt32(6);
                        All_Records.Rows.Add(ProductDetails.SaleID, ProductDetails.SaleTime, ProductDetails.ID, ProductDetails.Name, ProductDetails.Price, ProductDetails.Quantity, ProductDetails.Total);


                    }
                }
                reader.Close();

                
            }


        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 Main = new Form1();
            Main.ShowDialog();
            Main.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void Query_Load(object sender, EventArgs e)
        {
            this.Hide();
            Queries Query = new Queries();

            Query.ShowDialog();
            Query.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void Update_Product(object sender, EventArgs e)
        {
            this.Hide();
            Product_Update product_Update = new Product_Update();

            product_Update.ShowDialog();
            product_Update.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void Delete_Sales(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Sale Delete = new Delete_Sale();

            Delete.ShowDialog();
            Delete.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void All_Records_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
