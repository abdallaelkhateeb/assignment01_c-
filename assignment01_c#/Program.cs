namespace assignment01_c_
{
    

    
        internal class Program
        {
            static void Main(string[] args)
            {
                //Assignment 1
                #region Q1
                //Write a program that allows the user to enter a number then print it.
                //Console.WriteLine("Enter a number:");
                //string input = Console.ReadLine();
                //Console.WriteLine($"You entered: {input}");
                #endregion

                #region Q2
                //Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
                //string str = "111aaa";

                //int num = int.Parse(str);
                //Console.WriteLine("Converted number: " + num);
                // This will throw a FormatException because the string contains non-numeric characters.
                #endregion

                #region Q3
                //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
                //float a = 1.1f;
                //float b = 2.2f;
                //float sum = a + b;
                //Console.WriteLine("Sum: " + sum);



                #endregion

                #region Q4
                ////Write C# program that Extract a substring from a given string.
                //string originalString = "Hello, World!";
                //string substring = originalString.Substring(7, 5); // Extracts "World"
                #endregion

                #region Q5
                //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
                //int x = 10;
                //int y = x; // y is assigned the value of x      
                //y = 20; // Modifying y does not affect x
                //Console.WriteLine($"x: {x}, y: {y}"); // Output: x: 10, y: 20


                #endregion

                #region Q6
                //Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
                Square s1 = new Square();
                s1.side = 5;
                Square s2 = s1; // s2 references the same object as s1
                s2.side = 10; // Modifying s2 affects the object referenced by s1
                Console.WriteLine($"s1.side: {s1.side}, s2.side: {s2.side}"); // Output: s1.side: 10, s2.side: 10



                #endregion

                #region Q7
                //Write C# program that take two string variables and print them as one variable 
                string first = "Hello";
                string second = "World";
                string conc = first + " " + second;
                Console.WriteLine("concated string: " + conc);
                #endregion

                #region Q8

                int d;
                d = Convert.ToInt32(!(30 < 20));

                //b) A value 1 will be assigned to d.


                #endregion

                #region Q9
                //Which of the following is the correct output for the C# code given below?Console.WriteLine(13 / 2 + " " + 13 % 2); 

                // d) 6 1
                #endregion

                #region Q10
                //10-What will be the output of the C# code given below?

                int num = 1, z = 5;


                if (!(num <= 0))
                    Console.WriteLine(++num + z++ + " " + ++z);
                else
                    Console.WriteLine(--num + z-- + " " + --z);
                //D) 7 7
                #endregion
            }

        }
    
}
    #region Q6
    class Square
    {
        public int side;

    }
    #endregion


