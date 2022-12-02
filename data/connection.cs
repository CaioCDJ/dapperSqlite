using Microsoft.Data.Sqlite;

namespace dapperExamples.Data;

public class DbConnection{

  public static SqliteConnection GetConnection()
    => new SqliteConnection("Data Source=app.db");
}
