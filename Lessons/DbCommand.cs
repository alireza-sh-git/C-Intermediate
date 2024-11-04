namespace Lessons
{
    public class DbCommand
    {
        public DbConnection Connection { get; set; }
        private readonly string Instruction;
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (instruction == null) throw new NullReferenceException("Null instruction input");
            if (dbConnection == null) throw new NullReferenceException("Null connection input");
            this.Instruction = instruction;
            Connection = dbConnection;
        }

        public void Execute()
        {
            Connection.OpenConnection();
            this.Run();
            Connection.CloseConnection();

        }
        public void Run()
        {
            System.Console.WriteLine(Instruction + " was run.");
        }
    }
}