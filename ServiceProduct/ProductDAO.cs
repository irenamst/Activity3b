using Activity3b.Models;
using Activity3b.ServiceProduct;
using System.Data.SqlClient;

namespace Activity3b.ServiceProduct
{
    public class ProductDAO : IProductDataService
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public int Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> foundProducts = new List<ProductModel>();

            string sqlStatement = "SELECT * FROM dbo.Product";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        foundProducts.Add(new ProductModel { Id= (int)reader[0], Name= (string)reader[1],Price= (decimal)reader[2] ,Description=(string)reader[3]});

                    }
                }catch (SqlException ex)
                {
                    Console.WriteLine();
                }
            }
            return foundProducts;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
