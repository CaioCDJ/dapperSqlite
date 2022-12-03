using Spectre.Console;
using dapperExamples.Models;

namespace dapperExamples.Ui;

public class Menu {

  public static string show(string[] options, string title="") {

    string option = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
          .Title(title)
          .PageSize(10)
          .MoreChoicesText("[white](press enter to select an option)")
          .AddChoices(options));
    return option;
  }

  public static User usersSelect(List<User>users,string title=""){
     
    string option = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
          .Title(title)
          .PageSize(10)
          .MoreChoicesText("[white](press enter to select an option)")
          .AddChoices(users.Select(x=>x.name)));
  
    return users.FirstOrDefault(x=>x.name == option);
  }

}
