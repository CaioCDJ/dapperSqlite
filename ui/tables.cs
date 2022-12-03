using Spectre.Console;
using dapperExamples.Models;
using dapperExamples.Repositories;

namespace dapperExamples.Ui;

public class Tables{

  public static void showUsers(List<User>users){
    
    Console.Clear();

    var table = new Table();
    
    table.Centered();
    
    table.Title = new TableTitle("Users");

    table.AddColumn("[green]Id[/]");
    table.AddColumn("[green]Name[/]");
    table.AddColumn("[green]Age[/]");
  
    foreach(User user in users)
      table.AddRow(user.id,user.name,user.age.ToString());

    AnsiConsole.Write(table);
  } 
}
