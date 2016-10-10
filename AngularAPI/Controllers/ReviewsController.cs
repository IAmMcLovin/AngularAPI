using System.Web.Http;
using AngularAPI.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
namespace AngularAPI.Controllers
{
    public class ReviewsController : ApiController
    {


        //POST api/values
        public void Post([FromBody]ProductModels value)
        {
            //TODO: Save this to a database next week!
            string connectionString = ConfigurationManager.ConnectionStrings["Football"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                connection.Open();
                //Using Lambda expressions
                var newReview = value.reviews.First(x => x.id == 0);

                command.CommandText = "sp_AddReview";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@productId", value.id);
                command.ExecuteNonQuery();
                connection.Close();

            }

                
        }
    }
}
