using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.InteropServices;
using ProjektManagerChri;



namespace ProjektManagerChri
{
   public class Program 
    {
        public static void Main(string[] args)
        {
            Login.LoginFunktion();
            Hub.HubFunktion();  
            
        }
        
        
    }
}











// //login var 
// string username = "";
// string password = "";
// var login = false;
// var loginCount = 0;
//
// //timer var 
//  int milliseconds = 1000;
// int timer = 5;
//
// //Hub var
// string hubChoice;
//
// //exit var
// string exit;
//
// //problem var
// string problemChoice;
// string problemOne ="";
// string problemTwo = "";
// string problemThree = "";
// string problemOFour = "";
// string problemFive = "";
// string solutionChoice;
// string deleteChoice;
//
// //TodoList var
// string taskmChoice;
// string taskOne ="";
// string taskTwo = "";
// string taskThree = "";
// string taskFour = "";
// string taskFive = "";
// string taskChoice;
// string deleteTask;
// int taskStatus = 0;
// int taskCount = 0;
//
//
//
// // Project Analyses var
// string prodHubChoice;
// int question1;
// int question2;
// int question3;
// int question4;
// int question5;
// string prodBackChoice;
// string proConclution = "";
// bool proAlreadyDone = false;
//
//


// //login
//
// Login();
//
//
// // Element 0 Login 
// void Login(){
//     while (!login)
//     {
//         if (loginCount > 2)
//         {
//
//             Console.Clear();
//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.WriteLine("----------------");
//             Console.WriteLine("to many login tries");
//             Console.WriteLine("----------------");
//             Thread.Sleep(2000);
//            
//             while (timer >= 0)
//             {
//                 Console.Clear();
//
//                 Console.WriteLine("----------------");
//                 Console.WriteLine("time until you can try again: {0}", timer);
//                 Console.WriteLine("----------------");
//                 Thread.Sleep(milliseconds);
//                 timer--;
//                 if (timer == 0)
//                 {
//                     Console.ResetColor();
//                     loginCount = 0;
//                     login = false;
//                     Login();
//                 }
//
//             }
//
//             login = true;
//         }
//         else
//         {
//             Console.Clear();
//             Console.ForegroundColor = ConsoleColor.DarkCyan;
//
//             Console.WriteLine("----------------");
//             Console.WriteLine("'Hello welcome to Fibi the project management application");
//             Console.WriteLine("----------------");
//             Console.ResetColor();
//             
//             
//             Console.WriteLine("Please login");
//             Console.Write("Username: ");
//             username = Console.ReadLine();
//
//             Console.Write("Password: ");
//             password = Console.ReadLine();
//
//
//             if (username == "Chri" && password == "1234")
//             {
//                 login = true;
//                 Hub();
//                 Console.ReadLine();
//             }
//             else
//             {
//                 login = false;
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine("false input of password or username");
//                 Console.ResetColor();
//                 Console.ReadLine();
//                 loginCount++;
//             }
//         }
//     }
//
//
//
//
// }

// Element 1 Hub 
// void Hub()
//     {
//         Console.Clear();
//         Console.WriteLine("Loading Hub ");
//         Thread.Sleep(500);
//         Console.Write(".");
//         Thread.Sleep(500);
//         Console.Write("..");
//         Thread.Sleep(500);
//         Console.Write("...");
//         
//         Console.Clear();
//         Console.ForegroundColor = ConsoleColor.DarkCyan;
//         Console.WriteLine("----------------");
//         Console.WriteLine("Welcome in the hub from here you can go to the different elements of this application");
//         Console.WriteLine("----------------");
//         Console.ResetColor();
//
//         Console.WriteLine("what do you want to do?");
//         Console.WriteLine("[1] Todo list");
//         Console.WriteLine("[2] Project analyses");
//         Console.WriteLine("[3] Solution table");
//         Console.WriteLine("[4] Exit");
//         Console.WriteLine("");
//         hubChoice = Console.ReadLine();
//         
//         if (hubChoice == "1")
//         {
//             TodoList();
//         }
//         if (hubChoice == "2")
//         {
//            ProjectAnalyses();
//         }
//         if (hubChoice == "3")
//         {
//             SolutionTable();
//         }
//         if (hubChoice == "4")
//         {
//             Exit();
//         }
//     }

 

