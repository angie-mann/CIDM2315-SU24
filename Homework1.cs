namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        //Line to ask user to input a grade
    {
      Console.WriteLine("Here is the first Homework Problem for Week 1\n");
      Console.WriteLine("The purpose of this problem is to assign a letter grade with the corresponding GPA number\n");
      Console.WriteLine("\nPlease input a letter grade: ");
    string user_grade = Console.ReadLine();
    	//convert string to char 
    char grade = Convert.ToChar(user_grade);
    
	//if else statements - include capital and lowercase letters to lessen input errors
    if(grade == 'A' || grade == 'a') {
        Console.WriteLine("GPA point: 4");
    }
    else if(grade == 'B'|| grade == 'b') {
     Console.WriteLine("GPA point: 3");
    }
    else if(grade == 'C' || grade == 'c') {
     Console.WriteLine("GPA point: 2");
    }
    else if (grade == 'D' || grade == 'd') {
     Console.WriteLine("GPA point: 1");
    }
    else if (grade =='F' || grade == 'f') {
     Console.WriteLine("GPA point: 0");
    }
    
    else{
     Console.WriteLine("Wrong Letter Grade!");
        }
    }

      Console.WriteLine("\nHere is the beginning of Homework Problem 2\n ");
      Console.WriteLine("The purpose of this program is to determine the lowest number input by the user out of three different numbers\n");
        Console.WriteLine("\nPlease input the first number: ");
      string n1 = Console.ReadLine();
      int num1 = Convert.ToInt16(n1);

      Console.WriteLine("Please input the second number: ");
      string n2 = Console.ReadLine();
      int num2 = Convert.ToInt16(n2);

      Console.WriteLine("Please input the third number: ");
      string n3 = Console.ReadLine();
      int num3 = Convert.ToInt16(n3);

      if (num1<num2) {
            if (num1<num3){
                Console.WriteLine("The smallest value is "+ num1);
            }
            else {  //num1>num3
                Console.WriteLine("The smallest value is "+ num3);
            }
    }
    else {  //num2 > num1 
        if (num2<num3){
            Console.WriteLine("The smallest value is "+ num2);
        }
        else {  //num3 < num 2
            Console.WriteLine("The smallest value is " + num3);
            }
        }
    




    //Ask user to input a year
    /* How to know if it is a Leap Year:
    yes	Leap Years are any year that can be exactly divided by 4 (such as 2020, 2024, 2028, etc)
 	not	except if it can be exactly divided by 100, then it isn't (such as 2100, 2200, etc)
 	 	yes	except if it can be exactly divided by 400, then it is (such as 2000, 2400) */

    {  Console.WriteLine("\nHere is the beginning of the Bonus Homework Problem\n");
        Console.WriteLine("The purpose of this program is to determine if the year input by the user is a leap year\n");
      Console.WriteLine("Please input a year: \n");
      string input_year = Console.ReadLine();
      int year = Convert.ToInt16(input_year);

      if(year%400==0 || year%4==0 && year%100!=0) {
        Console.WriteLine(year +" is a Leap Year");
      }
    else{
        Console.WriteLine(year+" is not a Leap Year");
        }
    }
    }
}