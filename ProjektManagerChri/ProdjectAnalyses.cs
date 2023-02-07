namespace ProjektManagerChri;

public class ProdjectAnalyses : Hub
{
    void ProjectAnalyses()
{
    // Project Analyses var
    string prodHubChoice;
    int question1;
    int question2;
    int question3;
    int question4;
    int question5;
    string prodBackChoice;
    string proConclution = "";
    bool proAlreadyDone = false;

    
    
    Console.Clear();
    Console.WriteLine("Loading Project Analyses");
    Thread.Sleep(500);
    Console.Write(".");
    Thread.Sleep(500);
    Console.Write("..");
    Thread.Sleep(500);
    Console.Write("...");
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkCyan;

    Console.WriteLine("----------------");
    Console.WriteLine("Project Analyses");
    Console.WriteLine("----------------");
    Console.ResetColor();
    Console.WriteLine("");
    Console.WriteLine("[1] | Make an Project Analyses");
    Console.WriteLine("[2] | Back to Hub");
    prodHubChoice = Console.ReadLine();

    if (prodHubChoice == "1")
    {

        if (!proAlreadyDone)
        {
            //Q1
                    Console.Clear();
            
                    Console.WriteLine("how would you rate the complexity of your Project ");
                    Console.WriteLine("");
                    Console.WriteLine("[1] | low");
                    Console.WriteLine("[2] | middle");
                    Console.WriteLine("[3] | high");
                    question1 = Convert.ToInt32(Console.ReadLine());
                    
                    //Q2
                    Console.Clear();
            
                    Console.WriteLine("how would you rate the novelty of your Project");
                    Console.WriteLine("");
                    Console.WriteLine("[1] | low");
                    Console.WriteLine("[2] | middle");
                    Console.WriteLine("[3] | high");
                    question2 = Convert.ToInt32(Console.ReadLine());
                    
                    //Q3
                    Console.Clear();
            
                    Console.WriteLine("how would you rate the risk of your Project");
                    Console.WriteLine("");
                    Console.WriteLine("[1] | low");
                    Console.WriteLine("[2] | middle");
                    Console.WriteLine("[3] | high");
                    question3 = Convert.ToInt32(Console.ReadLine());
                    
                    //Q4
                    Console.Clear();
            
                    Console.WriteLine("how would you rate the strategic importance of your Project");
                    Console.WriteLine("");
                    Console.WriteLine("[1] | low");
                    Console.WriteLine("[2] | middle");
                    Console.WriteLine("[3] | high");
                    question4 = Convert.ToInt32(Console.ReadLine());
                    
                    //Q5
                    Console.Clear();
                    
                    Console.WriteLine("how would you rate the target contaminated of your Project");
                    Console.WriteLine(""); 
                    Console.WriteLine("[1] | low");
                    Console.WriteLine("[2] | middle");
                    Console.WriteLine("[3] | high");
                    question5 = Convert.ToInt32(Console.ReadLine());
            
                    Console.Clear();
                    //algorithm  
                    if (question5 > 1 && question2 > 1 && question3 < 3 && question4 <= 3 && question1 <= 3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Do that now!");
                        proConclution = "Do that now!";
                     
                        Console.ResetColor();
            
                    }
                    else if (question5 <= 2 && question1 == 3 && question2 == 1 && question3 == 3 && question4 < 3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Dont do that!");     
                        proConclution = "Dont do that!";
                        Console.ResetColor();
            
                    }
                    else if(question5 <= 1 && question2 >= 1 && question4 > 1 && question1 >= 1 && question3 >= 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You could do that");
                        proConclution = "You could do that";
                        Console.ResetColor();
            
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Dont do that!");
                        proConclution = "Dont do that!";
                        Console.ResetColor();
                    }

                    proAlreadyDone = true;
                    Console.WriteLine("");
                    Console.WriteLine("[1] | return to menu");
                    Console.WriteLine("[2] | Back to Hub");
                    prodBackChoice = Console.ReadLine();
                    if (prodBackChoice == "1")
                    {
                        ProjectAnalyses();
                    }
                    else
                    {
                        HubFunktion();    
                    }
        }
        else
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("----------------");
            Console.WriteLine("Project Analyses");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("You already made an Analyses!");
            Console.WriteLine("");
            Console.WriteLine("The Conclusion:");
            if (proConclution == "Dont do that!")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(proConclution);
                Console.ResetColor();
            }
            else if (proConclution == "You could do that")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(proConclution);
                Console.ResetColor();
            }
            else if (proConclution == "Do that now!")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(proConclution);
                Console.ResetColor();
            }
     
            Console.WriteLine("");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();
           HubFunktion();
        }
       
        

    }
    else
    {
        HubFunktion();
    }

}
}