// Element 2 TodoList 
// void TodoList()
// {
//     Console.Clear();
//  
//     
//      Console.Clear();
//     Console.WriteLine("Loading Todo List");
//     Thread.Sleep(500);
//     Console.Write(".");
//     Thread.Sleep(500);
//     Console.Write("..");
//     Thread.Sleep(500);
//     Console.Write("...");
//     Console.Clear();
//     Console.ForegroundColor = ConsoleColor.DarkCyan;
//
//     Console.WriteLine("----------------");
//     Console.WriteLine("todo List");
//     Console.WriteLine("----------------");
//     Console.ResetColor();
//     Console.WriteLine("");
//     
//     Console.WriteLine("[1] | Show todo List");
//     Console.WriteLine("[2] | Add task");
//     Console.WriteLine("[3] | clear task");
//     Console.WriteLine("[4] | Back to Hub");
//     taskmChoice = Console.ReadLine();
//
//     if (taskmChoice == "1") // show taks and Status
//     {
//
//      
//         if (taskCount > 0)
//         {
//             taskStatus = 100 / taskCount;
//         }
//       
//         
//
//             
//
//             
//        
//             Console.Clear();
//             if (string.IsNullOrEmpty(taskOne))
//             {
//                 Console.WriteLine();
//             }
//             else
//             {
//                
//                 Console.WriteLine("----------------");
//                 Console.WriteLine("tasks: {0}", taskCount);
//                 Console.WriteLine("----------------");
//                 Console.WriteLine("task Status {0}%", taskStatus);
//                 Console.WriteLine("----------------"); 
//                 Console.WriteLine("Task 1: {0}", taskOne);
//
//             }
//
//             if (string.IsNullOrEmpty(taskTwo))
//             {
//                 Console.WriteLine();
//             }
//             else
//             {
//                 Console.WriteLine("Task 2: {0}", taskTwo);
//             }
//
//             if (string.IsNullOrEmpty(taskThree))
//             {
//                 Console.WriteLine();
//             }
//             else
//             {
//                 Console.WriteLine("Task 3: {0}", taskThree);
//             }
//
//             if (string.IsNullOrEmpty(taskFour))
//             {
//                 Console.WriteLine();
//             }
//             else
//             {
//                 Console.WriteLine("Task 4: {0}", taskFour);
//
//             }
//
//             if (string.IsNullOrEmpty(taskFive))
//             {
//                 Console.WriteLine();
//             }
//             else
//             {
//                 Console.WriteLine("Task 5: {0}", taskFive);
//
//             }
//
//             if (taskCount == 0)
//             {     
//                 Console.Clear();
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine("You need to add a task!");
//                 Thread.Sleep(500);
//                 Console.Write(".");
//                 Thread.Sleep(500);
//                 Console.Write("..");
//                 Thread.Sleep(500);
//                 Console.Write("...");
//                 Console.ResetColor();
//                 TodoList();
//             }
//             else
//             {
//                      
//             Console.WriteLine();
//             Console.WriteLine("Do you want to go back or go to Hub?");
//             Console.WriteLine("[1] | Go back to Menu");
//             Console.WriteLine("[2] | Back to Hub");
//             taskChoice = Console.ReadLine();
//             if (taskChoice == "1")
//             {
//                 TodoList();
//             }
//             else
//             {
//                 Hub();
//             }
//             }
//             
//         
//     }
//
//     if (taskmChoice == "2") // add tasks + taskCounter ++
//         {
//             Console.Clear();
//             Console.WriteLine("Add a task: ");
//             if (string.IsNullOrEmpty(taskOne)) //t1
//             {
//                 taskOne = Console.ReadLine();
//                 taskCount++;
//                 TodoList();
//             }
//             else
//             {
//
//                 if (string.IsNullOrEmpty(taskTwo)) // t2
//                 {
//                     taskTwo = Console.ReadLine();
//                     taskCount++;
//
//                     TodoList();
//                 }
//                 else
//                 {
//                     if (string.IsNullOrEmpty(taskThree)) //t3
//                     {
//                         taskThree = Console.ReadLine();
//                         taskCount++;
//
//                         TodoList();
//                     }
//                     else
//                     {
//                         if (string.IsNullOrEmpty(taskFour)) //t4
//                         {
//                             taskFour = Console.ReadLine();
//                             taskCount++;
//
//                             TodoList();
//                         }
//                         else
//                         {
//                             if (string.IsNullOrEmpty(taskFive)) //t5
//                             {
//                                 taskFive = Console.ReadLine();
//                                 taskCount++;
//
//                                 TodoList();
//                             }
//                             else
//                             {
//                                 Console.ForegroundColor = ConsoleColor.Red;
//                                 Console.WriteLine("Your maximum of 5 Tasks is reached!");
//
//                                 Thread.Sleep(500);
//                                 Console.Write(".");
//                                 Thread.Sleep(500);
//                                 Console.Write("..");
//                                 Thread.Sleep(500);
//                                 Console.Write("...");
//                                 Console.ResetColor();
//                                 TodoList();
//
//                             }
//
//                         }
//                     }
//                 }
//             }
//
//
//         
//
//     }
//
//     if (taskmChoice =="3") //delet a Task
//     {
//         Console.Clear();
//         Console.ForegroundColor = ConsoleColor.DarkCyan;
//
//         Console.WriteLine("----------------");
//         Console.WriteLine("Which Task want to delete: ");
//         Console.WriteLine("----------------");
//         Console.ResetColor();
//
//         if (taskCount == 0 )
//         {
//             Console.Clear();
//             Console.ForegroundColor = ConsoleColor.Red;          
//             Console.WriteLine("you need to add a Task first!");
//             Thread.Sleep(500);
//             Console.Write(".");
//             Thread.Sleep(500);
//             Console.Write("..");
//             Thread.Sleep(500);
//             Console.Write("...");
//             Console.ResetColor();
//             TodoList();
//         }
//         else
//         {
//             Console.WriteLine( "[1] | {0}", taskOne);
//             if (string.IsNullOrEmpty(taskTwo))
//             {
//                 Console.WriteLine();
//             }
//             else
//             {
//                 Console.WriteLine( "[2] | {0}", taskTwo);
//                 if (string.IsNullOrEmpty(taskThree))
//                 {
//                     Console.WriteLine();
//                 }
//                 else
//                 {
//                     Console.WriteLine( "[3] | {0}", taskThree);
//                     if (string.IsNullOrEmpty(taskFour) )
//                     {
//                         Console.WriteLine();
//                     }
//                     else
//                     {
//                         Console.WriteLine( "[4] | {0}", taskFour);
//                         if (string.IsNullOrEmpty(taskFive) )
//                         {
//                             Console.WriteLine();
//                         }
//                         else
//                         {
//                             Console.WriteLine( "[5] | {0}", taskFive);
//                         }
//                     }
//                 }
//             }
//             
//         }
//
//         deleteTask = Console.ReadLine();
//         if (deleteTask == "1")
//         {
//             taskOne = "";
//             Console.ForegroundColor = ConsoleColor.Blue;          
//             Console.WriteLine("Task Deleting");
//             Thread.Sleep(500);
//             Console.Write(".");
//             Thread.Sleep(500);
//             Console.Write("..");
//             Thread.Sleep(500);
//             Console.Write("...");
//             Console.ResetColor();
//             TodoList();
//         }
//         if (deleteTask == "2")
//         {
//             taskTwo = "";
//             Console.ForegroundColor = ConsoleColor.Blue;          
//             Console.WriteLine("Task Deleting");
//             Thread.Sleep(500);
//             Console.Write(".");
//             Thread.Sleep(500);
//             Console.Write("..");
//             Thread.Sleep(500);
//             Console.Write("...");
//             Console.ResetColor();
//             TodoList();
//         }
//         if (deleteTask == "3")
//         {
//             taskChoice = "";
//             Console.ForegroundColor = ConsoleColor.Blue;          
//             Console.WriteLine("Task Deleting");
//             Thread.Sleep(500);
//             Console.Write(".");
//             Thread.Sleep(500);
//             Console.Write("..");
//             Thread.Sleep(500);
//             Console.Write("...");
//             Console.ResetColor();
//             TodoList();
//         }
//         if (deleteTask == "4")
//         {
//             taskFour = ""; 
//             Console.ForegroundColor = ConsoleColor.Blue;          
//             Console.WriteLine("Task Deleting");
//             Thread.Sleep(500);
//             Console.Write(".");
//             Thread.Sleep(500);
//             Console.Write("..");
//             Thread.Sleep(500);
//             Console.Write("...");
//             Console.ResetColor();
//             TodoList();
//         }
//         else
//         {
//             taskFive = "";
//             Console.ForegroundColor = ConsoleColor.Blue;          
//             Console.WriteLine("Task Deleting");
//             Thread.Sleep(500);
//             Console.Write(".");
//             Thread.Sleep(500);
//             Console.Write("..");
//             Thread.Sleep(500);
//             Console.Write("...");
//             Console.ResetColor();
//             TodoList();
//         }
//     }
//     if (taskmChoice =="4") // go back o hub 
//     {
//         Console.Clear();
//         Hub();
//     }
//
//     
//     
// }


