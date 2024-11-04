namespace Lessons
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }
        public override void OpenConnection()
        {
            if (IsConnected == true) throw new InvalidOperationException("Connection is already open.");
            System.Console.WriteLine("Opened Sql Connection");
            IsConnected = true;
        }

        public override void CloseConnection()
        {
            if (IsConnected == false) throw new InvalidOperationException("No open connection.");
            System.Console.WriteLine("Closed Sql Connection");
            IsConnected = false;
        }
    }

}