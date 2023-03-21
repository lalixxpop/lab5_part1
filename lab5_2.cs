using System;
using System.Text;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        //task 6
        StringBuilder sb = new StringBuilder();
        string input;

        do
        {
            Console.Write("Введите строку (или пустую строку для завершения): ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                string[] words = input.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        char[] charArray = words[i].ToCharArray();
                        Array.Reverse(charArray);
                        sb.Append(new string(charArray));
                    }
                    else if (i % 2 == 0)
                    {
                        sb.Append(words[i]);
                    }
                    if (i != words.Length - 1)
                    {
                        sb.Append(' ');
                    }
                }
                sb.Append(". ");
            }
        } while (!string.IsNullOrEmpty(input));

        Console.WriteLine("Результирующий текст:");
        Console.WriteLine(sb.ToString());

        //task7
        string input3 = "Киев Нью-Йорк Амстердам Вена Мельбурн";
        string[] words1 = input3.Split(' ');
        StringBuilder s = new StringBuilder();
        sb.Append(words1[0]);
        words1[0] = "";

        while (words1.Any(w => w != ""))
        {
            string lastChar = s[s.Length - 1].ToString();
            string nextWord = words1.FirstOrDefault(w => w.StartsWith(lastChar, StringComparison.OrdinalIgnoreCase));
            if (nextWord != null)
            {
                sb.Append(' ');
                sb.Append(nextWord);
                words1[Array.IndexOf(words1, nextWord)] = "";
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(sb.ToString());

    }
}

