// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Abstracts;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine("Hello, World!");
ProductManager productManager = new ProductManager(new InMemoryProductDal());
List<Product> products = productManager.GetAll();
foreach (Product product in products)
{
    Console.Write(product.Id);
    Console.Write(product.CategoryId);
    Console.Write(product.ProductName);
    Console.Write(product.UnitPrice);
    Console.Write(product.UnitsInStock);
    Console.WriteLine();
}