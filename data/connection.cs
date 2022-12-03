using System.Data;
using Microsoft.Data.Sqlite;

namespace dapperExamples.Data;

public class DbConnection{

  public static IDbConnection GetConnection() 
    => new SqliteConnection("Data Source=app.db");

}
