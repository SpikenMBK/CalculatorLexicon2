using System;

namespace CalculatorLexicon2
{
    class Program
    {
        public static double Resultat { get; private set; }

        static void Main(string[] args)
        {
            bool kör = true;

            while (kör)
            {
                double tal1 = 0;
                double tal2 = 0;
                double menu;
                Console.WriteLine("MENU");
                Console.WriteLine("----------------------");
                Console.WriteLine("Add tryck 1");
                Console.WriteLine("Sub tryck 2");
                Console.WriteLine("Mult tryck 3");
                Console.WriteLine("Div tryck 4");
                Console.WriteLine("Avsluta tryck 5");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Gör ditt val i menyn");

                menu = GetNumberFromUser();
                if(menu != 5)
                {
                    Console.Write("\r\nSlå in ditt första tal: ");
                    tal1 = GetNumberFromUser();
                    Console.Write("\r\nSlå in ditt andra tal: ");
                    tal2 = GetNumberFromUser();              
                }

                switch (menu)
                {
                    case 1:
                        Add(tal1, tal2);
                        break;

                    case 2:
                        Sub(tal1, tal2);
                        break;

                    case 3:
                        Mult(tal1, tal2); 
                        break;

                    case 4:
                        Div(tal1, tal2); 
                        break;

                    case 5:                       
                        kör = false;
                        break;

                    default:
                      
                        break;                      
                }

                if(kör == true)
                {
                    Console.WriteLine("resultat är " + Resultat);

                }              

            }
            
        }

      
        private static double GetNumberFromUser()
        {
            double userInput = 0;
            bool succeeded = false;

            while (!succeeded)
            {

                succeeded = double.TryParse(Console.ReadLine(), out userInput);
                while (!succeeded)
                {
                    Console.WriteLine("Du har gjort ett otillåtet val i menyn. Försök igen!");
                    break;
                }
            }
            return userInput;
           }

        private static double Add(double tal1, double tal2)
        {
            Resultat = tal1 + tal2;
          
            return Resultat;
        }
        private static double Sub(double tal1, double tal2)
        {
            
                Resultat = tal1 - tal2;               
           
            return Resultat;
        }
        private static double Mult(double tal1, double tal2)
        {
            Resultat = tal1 * tal2;

            return Resultat;
        }
        private static double Div(double tal1, double tal2)
        {               
                while (tal2 == 0)
                {
                Console.WriteLine("Du försöker att dela med 0, det är inte tillåtet, försök med ett nytt tal!");
                tal2 = double.Parse(Console.ReadLine());
                break;
                }
            Resultat = tal1 / tal2;         
            return Resultat;
        }

    }
}
