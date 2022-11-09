using System.Text;

namespace LO3_TSO_2022_2023_COLLECTIES1
{
    internal class Program
    {
        /* O P D R A C H T
         * ===============
         * 
         * Een onderneming heeft een lijst met de fietsen die het op stock heeft. 
         * Van deze fietsen wordt het merk, de categorie, het type en de prijs bijgehouden.
         * In het programma is er een klasse Fiets toegevoegd. In een object van deze klasse
         * worden alle kenmerken van één fiets bijgehouden.
         * 
         * Het stockbeheer wordt gedaan met behulp van een consoletoepassing. De stock van fietsen wordt 
         * bijgehouden in een lijst. De lijst bevat dus objecten van het type fiets.
         * Je moet in de toepassing deze lijst declareren.
         * 
         * De toepassing die je moet schrijven biedt mogelijkheden om de lijst te manipuleren. 
         * Het keuzemenu is al in de code voorzien. Dat moet je zelf dus niet meer schrijven. 
         * 
         * Via het keuzemenu kan je de volgende vijf functies uitvoeren: 
         * 1. Fietsen toevoegen aan een lijst
         * 2. Fietsen op basis van index te verwijderen uit de lijst
         * 3. Fietsen op basis van het merk verwijderen uit de lijst
         * 4. De lijst op het scherm afdrukken.
         * 5. De toepassing afsluiten.
         * 
         * Het is jouw opdracht om de gevraagde functies te coderen. Je zorgt ervoor dat de 
         * gebruikerservaring zo optimaal mogelijk is.  
         * 
         * Voorbeelden van fietsen:
         * 
         *   MERK	        CATEGORIE	    TYPE	            PRIJS (€)
         *   
         *   Cube	          MTB	        Reaction C62:Pro	  1899
         *   Trek	          MTB	        Xcaliber 9	          1649
         *   Scott	          MTB	        Spark 950	          3699
         *   Cube	          E-MTB	        Reaction Pro SL	      3499
         *   Specialized	  E-MTB	        Turbo Tero 4	      4800
         *   Scott	          E-MTB	        Aspect eRide 940	  2799
         *   
         */


        static void Main(string[] args)
        {
            //om € teken in console te kunnen weergeven
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            const int AANTALKEUZES = 5;

            int keuze = KeuzeMenu(AANTALKEUZES);


            /* 
             * Programmeer hier het vervolg van de main-code.
             * Let op : je werkt met functies! Een functie doet slechts één ding.
             */

        }

        /*
         * Programmeer onder dit commentaarblok jouw eigen functies
         */




        /*
         * Einde van jouw code...
         */

        static void PrintKeuzeMenu()
        {
            Console.WriteLine("Stockbeheer fietsen");
            Console.WriteLine("===================\n");
            Console.WriteLine("1. Fietsen toevoegen aan lijst");
            Console.WriteLine("2. Fietsen verwijderen op index");
            Console.WriteLine("3. Fietsen verwijderen op merknaam");
            Console.WriteLine("4. Print lijst op scherm");
            Console.WriteLine("5. Toepassing afsluiten\n");
            Console.Write("Uw keuze : ");
        }

        static int LeesKeuzeIn()
        {
            string? invoer;

            invoer = Console.ReadLine();
            int.TryParse(invoer, out int keuze);

            return keuze;
        }

        static bool IsKeuzeBuitenGrensWaarden(int keuze, int ondergrens, int bovengrens)
        {
            bool buitenGrensWaarden = (keuze < ondergrens || keuze > bovengrens) ? true : false;
            return buitenGrensWaarden;
        }

        static void PrintBoodschap(bool select, string messageIfSelectIsTrue, string messageIfSelectIsFalse)
        {
            string msg = (select == true) ? messageIfSelectIsTrue : messageIfSelectIsFalse;
            Console.WriteLine(msg);
        }

        static int KeuzeMenu(int aantalKeuzes)
        {
            int keuze;
            bool ongeldigeKeuze;

            do
            {
                PrintKeuzeMenu();
                keuze = LeesKeuzeIn();
                ongeldigeKeuze = IsKeuzeBuitenGrensWaarden(keuze, 1, aantalKeuzes);
                PrintBoodschap(ongeldigeKeuze, "Ongeldige keuze! Probeer opnieuw...\n", "Uw keuze wordt uitgevoerd...\n");

            } while (ongeldigeKeuze);

            return keuze;
        }
    }
}