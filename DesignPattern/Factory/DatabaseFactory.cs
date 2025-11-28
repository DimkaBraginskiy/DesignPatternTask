namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType dbType)
        {
            IDatabase db;
            if (dbType.Equals(DatabaseType.Oracle))
            {
                db = new OracleDatabase();
            }else if (dbType.Equals(DatabaseType.SqlServer))
            {
                db = new SqlServerDatabase();
            }else
            {
                throw new ArgumentException("Database Type: " + dbType + " is not supported.");
            }

            return db;
        }
    }
}
