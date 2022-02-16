using Activity3b.Models;

namespace Activity3b.ServiceProduct
{
    public interface IProductDataService
    {
        List<ProductModel> GetAllProducts();
        List<ProductModel> SearchProducts(string searchTerm);

        ProductModel GetProductById(int id);
        int Insert(ProductModel product);
        int Delete(ProductModel product);
        int Update(ProductModel product);

    }
}
