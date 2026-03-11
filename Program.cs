using System;
using System.Collections.Generic;

class Program
{
    public static int MestFrekventSiffra(int[] arr)
    {
        // Steg 1: Räkna hur många gånger varje siffra förekommer
        Dictionary<int, int> räknare = new Dictionary<int, int>();

        foreach (int tal in arr)
        {
            if (räknare.ContainsKey(tal))
            {
                räknare[tal]++;
            }
            else
            {
                räknare[tal] = 1;
            }
        }

        // Steg 2: Hitta siffran med högst frekvens
        int bästaSiffra = int.MaxValue;
        int högstaFrekvens = 0;

        foreach (KeyValuePair<int, int> post in räknare)
        {
            // Om högre frekvens ELLER lika frekvens men lägre siffra
            if (post.Value > högstaFrekvens ||
               (post.Value == högstaFrekvens && post.Key < bästaSiffra))
            {
                högstaFrekvens = post.Value;
                bästaSiffra = post.Key;
            }
        }

        return bästaSiffra;
    }

    static void Main()
    {
        // Test 1 
        Console.WriteLine(MestFrekventSiffra(new int[] { 1, 3, 2, 3, 4, 1, 3, 2, 2, 2, 5 }));

        // Test 2 
        Console.WriteLine(MestFrekventSiffra(new int[] { 7, 7, 5, 5, 1, 1, 1, 2, 2, 2 }));

        // Test 3 - negativa tal
        Console.WriteLine(MestFrekventSiffra(new int[] { -1, -1, -2 })); 
    }
}

