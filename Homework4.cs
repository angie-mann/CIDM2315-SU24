namespace Homework42;

 class Program
{
    
    static void Main()
{    Console.WriteLine("********************Homework Problem #1*******************");
    //Create a program to input 2 numbers on the keyboard, determine which number is largest and Print the results
    {
        Console.WriteLine("Please enter the first integer: ");  //print request for input for number 1
        int a = Convert.ToInt16(Console.ReadLine());            // gather input and assign to variable a

        Console.WriteLine("Please enter the second integer: "); //  print request for input for number 2
        int b = Convert.ToInt16(Console.ReadLine());            // print request for input for variable b

        int max=MaxNumber(a,b);                                 // assign variable max to int and calculate which number is the largest . Call method MaxNumber
        Console.WriteLine("a = " + a +"; b = " + b);
        Console.WriteLine("The largest number is: " + max);
    }

    static int MaxNumber(int x, int y)              //Create method MaxNumber
    {
        if (x > y)                                  //Calculate if number 1 is higher than number 2
            return x;                               // if yes - return number 1
        else
            return y;                               // if not, return number 2
    }

    {   Console.WriteLine("*******************Problem 2 start*******************");
    //Create a program to input 4 numbers on the keyboard, determine which number is largest and Print the results. Use same method from Problem 1(MaxNumber)
        Console.WriteLine("Please enter the first integer: ");  //print request for input for number 1
        int a = Convert.ToInt16(Console.ReadLine());            // gather input and assign to variable a

        Console.WriteLine("Please enter the second integer: "); //print request for input for number 2
        int b = Convert.ToInt16(Console.ReadLine());            //gather input and assign to vairable b

        Console.WriteLine("Please enter the third integer: "); //print request for input for number 3
        int c = Convert.ToInt16(Console.ReadLine());        //gather input and assign to variable c

        Console.WriteLine("Please enter the fourth integer: "); //print request for input for number 4
        int d = Convert.ToInt16(Console.ReadLine());            //gather input and assign to variable d

        int max= MaxNumber(MaxNumber(a,b),MaxNumber(c,d));  //call method MaxNumber to determine the largest number from the 4 inputs. Declare max as the variable

        Console.WriteLine("a = "+ a +"; b = "+b +"; c = "+c +"; d = "+d);  //Write what the four numbers are
        Console.WriteLine("The largest number is: " + max);             //Write what the highest number is (variable max)
    }
  /* Note regarding the method: I honestly do not understand how this same method works when there are 4 variables instead of just 2. In the method, it 
  only has two parameters - and not four. The only way I came to this answer was after 7 hours of trial and error and research*/


    Console.WriteLine("*********************Homework Problem 3****************************");
    //Implement the following methods to design an account creation process
   {
    createAccount();
   }
   
   static bool checkAge(int birth_year)
    {
	
    int age = 2024 - birth_year;    // calculate the age based on the birth_year (age = 2022-birthyear)
    if(age >= 18)        
        return true;                // if age >=18, return true;
        else 
        return false;               //else return false;
    } 

    static void createAccount () //(string userName, string password, string password1, int birthyear, bool checkAge);
{
   Console.WriteLine("Please input username: ");// ask user to input username
   string username = Console.ReadLine();
   
    Console.WriteLine("Please input your password: ");  // ask user to input password
    string password = Console.ReadLine();

    Console.WriteLine("Please input your password again: "); // ask user to input password again
    string password1 = Console.ReadLine();

    Console.WriteLine("Please type in your birth year: "); // ask user to input birthyear
    int birthyear = Convert.ToInt16(Console.ReadLine());

    if (checkAge(birthyear))
    {                //call checkAge(birthyear) method to check if age is greater than 18
        if (password==password1)  // if checkAge(birthyear) returns true, hen check if two passwords are same, if passwords are same, print “Account is created successfully”
        {
            Console.WriteLine("Account is created successfully");
        }
        else
        {
            Console.WriteLine("Wrong password");  // else print “Wrong password”
        }
    }
       else
       {
        Console.WriteLine("Could not create an account due to age"); // if checkAge(birthyear) returns false, print “Could not create an account”
       }
    }
    }
}

	


  