using System;
using System.IO;

public static class Des1
{
    public static void Run()
    {
        string[] lines = File.ReadAllLines("input.txt");

        int position = 50;
        int zeroCount = 0;

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            char dir = line[0]; // L eller R
            int steps = int.Parse(line[1..]);
            int m = steps % 100;

            if (dir == 'R')
            {
                position = (position + m) % 100;
            }
            else if (dir == 'L')
            {
                position = position - m;
                if (position < 0)
                    position += 100;
            }
            if (position == 0)
                zeroCount++;
        }
        Console.WriteLine($"Passordet er: {zeroCount}");
    }
}