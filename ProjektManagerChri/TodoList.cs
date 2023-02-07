namespace ProjektManagerChri;

public class TodoList : Hub
{
    //TodoList var
    string taskmChoice;
    string taskOne ="";
    string taskTwo = "";
    string taskThree = "";
    string taskFour = "";
    string taskFive = "";
    string taskChoice;
    string deleteTask;
    int taskStatus = 0;
    int taskCount = 0;
    
    void TodoListFunktion()
{
    Console.Clear();
 
    
     Console.Clear();
    Console.WriteLine("Loading Todo List");
    Thread.Sleep(500);
    Console.Write(".");
    Thread.Sleep(500);
    Console.Write("..");
    Thread.Sleep(500);
    Console.Write("...");
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkCyan;

    Console.WriteLine("----------------");
    Console.WriteLine("todo List");
    Console.WriteLine("----------------");
    Console.ResetColor();
    Console.WriteLine("");
    
    Console.WriteLine("[1] | Show todo List");
    Console.WriteLine("[2] | Add task");
    Console.WriteLine("[3] | clear task");
    Console.WriteLine("[4] | Back to Hub");
    taskmChoice = Console.ReadLine();

    if (taskmChoice == "1") // show taks and Status
    {

     
        if (taskCount > 0)
        {
            taskStatus = 100 / taskCount;
        }
      
        

            

            
       
            Console.Clear();
            if (string.IsNullOrEmpty(taskOne))
            {
                Console.WriteLine();
            }
            else
            {
               
                Console.WriteLine("----------------");
                Console.WriteLine("tasks: {0}", taskCount);
                Console.WriteLine("----------------");
                Console.WriteLine("task Status {0}%", taskStatus);
                Console.WriteLine("----------------"); 
                Console.WriteLine("Task 1: {0}", taskOne);

            }

            if (string.IsNullOrEmpty(taskTwo))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Task 2: {0}", taskTwo);
            }

            if (string.IsNullOrEmpty(taskThree))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Task 3: {0}", taskThree);
            }

            if (string.IsNullOrEmpty(taskFour))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Task 4: {0}", taskFour);

            }

            if (string.IsNullOrEmpty(taskFive))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Task 5: {0}", taskFive);

            }

            if (taskCount == 0)
            {     
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You need to add a task!");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write("..");
                Thread.Sleep(500);
                Console.Write("...");
                Console.ResetColor();
                TodoListFunktion();
            }
            else
            {
                     
            Console.WriteLine();
            Console.WriteLine("Do you want to go back or go to Hub?");
            Console.WriteLine("[1] | Go back to Menu");
            Console.WriteLine("[2] | Back to Hub");
            taskChoice = Console.ReadLine();
            if (taskChoice == "1")
            {
                TodoListFunktion();
            }
            else
            {
                HubFunktion();
            }
            }
            
        
    }

    if (taskmChoice == "2") // add tasks + taskCounter ++
        {
            Console.Clear();
            Console.WriteLine("Add a task: ");
            if (string.IsNullOrEmpty(taskOne)) //t1
            {
                taskOne = Console.ReadLine();
                taskCount++;
                TodoListFunktion();
            }
            else
            {

                if (string.IsNullOrEmpty(taskTwo)) // t2
                {
                    taskTwo = Console.ReadLine();
                    taskCount++;

                    TodoListFunktion();
                }
                else
                {
                    if (string.IsNullOrEmpty(taskThree)) //t3
                    {
                        taskThree = Console.ReadLine();
                        taskCount++;

                        TodoListFunktion();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(taskFour)) //t4
                        {
                            taskFour = Console.ReadLine();
                            taskCount++;

                            TodoListFunktion();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(taskFive)) //t5
                            {
                                taskFive = Console.ReadLine();
                                taskCount++;

                                TodoListFunktion();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Your maximum of 5 Tasks is reached!");

                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write("..");
                                Thread.Sleep(500);
                                Console.Write("...");
                                Console.ResetColor();
                                TodoListFunktion();

                            }

                        }
                    }
                }
            }


        

    }

    if (taskmChoice =="3") //delet a Task
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine("----------------");
        Console.WriteLine("Which Task want to delete: ");
        Console.WriteLine("----------------");
        Console.ResetColor();

        if (taskCount == 0 )
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;          
            Console.WriteLine("you need to add a Task first!");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("..");
            Thread.Sleep(500);
            Console.Write("...");
            Console.ResetColor();
            TodoListFunktion();
        }
        else
        {
            Console.WriteLine( "[1] | {0}", taskOne);
            if (string.IsNullOrEmpty(taskTwo))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine( "[2] | {0}", taskTwo);
                if (string.IsNullOrEmpty(taskThree))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine( "[3] | {0}", taskThree);
                    if (string.IsNullOrEmpty(taskFour) )
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine( "[4] | {0}", taskFour);
                        if (string.IsNullOrEmpty(taskFive) )
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine( "[5] | {0}", taskFive);
                        }
                    }
                }
            }
            
        }

        deleteTask = Console.ReadLine();
        if (deleteTask == "1")
        {
            taskOne = "";
            Console.ForegroundColor = ConsoleColor.Blue;          
            Console.WriteLine("Task Deleting");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("..");
            Thread.Sleep(500);
            Console.Write("...");
            Console.ResetColor();
            TodoListFunktion();
        }
        if (deleteTask == "2")
        {
            taskTwo = "";
            Console.ForegroundColor = ConsoleColor.Blue;          
            Console.WriteLine("Task Deleting");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("..");
            Thread.Sleep(500);
            Console.Write("...");
            Console.ResetColor();
            TodoListFunktion();
        }
        if (deleteTask == "3")
        {
            taskChoice = "";
            Console.ForegroundColor = ConsoleColor.Blue;          
            Console.WriteLine("Task Deleting");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("..");
            Thread.Sleep(500);
            Console.Write("...");
            Console.ResetColor();
            TodoListFunktion();
        }
        if (deleteTask == "4")
        {
            taskFour = ""; 
            Console.ForegroundColor = ConsoleColor.Blue;          
            Console.WriteLine("Task Deleting");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("..");
            Thread.Sleep(500);
            Console.Write("...");
            Console.ResetColor();
            TodoListFunktion();
        }
        else
        {
            taskFive = "";
            Console.ForegroundColor = ConsoleColor.Blue;          
            Console.WriteLine("Task Deleting");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("..");
            Thread.Sleep(500);
            Console.Write("...");
            Console.ResetColor();
            TodoListFunktion();
        }
    }
    if (taskmChoice =="4") // go back o hub 
    {
        Console.Clear();
        HubFunktion();
    }

    
    
}

}