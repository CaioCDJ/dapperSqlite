using Dapper;
using dapperExamples.Data;
using dapperExamples.Models;

namespace dapperExamples.Repositories;

public class UserRepository{

  public static List<User> getUsers(){
    
    List<User> users;
    using var cnn = DbConnection.GetConnection();
      
    string query = "SELECT * FROM users ORDER BY name";

    users = (cnn.Query<User>(sql:query)).ToList();
    
    return users;
  }

  public static void newUser(User user){

    using var cnn = DbConnection.GetConnection();
  
    string id = Guid.NewGuid().ToString();

    user.id = id.Substring(0,id.Length/2);

    cnn.Execute("INSERT INTO users (id,name,age) VALUES (@id,@name,@age)", user);
  }

  public static void update(User user){

    using var cnn = DbConnection.GetConnection();
    
    cnn.Execute("UPDATE users (name,age) VALUES (@name,@age) WHERE id = @id", user);
  }
  
  public static void remove(User user){

    using var cnn = DbConnection.GetConnection();
    
    cnn.Execute("DELETE FROM user WHERE id = @id",user);
  }
}