// Element 3 Project Analyses
// void ProjectAnalyses()
// {
//     Console.Clear();
//     Console.WriteLine("Loading Project Analyses");
//     Thread.Sleep(500);
//     Console.Write(".");
//     Thread.Sleep(500);
//     Console.Write("..");
//     Thread.Sleep(500);
//     Console.Write("...");
//     Console.Clear();
//     Console.ForegroundColor = ConsoleColor.DarkCyan;
//
//     Console.WriteLine("----------------");
//     Console.WriteLine("Project Analyses");
//     Console.WriteLine("----------------");
//     Console.ResetColor();
//     Console.WriteLine("");
//     Console.WriteLine("[1] | Make an Project Analyses");
//     Console.WriteLine("[2] | Back to Hub");
//     prodHubChoice = Console.ReadLine();
//
//     if (prodHubChoice == "1")
//     {
//
//         if (!proAlreadyDone)
//         {
//             //Q1
//                     Console.Clear();
//             
//                     Console.WriteLine("how would you rate the complexity of your Project ");
//                     Console.WriteLine("");
//                     Console.WriteLine("[1] | low");
//                     Console.WriteLine("[2] | middle");
//                     Console.WriteLine("[3] | high");
//                     question1 = Convert.ToInt32(Console.ReadLine());
//                     
//                     //Q2
//                     Console.Clear();
//             
//                     Console.WriteLine("how would you rate the novelty of your Project");
//                     Console.WriteLine("");
//                     Console.WriteLine("[1] | low");
//                     Console.WriteLine("[2] | middle");
//                     Console.WriteLine("[3] | high");
//                     question2 = Convert.ToInt32(Console.ReadLine());
//                     
//                     //Q3
//                     Console.Clear();
//             
//                     Console.WriteLine("how would you rate the risk of your Project");
//                     Console.WriteLine("");
//                     Console.WriteLine("[1] | low");
//                     Console.WriteLine("[2] | middle");
//                     Console.WriteLine("[3] | high");
//                     question3 = Convert.ToInt32(Console.ReadLine());
//                     
//                     //Q4
//                     Console.Clear();
//             
//                     Console.WriteLine("how would you rate the strategic importance of your Project");
//                     Console.WriteLine("");
//                     Console.WriteLine("[1] | low");
//                     Console.WriteLine("[2] | middle");
//                     Console.WriteLine("[3] | high");
//                     question4 = Convert.ToInt32(Console.ReadLine());
//                     
//                     //Q5
//                     Console.Clear();
//                     
//                     Console.WriteLine("how would you rate the target contaminated of your Project");
//                     Console.WriteLine(""); 
//                     Console.WriteLine("[1] | low");
//                     Console.WriteLine("[2] | middle");
//                     Console.WriteLine("[3] | high");
//                     question5 = Convert.ToInt32(Console.ReadLine());
//             
//                     Console.Clear();
//                     //algorithm  
//                     if (question5 > 1 && question2 > 1 && question3 < 3 && question4 <= 3 && question1 <= 3)
//                     {
//                         Console.Clear();
//                         Console.ForegroundColor = ConsoleColor.Green;
//                         Console.WriteLine("Do that now!");
//                         proConclution = "Do that now!";
//                      
//                         Console.ResetColor();
//             
//                     }
//                     else if (question5 <= 2 && question1 == 3 && question2 == 1 && question3 == 3 && question4 < 3)
//                     {
//                         Console.Clear();
//                         Console.ForegroundColor = ConsoleColor.Red;
//                         Console.WriteLine("Dont do that!");     
//                         proConclution = "Dont do that!";
//                         Console.ResetColor();
//             
//                     }
//                     else if(question5 <= 1 && question2 >= 1 && question4 > 1 && question1 >= 1 && question3 >= 1)
//                     {
//                         Console.Clear();
//                         Console.ForegroundColor = ConsoleColor.Yellow;
//                         Console.WriteLine("You could do that");
//                         proConclution = "You could do that";
//                         Console.ResetColor();
//             
//                     }
//                     else
//                     {
//                         Console.Clear();
//                         Console.ForegroundColor = ConsoleColor.Red;
//                         Console.WriteLine("Dont do that!");
//                         proConclution = "Dont do that!";
//                         Console.ResetColor();
//                     }
//
//                     proAlreadyDone = true;
//                     Console.WriteLine("");
//                     Console.WriteLine("[1] | return to menu");
//                     Console.WriteLine("[2] | Back to Hub");
//                     prodBackChoice = Console.ReadLine();
//                     if (prodBackChoice == "1")
//                     {
//                         ProjectAnalyses();
//                     }
//                     else
//                     {
//                         Hub();    
//                     }
//         }
//         else
//         {
//             Console.Clear();
//             Console.ForegroundColor = ConsoleColor.DarkCyan;
//
//             Console.WriteLine("----------------");
//             Console.WriteLine("Project Analyses");
//             Console.WriteLine("----------------");
//             Console.ResetColor();
//             Console.WriteLine("");
//             Console.WriteLine("You already made an Analyses!");
//             Console.WriteLine("");
//             Console.WriteLine("The Conclusion:");
//             if (proConclution == "Dont do that!")
//             {
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine(proConclution);
//                 Console.ResetColor();
//             }
//             else if (proConclution == "You could do that")
//             {
//                 Console.ForegroundColor = ConsoleColor.Yellow;
//                 Console.WriteLine(proConclution);
//                 Console.ResetColor();
//             }
//             else if (proConclution == "Do that now!")
//             {
//                 Console.ForegroundColor = ConsoleColor.Green;
//                 Console.WriteLine(proConclution);
//                 Console.ResetColor();
//             }
//      
//             Console.WriteLine("");
//             Console.WriteLine("press any key to continue");
//             Console.ReadKey();
//             Console.Clear();
//             Hub(); 
//         }
//        
//         
//
//     }
//     else
//     {
//         Hub();
//     }
//
// }

