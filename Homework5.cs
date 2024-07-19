using System.Security.Cryptography;

namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        //create two customers 
        Customer c1 = new Customer(110,"Alice",28);
        Customer c2 = new Customer(111,"Bob", 30);

    
        //print customer information
        c1.PrintCusInfo();
        c2.PrintCusInfo();

        //update customer ID numbers
        c1.ChangeID(220);
        c2.ChangeID(221);

        //Print updated customer infor
        c1.PrintCusInfo();
        c2.PrintCusInfo();

        // Compare ages and determine which customer is older
        c1.CompareAge(c2);
    }
class Customer{

    //create the Attributes: Variables
    private int cus_id;  //cus_id is private and can not be accessed outside of class
    public string cus_name;
    public int cus_age;

    //Constructor: used to assign id, name and age to the customer when object created
    public Customer(int custID, string custName, int custAge){
       cus_id = custID;
       cus_name = custName;
       cus_age = custAge;
        
    }
    
    
    //create the Behavoirs: Methods
    //method used to change customer id
    public void ChangeID(int new_id){
       cus_id = new_id;
    } 

    //method used to pring customer info (Id, name, ag
    
    public void PrintCusInfo() {
    
        Console.WriteLine($"Customer ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

//method used to compare the current object's age with the objCustomer's age. Then print
    //out the cus_name of the older customer
    public void CompareAge(Customer objCustomer) {
    
    if(cus_age > objCustomer.cus_age){
        Console.WriteLine($"{cus_name} is older.");
    }
    else if (cus_age < objCustomer.cus_age){
        Console.WriteLine($"{objCustomer.cus_name} is older.");
     }
     else
     {  
        Console.WriteLine($"{cus_name} and {objCustomer.cus_name} are the same age");
     }
    }

}

    }

