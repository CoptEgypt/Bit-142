using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Simple_Loops sl = new Simple_Loops();
            sl.RunExercise();

            // Break_Continue_Keywords bck = new Break_Continue_Keywords();
            // bck.RunExercise();

            // Compound_Operators co = new Compound_Operators();
            // co.RunExercise();

            // Increment_Decrement id = new Increment_Decrement();
            // id.RunExercise();

            // Integer_Vs_Real_Division ivrd = new Integer_Vs_Real_Division();
            // ivrd.RunExercise();

            // Modulus_Operator mo = new Modulus_Operator();
            // mo.RunExercise();

            // Fahrenheit_To_Celsius ftc = new Fahrenheit_To_Celsius();
            // ftc.RunExercise();

            // RandomNumbersBasic rnb = new RandomNumbersBasic();
            // rnb.RunExercise();

            // Sentinel_Controlled_Loop scl = new Sentinel_Controlled_Loop();
            // scl.RunExercise();

            // Print_A_Range_Of_Numbers paron = new Print_A_Range_Of_Numbers();
            // paron.RunExercise();

            // Nested_Loops_Rectangles nlr = new Nested_Loops_Rectangles();
            // nlr.RunExercise();

            // Nested_Loops_Hollow_Rectangles nlhr = new Nested_Loops_Hollow_Rectangles();
            // nlhr.RunExercise();

            // Built_In_Math_Functions bimf = new Built_In_Math_Functions();
            // bimf.RunExercise();
        }
    }


    class Simple_Loops
    {
        public void RunExercise()
        {
        }
    }

    class Break_Continue_Keywords
    {
        public void RunExercise()
        {

        }
    }

    class Compound_Operators
    {
        public void RunExercise()
        {
        }
    }

    class Increment_Decrement
    {
        public void RunExercise()
        {
            int num = 0;
            // ++ before num is 'prefix' 
            while (++num < 10)
                Console.WriteLine("Num: {0}", num);

            num = 0;
            // ++ after num is 'postfix' 
            while (num++ < 10)
                Console.WriteLine("Num: {0}", num);

            num = 10;
            // -- before num is 'prefix' 
            while (--num > 0)
                Console.WriteLine("Num: {0}", num);

            num = 10;
            // -- after num is 'postfix' 
            while (num-- < 10)
                Console.WriteLine("Num: {0}", num);
        }
    }

    class Integer_Vs_Real_Division
    {
        public void RunExercise()
        {
        }
    }

    class Modulus_Operator
    {
        public void RunExercise()
        {
        }
    }

    class Fahrenheit_To_Celsius
    {
        public void RunExercise()
        {
        }
    }

    class RandomNumbersBasic
    {
        public void RunExercise()
        {
            Random dieToRoll = new Random();

            // First, generate (and print) a random number between 1 & 6
            //      (including, potentially, 1 or 6 as possible output)

            // Now, call dieToRoll.Next() lots of times,
            // as described in the exercise
        }
    }

    class Sentinel_Controlled_Loop
    {
        public void RunExercise()
        {
        }
    }

    class Print_A_Range_Of_Numbers
    {
        public void RunExercise()
        {
        }
    }

    class Nested_Loops_Rectangles
    {
        public void RunExercise()
        {
        }
    }

    class Nested_Loops_Hollow_Rectangles
    {
        public void RunExercise()
        {
        }
    }

    class Built_In_Math_Functions
    {
        public void RunExercise()
        {
        }
    }
}
