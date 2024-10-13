//Authors: Blessing & Tommy 

using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare variables to hold whole numbers (favorite numbers)
        int blessingFavoriteNumber;
        int tommyFavoriteNumber;


        ///initialize 

        tommyFavoriteNumber = 17;
        blessingFavoriteNumber = 22;

        //subtract method 
        static int Subtract(int a, int b)
        {
            return a - b;  
        }

        ///Start of our actual program

        Console.WriteLine("Tommy's favorite number is: " + tommyFavoriteNumber);
        Console.WriteLine("Blessing's favorite number is: " + blessingFavoriteNumber);

       /// Console.WriteLine(Addition(tommyFavoriteNumber,blessingFavoriteNumber));
        Console.WriteLine(Subtract(blessingFavoriteNumber,tommyFavoriteNumber));
        
        
        
        int addingOfNumbers = Addition(tommyFavoriteNumber, blessingFavoriteNumber);




        Console.WriteLine("When we add our favorite numbers together we get: " + addingOfNumbers);
    }

     static int Addition(int num1, int num2)
    {
        return num1 + num2;
    }
}
