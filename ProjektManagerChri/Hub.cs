namespace ProjektManagerChri;



public class Hub 
{
    //Hub var
    string hubChoice;
    
   public void HubFunktion()
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
        
        // if (hubChoice == "1")
        // {
        //     
        // }
        // if (hubChoice == "2")
        // {
        //     ProjectAnalyses();
        // }
        // if (hubChoice == "3")
        // {
        //     SolutionTable();
        // }
        // if (hubChoice == "4")
        // {
        //     Exit();
        // }
    }
}