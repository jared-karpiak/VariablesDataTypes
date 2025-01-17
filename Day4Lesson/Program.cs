namespace Day4Lesson
{
    internal class Program
    {
        // CONSTANTS
        // A constant is special type of variable that indicates a value that will never change
        // Constants are usually declared at the top of an application,
        // or in a different file dedicated to constants in the application.
        // A common naming convention for constants is SCREAMING_SNAKE_CASE
        const double GOLDEN_RATIO = 1.61;

        // This is the Main() method, the entry point to the program.
        static void Main(string[] args)
        {
            /* Basic C# rules
             * 
             * C# is case sensitive
             * C# programs must be stored in a .cs file
             * Every C# application must have a method called Main(), which is the origin point of the program.
             * Every left/opening brace { must have a right/closing brace }
             * Statements are terminated by semicolons ;
            */

            //The following two variables are different, because they have different cases.
            int myAge = 40;
            int myage = 40;

            
            
            /* C# has many special characters. The following are just a few:
             * 
             * {} : Curly Braces ("duck lips")
             *   - these enclose a group of statements
             * () : Parentheses
             *   - these are used in a "method header", or "definition".
             *   - They are also used to hold conditions in conditional logic.
             * ;  : Semicolon
             *   - marks the end of a programming statement
             * "" : Double Quotation Marks
             *   - Encloses a string
             * '' : Single Quotation Marks
             *   - Encloses a single character
               // : Double Slash
                 - Marks the beginning of a single line comment.
         
             */

            // /* : Begins a multi-line comment
            // */ : Closes a multi-line comment

            // Here is a use of double quotes to hold a string
            string myString = "like this";

            // Here is a use of single quotes to hold a character
            char myChar = 'h';

            /*
             * Console.Write()
             * - Writes to the console, but does not add a new line.
             * - Use this for prompting users for input.
             * 
             * Console.WriteLine()
             * - Writes to the console and adds a new line afterwards.
             * - Use this for giving information to the user.
             */

            Console.Write("Console.Write() will not print a new line.");
            Console.WriteLine("Console.WriteLine() will print a new line.");

            // Escaping Characters
            // There are ways to add different characters to strings using specific escape sequences.
            // They are written with a backslash \, followed by the character
            // Below are a few examples:
            //    \n = new line. Create a new line.
            //    \t = tab. Create a tab character (ie. 4 spaces)
            //    \r = return carriage. Will move the cursor back to the beginning of the line. NOTE: any text written after this will overwrite any previously written text.
            //    \\ = Write a backslash
            //    \" = write double quote
            //    \' = write single quote
            // For more examples see: https://learn.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-170
            Console.Write("A quote by Socrates: \"Life is like a box of chocolates. Expensive....\"\n\n\nDon't believe everything you read.\n");

            // Variables and Literals
            // A variable is a container for single piece of data. A number or text for example.
            // A literal would be using the value of the data itself.

            // Here is an example of using a variable

            string myMessage = "This is a message using a variable.";
            Console.WriteLine(myMessage);

            // Here is an example of using a literal.

            Console.WriteLine("This is a message that uses a literal. The message is typed directly into WriteLine().");

            // Variables follow specific naming conventions, but they vary by programming language
            // and even from company to company.
            // The coding standards for CPSC1012 are found here: https://lms.nait.ca/d2l/le/content/36982/viewContent/2711262/View
           
            // Variable Terminology
            // "Declaring" a variable means to create the data type and the variable name.
            // For example:
            string firstName;

            // You can declare multiple variables in a single line using commas, as long as they are the same data type.
            string middleName, lastName;

            // "Initializing" a variable means to give the variable a value.
            // For example:

            int age = 45;

            // You can declare a variable and initialize it in the same line.
            // You can also initialize a variable that has already been declared.

            firstName = "Aristotle";

            // you can also declare and initialize multiple variables in the same line, as long as they are the same data type.

            char letterA = 'A', letterB = 'B';

            // Other notes on variables:
            //   - Variables must be declared before they can be used.
            //   - The value of a variable can change, as long as it is the same data type.

            // DATA TYPES
            // There are many data types that specify the type of data that is contained within a variable.
            
            // NUMBERS
            // byte
            // The byte data type can contain a number from 0 - 255
            // takes up 1 Byte of space on the disk.
            byte myByte = 5;

            // short
            // the short data type can contain the numbers -32,768 to 32,767
            // takes up 2 bytes of space on the disk.
            short myShort = 20000;

            // int
            // the int data type contains the numbers -2,147,483,648 to 2,147,483,647
            // take up 4 bytes of space on the disk
            int myInt = -23671563;

            // long
            // the long data type contains the numbers -9,223,372,036,854,775,808 to
            // 9,223,372,036,854,775,807
            // It takes up 8 bytes of space on the disk
            long myLong = 84357387389523;

            // short, int, and long are all whole numbers. Decimal points aren't allowed.
            // a different version of short, int, and long exist that will prevent them from being negative
            // this is called unsigned.

            ushort myUnsignedShort = 40000;
            uint myUnsignedInt = 3000000000;
            ulong myUnsignedLong = 3888888888888888;


            // float
            // the float data type encompases the numbers ±1.5 x 10^−45 to ±3.4 x 10^38
            // It has 7 digits of precision
            // It takes up 4 bytes of space on the disk
            // In C#, a number with decimal points is automatically treated as a "double" data type
            // to specify we want to use a float, we need to add the letter 'f' after the number.

            float myFloat = 4.267f;

            // double
            // the double data type encompases the numbers ±5.0 × 10^−324 to ±1.7 × 10^308
            // It has 15 digits of precision
            // It takes up 8 bytes of space on the disk
            double myDouble = 7.327432746328;

            // decimal
            // the decimal data type encompases the numbers ±1.0 x 10^-28 to ±7.9228 x 10^28
            // It has 28 digits of precision
            // It takes up 16 bytes of space on the disk
            // to specify we want to use a decimal, we need to add the suffix 'M'. to the number
            decimal myDecimal = 721.542678M;

            // bool
            // The bool data type contains a value that is either true or false

            bool myBool = false;

            // char
            // The char data type holds a single character.
            // The character must be initialized using single quotes.
            char myCharizard = 'a';

            // string
            // the string data type holds more than one character
            // It must be surrounded by double quotes
            string mySecondString = "HELLO";
        }
    }
}
