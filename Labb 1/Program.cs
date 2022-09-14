//string input = "29535123p48723487597645723645";
long output = 0;
int i = 0;
int j = 1;

Console.ForegroundColor = ConsoleColor.White;

Console.Write("Ange ett antal siffror och bokstäver: ");
string input = Console.ReadLine();
for (i = 0; i < input.Length - 1; i++)
{

    for (j = i + 1; j < input.Length; j++)
    {

        if (Char.IsDigit(input[j]))
        {


            if (input[j] == input[i])
            {
                Console.Write(input.Substring(0, i));
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(input.Substring(i, j - i + 1));
                Console.ForegroundColor = ConsoleColor.White;
                
                output += Convert.ToInt64(input.Substring(i, j - i + 1));
                Console.WriteLine(input.Substring(j + 1));
                break;
            }

        }
        else
        {

            break;
        }

    }

}
Console.WriteLine("\n" + "Total = " + output);