namespace Lessons
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }
        public override void OpenConnection()
        {
            if (IsConnected == true) throw new InvalidOperationException("Connection is already open.");
            System.Console.WriteLine("Opened Oracle Connection");
            IsConnected = true;
        }

        public override void CloseConnection()
        {
            if (IsConnected == false) throw new InvalidOperationException("Connection is not open");
            System.Console.WriteLine("Closed Oracle Connection");
            IsConnected = false;
        }
    }

}