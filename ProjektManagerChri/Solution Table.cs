namespace ProjektManagerChri;

public class Solution_Table : Hub
{
    
    //problem var
    string problemChoice;
    string problemOne ="";
    string problemTwo = "";
    string problemThree = "";
    string problemOFour = "";
    string problemFive = "";
    string solutionChoice;
    string deleteChoice;
    
    void SolutionTable()
{
    Console.Clear();
    Console.WriteLine("Loading Solution-table");
    Thread.Sleep(500);
    Console.Write(".");
    Thread.Sleep(500);
    Console.Write("..");
    Thread.Sleep(500);
    Console.Write("...");
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("----------------");
    Console.WriteLine("Solution Table");
    Console.WriteLine("----------------");
    Console.ResetColor();
    Console.WriteLine("");
    
    Console.WriteLine("[1] | Show problems");
    Console.WriteLine("[2] | Add Problem");
    Console.WriteLine("[3] | clear a Problem");
    Console.WriteLine("[4] | Back to Hub");
    problemChoice = Console.ReadLine();

    if (problemChoice == "1")
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine("----------------");
        Console.WriteLine("Problems: ");
        Console.WriteLine("----------------");
        Console.ResetColor();
        if (string.IsNullOrEmpty(problemOne))
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Problem 1: {0}", problemOne);

        }
        if (string.IsNullOrEmpty(problemTwo))
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Problem 2: {0}", problemTwo);
        }
        if (string.IsNullOrEmpty(problemThree))
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Problem 3: {0}", problemThree); 
        }
        if (string.IsNullOrEmpty(problemOFour))
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Problem 4: {0}", problemOFour);

        }
        if (string.IsNullOrEmpty(problemFive))
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Problem 5: {0}", problemFive);
   
        }

        Console.WriteLine();
        Console.WriteLine("Do you want to add a Problm or go back to Hub?");
        Console.WriteLine("[1] | Go back to Menu");
        Console.WriteLine("[2] | Back to Hub");
        solutionChoice = Console.ReadLine();
        if (solutionChoice == "1")
        {
        SolutionTable();
        }
        else
        {
            HubFunktion();
        }
    }
    if(problemChoice == "2")
    {
        Console.Clear();
        Console.WriteLine("Add a problem: ");
        if (string.IsNullOrEmpty(problemOne)) //p1
        {
            problemOne = Console.ReadLine();
            SolutionTable();
        }
        else
        {
            
        if (string.IsNullOrEmpty(problemTwo))// p2
        {
            problemTwo = Console.ReadLine();
            SolutionTable();
        }
        else
        { 
            if (string.IsNullOrEmpty(problemThree)) //p3
            {
                problemThree = Console.ReadLine();
                SolutionTable();;
            }
            else
            {
                 if (string.IsNullOrEmpty(problemOFour))
                        {
                            problemOFour = Console.ReadLine();
                            SolutionTable();;
                        }
                        else
                        {
                             if (string.IsNullOrEmpty(problemFive))
                                   {
                                       problemFive = Console.ReadLine();
                                       SolutionTable();;
                                   }
                                   else
                                   {
                                       Console.WriteLine("Your maximum of 5 Problems is reached!");
                                       
                                       Thread.Sleep(500);
                                       Console.Write(".");
                                       Thread.Sleep(500);
                                       Console.Write("..");
                                       Thread.Sleep(500);
                                       Console.Write("...");
                                       SolutionTable();
                                       
                                   }
                
                        }
            }
        }
        }
       
       
       
      
    }

    if (problemChoice =="3") //delete a Problem
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine("----------------");
        Console.WriteLine("Which Problem   want to delete: ");
        Console.WriteLine("----------------");
Console.ResetColor();
        if (string.IsNullOrEmpty(problemOne))
        {
            Console.Clear();
            Console.WriteLine("you need to add a problem!");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("..");
            Thread.Sleep(500);
            Console.Write("...");
            SolutionTable();
        }
        else
        {
            Console.WriteLine( "[1] | {0}", problemOne);
            if (string.IsNullOrEmpty(problemOne) && string.IsNullOrEmpty(problemTwo) )
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine( "[2] | {0}", problemTwo);
                if (string.IsNullOrEmpty(problemTwo) && string.IsNullOrEmpty(problemThree))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine( "[3] | {0}", problemThree);
                    if (string.IsNullOrEmpty(problemThree) && string.IsNullOrEmpty(problemOFour))
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine( "[4] | {0}", problemOFour);
                        if (string.IsNullOrEmpty(problemOFour) && string.IsNullOrEmpty(problemFive))
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine( "[5] | {0}", problemFive);
                        }
                    }
                }
            }
            
        }

        deleteChoice = Console.ReadLine();
        if (deleteChoice == "1")
        {
            problemOne = "";
        }
        if (deleteChoice == "2")
        {
            problemTwo = "";
        }
        if (deleteChoice == "3")
        {
            problemThree = "";
        }
        if (deleteChoice == "4")
        {
            problemOFour = "";
        }
        else
        {
            problemFive = "";
        }
    }
    if (problemChoice =="4") // go back o hub 
    {
        Console.Clear();
       HubFunktion();
    }

}

}