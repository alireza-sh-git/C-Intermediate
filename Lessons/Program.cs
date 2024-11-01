// See https://aka.ms/new-console-template for more information
using Lessons;




static void FieldsDemo()
{
    var customer = new Customer(100, "John");
    customer.Orders.Add(new Order());
    customer.Orders.Add(new Order());
    System.Console.WriteLine(customer.Orders.Count);
    customer.Promote();
    System.Console.WriteLine(customer.Orders.Count);
}