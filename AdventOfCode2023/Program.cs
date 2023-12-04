using AdventOfCode2023.Day1;
using System.IO;

String line;

try
{
  int sum = 0;
  StreamReader sr = new StreamReader("./input.txt");
  line = sr.ReadLine();
  while (line != null)
  {
    Decoder LineDecoder = new($"{line}");
    LineDecoder.CleanValues();
    sum += Convert.ToInt32(LineDecoder.FinalCoords);
    line = sr.ReadLine();
  }
  sr.Close();
  Console.WriteLine(sum);
  Console.ReadLine();
}
catch (Exception e)
{
  Console.WriteLine("Exception: " + e.Message);
}
finally
{
  Console.WriteLine("Executing Finally block.");
}
