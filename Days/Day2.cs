using System;
using System.IO;

namespace Days
{
    public class Day2
    {
        public static void Run()
        {
            string line = File.ReadAllText("Inputs/inp2.txt");
            if (string.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine("Cannot Find input");
                return;
            }

            long totalSum = 0;

            // deler opp ranges på komma
            string[] ranges = line.Split(',', StringSplitOptions.RemoveEmptyEntries);

            foreach (string range in ranges)
            {
                // Hver range er på formen "start-end"
                string[] parts = range.Split('-');
                if (parts.Length != 2)
                    continue;
                
                long start = long.Parse(parts[0]);
                long end = long.Parse(parts[1]);

                for (long id = start; id <= end; id++)
                {
                    if (IsInvalidId(id))
                    {
                        totalSum += id;
                    }
                }

            }
            Console.WriteLine(totalSum);
        }

        // Ugyldig ID = noen siffersekvens gjentatt to ganger
        static bool IsInvalidId(long id)
        {
            string s = id.ToString();

            // Må ha partall lengde
            if (s.Length %2 !=0)
                return false;
            
            int half = s.Length / 2;

            for (int i = 0; i<half; i++)
            {
                if (s[i] != s[i+half])
                    return false;
            }
            return true;
        }
    }
}
