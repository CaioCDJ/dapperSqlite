using Spectre.Console;
using dapperExamples.Models;

namespace dapperExamples.Ui;

public class Forms{

  public static User newClient(){
    
    User user = new User();

    user.name = AnsiConsole.Ask<string>("What's your [green]name[/]?");
    user.age = int.Parse( AnsiConsole.Ask<string>("How old are you?") );
   
    return user;
  }

  public static void proceed(){

    AnsiConsole.Write("Press any key to proceed");
    string i = Console.ReadLine();
  }

  public static bool exit(){

    if (!AnsiConsole.Confirm("Do you realy want to exit?"))
    {
      AnsiConsole.MarkupLine("Ok... :(");
      return false;
    }
    return true;
  }
}