// Element 4 Solution Table
// void SolutionTable()
// {
//     Console.Clear();
//     Console.WriteLine("Loading Solution-table");
//     Thread.Sleep(500);
//     Console.Write(".");
//     Thread.Sleep(500);
//     Console.Write("..");
//     Thread.Sleep(500);
//     Console.Write("...");
//     Console.Clear();
//     Console.ForegroundColor = ConsoleColor.DarkCyan;
//     Console.WriteLine("----------------");
//     Console.WriteLine("Solution Table");
//     Console.WriteLine("----------------");
//     Console.ResetColor();
//     Console.WriteLine("");
//     
//     Console.WriteLine("[1] | Show problems");
//     Console.WriteLine("[2] | Add Problem");
//     Console.WriteLine("[3] | clear a Problem");
//     Console.WriteLine("[4] | Back to Hub");
//     problemChoice = Console.ReadLine();
//
//     if (problemChoice == "1")
//     {
//         Console.Clear();
//         Console.ForegroundColor = ConsoleColor.DarkCyan;
//
//         Console.WriteLine("----------------");
//         Console.WriteLine("Problems: ");
//         Console.WriteLine("----------------");
//         Console.ResetColor();
//         if (string.IsNullOrEmpty(problemOne))
//         {
//             Console.WriteLine();
//         }
//         else
//         {
//             Console.WriteLine("Problem 1: {0}", problemOne);
//
//         }
//         if (string.IsNullOrEmpty(problemTwo))
//         {
//             Console.WriteLine();
//         }
//         else
//         {
//             Console.WriteLine("Problem 2: {0}", problemTwo);
//         }
//         if (string.IsNullOrEmpty(problemThree))
//         {
//             Console.WriteLine();
//         }
//         else
//         {
//             Console.WriteLine("Problem 3: {0}", problemThree); 
//         }
//         if (string.IsNullOrEmpty(problemOFour))
//         {
//             Console.WriteLine();
//         }
//         else
//         {
//             Console.WriteLine("Problem 4: {0}", problemOFour);
//
//         }
//         if (string.IsNullOrEmpty(problemFive))
//         {
//             Console.WriteLine();
//         }
//         else
//         {
//             Console.WriteLine("Problem 5: {0}", problemFive);
//    
//         }
//
//         Console.WriteLine();
//         Console.WriteLine("Do you want to add a Problm or go back to Hub?");
//         Console.WriteLine("[1] | Go back to Menu");
//         Console.WriteLine("[2] | Back to Hub");
//         solutionChoice = Console.ReadLine();
//         if (solutionChoice == "1")
//         {
//         SolutionTable();
//         }
//         else
//         {
//             Hub();
//         }
//     }
//     if(problemChoice == "2")
//     {
//         Console.Clear();
//         Console.WriteLine("Add a problem: ");
//         if (string.IsNullOrEmpty(problemOne)) //p1
//         {
//             problemOne = Console.ReadLine();
//             SolutionTable();
//         }
//         else
//         {
//             
//         if (string.IsNullOrEmpty(problemTwo))// p2
//         {
//             problemTwo = Console.ReadLine();
//             SolutionTable();
//         }
//         else
//         { 
//             if (string.IsNullOrEmpty(problemThree)) //p3
//             {
//                 problemThree = Console.ReadLine();
//                 SolutionTable();;
//             }
//             else
//             {
//                  if (string.IsNullOrEmpty(problemOFour))
//                         {
//                             problemOFour = Console.ReadLine();
//                             SolutionTable();;
//                         }
//                         else
//                         {
//                              if (string.IsNullOrEmpty(problemFive))
//                                    {
//                                        problemFive = Console.ReadLine();
//                                        SolutionTable();;
//                                    }
//                                    else
//                                    {
//                                        Console.WriteLine("Your maximum of 5 Problems is reached!");
//                                        
//                                        Thread.Sleep(500);
//                                        Console.Write(".");
//                                        Thread.Sleep(500);
//                                        Console.Write("..");
//                                        Thread.Sleep(500);
//                                        Console.Write("...");
//                                        SolutionTable();
//                                        
//                                    }
//                 
//                         }
//             }
//         }
//         }
//        
//        
//        
//       
//     }
//
//     if (problemChoice =="3") //delete a Problem
//     {
//         Console.Clear();
//         Console.ForegroundColor = ConsoleColor.DarkCyan;
//
//         Console.WriteLine("----------------");
//         Console.WriteLine("Which Problem   want to delete: ");
//         Console.WriteLine("----------------");
// Console.ResetColor();
//         if (string.IsNullOrEmpty(problemOne))
//         {
//             Console.Clear();
//             Console.WriteLine("you need to add a problem!");
//             Thread.Sleep(500);
//             Console.Write(".");
//             Thread.Sleep(500);
//             Console.Write("..");
//             Thread.Sleep(500);
//             Console.Write("...");
//             SolutionTable();
//         }
//         else
//         {
//             Console.WriteLine( "[1] | {0}", problemOne);
//             if (string.IsNullOrEmpty(problemOne) && string.IsNullOrEmpty(problemTwo) )
//             {
//                 Console.WriteLine();
//             }
//             else
//             {
//                 Console.WriteLine( "[2] | {0}", problemTwo);
//                 if (string.IsNullOrEmpty(problemTwo) && string.IsNullOrEmpty(problemThree))
//                 {
//                     Console.WriteLine();
//                 }
//                 else
//                 {
//                     Console.WriteLine( "[3] | {0}", problemThree);
//                     if (string.IsNullOrEmpty(problemThree) && string.IsNullOrEmpty(problemOFour))
//                     {
//                         Console.WriteLine();
//                     }
//                     else
//                     {
//                         Console.WriteLine( "[4] | {0}", problemOFour);
//                         if (string.IsNullOrEmpty(problemOFour) && string.IsNullOrEmpty(problemFive))
//                         {
//                             Console.WriteLine();
//                         }
//                         else
//                         {
//                             Console.WriteLine( "[5] | {0}", problemFive);
//                         }
//                     }
//                 }
//             }
//             
//         }
//
//         deleteChoice = Console.ReadLine();
//         if (deleteChoice == "1")
//         {
//             problemOne = "";
//         }
//         if (deleteChoice == "2")
//         {
//             problemTwo = "";
//         }
//         if (deleteChoice == "3")
//         {
//             problemThree = "";
//         }
//         if (deleteChoice == "4")
//         {
//             problemOFour = "";
//         }
//         else
//         {
//             problemFive = "";
//         }
//     }
//     if (problemChoice =="4") // go back o hub 
//     {
//         Console.Clear();
//         Hub();
//     }
//
// }



//  Element 5 Exit
// void Exit()
// {
//     Console.Clear();
//     Console.WriteLine("Loading Exit");
//     Thread.Sleep(500);
//     Console.Write(".");
//     Thread.Sleep(500);
//     Console.Write("..");
//     Thread.Sleep(500);
//     Console.Write("...");
//     Console.Clear();
//
//     Console.ForegroundColor = ConsoleColor.DarkCyan;
//
//     Console.WriteLine("----------------");
//     Console.WriteLine("Do you really want to close the Program?");
//     Console.WriteLine("----------------");
//     Console.ResetColor();
//     Console.WriteLine("");
//     Console.WriteLine("[1] | yes");
//     Console.WriteLine("[2] | No");
//     exit = Console.ReadLine();
//     if (exit == "1")
//     {
//         
//         Console.Clear();
//         Environment.Exit(0);
//     }
//     else
//     {
//         Console.Clear();
//         Hub();
//     }
// }
