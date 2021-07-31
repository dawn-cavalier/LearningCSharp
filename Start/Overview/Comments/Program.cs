using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary>
        /// This is the main function
        /// </summary>
        /// <param name='args'> An Array of string arguments from the command line </param>
        /// <returns>
        /// No returns
        /// </returns>

        static void Main(string[] args)
        {
            // Single Line Comment
            // Can have many of these together
            Console.WriteLine("Hello World!");
            /* This is a multiline comment

                Still a comment

            Now the comment is closed*/

        }
    }
}
