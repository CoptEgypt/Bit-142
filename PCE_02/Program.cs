using System;

namespace PCE_StarterProject {
    class Program {
        static void Main(string[] args) {
            //Conditional_Statements cs = new Conditional_Statements();
            //cs.RunExercise();

            // Comparison_Operators co = new Comparison_Operators();
            // co.RunExercise();

             IO_Operators ioo = new IO_Operators();
             ioo.RunExercise();

            // Integer_Vs_Real_Division ivrd = new Integer_Vs_Real_Division();
            // ivrd.RunExercise();

            // Clearly, you will need to uncomment these to test them...
            // Modulus_Operator mo = new Modulus_Operator();
            // mo.RunExercise();

            // Fahrenheit_To_Celsius ftc = new Fahrenheit_To_Celsius();
            // ftc.RunExercise();
        }
    }

    class Conditional_Statements {
        public void RunExercise() {
            Console.WriteLine("About to do the \"Conditional Statements\" exercise");
            Conditional_Methods cm = new Conditional_Methods();
            cm.UsingIf();
            cm.UsingIfElse();
            cm.UsingSwitch();
        }
    }

    class Comparison_Operators {
        public void RunExercise() {
            Console.WriteLine("Get 2 integers & store them, then compare them using <, <=, etc, etc");
        }
    }


    class IO_Operators {
        public void RunExercise() {
            int value1, value2;
            Console.WriteLine("Type first number: ");
            string line = Console.ReadLine(); // Read string from console
            int.TryParse(line, out value1);
            Console.WriteLine("Type second number: ");
            string line2 = Console.ReadLine();
            int.TryParse(line2, out value2);
            //20 25 && (value2-value1 <= 5)
            if (value1 < value2 && (value2-value1) <= 5) {
                Console.WriteLine(value1 + " and " + value2 + " are within 5 integers of each other.");
            } else if (value1 < value2 && (value2 - value1) > 5) {
                Console.WriteLine(value1 + " and " + value2 + " are NOT within 5 integers of each other.");
            } else if (value2 < value1 && (value1 - value2) <= 5) {
                Console.WriteLine(value2 + " and " + value1 + " are within 5 integers of each other.");
            } else if (value2 < value1 && (value1 - value2) > 5) {
                Console.WriteLine(value2 + " and " + value1 + " are NOT within 5 integers of each other.");
            }



        }

        class Conditional_Methods {

            int value;

            public void UsingIf() {
                Console.WriteLine("Type a number: ");
                string line = Console.ReadLine(); // Read string from console
                if (int.TryParse(line, out value)) {
                    if (value < 0) {
                        Console.WriteLine("Negative numbers aren't allowed.");
                    }
                    if (value > 10) {
                        Console.WriteLine("Your number is too high.");
                    }
                    if (value == 0) {
                        Console.WriteLine("You need to talk to the professor immediately!");
                    }
                    if (value == 1) {
                        Console.WriteLine("You need to study a lot more!");
                    }
                    if (value == 2 || value == 3 || value == 4) {
                        Console.WriteLine("If you keep working at this, you'll do better!");
                    }
                    if (value == 5 || value == 6) {
                        Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even betetr!");
                    }
                    if (value == 7 || value == 8) {
                        Console.WriteLine("Nice job, but don't let yourself slack!");
                    }
                    if (value == 9) {
                        Console.WriteLine("Very nice job - keep up the good work!");
                    }
                    if (value == 10) {
                        Console.WriteLine("Perfect!");
                    }
                }
            }

            public void UsingIfElse() {
                Console.WriteLine("Type a number: ");
                string line = Console.ReadLine(); // Read string from console
                if (int.TryParse(line, out value)) {
                    if (value < 0) {
                        Console.WriteLine("Negative numbers aren't allowed.");
                    } else if (value > 10) {
                        Console.WriteLine("Your number is too high.");
                    } else if (value == 0) {
                        Console.WriteLine("You need to talk to the professor immediately!");
                    } else if (value == 1) {
                        Console.WriteLine("You need to study a lot more!");
                    } else if (value == 2 || value == 3 || value == 4) {
                        Console.WriteLine("If you keep working at this, you'll do better!");
                    } else if (value == 5 || value == 6) {
                        Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even betetr!");
                    } else if (value == 7 || value == 8) {
                        Console.WriteLine("Nice job, but don't let yourself slack!");
                    } else if (value == 9) {
                        Console.WriteLine("Very nice job - keep up the good work!");
                    } else { //it's 10 
                        Console.WriteLine("Perfect!");
                    }
                }
            }
            public void UsingSwitch() {
                switch (value) {
                    case 0: Console.WriteLine("You need to talk to the professor immediately!"); break;
                    case 1: Console.WriteLine("You need to study a lot more!"); break;
                    case 2: Console.WriteLine("If you keep working at this, you'll do better!"); break;
                    case 3: Console.WriteLine("If you keep working at this, you'll do better!"); break;
                    case 4: Console.WriteLine("If you keep working at this, you'll do better!"); break;
                    case 5: Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even betetr!"); break;
                    case 6: Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even betetr!"); break;
                    case 7: Console.WriteLine("Nice job, but don't let yourself slack!"); break;
                    case 8: Console.WriteLine("Nice job, but don't let yourself slack!"); break;
                    case 9: Console.WriteLine("Very nice job - keep up the good work!"); break;
                    case 10: Console.WriteLine("Perfect!"); break;

                    default: Console.WriteLine("Negative numbers aren't allowed or your number is too high."); break;
                }
            }
        }

        class Integer_Vs_Real_Division {
            public void RunExercise() {
                private double TestitOut() {
                    int a = 30;
                    int b = 40;
                    double c = a / b;
                    return c;
                }
            }
        }

        class Modulus_Operator {
            public void RunExercise() {
                int x = 3, y = 5;
                int z = 10;
                Console.WriteLine(x % y);
                Console.WriteLine(y % x);
                Console.WriteLine(x % x);
                Console.WriteLine(x % 2);
                Console.WriteLine((x + z) % y);
            }
        }

        class Fahrenheit_To_Celsius {
            public void RunExercise() {
                double celsius;
                Console.Write("Enter Fahrenheit temperature : ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine("The converted Celsius temperature is" + celsius);
                Console.ReadLine();
            }
        }

        class Logical_Operators {
            x > 4 && z <= 10
    
    // First annotate everything with their data types
    x[int] > 4 [int] && z[int] <= 10 [int]
    
    // > and <= have the same precedence, so
    // the left-to-right associativity of the operators
    // tells us that > goes first ,
    // so substitute the value of x
    5 [int] > 4 [int] && z[int] <= 10 [int]
    
    // 5 is greater than 4 – it's true
    true [bool] && z[int] <= 10 [int]
    
    // <= goes next, so substitute the value of z
    true [bool] && 10 [int] <= 10 [int]
    
    // 10 is clearly <= 10, therefore it's true
    true [bool] && true [bool]
    
    // && is the only one left
    // true AND true is true, so we get:
    true [bool]
            // Side-Note: Notice that this class has NO methods, and that it still compiles :)
        }
    }
}