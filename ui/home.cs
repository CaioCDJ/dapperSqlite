using Spectre.Console;
using dapperExamples.Ui;
using dapperExamples.Controller;

namespace dapperExamples.Ui;

public class Home{

  public static string[] options = {
    "Show Users",
    "Create an user",
    "Update an user",
    "Delete an user",
    "Exit"
  };

  public static void run(){
    Console.Clear();
    intro();
    HomeController.mainMenu(Menu.show(options));
  }

  private static void intro(){
  
    AnsiConsole.Write(
      new FigletText("Dapper Examples")
        .Centered()
        .Color(Color.Green));  
   
    var rule = new Rule();
    AnsiConsole.Write(rule);

  }
} 

