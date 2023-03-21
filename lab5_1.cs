using System;

class Program
{
    static void Main(string[] args)
    {
        //1 task
        //Console.WriteLine("Введите имена, разделенные пробелами:");
        //string input = Console.ReadLine();

        //string[] names = input.Split(' ');

        //Console.WriteLine("Имена, стоящие в алфавитном порядке раньше имени 'Маша':");

        //foreach (string name in names)
        //{
        //  if (name.CompareTo("Маша") < 0)
        // {
        //   Console.WriteLine(name);
        //}

        //2 task
        //Console.Write("Введите строку: ");
        //string input1 = Console.ReadLine();
        //string[] words = input1.Split(' ');
        //for (int i = 0; i < words.Length; i++)
        //{
        //  if (words[i].Length == 4)
        //  {
        //     words[i] = "love_Is";
        //  }
        // }
        //string output = string.Join(" ", words);
        //Console.WriteLine(output);


        //3 task
        //Console.Write("Введите строку: ");
        //string text = Console.ReadLine();
        //Console.Write("Введите количество элементов, через которое будут повторения: ");
        //int n = Convert.ToInt32(Console.ReadLine());
        //for (int i = n; i < text.Length; i += n)
        //{
        //   text = text.Insert(i, ":)");

        // }
        // Console.WriteLine(text);


        //4 task
        //Console.Write("Введите строку: ");
        //string input2 = Console.ReadLine();
        //string[] words = input2.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        //string shortestWord = words[0];
        //string longestWord = words[0];
        //foreach (string word in words)
        //{
        //  if (word.Length < shortestWord.Length)
        // {
        //     shortestWord = word;
        // }
        // if (word.Length > longestWord.Length)
        // {
        //   longestWord = word;
        // }
        // }

        //string result = $"{shortestWord}{new string(',', shortestWord.Length - 1)}," +
        // $"{longestWord}{new string(',', longestWord.Length - 1)}";

        // Console.WriteLine(result); 


        //5 task
        Console.Write("Введите строку: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string uniqueWords = "";
        foreach (string word in words)
        {
            if (!uniqueWords.Contains(word))
            {
                uniqueWords += word + " ";
            }
        }
        uniqueWords = uniqueWords.Trim();
        Console.WriteLine(uniqueWords); 

    }
}
