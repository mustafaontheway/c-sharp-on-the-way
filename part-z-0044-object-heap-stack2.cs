// from stack to heap

object searchYear = (short) 2000; // heap data (Reference Type)

short age = 17;

//System.Console.WriteLine($"Birth year: {searchYear - age}"); // Error => Operator '-' cannot be applied to operands of type 'object' and 'byte'

short year = (short) searchYear; // stack data

System.Console.WriteLine($"Birth year: {year - age}"); // Birth year: 1983
