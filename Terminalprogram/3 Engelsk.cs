using System;
using System.Collections; //arraylist
//using System.Collections.Generic;
using System.Windows.Forms; //copy-to-clipboard (gæstebog)
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminalprogram
{
    class Engelsk
    {
        //EngelskOutput = Console.ForegroundColor = ConsoleColor.DarkCyan;
        //BrugerInput = Console.ForegroundColor = ConsoleColor.White;
        //ENPriser = Console.ForegroundColor = ConsoleColor.Cyan;
        //Attention = Console.ForegroundColor = ConsoleColor.Green;
        static string menuQuery = "";
        [STAThread] //for clipboard windows.Forms;
        public static void Menu()
        {
            do
            {
                Console.SetWindowSize(95, 25);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Clear();
                Console.WriteLine("How would you like to continue?");
                Console.WriteLine();
                Console.WriteLine("Type [1] for information for guests and volunteers.");
                Console.WriteLine();
                Console.WriteLine("Type [2] for merchandiseprices.");
                Console.WriteLine();
                Console.WriteLine("Type [3] for Wi-Fi information.");
                Console.WriteLine();
                Console.Write("Type [4] for a guide to this terminal and our ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[NEW] ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("guestbook!");
                Console.WriteLine();
                Console.WriteLine("Type [5] for the RF17 Map.");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Type [X] to exit the program.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.CursorVisible = true;
                menuQuery = Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            } while (menuQuery != "1" && menuQuery != "2" && menuQuery != "3" && menuQuery != "4" && menuQuery != "5" && menuQuery != "x" && menuQuery != "X");

            switch (menuQuery)
            {

                case "1": //Generel information 
                    Console.Clear();
                    subINFO();
                    ReturnMenu();
                    break;

                case "2": //Merchandisepriser
                    Console.Clear();
                    subMERCH();
                    ReturnMenu();
                    break;

                case "3": //Wi-Fi & datapriser
                    Console.Clear();
                    subWIFI();
                    break;

                case "4": //Guide + gæstebog
                    Console.Clear();
                    subGUIDE();
                    break;

                case "5": //"Kort" (Haha) 
                    Console.Clear();
                    subMAP();
                    break;

                case "x": //Exit
                    Console.Clear();
                    Program.ProgramExit();
                    break;
            }

        }
        private static void subINFO() //Pkt. 1 - Info & nødnumre
        {
            Console.SetWindowSize(125, 33);
            Console.WriteLine("Hello and welcome to Roskilde Festival 2017! \n\n" +
                            "The festival lasts 7 days, from June 24th to July 1st,\n" +
                            "where you get to experience and enjoy over 180 music acts.");
            Console.WriteLine();
            Console.WriteLine("The music programme for this year can be found on www.rf.dk or by the staff.\n" + //Her skulle man jo så have haft en -NEM- måde at vise spilleplanerne på
                "They can be found on the whole area, wearing yellow wests saying \"Spørg mig\". \n" +
                "They can also be found by the info towers, where first aid is also provided.");
            Console.WriteLine();
            Console.WriteLine("Tents are only allowed on the marked areas and only with a valid ticket full-week ticket.");
            Console.WriteLine();
            Console.WriteLine("With your arrival, you received a bracelet. \n" +
                "This bracelet must be worn at all times during the festival and MUST be shown if requested by staff or authorities.");
            Console.WriteLine();
            Console.WriteLine("By purchasing daytickets, you get entrance to Roskilde Festival for 24 hours, for half the price of a full-week ticket. \n" +
                "The provided bracelet must be worn at all times. The dayticket-bracelet does not give access to a tent space.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CONTACT:");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
            Console.WriteLine("Roskilde Festival main office - Call +45 46 36 66 13 or e-mail info@roskilde-festival.dk");
            Console.WriteLine("Emergencies (Police, Fire- and health dpt) - Call 112");
            Console.WriteLine("Suspicious situations, use/selling of narcotics or weapons - Call 114");
            Console.WriteLine();
            Console.WriteLine("You can download the app \"112\" with a GPS-localization service case of an emergency.");
            Console.WriteLine("____________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("ATTENTION: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Volunteers are asked to contact their superiors at minimum 6 hours before their first shift. \n" +
                "You will be briefed and given your volunteer-bracelet.");
        }
        private static void subMERCH() //Pkt. 2 - Merchandise
        {
            string continueDialog;
            int tshirtAntal = 0;
            int hatAntal = 0;
            int varerAntal = (tshirtAntal + hatAntal);
            int tshirtPris = 150;
            int hatPris = 100;
            double EurValue = 7.5; //Det antages at valutaen EURO står fast på 7.5 DKK.
            double tshirtEur = tshirtPris / EurValue;
            double hatEur = hatPris / EurValue;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Support Roskilde Festival 2017 by purchasing merchandise. \n\n" +
                    "This year t-shirts and hats are available.\n" +
                "These can be bought at the service towers, where you also can find free Wi-Fi and first-aid.");
                Console.WriteLine();
                Console.WriteLine("Here you can calculate the prices of the merchandise, see group discounts and more.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you wish to continue?");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Type [Y] for yes or [N] for no; you will return to the main menu.");
                Console.ForegroundColor = ConsoleColor.White;
                continueDialog = Console.ReadLine();
                continueDialog = continueDialog.ToUpper();
            } while (continueDialog != "Y" && continueDialog != "N" && continueDialog != "y" && continueDialog != "n"); //.ToUpper(); driller, denne metode virker også.

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            if (continueDialog == "Y" || continueDialog == "y")
            {

                Console.Clear();
                Console.WriteLine("The prices are as follows:");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Hats Sz. Onesize: DKK {hatPris} or EUR {hatEur.ToString("F")}."); //Kun 2 decimaler, runder op/ned
                Console.WriteLine($"T-shirts Sz. S/M/L: DKK {tshirtPris} or EUR {tshirtEur.ToString("F")}."); //Kun 2 decimaler, runder op/ned
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine();
                Console.WriteLine("Attention! Receive a 15% discount on your purchase by purchasing more than 4 items.");
                Console.WriteLine();

                //---------------------------------------------------------------------------TSHIRT---------------------------------------------------------------------------
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("How many t-shirts would you like?");
                    Console.WriteLine("(To purchase more than 10, please contact staff.)");
                    Console.ForegroundColor = ConsoleColor.White;

                    try
                    {
                        tshirtAntal = int.Parse(Console.ReadLine()); //TryParse virker ikke.
                    }

                    catch (Exception)
                    {
                        Console.Beep();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only whole numbers, thanks.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Lets try that again. Restarting from top~");
                        Console.CursorVisible = false;
                        System.Threading.Thread.Sleep(2200);
                        menuQuery = "";
                        hatAntal = 0;
                        tshirtAntal = 0;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.CursorVisible = true;
                        subMERCH();
                        return;
                    }
                } while (tshirtAntal >= 0 && tshirtAntal >= 10);

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                double tshirtTotal = (tshirtAntal * tshirtPris);
                double tshirttotalEUR = (tshirtTotal) / EurValue;

                if (tshirtAntal >= 1 && tshirtAntal <= 10)
                {
                    Console.Clear();
                    Console.Write($"{tshirtAntal} t-shirt(s) costs DKK");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($" {tshirtTotal}");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write(" or EUR ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{tshirttotalEUR.ToString("F")}.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;


                    if (tshirtAntal < 5)
                    {
                        Console.WriteLine();
                        Console.Write("Buy ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{ 5 - tshirtAntal} ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("item(s) more to receive 15 % discount on your purchase.");

                    }

                }

                else if (tshirtAntal >= 0)
                {
                    Console.Clear();
                    Console.WriteLine("No t-shirts registered.");
                }

                //---------------------------------------------------------------------------HAT---------------------------------------------------------------------------
                do
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("How many hats would you like to buy?");
                    Console.WriteLine("(To purchase more than 10, please contact staff.)");
                    Console.ForegroundColor = ConsoleColor.White;

                    try
                    {
                        hatAntal = int.Parse(Console.ReadLine()); //TryParse virker ikke.
                    }

                    catch (Exception)
                    {
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only whole numbers, thanks.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Lets try again! Restarting from the top.");
                        Console.CursorVisible = false;
                        System.Threading.Thread.Sleep(2200);
                        menuQuery = "";
                        hatAntal = 0;
                        tshirtAntal = 0;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.CursorVisible = true;
                        subMERCH();
                        return;
                    }
                } while (hatAntal >= 0 && hatAntal >= 10);

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                double hatTotal = (hatAntal * hatPris);
                double hatTotalEur = (hatTotal) / EurValue;

                if (hatAntal >= 1 && hatAntal <= 10)
                {
                    Console.Clear();
                    Console.Write($"{hatAntal} hat(s) costs DKK");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($" {hatTotal}");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write(" or EUR ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{hatTotalEur.ToString("F")}.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;


                    if ((hatAntal + tshirtAntal) < 5)
                    {
                        Console.WriteLine();
                        Console.Write("Buy ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{ 5 - (hatAntal + tshirtAntal)} ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("item(s) more to receive 15% discount on your purchase.");

                    }

                }

                else if (hatAntal >= 0)
                {
                    Console.Clear();
                    Console.WriteLine("No hats registered.");
                    Console.WriteLine();

                }

                Console.WriteLine();
                Console.WriteLine("You have selected {0} t-shirt(s) and {1} hat(s).", tshirtAntal, hatAntal);
                Console.WriteLine();
                Console.WriteLine("Press a random button to continue:");
                Udregner();

                double eurSum = ((tshirtAntal * tshirtPris) / 7.5 + (hatAntal * hatPris) / 7.5);
                double dkkSum = (tshirtTotal) + (hatTotal);
                Console.WriteLine("Your order is as follows:");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{tshirtAntal} t-shirt(s) of DKK {tshirtPris}, totalling {tshirtTotal} DKK or {tshirttotalEUR.ToString("F")} EUR.");
                Console.WriteLine();
                Console.WriteLine($"{hatAntal} hat(s) of DKK {hatPris}, totalling {hatTotal} DKK or {hatTotalEur.ToString("F")} EUR.");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine();

                double discountDKK = (dkkSum) * 0.85;
                double discountEUR = (eurSum) * 0.85;
                double SavedDKK = (dkkSum) * 0.15;
                double savedEUR = (eurSum) * 0.15;

                if ((hatAntal + tshirtAntal) <= 4) //VarerAntal virker ikke altid -- Her kunne man have indsat "Hvis bare du havde brugt lidt flere genstande, kunne du have sparet 15%"
                {
                    Console.WriteLine("Your total is:");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("DKK {0} or EUR {1}.", dkkSum, eurSum.ToString("F"));
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                }

                else if ((hatAntal + tshirtAntal) >= 5) //VarerAntal virker ikke altid
                {
                    Console.WriteLine("Your total is:");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("DKK {0} or EUR {1}.", dkkSum, eurSum.ToString("F"));
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine();
                    Console.WriteLine("Since you have chosen more than 4 items, you will receive a 15% discount on your purchase.");
                    Console.WriteLine();
                    Console.WriteLine("Your final total is:");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("DKK {0} or EUR {1}.", discountDKK, discountEUR.ToString("F"));
                    Console.WriteLine();
                    Console.WriteLine("Your savings are DKK {0} or EUR {1}.", SavedDKK, savedEUR.ToString("F"));
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                }

            }

            if (continueDialog == "N" || continueDialog == "n")
            {
                Console.Clear();
                Console.WriteLine("You will now return to the main menu.");
                Console.CursorVisible = false;
                System.Threading.Thread.Sleep(2200);
                menuQuery = "";
                hatAntal = 0;
                tshirtAntal = 0;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.CursorVisible = true;
                Menu();
            }

            ReturnMenu();
        }
        private static void subWIFI() //Pkt. 3 - Wi-Fi & datapriser
        {
            string WiFiQuery;

            Console.WriteLine("Thanks to the telecompany 3, Roskilde Festival 2017 has free Wi-Fi by the main area, and camps G & N");
            Console.WriteLine();
            Console.WriteLine("The Wi-Fi is accesible within 300 feet of the masts. \n" +
                "Connect your device to the network \"3-RF\", accept the conditions and you're on!");
            Console.WriteLine();
            Console.WriteLine("The network might get overloaded.\n" +
                "In this case you can purchase additional data on your phone for personal use: ");
            Console.WriteLine();
            Console.WriteLine("Send a text to 1247 with the text DATA followed by the desired amount of GB. Example: Data 50");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\"Data 15\" for 15GB [DKK 75]");
            Console.WriteLine("\"DATA 25\" for 25GB [DKK 100]");
            Console.WriteLine("\"Data 50\" for 50GB [DKK 175]");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
            Console.WriteLine("You accept 3s fair use- and personaldata politics by using their services.\n" +
                "To read their politics, text INFO to 1247.");
            Console.WriteLine();
            Console.WriteLine("Outside the free Wi-Fi zones, you can use your own data at your own expense.");

            Console.CursorVisible = false;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("____________________________________________________________");
            System.Threading.Thread.Sleep(1600);
            Console.WriteLine();
            Console.CursorVisible = true;
            do
            {
                Console.WriteLine("Do you wish to go to the map, to see the Wi-FI masts?");
                Console.WriteLine("Type [Y] to head to the map, type [N] to return to the main menu.");
                Console.ForegroundColor = ConsoleColor.White;
                WiFiQuery = Console.ReadLine();
                WiFiQuery = WiFiQuery.ToUpper();
                Console.ForegroundColor = ConsoleColor.DarkCyan;

            } while (WiFiQuery != "Y" && WiFiQuery != "N" && WiFiQuery != "y" && WiFiQuery != "n");


            if (WiFiQuery == "Y" || WiFiQuery == "y")
            {
                Console.Clear();
                WiFiQuery = "";
                subMAP();

            }

            else if (WiFiQuery == "N" || WiFiQuery == "n")
            {
                Console.Clear();
                Console.WriteLine("You will now return to the main menu.");
                Console.CursorVisible = false;
                System.Threading.Thread.Sleep(2200);
                WiFiQuery = "";
                menuQuery = "";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.CursorVisible = true;
                Menu();
            }
        }
        private static void subGUIDE() //Pkt. 4 - Guide
        {
            string guestbookQuery = "";
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Hello and welcome to the terminal. \n" +
                "Here you can find various information about the festival, \n" +
                "see merchandise prices, emergency options and much more.");
            Console.WriteLine();
            Console.WriteLine("After chosing your language, you will be presented with a categorized menu. " +
                "\nPress the number for the desired category and press ENTER. \n" +
                "If you seek play times and stage overview, please go to www.rf.dk or ask the service staff.");
            Console.WriteLine("The staff will always wear the yellow vests with our logo and \"Ask me!\" on their backs.");
            Console.WriteLine();
            Console.WriteLine("If you have a smartphone with you, please consider downloading our app. \n" +
                "it includes live updates and a GPS-localizator for emergencies. \n" +
                "Search \"Roskilde Festival\" on Google Play or App Store.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[NEW] ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Guestbook!");
            Console.ForegroundColor = ConsoleColor.Black; // :)
            Console.WriteLine("This program was written in C# in October 2017 by Rúni Vedel Niclasen, D21, TEC Ballerup");
            Console.WriteLine("Damn, did it take a long time!");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.CursorVisible = false;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("____________________________________________________________");
            System.Threading.Thread.Sleep(1600);
            Console.WriteLine();
            Console.CursorVisible = true;

            do
            {
                Console.WriteLine("Do you want to proceed to the guestbook?");
                Console.WriteLine("Type [Y] to continue, type [N] to return to the main menu.");
                Console.ForegroundColor = ConsoleColor.White;
                guestbookQuery = Console.ReadLine();
                guestbookQuery = guestbookQuery.ToUpper();
                Console.ForegroundColor = ConsoleColor.DarkCyan;

            } while (guestbookQuery != "Y" && guestbookQuery != "N" && guestbookQuery != "y" && guestbookQuery != "n");


            if (guestbookQuery == "Y" || guestbookQuery == "y")
            {
                menuQuery = "";
                guestbookQuery = "";
                subGUESTBOOK();

            }

            else if (guestbookQuery == "N" || guestbookQuery == "n")
            {
                Console.Clear();
                Console.WriteLine("You will now return to the main menu.");
                Console.CursorVisible = false;
                System.Threading.Thread.Sleep(2200);
                guestbookQuery = "";
                menuQuery = "";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.CursorVisible = true;
                Menu();
            }

        }
        private static void subGUESTBOOK()//Pkt 4.5 - Gæstebog
        {
            //ArrayList = Greetings
            string guestbookQuery = "";
            string guestbookSvar = "";

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Welcome to the guestbook!");
                Console.WriteLine("How do you want to continue?");
                Console.WriteLine();
                Console.WriteLine("Type [1] to write your own personal message.");
                Console.WriteLine();
                Console.WriteLine("Type [2] to see others greetings.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Type [X] to exit the guest book and return to the main menu.");
                Console.ForegroundColor = ConsoleColor.White;
                guestbookSvar = Console.ReadLine().ToLower(); //ToLower & ToUpper driller. Ændrer do-while og If betingelser til at indeholde både upper- og lowercase

            } while (guestbookSvar != "1" && guestbookSvar != "2" && guestbookSvar != "x" && guestbookSvar != "X");
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            if (guestbookSvar == "1") //Indtast hilsen
            {
                string country = ""; //Her har brugeren kun valgt engelsk, derfor efterspørger vi land.
                string message = "";
                string name = "";

                Console.Clear();

                Console.WriteLine("Please enter your country:");
                Console.ForegroundColor = ConsoleColor.White;
                country = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine();
                Console.WriteLine("Please enter your name:");
                Console.ForegroundColor = ConsoleColor.White;
                name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine();
                Console.WriteLine("Please enter your message: [Max 200 characters]");
                Console.ForegroundColor = ConsoleColor.White;
                message = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;



                int length = message.Length;

                if (length > 200)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(!) [{0}/200] characters", length);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Your message was too long. We copied it to the clipboard. Shorten it and give it another try.");
                    Clipboard.SetText(message);
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(3200);
                    Console.WriteLine("Press a random button to return to the main menu.");
                    Console.ReadKey();
                    guestbookQuery = "";
                    guestbookSvar = "";
                    message = "";
                    name = "";
                    country = "";
                    menuQuery = "";
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    subGUESTBOOK();
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[{length}/200] characters.");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Program.Greetings.Add(DateTime.Now + " ## " + country + " ## " + "\"" + name + "\"" + " WRITES: " + message);

                Console.WriteLine();
                Console.WriteLine("Your message has succesfully been saved to the guestbook.");
                Console.WriteLine();
                message = "";
                System.Threading.Thread.Sleep(1000);
                do
                {
                    Console.WriteLine("Head directly to the guestbook to see recent greetings?");
                    Console.WriteLine("Type [Y] to continue, type [N] for the main menu.");
                    Console.ForegroundColor = ConsoleColor.White;
                    guestbookQuery = Console.ReadLine();
                    guestbookQuery = guestbookQuery.ToUpper();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                } while (guestbookQuery != "Y" && guestbookQuery != "N" && guestbookQuery != "y" && guestbookQuery != "n");


                if (guestbookQuery == "Y" || guestbookQuery == "y")
                {
                    menuQuery = "";
                    guestbookQuery = "";
                    guestbookSvar = "2";

                }

                else if (guestbookQuery == "N" || guestbookQuery == "n")
                {
                    Console.Clear();
                    Console.WriteLine("You will now return to the main menu.");
                    Console.CursorVisible = false;
                    System.Threading.Thread.Sleep(2200);
                    guestbookQuery = "";
                    guestbookSvar = "";
                    message = "";
                    name = "";
                    country = "";
                    menuQuery = "";
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.CursorVisible = true;
                    subGUESTBOOK();
                }

            }

            if (guestbookSvar == "2") //Se alle hilsener
            {
                Console.Clear();
                Console.WriteLine("All current {0} greetings:", (Program.Greetings.Count + 1));
                Console.WriteLine("-------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("08-10-2017 21:43:33 ## DENMARK ## \"DEVELOPER\" WRITES: THANKS FOR TRYING OUT OUR NEW GUESTBOOK!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("-------------------------------------------------------------");
                foreach (var item in Program.Greetings)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("-------------------------------------------------------------");
                }

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.CursorVisible = false;
                System.Threading.Thread.Sleep(1000);
                System.Threading.Thread.Sleep(1200);
                Console.WriteLine();
                Console.WriteLine("Press a random button to return to the main menu.");
                Console.CursorVisible = true;
                Console.ReadKey();
                Console.Clear();
                menuQuery = "";
                guestbookSvar = "";
                subGUESTBOOK();

            }

            if (guestbookSvar == "X" || guestbookSvar == "x") //Exit
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Clear();
                Console.WriteLine("You will now return to the main menu.");
                Console.CursorVisible = false;
                System.Threading.Thread.Sleep(2200);
                menuQuery = "";
                guestbookSvar = "";
                Console.Clear();
                Console.CursorVisible = true;
                Menu();

            }

        }
        private static void subMAP() //Pkt. 5 - Kort over festivallen
        {
            Console.SetWindowSize(125, 30);
            char leftCorner = '\u2554'; //Indsætter Unicode karakterer
            char rightCorner = '\u2557';
            char lowerLCorner = '\u255A';
            char lowerRCorner = '\u255D';
            char horizontal = '-'; //\u2550 ═ har en Drawbug ifbm. visse skærmresolutioner, så vi må tage til takke med dette symbol. 
            char vertical = '\u2551';

            Console.ForegroundColor = ConsoleColor.White; //Main Frame
            for (int x = 6; x <= 109; x++)
            {
                Console.SetCursorPosition(x, 2);
                Console.Write(horizontal);
            }//top, horizontal
            Console.SetCursorPosition(5, 2);
            Console.Write(leftCorner);

            for (int x1 = 6; x1 <= 109; x1++)
            {
                Console.SetCursorPosition(x1, 25);
                Console.Write(horizontal);
            }//bund, horizontal
            Console.SetCursorPosition(110, 25);
            Console.Write(lowerRCorner);

            for (int y = 3; y < 25; y++)
            {
                Console.SetCursorPosition(5, y);
                Console.Write(vertical);
            }//vertikal, venstre
            Console.SetCursorPosition(5, 25);
            Console.Write(lowerLCorner);

            for (int y1 = 3; y1 < 25; y1++)
            {
                Console.SetCursorPosition(110, y1);
                Console.Write(vertical);
            }//vertikal, højre
            Console.SetCursorPosition(110, 2);
            Console.Write(rightCorner);

            Console.ForegroundColor = ConsoleColor.Red; //"You" Frame

            for (int x9 = 50; x9 <= 57; x9++)
            {
                Console.SetCursorPosition(x9, 7);
                Console.Write(horizontal);
            } //You-Frame Top
            Console.SetCursorPosition(50, 7);
            Console.Write(leftCorner);

            for (int x10 = 51; x10 <= 57; x10++)
            {
                Console.SetCursorPosition(x10, 9);
                Console.Write(horizontal);
            }  //You-Frame Bottom
            Console.SetCursorPosition(58, 9);
            Console.Write(lowerRCorner);

            for (int y9 = 8; y9 < 9; y9++)
            {
                Console.SetCursorPosition(50, y9);
                Console.Write(vertical);
            }//You-frame Left
            Console.SetCursorPosition(50, 9);
            Console.Write(lowerLCorner);

            for (int y10 = 8; y10 < 9; y10++)
            {
                Console.SetCursorPosition(58, y10);
                Console.Write(vertical);
            }//You-Frame Right
            Console.SetCursorPosition(58, 7);
            Console.Write(rightCorner);

            Console.ForegroundColor = ConsoleColor.Green; //Header
            Console.SetCursorPosition(47, 0);
            Console.Write("Roskilde Festival");
            Console.SetCursorPosition(47, 1);
            Console.Write("June 24th - July 1st");

            Console.ForegroundColor = ConsoleColor.Yellow; //Camp locations
            Console.SetCursorPosition(10, 5);
            Console.Write("[C]");

            Console.SetCursorPosition(12, 15);
            Console.Write("[E]");

            Console.SetCursorPosition(30, 14);
            Console.Write("[G]");

            Console.SetCursorPosition(35, 20);
            Console.Write("[J]");

            Console.SetCursorPosition(40, 17);
            Console.Write("[K]");

            Console.SetCursorPosition(77, 20);
            Console.Write("[P]");

            Console.SetCursorPosition(82, 14);
            Console.Write("[N]");

            Console.SetCursorPosition(76, 10);
            Console.Write("[M]");

            Console.SetCursorPosition(62, 13);
            Console.Write("[L]");

            Console.SetCursorPosition(52, 15);
            Console.Write("[F]");

            Console.ForegroundColor = ConsoleColor.Magenta; //Wi-Fi tårne
            Console.SetCursorPosition(45, 8);
            Console.Write("|*|");

            Console.SetCursorPosition(62, 8);
            Console.Write("|*|");

            Console.SetCursorPosition(54, 12);
            Console.Write("|*|");

            Console.SetCursorPosition(34, 14);
            Console.Write("|*|");

            Console.SetCursorPosition(82, 15);
            Console.Write("|*|");

            Console.ForegroundColor = ConsoleColor.Cyan; //Stage locations
            Console.SetCursorPosition(50, 5);
            Console.Write("MAIN STAGE");
            Console.SetCursorPosition(35, 7);
            Console.Write("AVALON");
            Console.SetCursorPosition(70, 7);
            Console.Write("ARENA");
            Console.SetCursorPosition(51, 8);

            Console.ForegroundColor = ConsoleColor.Red; // Your/Terminal location
            Console.Write("**YOU**");
            Console.ResetColor();

            Console.SetCursorPosition(6, 26); //Map legend
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("SCENES");

            Console.SetCursorPosition(35, 26);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("CAMPS");

            Console.SetCursorPosition(60, 26);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Wi-Fi/SERVICE/ATMs");

            Console.SetCursorPosition(96, 26);
            Console.ForegroundColor = ConsoleColor.Red; ;
            Console.Write("*YOUR LOCATION*");
            Console.SetCursorPosition(0, 27);
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.CursorVisible = false;
            System.Threading.Thread.Sleep(2200);
            Console.WriteLine();
            Console.WriteLine("Press a random button to return to the main menu. ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.CursorVisible = true;
            Console.ReadKey();
            Console.Clear();
            menuQuery = "";
            Menu();
        }

        private static void ReturnMenu() //Retur til hovedmenuen
        {
            Console.CursorVisible = false;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("____________________________________________________________");
            System.Threading.Thread.Sleep(1200);
            Console.WriteLine();
            Console.WriteLine("Press a random button to return to the main menu. ");
            Console.ResetColor();
            Console.CursorVisible = true;
            Console.ReadKey();
            menuQuery = "";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Menu();
        }
        private static void Udregner() //For sjov - Bruges i Pkt. 2 SubMERCH()
        {
            Console.ReadKey();
            Console.Clear();
            Console.CursorVisible = false;
            Console.Write("Calculating total");
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.Write("Calculating total");
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.CursorVisible = true;
        }
    }
}

