using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CalculatorLexicon2
{
    public class Program
    {
        public static double Resultat { get; private set; }      
        public static double[] ArryListIn { get; private set; }

        static void Main(string[] args)
        {

            bool kör = true;

            while (kör)
            {
               
                double tal1 = 0;
                double tal2 = 0;
               


                Console.WriteLine("MENU");
                Console.WriteLine("----------------------");
                Console.WriteLine("Add tryck 1");
                Console.WriteLine("Sub tryck 2");
                Console.WriteLine("Mult tryck 3");
                Console.WriteLine("Div tryck 4");
                Console.WriteLine("Avsluta tryck 5");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Gör ditt val i menyn");

                int menu = int.Parse(Console.ReadLine());
                if ( menu == 3  || menu ==4)
                {
                Console.Write("\r\nSlå in ditt första tal: ");
                tal1 = GetNumberFromUser();
                Console.Write("\r\nSlå in ditt andra tal: ");
                tal2 = GetNumberFromUser();
                }

                switch (menu)
                {
              

                    case 1:
                        
                        ArryListIn  = TalArray();
                        if( ArryListIn.Length < 3)
                        {
                            tal1 = ArryListIn[0];
                            tal2 = ArryListIn[1];
                            Add(tal1, tal2);                           
                        }                      
                        else 
                        {
                            Add(ArryListIn);
                        }
                        
                        
                        break;

                    case 2:
                        ArryListIn = TalArray();
                       
                        if (ArryListIn.Length < 3)
                        {
                            tal1 = ArryListIn[0];
                            tal2 = ArryListIn[1];
                            Sub(tal1, tal2);
                        }
                        else
                        {
                            Sub(ArryListIn);
                        }                                                                                     //Sub(tal1, tal2);
                        break;

                    case 3:
                        Mult(tal1, tal2);
                        break;

                    case 4:
                        /*if (tal2 == 0)
                        {
                            Console.WriteLine("Du har delat med 0 som är ogiltligt, försök igen");

                        }
                        
                        else
                        Div(tal1, tal2);
                  
                        break;*/
                        while(tal2 == 0)
                        {
                            Console.WriteLine("Du försöker dela med 0 som är ogiltligt. Slå in ett värde som inte är 0");
                            tal2 = GetNumberFromUser();
                        }
                        Sub(tal1, tal2);
                        break;

                    case 5:
                        kör = false;
                        Console.ReadLine();
                        break;

                    default:

                        break;
                }
                if (menu != 5)
                {
                    Console.WriteLine("resultat är " + Resultat);
                }

            }        

        }
        public static double Add(double[] arrayListIn)
            {

            Resultat = 0;
            foreach (double tal in arrayListIn)
            {
                Resultat = Resultat + tal;
               
            }
          
            return Resultat;

            }

        public static double Sub(double[] arrayListIn)
        {

            Resultat = arrayListIn[0];
             for(int i = 1; i < arrayListIn.Length; i++)                                                   //foreach (int tal in arrayListIn)
            {
                Resultat = Resultat - arrayListIn[i];

            }
           
            return Resultat;

        }

        public static double[] TalArray()
        {
             int y = 0;
            Console.WriteLine("Välj hur många tal du vill slå in");                         // vet att jag inte behöver göra detta men han inte göra om.... JUL!
            int antal = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();
            
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("Please enter a number");
                //list.Add(double.Parse(Console.ReadLine()));
                list.Add(GetNumberFromUser());
                y = y + i;
            }
            double[] arryList = new double[y];
            double[] arrayList = list.ToArray();
            return arrayList;
        }
     
        public static double GetNumberFromUser()
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


        public static double Add(double tal1, double tal2)
        {
            Resultat = tal1 + tal2;
          
            return Resultat;
        }

        public static double Sub(double tal1, double tal2)
        {
            
                Resultat = tal1 - tal2;               
           
            return Resultat;
        }

        public static double Mult(double tal1, double tal2)
        {
            Resultat = tal1 * tal2;

            return Resultat;
        }

        public static double Div(double tal1, double tal2)
        {


          
            /*try
            {
                Resultat = tal1 / tal2;
                //Console.WriteLine(tal1 / tal2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", tal1);
            }
            return Resultat;
            /*try
            {
                Resultat = tal1 / tal2;
            }
            catch (DivideByZeroException )//e innanför ()
            {
                Console.WriteLine("Exception caught: {0}");//, e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", Resultat);
            }
            /* while (tal2 == 0)
             {
             if(tal2 == 0)
             {
                 throw new DivideByZeroException("dlllllllllllllelelele");
             }



             Console.WriteLine("Du försöker att dela med 0, det är inte tillåtet, försök med ett nytt tal!");
             tal2 = double.Parse(Console.ReadLine());
             //break; Fick ta bort denna såklart. annars funkade den bara en gång.
             }*/

            Resultat = tal1 / tal2;
            return Resultat;

        }
     

    }
}
