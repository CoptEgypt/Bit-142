using System;

namespace major_ass_2_Quilt_size_program {
    class MainClass {
        public static void Main(string[] args) {
            //
            Console.WriteLine("Welcome to Geo's Quilts! I'm really happy to work with you!");
            Console.WriteLine("What size quilt would you like?");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
                Console.Write("#================# ");
            Console.WriteLine();
            for (int i = 0; i < 10 * size - 1 - 2 * size - 2; i++)
                Console.Write(" ");
            Console.Write("| ");
            for (int i = 0; i < size; i++)
                Console.Write("<><>");
            Console.Write(" |\n");
            // the past lines of codes create the initial quilt
            for (int i = 0; i < 10 * size - 1 - 2 * size - 2 - 2; i++)
                Console.Write(" ");
            Console.Write("| ");
            Console.Write("<>");
            for (int i = 0; i < size; i++)
                Console.Write("....");
            Console.Write("<>");
            Console.Write(" |\n");
            //using for loops do do the order of operation program, therefore this lets you to do the math for any size quilt you'll want.
            for (int i = 0; i < 6 * (size - 1) + 1; i++)
                Console.Write(" ");
            Console.Write("| ");
            Console.Write("<>");
            for (int i = 0; i < size; i++)
                Console.Write("........");
            Console.Write("<>");
            Console.Write(" |\n");
            //all these for loops are for different lines of the drawing in the program.
            for (int i = 0; i < 4 * (size - 1) - 1; i++)
                Console.Write(" ");
            Console.Write("|");
            Console.Write("<>");
            for (int i = 0; i < size; i++)
                Console.Write("............");
            Console.Write("<>");
            Console.Write("|\n");

            for (int i = 0; i < 4 * (size - 1) - 1; i++)
                Console.Write(" ");
            Console.Write("|");
            Console.Write("<>");
            for (int i = 0; i < size; i++)
                Console.Write("............");
            Console.Write("<>");
            Console.Write("|\n");

            for (int i = 0; i < 6 * (size - 1) + 1; i++)
                Console.Write(" ");
            Console.Write("| ");
            Console.Write("<>");
            for (int i = 0; i < size; i++)
                Console.Write("........");
            Console.Write("<>");
            Console.Write(" |\n");

            for (int i = 0; i < 10 * size - 1 - 2 * size - 2 - 2; i++)
                Console.Write(" ");
            Console.Write("| ");
            Console.Write("<>");
            for (int i = 0; i < size; i++)
                Console.Write("....");
            Console.Write("<>");
            Console.Write(" |\n");

            for (int i = 0; i < 10 * size - 1 - 2 * size - 2; i++)
                Console.Write(" ");
            Console.Write("| ");
            for (int i = 0; i < size; i++)
                Console.Write("<><>");
            Console.Write(" |\n");

            for (int i = 0; i < size; i++)
                Console.Write("#================# ");
            Console.WriteLine();

            Console.ReadLine();


        }


    }
}
