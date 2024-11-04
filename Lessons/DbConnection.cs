namespace Lessons
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public bool IsConnected { get; set; }

        public DbConnection(string connectionString)
        {
            this.ConnectionString = connectionString;
            Timeout = TimeSpan.FromHours(3);
            IsConnected = false;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
