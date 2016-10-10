using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularAPI.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AngularAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private object imageCommand;

        //GET api/products
        public IEnumerable<ProductModels> Get()
        {
            List<ProductModels> model = new List<ProductModels>();
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Football"].ConnectionString);
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "sp_GetProducts";
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductModels product = new ProductModels();
                        product.id = reader.GetInt32(0);
                        //product.canPurchase = reader.GetBoolean(4);
                        //product.soldOut = reader.GetBoolean(3);
                        product.name = reader.GetString(1);
                        product.description = reader.GetString(3);
                        product.price = reader.GetDecimal(2);
                        

                        model.Add(product);
                        


                    }
                    foreach(ProductModels p in model)
                    {
                        SqlCommand imageCommand = connection.CreateCommand();
                        imageCommand.CommandText = "sp_GetImagesForProduct";
                        imageCommand.CommandType = CommandType.StoredProcedure;
                        imageCommand.Parameters.AddWithValue("@productId", p.id);

                        using (SqlDataReader Reader = imageCommand.ExecuteReader()) ;

                    }

                }
                connection.Close();
            }

            return model;
        }

    }
}


    

        


   





