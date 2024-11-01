// See https://aka.ms/new-console-template for more information
using Lessons;

var cookie = new HttpCookie();
cookie["name"] = "Mosh";
System.Console.WriteLine(cookie["name"]);



static void FieldsDemo()

{
    var customer = new Customer(100, "John");
    customer.Orders.Add(new Order());
    customer.Orders.Add(new Order());
    System.Console.WriteLine(customer.Orders.Count);
    customer.Promote();
    System.Console.WriteLine(customer.Orders.Count);
}
static void PropertiesDemo()
{
    var person = new Person(new DateTime(1982, 1, 1));
    System.Console.WriteLine(person.Age);
}