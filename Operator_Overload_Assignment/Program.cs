using System;

namespace Operator_Overload_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee william = new Employee();
            william.Id = 1234;
            william.Name = "William";
            william.Department = ".Net Developer";

            Employee susan = new Employee();
            susan.Id = 1235;
            susan.Name = "Susan";
            susan.Department = ".Net Developer";

            if (william == susan)
            {
                Console.WriteLine($"{william.Name}'s and {susan.Name}'s Id's are equal");
            }
            else if (william != susan)
            {
                Console.WriteLine($"{william.Name}'s and {susan.Name}'s Id's are not equal");
            }
            Console.Read();
        }
    }
}


        
        
           
    

       
        


        


