// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;

Console.WriteLine("Hello, World!");

CarManager carManager = new CarManager(new InMemoryDal());
foreach (var cars in carManager.GetAll())
{
    Console.WriteLine(cars.Description);
}