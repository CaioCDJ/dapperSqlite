using Dapper;
using dapperExamples.Data;
using dapperExamples.Models;
using Microsoft.Data.Sqlite;

namespace dapperExamples.Repositories;

public class UserRepository{
  

  public static List<User> getUsers(){
    
    List<User> users;
    using (var cnn = DbConnection.GetConnection()){
      
      string query = "SELECT * FROM users";

      users = (cnn.Query<User>(sql:query)).ToList();
      
    }
    
    return users;
  }

  public static void o(){
    
     using var connection = DbConnection.GetConnection();
    
    var table = connection.Query("SELECT * FROM users;");

  }
}

