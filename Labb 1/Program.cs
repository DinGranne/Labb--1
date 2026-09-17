using System.Numerics;
Console.WriteLine("Mata in en text:");
string text = Console.ReadLine() ?? "";
BigInteger total = 0;
for (int i = 0; i < text.Length; i++)
{
    if (char.IsDigit(text[i]))
    {
        for (int j = i + 1; j < text.Length; j++)
        {
            if (!char.IsDigit(text[j]))
            {
                break;
            }

            if (text[i] == text[j])
            {
                string fore = text.Substring(0, i);
                string hittatTal = text.Substring(i, j - i + 1);
                string efter = text.Substring(j + 1);
                total += BigInteger.Parse(hittatTal);
                Console.Write(fore);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(hittatTal);
                Console.ResetColor();

                Console.WriteLine(efter);

                break;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Total = " + total);