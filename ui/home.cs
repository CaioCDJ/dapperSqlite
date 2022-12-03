using Spectre.Console;
using dapperExamples.Models;
using dapperExamples.Repositories;
using dapperExamples.Ui;

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
    redirect(Menu.show(options));
  }

  public static void redirect(string option){
    
    if(options[0] == option) {
      Tables.showUsers(UserRepository.getUsers());
      Forms.proceed();   
    }
    else if(options[1]==option){
      User user = Forms.newClient();
      UserRepository.newUser(user);
    }
    
    else if(options[2] == option){
      

    }
    
    else if(options[3]==option){}
    
    else if(options[4]==option) {
      if(Forms.exit()) 
        Environment.Exit(0);
    }
   
    run();
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

