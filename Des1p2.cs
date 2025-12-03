using System;
using System.IO;

public static class Des1p2
{
    public static void Run()
    {
        string[] lines = File.ReadAllLines("input1.txt");

        int position = 50;
        long zeroCount = 0; // long i tilfelle veldig mange klikk

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            char dir = line[0]; // L eller R
            int steps = int.Parse(line[1..]);

            int stepDelta = dir == 'R' ? 1 : -1;

            // Simuler hvert klikk
            for (int i = 0; i < steps; i++)
            {
                position = (position + stepDelta + 100) % 100;

                if (position == 0)
                    zeroCount++;
            }
        }

        Console.WriteLine($"Passordet (metode 0x434C49434B) er: {zeroCount}");
    }
}
