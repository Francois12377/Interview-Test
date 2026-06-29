using System.Text.RegularExpressions;

int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
string display = "";

for (int i = 1; i <= 3999; i++)
{
    int Num = i;
    for (int j = 0; j < numbers.Length; j++)
    {

        while (Num >= numbers[j])
        {
            Num -= numbers[j];
            display += roman[j];
        }
    }
    Console.WriteLine(display);
    display = "";
}
;

Console.WriteLine("Enter the ROMAN number you want to convert...");
string input = Console.ReadLine();
int output = 0;

string pattern = @"^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";


if (Regex.IsMatch(input, pattern))
{


    for (int i = 0; i < input.Length; i++)
    {
        char I = input[i];
        try
        {
            string II = input.Substring(i, 2);

            if (roman.Contains(II))
            {
                output += numbers[roman.IndexOf(II)];
                i += 1;
            }
            else
            {
                output += numbers[roman.IndexOf(I.ToString())];
            }
        }
        catch
        {
            output += numbers[roman.IndexOf(I.ToString())];
        }
    }

    Console.WriteLine(output);
}
else
{
    Console.WriteLine("Invalid Numeral \n Must be between 0 and 3999 \n Cannot have more than 3 symbols of same type (IIII, XXXX) \n" +
        "a single 'C' may precede only 'D' or 'M' \n" +
        "a single 'X' may precede only 'L' or 'C' \n " +
        "a single 'I' may precede only 'X' or 'V'");
}
