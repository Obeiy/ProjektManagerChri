namespace ProjektManagerChri;

public class Login : Hub
{
  static  string username = "";
   static string password = "";
   static bool login = false;
   static int loginCount = 0;

//timer var 
  static  int milliseconds = 1000;
  static  int timer = 5;
    



// Element 0 Login 
public static void LoginFunktion(){
    
    
    
    while (!login)
    {
        if (loginCount > 2)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------");
            Console.WriteLine("to many login tries");
            Console.WriteLine("----------------");
            Thread.Sleep(2000);
           
            while (timer >= 0)
            {
                Console.Clear();

                Console.WriteLine("----------------");
                Console.WriteLine("time until you can try again: {0}", timer);
                Console.WriteLine("----------------");
                Thread.Sleep(milliseconds);
                timer--;
                if (timer == 0)
                {
                    Console.ResetColor();
                    loginCount = 0;
                    login = false;
                    LoginFunktion();
                }

            }

            login = true;
        }
        else
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("----------------");
            Console.WriteLine("'Hello welcome to Fibi the project management application");
            Console.WriteLine("----------------");
            Console.ResetColor();
            
            
            Console.WriteLine("Please login");
            Console.Write("Username: ");
            username = Console.ReadLine();

            Console.Write("Password: ");
            password = Console.ReadLine();


            if (username == "Chri" && password == "1234")
            {
                login = true;
                HubFunktion();
                Console.ReadLine();
            }
            else
            {
                login = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("false input of password or username");
                Console.ResetColor();
                Console.ReadLine();
                loginCount++;
            }
        }
    }




}

}