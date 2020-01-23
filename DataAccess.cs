using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace VPPROJECT
{
    class DataAccess
    {
        string ConnectionString;
        public DataAccess()
        {
            ConnectionString = "server=DESKTOP-VQFCIJ2;database=Project;UID=sa;password=1234";
        }
        public Details RetreiveProductDetails(String Product_Name)
        {
            Details ProductDetails = new Details();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Product_ID,Product_Name,Product_Price FROM [Project].[dbo].[Products] where Product_Name = '" + Product_Name + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductDetails.ID = reader.GetInt32(0);
                        ProductDetails.Name = reader.GetString(1);
                        ProductDetails.Price = reader.GetInt32(2);

                    }
                }
                reader.Close();

                return ProductDetails;
            }
        }
        public bool Confirm_Login(String Username, String Password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Username,Password FROM [Project].[dbo].[Admin] where Username = '"+Username+"'AND Password ='"+Password+"';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                bool Confirm = false;
                if (reader.HasRows)
                {
                    Confirm = true;
                }
                else
                {
                    Confirm = false;
                }
                reader.Close();
                return Confirm;
            }
            

            
        }


      }

  }



    

