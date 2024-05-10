using System;
using System.IO;

namespace FilePower2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if the filename argument is provided
            if (args.Length != 2 || args[0] != "--file")
            {
                Console.WriteLine("Usage: dotnet run --project FilePower1 -- --file <filename>");
                return;
            }

            // Get the filename from command-line arguments
            string filename = args[1];

            // Read user input and write directly to the file
            Console.WriteLine("Enter strings (empty string to stop):");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                while (true)
                {
                    string input = Console.ReadLine();

                    // Break the loop if the user enters an empty string
                    if (string.IsNullOrEmpty(input))
                        break;

                    // Write the input string to the file
                    writer.WriteLine(input);
                }
            }

            Console.WriteLine("Strings written to file successfully.");
        }
    }
}
