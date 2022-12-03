using Spectre.Console;
using dapperExamples.Models;

namespace dapperExamples.Ui;

public class Forms{

  public static User newClient(){
    
    User user = new User();

    user.name = name("What`s your name?");
    user.age = age("How old are you?");
   
    return user;
  }

  public static string name(string text){
    return AnsiConsole.Ask<string>(text);
  }

  public static int age(string text){
    return AnsiConsole.Prompt(
        new TextPrompt<int>(text)
          .PromptStyle("white")
          .ValidationErrorMessage("")
          .Validate(age => {
              return age switch{
                <= 0 => ValidationResult.Error("You must at least be 1 years old"),
                _=> ValidationResult.Success(),
              };
            } 
          )
    );
  }

  public static void proceed(string msg=""){

    Console.WriteLine("\n");
    var rule = new Rule(msg);
    
    rule.LeftAligned();
    rule.Style = "green";

    AnsiConsole.Write(rule);

    AnsiConsole.Write("Press any key to proceed");
    string i = Console.ReadLine();
  }
  

  public static bool exit(string text){

    if (!AnsiConsole.Confirm(text))
    {
      AnsiConsole.MarkupLine("Ok... :(");
      return false;
    }
    return true;
  }
}
