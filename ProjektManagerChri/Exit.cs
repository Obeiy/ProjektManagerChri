namespace ProjektManagerChri;

public class Exit : Hub
{
    //exit var
   static string exit;
    
 public  static void  ExitFunktion()
    {
        Console.Clear();
        Console.WriteLine("Loading Exit");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write("..");
        Thread.Sleep(500);
        Console.Write("...");
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine("----------------");
        Console.WriteLine("Do you really want to close the Program?");
        Console.WriteLine("----------------");
        Console.ResetColor();
        Console.WriteLine("");
        Console.WriteLine("[1] | yes");
        Console.WriteLine("[2] | No");
        exit = Console.ReadLine();
        if (exit == "1")
        {
        
            Console.Clear();
            Environment.Exit(0);
        }
        else
        {
            Console.Clear();
            HubFunktion();
        }
    }
}