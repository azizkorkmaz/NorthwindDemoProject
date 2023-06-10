using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    //SOLID
    //Open Closed Principle kuralı(yeni eklenen bir kod mevcut kodları değiştirmeyecek)
    private static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        
        Console.WriteLine("*********fiyata göre ürünler**********");
        foreach (var product in productManager.GetByUnitPrice(50,100))
        {
            Console.WriteLine(product.ProductName);
        }

        Console.WriteLine("*********kategoriye göre ürünler**********");
        foreach (var product in productManager.GetAllByCategoryId(5))
        {
            Console.WriteLine(product.ProductName);
        }

        Console.WriteLine("********Bütün ürünler*************");
        foreach (var product in productManager.GetAll())
        {
            Console.WriteLine(product.ProductName);
        }

    }
}