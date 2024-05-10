using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
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

            // Create a queue to store strings
            Queue<string> stringQueue = new Queue<string>();

            // Read user input in a loop
            Console.WriteLine("Enter strings (empty string to stop):");
            while (true)
            {
                string input = Console.ReadLine();

                // Break the loop if the user enters an empty string
                if (string.IsNullOrEmpty(input))
                    break;

                // Add the input string to the queue
                stringQueue.Enqueue(input);
            }

            // Write strings from the queue to the file
            WriteStringsToFile(filename, stringQueue);

            Console.WriteLine("Strings written to file successfully.");
        }

        static void WriteStringsToFile(string filename, Queue<string> stringQueue)
        {
            // Write strings from the queue to the file
            using (StreamWriter writer = new StreamWriter(filename))
            {
                while (stringQueue.Count > 0)
                {
                    writer.WriteLine(stringQueue.Dequeue());
                }
            }
        }
    }
}
