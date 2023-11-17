// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;


//ProductTest();
//CategoryTest();
ProductDetailsTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (Product product in productManager.GetAll().Data)
    {
        Console.Write(product.ProductID + " ");
        Console.Write(product.CategoryID + " ");
        Console.Write(product.ProductName + " ");
        Console.Write(product.UnitPrice + " ");
        Console.Write(product.UnitsInStock + " ");
        Console.WriteLine("************************************************");
    }
    foreach (Product product in productManager.GetAllByCategoryId(2).Data)
    {
        Console.WriteLine(product.ProductName);
    }
    foreach (Product product in productManager.GetAllByUnitPrice(20, 30).Data)
    {
        Console.WriteLine(product.ProductName);
    }
}
static void ProductDetailsTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (ProductDetailDTO product in productManager.GetProductDetails().Data)
    {
        Console.Write(product.ProductId + " ");
        Console.Write(product.CategoryName + " ");
        Console.Write(product.ProductName + " ");
        Console.Write(product.UnitsInsotck + " ");
        Console.WriteLine("************************************************");
    }
    foreach (Product product in productManager.GetAllByCategoryId(2).Data)
    {
        Console.WriteLine(product.ProductName);
    }
    foreach (Product product in productManager.GetAllByUnitPrice(20, 30).Data)
    {
        Console.WriteLine(product.ProductName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (Category category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}