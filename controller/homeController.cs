using dapperExamples.Models;
using dapperExamples.Ui;
using dapperExamples.Repositories;

namespace dapperExamples.Controller;

public class HomeController{

  private static string[] userUpdateOpt = { "Name","age" }; 

  public static void mainMenu(string option){

    if(Home.options[0] == option) showUsers(); 

    else if(Home.options[1] == option) newUser();

    else if(Home.options[2] == option) updateUser();
    
    else if(Home.options[3] == option) deleteUser();
    
    else if(Home.options[4] == option) exit();   
   
   Home.run();
  }

  private static void showUsers(){
    Tables.showUsers(UserRepository.getUsers());
    Forms.proceed();   
  }
  
  private static void newUser(){
    User user = Forms.newClient();
    UserRepository.newUser(user);
    Forms.proceed($"[bold]{user.name}[/] was created");   
  }

  private static void updateUser(){
   
    List<User> users = UserRepository.getUsers();

    User user = Menu.usersSelect(users, "Select an user");
    
    string opt = Menu.show(userUpdateOpt, "Select an property");
  
    if(opt == userUpdateOpt[0]){
      user.name = Forms.name("Whats the new name?");
    }
    else if(opt == userUpdateOpt[1]){
      user.age = Forms.age("Whats the new age ?");
    }

    Forms.proceed($"the [bold]{opt}[/] of {user.name} was updated.");   
    
    UserRepository.update(user);
  }
  
  private static void deleteUser(){
  
    List<User> users = UserRepository.getUsers();

    User user = Menu.usersSelect(users, "Select an user");
   
    if(Forms.exit($"Are you sure that you want to delete [red] {user.name} [/]")){
      UserRepository.remove(user);
    
      Forms.proceed($"[bold]{user.name}[/] was deleted.");   
    }

    Home.run();
  }

  private static void exit(){
     if(Forms.exit("Do you realy want to exit?")) 
        Environment.Exit(0);
  } 
}
