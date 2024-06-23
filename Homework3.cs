namespace Homework3;

class Program
{
    static void Main(string[] args)
    {   //write a program to take an input number and determine whether or not the number N is a prime number or not
        {Console.WriteLine("\n*********Here is the beginning of Homework Problem 1********\n ");

        Console.WriteLine("Please input a number: ");
        int N = Convert.ToInt32(Console.ReadLine()); //ask for user input
        bool isPrime = true; //establishes the two choices - isPrime and notPrime

         for (int i = 2; i <= N / 2; i++) 
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            
            if (N <= 1)
            {
                isPrime = false; // sets expectation that 1 and negative numbers can not be prime
            }
            
            if (isPrime)
            {
                Console.WriteLine(N + " is Prime");
            }
            else
            {
                Console.WriteLine(N + " is not Prime"); 
            }
        }
            Console.WriteLine("\n*********Here is the beginning of Homework Problem 2********\n ");
                //write a program to input an integer into N and prints a square pattern where rows and columns equal - use nested for loop
                                
                Console.WriteLine("Please input a positive number: ");
                int N2 = Convert.ToInt32(Console.ReadLine()); //ask for user input
                    for(int row = 0; row<=N2; row++){
                        for(int col = 0; col<=N2; col++)
                        {   
                            Console.Write('*');  //MUST use Write instead of WriteLine in order to print on the same line and make the right pattern
                        }
                            Console.WriteLine("");
                }

        Console.WriteLine("\n***********************Here is the beginning of Homework Problem 3************\n ");
            //write a program to input an integer N3 where the number of rows is equal to N3
            Console.WriteLine("Please input a positive number: ");
                int N3 = Convert.ToInt32(Console.ReadLine()); //ask for user input
                    for(int row = 0; row<N3; row++){
                        for(int col = 0; col<N3; col++)
                        {   
                            if(row>=col)
                            Console.Write('*');
                        }
                            Console.WriteLine("");
                }
        Console.WriteLine("\n***********************Here is the beginning of the Bonus Homework Problem ************\n ");
            //write a program to input an integer N4 where the number of rows is equal to N4, using numbers instead of symbols

            Console.WriteLine("Please input a positive number: ");
                int N4 = Convert.ToInt32(Console.ReadLine()); //ask for user input
                for(int row = 1; row <= N4; row++){
                    for(int col = 1; col <=N4; col++)
                    {
                        if (row>=col)
                        Console.Write(row);
                    }
                        Console.WriteLine("");
                }

        }
    
 }   