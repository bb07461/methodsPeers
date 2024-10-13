/*
    Tommy and Blessing
    IGME 201.01 - Interac Des & Alg Prob Sol III
    10/13/2024
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare variables to hold whole numbers (favorite numbers)
        int blessingFavoriteNumber;
        int tommyFavoriteNumber;


        //initialize 

        tommyFavoriteNumber = 17;
        blessingFavoriteNumber = 22;

        //subtract method 
        static int Subtract(int a, int b)
        {
            return a - b;  
        }

        //Start of our actual program

        Console.WriteLine("Tommy's favorite number is: " + tommyFavoriteNumber);
        Console.WriteLine("Blessing's favorite number is: " + blessingFavoriteNumber);

        
        int addingOfNumbers = Addition(tommyFavoriteNumber, blessingFavoriteNumber);
        int subtractOfNumbers = Subtract(blessingFavoriteNumber, tommyFavoriteNumber);
        Console.WriteLine("When we subtract together: " + subtractOfNumbers);




        Console.WriteLine("When we add our favorite numbers together we get: " + addingOfNumbers);
        
    }

/// <summary>
/// addition function for favorite numbers 
/// </summary>
/// <param name="num1"></param>
/// <param name="num2"></param>
/// <returns></returns>
     static int Addition(int num1, int num2)
    {
        return num1 + num2;
    }
}
