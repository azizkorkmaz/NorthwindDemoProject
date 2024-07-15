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
        //ProductTest();

        //CategortTest();

        //ProductDetailTest();

    }
    /*
    private static void ProductDetailTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        var result = productManager.GetProductDetails();

        if (result.Success == true)
        {
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryName);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
        
    }
    
    private static void CategortTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        var result = productManager.GetProductDetails();
        if (result.Success == true)
        {
            Console.WriteLine("*********fiyata göre ürünler**********");
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("*********kategoriye göre ürünler**********");
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("********Bütün ürünler*************");
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }*/
}