using Spectre.Console;

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
}
