using System;

class EntryPoint
{
    static void Main()
    {
        string fruit = "Strawberry";
        string juice = "Juice";
        int dollarSigns = 10000;

        Console.WriteLine("{0, 10}", fruit);
        Console.WriteLine("{0, 10}", juice);
        //Esentially says place the last character on the 10th place in the console
        //works with the strings directly with the brackets e.g ("{0, 10}", "Strawberry") althought using variable is recommended
        Console.WriteLine($"{fruit, 20}");
        Console.WriteLine($"{juice, 20}");
        //string interpolation is the prefered method of align string outputs
        Console.WriteLine($"{dollarSigns, 15:C}");
        //putting :C formats it into currency, can place numbers after C to specify how many decimal points you want
        //but it will still round to 2 decimal places (float has 7 digits, double can be used for larger number)
        //below is output challenge

        string lineBreak = "";
        string horizontalSeperator = new string('=', 22);
        //can use header.length to keep constant seperator, but alignment with interpolation require constant values
        string verticalSeperator = "|";
        string header = "Protein Intake Week: ";
        string total = "Total: ";
        int weekNumber = 1;
        float day1 = 80.88557f;
        float day2 = 94.56465f;
        float day3 = 78.67893f;
        float day4 = 88.66654f;
        float day5 = 88.6466f;
        float day6 = 76.777f;
        float day7 = 91.85759f;
        float totalNumber = day1+ day2+ day3+ day4 +day5 +day6 +day7;

        Console.WriteLine(verticalSeperator + header + weekNumber + verticalSeperator);
        Console.WriteLine(verticalSeperator + horizontalSeperator + verticalSeperator);
        Console.WriteLine(verticalSeperator + day1 + verticalSeperator);
        Console.WriteLine(verticalSeperator + day2 + verticalSeperator);
        Console.WriteLine(verticalSeperator + day3 + verticalSeperator);
        Console.WriteLine(verticalSeperator + day4 + verticalSeperator);
        Console.WriteLine(verticalSeperator + day5 + verticalSeperator);
        Console.WriteLine(verticalSeperator + day6 + verticalSeperator);
        Console.WriteLine(verticalSeperator + day7 + verticalSeperator);
        Console.WriteLine(verticalSeperator + horizontalSeperator + verticalSeperator);
        Console.WriteLine(verticalSeperator + total + totalNumber +verticalSeperator);
        Console.WriteLine(lineBreak);

        Console.WriteLine(verticalSeperator + header + weekNumber + verticalSeperator);
        Console.WriteLine(verticalSeperator + horizontalSeperator + verticalSeperator);
        Console.WriteLine($"{verticalSeperator}{day1, 22}{verticalSeperator}");
        Console.WriteLine($"{verticalSeperator}{day2,22}{verticalSeperator}");
        Console.WriteLine($"{verticalSeperator}{day3,22}{verticalSeperator}");
        Console.WriteLine($"{verticalSeperator}{day4,22}{verticalSeperator}");
        Console.WriteLine($"{verticalSeperator}{day5,22}{verticalSeperator}");
        Console.WriteLine($"{verticalSeperator}{day6,22}{verticalSeperator}");
        Console.WriteLine($"{verticalSeperator}{day7,22}{verticalSeperator}");
        Console.WriteLine(verticalSeperator + horizontalSeperator + verticalSeperator);
        Console.WriteLine($"{verticalSeperator}{total}{totalNumber,15}{verticalSeperator}");
    }
}