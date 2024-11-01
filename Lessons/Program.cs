// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using Lessons;

Stopwatch stopwatch = new Stopwatch();

while (true)
{
#pragma warning disable CS8602 // Dereference of a possibly null reference.
    string input = Console.ReadLine().ToLower().Trim();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    if (input == "start")
    {
        if (stopwatch.IsRunning) System.Console.WriteLine("The stopwatch is already running");
        else stopwatch.Start();

    }

    else if (input == "stop")
    {
        if (stopwatch.IsRunning) stopwatch.Stop();
        else System.Console.WriteLine("You need to start the stopwatch first.");
    }

    else if (input == "display")
    {
        if (stopwatch.IsRunning) System.Console.WriteLine("You need to stop the stopwatch first.");
        else System.Console.WriteLine(stopwatch.Display());
    }
    else System.Console.WriteLine("invalid input");
}



// static void FieldsDemo()

// {
//     var customer = new Customer(100, "John");
//     customer.Orders.Add(new Order());
//     customer.Orders.Add(new Order());
//     System.Console.WriteLine(customer.Orders.Count);
//     customer.Promote();
//     System.Console.WriteLine(customer.Orders.Count);
// }
// static void PropertiesDemo()
// {
//     var person = new Person(new DateTime(1982, 1, 1));
//     System.Console.WriteLine(person.Age);
// }
// static void IndexDemo()
// {
//     var cookie = new HttpCookie();
//     cookie["name"] = "Mosh";
//     System.Console.WriteLine(cookie["name"]);
// }
