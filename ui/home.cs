using Spectre.Console;
using dapperExamples.Repositories;

namespace dapperExamples.Ui;

public class Home{

  public static void run(){
    Console.Clear();
    intro();
    menu();
  }

  private static void intro(){
  
    AnsiConsole.Write(
      new FigletText("Dapper Examples")
        .Centered()
        .Color(Color.Green));  
  }

  private static void menu(){

    var option = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
          .Title("Options")
          .PageSize(10)
          .MoreChoicesText("[white](press enter to select an option)")
          .AddChoices(new string[]{
            "Show all users",
            "Search an user",
            "Create an user",
            "Edit an user",
            "Delete an user",
            "[bold]Exit[/]"
    }));
  }
} 

