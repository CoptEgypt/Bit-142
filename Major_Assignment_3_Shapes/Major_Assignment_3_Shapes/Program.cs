using System;


namespace Major_Assignment_3_Shapes {
    public class Program {
        public static void Main(String[] args) {
            new Rectangle();
            new Triangle();
            new Circle();
        }

    }

    //class shape
    public class Shape {
        //print method print the message
        public void print() {
            Console.WriteLine("I am a Shape! Shapes are cool!");
            Console.WriteLine("Shape");
            Console.WriteLine("Shape");
            Console.WriteLine("Shape");
            Console.WriteLine("Shape");
            Console.WriteLine("Shape");
        }
    }
    //rectangle class derives shape
    public class Rectangle : Shape {
        public Rectangle() {
            Console.WriteLine("");
            Console.WriteLine("I am a rectangle...who has 4 sides");
            //call to print() method of shape class
            base.print();

        }
    }
    //triangle class derives shape
    public class Triangle : Shape {
        public Triangle() {
            Console.WriteLine("");
            Console.WriteLine("I am a Triangle");
            Console.WriteLine("I have 3 sides");
            Console.WriteLine("I have 3 sides");
            Console.WriteLine("I have 3 sides");
            //call to print() method of shape class
            base.print();

        }
    }
    //circle class derives shape
    public class Circle : Shape {
        public Circle() {
            Console.WriteLine("");
            Console.WriteLine("I am round");
            Console.WriteLine("I like to roll!");
            Console.WriteLine("I like to roll!");
            Console.WriteLine("I like to roll!");
            Console.WriteLine("I like to roll!");
            Console.WriteLine("I like to roll!");
            Console.WriteLine("I like to roll!");
            Console.WriteLine("I like to roll!");
            //call to print() method of shape class
            base.print();

        }
    }
}
    
    