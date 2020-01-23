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
    public partial class Product_Update : Form
    {
        public Product_Update()
        {
            InitializeComponent();
        }

        private void Product_Update_Load(object sender, EventArgs e)
        {
            Details ProductDetails = new Details();
            String ConnectionString = "server=DESKTOP-VQFCIJ2;database=Project;UID=sa;password=1234";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Product_Name FROM [Project].[dbo].[Products];", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        ProductDetails.Name = reader.GetString(0);
                        Product_Select_Combobox.Items.Add(ProductDetails.Name);
                        

                    }
                }
                reader.Close();

                
            }
        }

        private void Load_New_Price(object sender, EventArgs e)
        {
            String ConnectionString = "server=DESKTOP-VQFCIJ2;database=Project;UID=sa;password=1234";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update_product";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            string ProductName = Product_Select_Combobox.SelectedItem.ToString();
            decimal ProductPrice = Product_Price_NU.Value;
            cmd.Parameters.AddWithValue("@name", ProductName);
            cmd.Parameters.AddWithValue("@price", ProductPrice);
            cmd.ExecuteNonQuery();
            con.Close();

        MessageBox.Show("Price Changed");
            Product_Select_Combobox.SelectedIndex = -1;
            Product_Price_NU.Value = 0;
        }

        private void Main_Menu(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Main = new Form1();
            Main.ShowDialog();
            Main.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            this.Hide();
            Sales Sales_Open = new Sales();
            Sales_Open.ShowDialog();
            Sales_Open.StartPosition = FormStartPosition.CenterScreen;
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

        private void Delete_Sales(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Sale Delete = new Delete_Sale();

            Delete.ShowDialog();
            Delete.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }
    }
}
