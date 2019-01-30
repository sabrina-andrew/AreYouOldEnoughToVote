using System;

namespace AreYouOldEnoughToVote
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You are not old enough to vote!");
            }

            else
            {
                Console.WriteLine("You are old enough to vote!");
            }
        }
    }
}