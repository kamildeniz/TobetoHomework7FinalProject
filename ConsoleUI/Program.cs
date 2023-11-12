// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Abstracts;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine("Hello, World!");
ProductManager productManager = new ProductManager(new EfProductDal());

//foreach (Product product in productManager.GetAll())
//{
//    Console.Write(product.ProductID + " ");
//    Console.Write(product.CategoryId + " ");
//    Console.Write(product.ProductName + " ");
//    Console.Write(product.UnitPrice + " ");
//    Console.Write(product.UnitsInStock + " ");
//    Console.WriteLine("************************************************");
//}
//foreach (Product product in productManager.GetAllByCategoryId(2))
//{
//    Console.WriteLine(product.ProductName);
//}
//foreach (Product product in productManager.GetAllByUnitPrice(20,30))
//{
//    Console.WriteLine(product.ProductName);
//}