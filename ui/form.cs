using Spectre.Console;
using dapperExamples.Models;

namespace dapperExamples.Ui;

public class Forms{

  public static User newClient(){
    
    User user = new User();

    user.name = AnsiConsole.Ask<string>("What's your [green]name[/]?");
    user.email = AnsiConsole.Ask<string>("What's your [green]email[/]?");
   
    return user;
  }

  public static bool exit(){

    if (!AnsiConsole.Confirm("Exit user control?"))
    {
      AnsiConsole.MarkupLine("Ok... :(");
      return false;
    }
    return true;
  }
}
