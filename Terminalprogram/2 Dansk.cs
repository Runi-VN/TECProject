using System;
using System.Collections; //arraylist
using System.Collections.Generic;
using System.Windows.Forms; //copy-to-clipboard (gæstebog)
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminalprogram
{
    class Dansk
    {
        //DanskOutput = Console.ForegroundColor = ConsoleColor.DarkGreen;
        //BrugerInput = Console.ForegroundColor = ConsoleColor.White;
        //DKKPriser = Console.ForegroundColor = ConsoleColor.Green;
        //Attention = Console.ForegroundColor = ConsoleColor.Blue;
        static string menuQuery = "";
        [STAThread] //for clipboard windows.Forms;
        public static void Menu()
        {
            do
            {
                Console.SetWindowSize(95, 25);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.WriteLine("Hvordan vil du fortsætte?");
                Console.WriteLine();
                Console.WriteLine("Tast [1] for information for gæster og frivillige, herunder nødnumre og kontaktinformation.");
                Console.WriteLine();
                Console.WriteLine("Tast [2] for merchandisepriser.");
                Console.WriteLine();
                Console.WriteLine("Tast [3] for Wi-Fi information.");
                Console.WriteLine();
                Console.Write("Tast [4] for en guide til denne terminal og ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("[NYT] ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("gæstebog!");
                Console.WriteLine();
                Console.WriteLine("Tast [5] for det officielle RF17 kort.");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tast [X] for at afslutte programmet.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.CursorVisible = true;
                menuQuery = Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
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
            Console.WriteLine("Goddag og velkommen til Roskilde Festival 2017! \n\n" +
                "Festivallen varer over 7 dage, fra lørdag d. 24 juni til lørdag d. 1 juli,\n" +
                "hvor der bliver spillet musik af over 180 kunstnere.");
            Console.WriteLine();
            Console.WriteLine("Ugens spilleprogram finder du på www.rf.dk eller hos personalet.\n" +
                "De kan findes på pladsen med gule veste, hvorpå der står \"Spørg mig\" eller ved infotårnene, hvor der også er samarithjælp."); //Her skulle man jo så have haft en -NEM- måde at vise spilleplanerne på
            Console.WriteLine();
            Console.WriteLine("Du må kun slå telt op på de afmærkede områder, og kun hvis du har købt en adgangsgivende billet. ");
            Console.WriteLine();
            Console.WriteLine("Du har i forbindelse med din entré på Roskilde Festival fået udleveret et armbånd. \n" +
                "Dette armbånd skal bæres under hele festivallen og skal fremvises hvis spurgt af ansatte eller myndigheder.");
            Console.WriteLine();
            Console.WriteLine("Med dagsbilletter på Roskilde Festival får du for halv pris adgang til 24 timer på Roskilde Festival. \n" +
                "Det udleverede armbånd skal bæres alle 24 timer. Armbåndet og billetten giver ikke adgang til teltplads.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("KONTAKT:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("Roskilde Festivals hovedkontor - Ring 46 36 66 13 eller e-mail info@roskilde-festival.dk");
            Console.WriteLine("Livstruende situationer (Politi, brand- og sygevæsen) - Ring 112");
            Console.WriteLine("Rapportering af mistænksomme situationer, salg af stoffer, tyveri og andet - Ring 114");
            Console.WriteLine();
            Console.WriteLine("Du kan med forddel bruge App'en \"112\" for at videregive din GPS lokation til politiet i nødstilfælde.");
            Console.WriteLine("____________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("OBS: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Frivillige bedes henvende sig til deres ansvarlige mindst 6 timer før første vagt, for briefing og medarbejder-armbånd.");
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
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Igen i år kan du støtte Roskilde Festival ved at købe merchandise i form af t-shirts og hatte. \n" +
                "Disse kan købes ved servicetårnene, hvor der også er fri Wi-Fi og samarithjælp.");
                Console.WriteLine();
                Console.WriteLine("Her kan du få beregnet din pris for et eventuelt køb.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ønsker du at fortsætte?");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Tast [Y] for ja eller [N] for nej; Du vil blive sendt tilbage til hovedmenuen.");
                Console.ForegroundColor = ConsoleColor.White;
                continueDialog = Console.ReadLine();
                continueDialog = continueDialog.ToUpper();
            } while (continueDialog != "Y" && continueDialog != "N" && continueDialog != "y" && continueDialog != "n"); //.ToUpper(); driller, denne metode virker også.

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (continueDialog == "Y" || continueDialog == "y")
            {

                Console.Clear();
                Console.WriteLine("Priserne er som følger:");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Hatte str. Onesize: DKK {hatPris} eller EUR {hatEur.ToString("F")}."); //Kun 2 decimaler, runder op/ned
                Console.WriteLine($"T-shirts str. S/M/L: DKK {tshirtPris} eller EUR {tshirtEur.ToString("F")}."); //Kun 2 decimaler, runder op/ned
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Bemærk! Der kan opnås 15% rabat ved køb af mere end 4 varer.");
                Console.WriteLine();

                //---------------------------------------------------------------------------TSHIRT---------------------------------------------------------------------------
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Hvor mange t-shirts kunne du tænke dig at købe?");
                    Console.WriteLine("(For køb af mere end 10, kontakt venligst personalet)");
                    Console.ForegroundColor = ConsoleColor.White;

                    try
                    {
                        tshirtAntal = int.Parse(Console.ReadLine()); //TryParse virker ikke.
                    }

                    catch (Exception OnlyInt)
                    {
                        Console.WriteLine(OnlyInt.Message);
                        Console.Beep();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Indtast kun hele tal, tak.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Prøv igen. Genstarter fra toppen.");
                        Console.CursorVisible = false;
                        System.Threading.Thread.Sleep(2200);
                        menuQuery = "";
                        hatAntal = 0;
                        tshirtAntal = 0;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.CursorVisible = true;
                        subMERCH();
                        return;
                    }
                } while (tshirtAntal >= 0 && tshirtAntal >= 10);

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                double tshirtTotal = (tshirtAntal * tshirtPris);
                double tshirttotalEUR = (tshirtTotal) / EurValue;

                if (tshirtAntal >= 1 && tshirtAntal <= 10)
                {
                    Console.Clear();
                    Console.Write($"{tshirtAntal} t-shirt(s) koster DKK");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($" {tshirtTotal}");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" eller EUR ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{tshirttotalEUR.ToString("F")}.");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;


                    if (tshirtAntal < 5)
                    {
                        Console.WriteLine();
                        Console.Write("Køb ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{ 5 - tshirtAntal} ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("genstand(e) mere for at opnå 15 % rabat på hele dit køb.");

                    }

                }

                else if (tshirtAntal >= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Ingen t-shirts registreret.");
                }

                //---------------------------------------------------------------------------HAT---------------------------------------------------------------------------
                do
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Hvor mange hatte kunne du tænke dig at købe?");
                    Console.WriteLine("(For køb af mere end 10, kontakt venligst personalet)");
                    Console.ForegroundColor = ConsoleColor.White;

                    try
                    {
                        hatAntal = int.Parse(Console.ReadLine()); //TryParse virker ikke.
                    }

                    catch (Exception)
                    {
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Indtast kun hele tal, tak.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Prøv igen. Genstarter fra toppen.");
                        Console.CursorVisible = false;
                        System.Threading.Thread.Sleep(2200);
                        menuQuery = "";
                        hatAntal = 0;
                        tshirtAntal = 0;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.CursorVisible = true;
                        subMERCH();
                        return;
                    }
                } while (hatAntal >= 0 && hatAntal >= 10);

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                double hatTotal = (hatAntal * hatPris);
                double hatTotalEur = (hatTotal) / EurValue;

                if (hatAntal >= 1 && hatAntal <= 10)
                {
                    Console.Clear();
                    Console.Write($"{hatAntal} hat(te) koster DKK");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($" {hatTotal}");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" eller EUR ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{hatTotalEur.ToString("F")}.");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;


                    if ((hatAntal + tshirtAntal) < 5)
                    {
                        Console.WriteLine();
                        Console.Write("Køb ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{ 5 - (hatAntal + tshirtAntal)} ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("genstand(e) mere for at opnå 15 % rabat på hele dit køb.");

                    }

                }

                else if (hatAntal >= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Ingen hatte registreret.");
                    Console.WriteLine();

                }

                Console.WriteLine();
                Console.WriteLine("Du har valgt {0} t-shirt(s) og {1} hat(te).", tshirtAntal, hatAntal);
                Console.WriteLine();
                Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte:");
                Udregner();

                double eurSum = ((tshirtAntal * tshirtPris) / 7.5 + (hatAntal * hatPris) / 7.5);
                double dkkSum = (tshirtTotal) + (hatTotal);
                Console.WriteLine("Din total er som følger:");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{tshirtAntal} t-shirt(s) á DKK {tshirtPris}, i alt {tshirtTotal} DKK eller {tshirttotalEUR.ToString("F")} EUR.");
                Console.WriteLine();
                Console.WriteLine($"{hatAntal} hat(te) á DKK {hatPris}, i alt {hatTotal} DKK eller {hatTotalEur.ToString("F")} EUR.");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();

                double discountDKK = (dkkSum) * 0.85;
                double discountEUR = (eurSum) * 0.85;
                double SavedDKK = (dkkSum) * 0.15;
                double savedEUR = (eurSum) * 0.15;

                if ((hatAntal + tshirtAntal) <= 4) //VarerAntal virker ikke altid -- Her kunne man have indsat "Hvis bare du havde brugt lidt flere genstande, kunne du have sparet 15%"
                {
                    Console.WriteLine("Alt i alt:");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DKK {0} eller EUR {1}.", dkkSum, eurSum.ToString("F"));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                }

                else if ((hatAntal + tshirtAntal) >= 5) //VarerAntal virker ikke altid
                {
                    Console.WriteLine("I alt:");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DKK {0} eller EUR {1}.", dkkSum, eurSum.ToString("F"));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine();
                    Console.WriteLine("Eftersom du har valgt mere end 4 varer, vil du opnå 15% rabat på hele dit køb.");
                    Console.WriteLine();
                    Console.WriteLine("Alt i alt:");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DKK {0} eller EUR {1}.", discountDKK, discountEUR.ToString("F"));
                    Console.WriteLine();
                    Console.WriteLine("Det vil sige at du har sparet DKK {0} eller EUR {1}.", SavedDKK, savedEUR.ToString("F"));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                }

            }

            if (continueDialog == "N" || continueDialog == "n")
            {
                Console.Clear();
                Console.WriteLine("Du vil nu blive sendt tilbage til hovedmenuen.");
                Console.CursorVisible = false;
                System.Threading.Thread.Sleep(2200);
                menuQuery = "";
                hatAntal = 0;
                tshirtAntal = 0;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.CursorVisible = true;
                Menu();
            }

            ReturnMenu();
        }
        private static void subWIFI() //Pkt. 3 - Wi-Fi & datapriser
        {
            string WiFiQuery;

            Console.WriteLine("Med tak til teleselskabet 3 har vi fået opsat master på festivalpladsen samt område G og N.");
            Console.WriteLine();
            Console.WriteLine("Du kan gratis bruge Wi-Fi indenfor 100 meter af masterne. \n" +
                "Tilslut dit device til netværket \"3-RF\" og acceptere betingelserne, så er du på!");
            Console.WriteLine();
            Console.WriteLine("Det kan hænde at masterne bliver overbelastede. \n" +
                "I dette tilfælde kan du tilkøbe data til din personlige telefon på følgende måde: ");
            Console.WriteLine();
            Console.WriteLine("Send en SMS til 1247 med teksten DATA efterfulgt af det ønskede antal GB. Eksempel: Data 50");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\"Data 15\" for 15GB [DKK 75]");
            Console.WriteLine("\"DATA 25\" for 25GB [DKK 100]");
            Console.WriteLine("\"Data 50\" for 50GB [DKK 175]");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("Du accepterer 3s brugs- og persondatapolitik ved køb af ekstra data.\nFor at læse disse politikker, send INFO til 1247.");
            Console.WriteLine();
            Console.WriteLine("Udenfor masternes rækkevidde kan du bruge egen data på egen beregning.");

            Console.CursorVisible = false;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("____________________________________________________________");
            System.Threading.Thread.Sleep(1600);
            Console.WriteLine();
            Console.CursorVisible = true;
            do
            {
                Console.WriteLine("Ønsker du at gå direkte til kortet for at se Wi-Fi tårnene?");
                Console.WriteLine("Tast [Y] for at gå til kort, tast [N] for hovedmenu.");
                Console.ForegroundColor = ConsoleColor.White;
                WiFiQuery = Console.ReadLine();
                WiFiQuery = WiFiQuery.ToUpper();
                Console.ForegroundColor = ConsoleColor.DarkGreen;

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
                Console.WriteLine("Du vil nu blive sendt tilbage til hovedmenuen.");
                Console.CursorVisible = false;
                System.Threading.Thread.Sleep(2200);
                WiFiQuery = "";
                menuQuery = "";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.CursorVisible = true;
                Menu();
            }
        }
        private static void subGUIDE() //Pkt. 4 - Guide
        {
            string guestbookQuery = "";
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Goddag og velkommen til. \n\n" +
                "I denne terminal kan du få information omkring dine muligheder på festivallen, \nse merchandisepriser, information om hvad du skal gøre i nødstilfælde og meget mere.");
            Console.WriteLine();
            Console.WriteLine("Efter at du har valgt sprog, vil du blive præsenteret med en kategoriseret menu. \n" +
                "Tast tallet for den ønskede kategori og tryk ENTER. ");
            Console.WriteLine("Spilletider og sceneoversigt kan ses på www.rf.dk eller hos personalet. \n" +
                "De kan findes på pladsen med gule veste, hvorpå der står \"Spørg mig\" eller ved infotårnene. ");
            Console.WriteLine();
            Console.WriteLine("Hvis du har en smartphone med på festivallen, kan du passende downloade vores app. \n" +
                "Søg efter \"Roskilde Festival\" på Google Play eller App Store.");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[NYT] ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Gæstebog!");
            Console.ForegroundColor = ConsoleColor.Black; // :)
            Console.WriteLine("Dette program er skrevet i C# i oktober 2017 af Rúni Vedel Niclasen, D21, TEC Ballerup");
            Console.WriteLine("Kæft hvor har det taget lang tid.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.CursorVisible = false;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("____________________________________________________________");
            System.Threading.Thread.Sleep(1600);
            Console.WriteLine();
            Console.CursorVisible = true;

            do
            {
                Console.WriteLine("Ønsker du at gå til gæstebogen?");
                Console.WriteLine("Tast [Y] for ja, tast [N] for hovedmenu.");
                Console.ForegroundColor = ConsoleColor.White;
                guestbookQuery = Console.ReadLine();
                guestbookQuery = guestbookQuery.ToUpper();
                Console.ForegroundColor = ConsoleColor.DarkGreen;

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
                Console.WriteLine("Du vil nu blive sendt tilbage til hovedmenuen.");
                Console.CursorVisible = false;
                System.Threading.Thread.Sleep(2200);
                guestbookQuery = "";
                menuQuery = "";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
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
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Velkommen til gæstebogen.");
                Console.WriteLine("Hvordan vil du fortsætte?");
                Console.WriteLine();
                Console.WriteLine("Tast [1] for at indtaste en hilsen.");
                Console.WriteLine();
                Console.WriteLine("Tast [2] for at se andres beskeder.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Tast [X] for at gå forlade gæstebogen og gå tilbage til hovedmenuen.");
                Console.ForegroundColor = ConsoleColor.White;
                guestbookSvar = Console.ReadLine().ToLower(); //ToLower & ToUpper driller. Ændrer do-while og If betingelser til at indeholde både upper- og lowercase

            } while (guestbookSvar != "1" && guestbookSvar != "2" && guestbookSvar != "x" && guestbookSvar != "X");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (guestbookSvar == "1") //Indtast hilsen
            {
                string country = "DENMARK "; //Brugeren har valgt dansk sprog i starten, derfor vælger vi deres land for dem!
                string message = "";
                string name = "";

                Console.Clear();

                //Console.WriteLine("Indtast dit land:");
                //Console.ForegroundColor = ConsoleColor.White;
                //country = Console.ReadLine();
                //Console.ForegroundColor = ConsoleColor.DarkGreen;
                //Console.WriteLine();
                Console.WriteLine("Indtast dit navn:");
                Console.ForegroundColor = ConsoleColor.White;
                name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Indtast din hilsen herunder: [Max 200 karakterer]");
                Console.ForegroundColor = ConsoleColor.White;
                message = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;



                int length = message.Length;

                if (length > 200)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(!) [{0}/200] karakterer", length);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Din besked var for lang. Vi har kopieret den til din udklipsholder. Forkort den og prøv igen.");
                    Clipboard.SetText(message);
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(3200);
                    Console.WriteLine("Tryk på en vilkårlig tast for at gå tilbage til hovedmenuen.");
                    Console.ReadKey();
                    guestbookQuery = "";
                    guestbookSvar = "";
                    message = "";
                    name = "";
                    country = "";
                    menuQuery = "";
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    subGUESTBOOK();
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[{length}/200] karakterer.");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Program.Greetings.Add(DateTime.Now + " ## " + country + "## " + "\"" + name + "\"" + " SKRIVER: " + message);

                Console.WriteLine();
                Console.WriteLine("Din hilsen er noteret og den er tilføjet til gæstebogen.");
                Console.WriteLine();
                message = "";
                System.Threading.Thread.Sleep(1000);
                do
                {
                    Console.WriteLine("Ønsker du at gå direkte til gæstebogen og se de seneste hilsener?");
                    Console.WriteLine("Tast [Y] for ja, tast [N] for gæstebogens hovedmenu.");
                    Console.ForegroundColor = ConsoleColor.White;
                    guestbookQuery = Console.ReadLine();
                    guestbookQuery = guestbookQuery.ToUpper();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

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
                    Console.WriteLine("Du vil nu blive sendt tilbage til gæstebogens hovedmenu.");
                    Console.CursorVisible = false;
                    System.Threading.Thread.Sleep(2200);
                    guestbookQuery = "";
                    guestbookSvar = "";
                    message = "";
                    name = "";
                    country = "";
                    menuQuery = "";
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.CursorVisible = true;
                    subGUESTBOOK();
                }

            }

            if (guestbookSvar == "2") //Se alle hilsener
            {
                Console.Clear();
                Console.WriteLine("Her er alle nuværende {0} hilsener:", (Program.Greetings.Count + 1));
                Console.WriteLine("-------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("08-10-2017 21:43:33 ## DENMARK ## \"DEVELOPER\" SKRIVER: TAK FORDI I PRØVER VORES NYE GÆSTEBOG!");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("-------------------------------------------------------------");
                foreach (var item in Program.Greetings)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("-------------------------------------------------------------");
                }

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.CursorVisible = false;
                System.Threading.Thread.Sleep(1000);
                System.Threading.Thread.Sleep(1200);
                Console.WriteLine();
                Console.WriteLine("Tryk på en vilkårlig tast for at gå tilbage til gæstebogens hovedmenu.");
                Console.CursorVisible = true;
                Console.ReadKey();
                Console.Clear();
                menuQuery = "";
                guestbookSvar = "";
                subGUESTBOOK();

            }

            if (guestbookSvar == "X" || guestbookSvar == "x") //Exit
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.WriteLine("Du vil nu blive sendt tilbage til hovedmenuen.");
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
            Console.Write("**DIG**");
            Console.ResetColor();

            Console.SetCursorPosition(6, 26); //Map legend
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("SCENER");

            Console.SetCursorPosition(35, 26);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("LEJRE");

            Console.SetCursorPosition(55, 26);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Wi-Fi/SERVICE/HÆVEAUTOMAT");

            Console.SetCursorPosition(96, 26);
            Console.ForegroundColor = ConsoleColor.Red; ;
            Console.Write("*HER ER DU*");
            Console.SetCursorPosition(0, 27);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.CursorVisible = false;
            System.Threading.Thread.Sleep(2200);
            Console.WriteLine();
            Console.WriteLine("Tryk på en vilkårlig tast for at gå tilbage til hovedmenuen. ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
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
            Console.WriteLine("Tryk på en vilkårlig tast for at gå tilbage til hovedmenuen. ");
            Console.ResetColor();
            Console.CursorVisible = true;
            Console.ReadKey();
            menuQuery = "";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Menu();
        }
        private static void Udregner() //For sjov - Bruges i Pkt. 2 subMERCH()
        {
            Console.ReadKey();
            Console.Clear();
            Console.CursorVisible = false;
            Console.Write("Udregner total");
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.Write("Udregner total");
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
