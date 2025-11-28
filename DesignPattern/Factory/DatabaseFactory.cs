namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType dbType)
        {
            IDatabase db;
                
            switch (dbType)
            {
                case DatabaseType.Oracle:
                    db = new OracleDatabase();
                    break;
                case DatabaseType.SqlServer:
                    db = new SqlServerDatabase();
                    break;
                default:
                    throw new ArgumentException("Database Type: " + dbType + " is not supported.");    
            } 

            return db;
        }
    }
}
