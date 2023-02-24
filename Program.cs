using System;

namespace Variables_Yo_Fix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declares an integer to store favorite number
            int favoriteNumber;
            //Booleans initalized to false for jumping and running
            bool isJumping = false, isRunning = false;
            //Declared random float variable
            float myFloat;
            //Assigning favoriteNumber to 4
            favoriteNumber = 4;
            //Asssigning myFloat to 54.65
            myFloat = 54.65f;
            //Initializing constant fianlGrade to 90
            const double finalGrade = 90.0;

            //Prints all variables to to console
            Console.WriteLine("Favorite #: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " +myFloat);
            Console.WriteLine("Final Grade:" + finalGrade);
        }
    }
}
