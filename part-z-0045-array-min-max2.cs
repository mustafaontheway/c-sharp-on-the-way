byte[] ages = {11, 14, 37, 47, 73, 102, 79};

byte maxAge = 0;

for (var i = ages.Length - 1; i >= 0; i--)
{
    if (ages[i] > maxAge)
    {
        maxAge = ages[i];
    }
}

System.Console.WriteLine($"Max age: {maxAge}"); // Max age: 102
