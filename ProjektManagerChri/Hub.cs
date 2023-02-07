namespace ProjektManagerChri;



public class Hub 
{
    //Hub var
  static  string hubChoice;
    
  public static void HubFunktion()
    {
        Console.Clear();
        Console.WriteLine("Loading Hub ");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write("..");
        Thread.Sleep(500);
        Console.Write("...");
        
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("----------------");
        Console.WriteLine("Welcome in the hub from here you can go to the different elements of this application");
        Console.WriteLine("----------------");
        Console.ResetColor();

        Console.WriteLine("what do you want to do?");
        Console.WriteLine("[1] Todo list");
        Console.WriteLine("[2] Project analyses");
        Console.WriteLine("[3] Solution table");
        Console.WriteLine("[4] Exit");
        Console.WriteLine("");
        hubChoice = Console.ReadLine();
        
        if (hubChoice == "1")
        {
            TodoList.TodoListFunktion();
        }
        if (hubChoice == "2")
        {
            ProdjectAnalyses.ProjectAnalysesFunktion();
        }
        if (hubChoice == "3")
        {
            Solution_Table.SolutionTableFunktion();
        }
        if (hubChoice == "4")
        {
           Exit.ExitFunktion();
        }
    }
}