using System;
using System.Collections; //arraylist
using System.Collections.Generic;
using System.Windows.Forms; //copy-to-clipboard (gæstebog)
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminalprogram
{
    class Program
    {
        static string introSvar = "";
        public static ArrayList Greetings = new ArrayList();
        public static bool Foreign = false;
        [STAThread] //for clipboard windows.Forms ifbm. gæstebog;

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); //standard størrelse
            FirstIntro();
        }
        public static void FirstIntro() //Velkomst - Dansk og Engelsk
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Velkommen til Roskilde Festival 2017! \n" +
                "Tryk på en vilkårlig tast for at fortsætte.");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Welcome to Roskilde Festival 2017! \n" +
                "Press a random button to continue.");
            Console.ResetColor();
            Console.ReadKey();
            Intro();
        }
        public static void Intro() //Valg af sprog
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Hej! \n\n" +
                    "Tast [1] for at fortsætte på Dansk.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tast [x] for at afslutte programmet.");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Hello! \n\n" +
                    "Type [2] to continue in English.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Type [x] to exit the program.");
                Console.ForegroundColor = ConsoleColor.White;
                introSvar = Console.ReadLine().ToLower(); //ToLower & ToUpper driller. Ændrer do-while og If betingelser til at indeholde både upper- og lowercase

            } while (introSvar != "1" && introSvar != "2" && introSvar != "x" && introSvar != "X");

            if (introSvar == "1") //Dansk
            {
                Console.Clear();
                Foreign = false;
                Dansk.Menu();
            }

            if (introSvar == "2") //Engelsk
            {
                Console.Clear();
                Foreign = true;
                Engelsk.Menu();
            }

            if (introSvar == "X" || introSvar == "x") //Exit
            {
                Console.Clear();
                ProgramExit();

            }

        }
        public static void ProgramExit() //Pkt. 6/"x" - Genstarter Program.
        {
            Console.Clear();
            if (Foreign == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Programmet vil nu genstarte.");
            }
            else if (Foreign == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("The program will now restart.");
            }
            Console.CursorVisible = false;
            Console.ResetColor();
            System.Threading.Thread.Sleep(3000);
            introSvar = "";
            Foreign = false;
            Console.Clear();
            Console.CursorVisible = true;
            Program.FirstIntro();

        }
    }
}
