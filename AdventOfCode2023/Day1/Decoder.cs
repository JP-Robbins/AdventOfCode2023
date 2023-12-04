namespace AdventOfCode2023.Day1;

public class Decoder(string calibrationValue)
{
    public string? LineData { get; set; }
    public string InputValue = new string(calibrationValue.Where(char.IsDigit).ToArray());
    public int DecodedValue;
    public string StringValue = "";
    public string FinalCoords = "";

    public void CleanValues()
    {
        foreach (char value in InputValue)
        {
            StringValue += value;
        }
        FinalCoords = Convert.ToString(StringValue[0]) + Convert.ToString(StringValue.Last());
    }



}

