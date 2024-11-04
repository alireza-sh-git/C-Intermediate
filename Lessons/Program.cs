// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using Lessons;


var sqlConnection = new SqlConnection("asdf");
var oracleConnection = new OracleConnection("1234");
sqlConnection.OpenConnection();
sqlConnection.CloseConnection();
oracleConnection.OpenConnection();
oracleConnection.CloseConnection();

var dbCommand = new DbCommand(oracleConnection, "Add new table");
dbCommand.Execute();









// static void StackExercise()
// {
//     Stack stack = new Stack();
//     stack.Push("Yellow");
//     stack.Push(2);
//     stack.Push(new int[] { 1, 2, 3, 4 });
//     System.Console.WriteLine(stack.Pop());
//     System.Console.WriteLine(stack.Pop());
//     System.Console.WriteLine(stack.Pop());

// }




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
// static void StopwatchExercise()
// {
//     Stopwatch stopwatch = new Stopwatch();

//     while (true)
//     {
// #pragma warning disable CS8602 // Dereference of a possibly null reference.
//         string input = Console.ReadLine().ToLower().Trim();
// #pragma warning restore CS8602 // Dereference of a possibly null reference.
//         if (input == "start")
//         {
//             if (stopwatch.IsRunning) System.Console.WriteLine("The stopwatch is already running");
//             else stopwatch.Start();

//         }

//         else if (input == "stop")
//         {
//             if (stopwatch.IsRunning) stopwatch.Stop();
//             else System.Console.WriteLine("You need to start the stopwatch first.");
//         }

//         else if (input == "display")
//         {
//             if (stopwatch.IsRunning) System.Console.WriteLine("You need to stop the stopwatch first.");
//             else System.Console.WriteLine(stopwatch.Display());
//         }
//         else System.Console.WriteLine("invalid input");
//     }
// // }

// static void OverflowPost()
// {
//     var post = new StackPost("C#", "I have been learning c# for 2 weeks, its the best");
//     post.Upvote();
//     post.Upvote();
//     post.Upvote();
//     post.Upvote();
//     post.Downvote();
//     System.Console.WriteLine(post.Vote);
// }

