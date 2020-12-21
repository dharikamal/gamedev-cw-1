using System;

namespace gamedevcw1
{
    class Program
    {
        //public static bool AgeDiffe { get; private set; }
        static double PlayerSpeed = 2.5;
        static void Main(string[] args)
        {
            //String CharName = "Ahmed";
            // int age = 15;
            //float Speed = 1.65f;
            // String superpower1 = "steel sheild";
            // String superpower2 = "Night vision";
            // string heroName = "aryax";
            // int Age = 21;
            // float speeds = 1.75f;
            //  string Spower1 = "fire";
            // string Spower2 = "moving fast";
            // bool isBoss = true;


            //Console.WriteLine("My name is {0}, My SuperPower is {1}, {2}, am {3} years old, my speed is {4}", CharName, superpower1, superpower2, age, Speed);
            //Console.WriteLine("My name is {0}, My SuperPower is {1}, {2}, am {3} years old, my speed is {4}", heroName, Spower1, Spower2, Age, speeds);
            //int AgeDiff = Age - age;
            // Console.WriteLine("the diff is {0}" ,AgeDiff);
            //Console.WriteLine(age -Age);
            SetSpeed();
            Console.WriteLine("The current player speed is "+PlayerSpeed);
            GetSpeed();
            Console.WriteLine("The super speed is "+PlayerSpeed);


        }

        static double SetSpeed()
        {
            return PlayerSpeed;
        }

        static double GetSpeed()
        {
            return PlayerSpeed = PlayerSpeed *10.5;
        }

    }
}
