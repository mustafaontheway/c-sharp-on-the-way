sbyte[] posOrNeg = {12, -5, 4, -7, 11, -3, 9};

int i = 0;

while (i < posOrNeg.Length)
{
    if (posOrNeg[i] > 0)
    {
        System.Console.WriteLine($"Positive value: {posOrNeg[i]}");
    }

    i++;
}

// Positive value: 12
// Positive value: 4
// Positive value: 11
// Positive value: 9
