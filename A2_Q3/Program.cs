using System;
using System.Linq;
namespace A2_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
           // int Number1 = 1;
            Console.WriteLine("How many elemnets do you want in the array?");
            int Number = Convert.ToInt32(Console.ReadLine());
            int[] numarray = new int[Number];
            int[] numarray1 = new int[Number];


            Console.WriteLine("\nEnter the elements of the array");

            for (int i = 0; i < Number; i++)
            {
                Console.Write("element " + i + " : ");
                numarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe elements in the array are");
            for (int j = 0; j < numarray.Length; j++)
            {
                Console.Write("  " + numarray[j]);
            }

            for (int i = 0; i < numarray.Length; i++)
            {

                

                if (numarray[i] == 0 || numarray[i] == 1)
                {
                    Console.WriteLine("\n" + numarray[i] + " is not prime number");
                    numarray1[i] = numarray[i];
                   
                    
                }
                else
                {
                    bool IsPrimeNumber = true;
                    for (int a = 2; a <= numarray[i] / 2; a++)
                    {
                        
                        if (numarray[i] % a == 0)
                        {
                            Console.WriteLine("\n" + numarray[i] + " is not prime number");
                            numarray1[i] = numarray[i];
                           
                            IsPrimeNumber = false;
                            break;
                        }

                    }

                    if (IsPrimeNumber)
                    {
                        Console.WriteLine("\n" + numarray[i] + " is a prime number");
                       
                    }
                }

            }
            Console.WriteLine("\nThe elements in the array after deleting primenumbers are\n");
            numarray1 = numarray1.Where(e => e != 0).ToArray();
            Console.WriteLine(String.Join(",", numarray1));
            
        }
    }
}