// See https://aka.ms/new-console-template for more information
using Lessons;

var person = new Person();
person.SetBirthdate(new DateTime(1982, 1, 2));
DateTime dateTime = person.GetBirthdate();
System.Console.WriteLine(dateTime);


static void FieldsDemo()
{
    var customer = new Customer(100, "John");
    customer.Orders.Add(new Order());
    customer.Orders.Add(new Order());
    System.Console.WriteLine(customer.Orders.Count);
    customer.Promote();
    System.Console.WriteLine(customer.Orders.Count);
}