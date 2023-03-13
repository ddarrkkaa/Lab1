using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
/////////////////////////////////////////////////////////////////////////1
/*
class Program
{
    static void Main()
    {
        string filePath = @"C:\кпи\ОП\toLab1.txt";

        List<char> charList = ReadFile(filePath);

        int vowelCount = CountVowels(charList);
        int consonantCount = CountConsonants(charList);

        Console.WriteLine($"Кількість голосних букв: {vowelCount}");
        Console.WriteLine($"Кількість приголосних букв: {consonantCount}");
    }

    static List<char> ReadFile(string filePath)
    {
        List<char> charList = new List<char>();
        using (StreamReader reader = new StreamReader(filePath))
        {
            do
            {
                string line = reader.ReadLine();
                foreach (char c in line)
                {
                    charList.Add(c);
                }
            }
            while (!reader.EndOfStream);
        }
        return charList;
    }

    static int CountVowels(List<char> list)
    {
        int count = 0;
        string vowels = "УуЕеЇїІіАаОоЄєЯяИиЮю";

        foreach (char item in list)
        {
            if (vowels.Contains(item.ToString()))
            {
                count++;
            }
        }

        return count;
    }

    static int CountConsonants(List<char> list)
    {
        int count = 0;
        string consonants = "ЙйЦцКкНнГгШшЩщЗзХхФфВвПпРрЛлДдЖжЧчМмТтБб";

        foreach (char item in list)
        {
            if (consonants.Contains(item.ToString()))
            {
                count++;
            }
        }
        return count;
    }
}
*/


/////////////////////////////////////////////////////////////////////////2
/*
class Program
{
    public static void Main(string[] args)
    {

        List<KeyValuePair<string, string>> inputList = new List<KeyValuePair<string, string>>() 
        {
            new KeyValuePair<string, string>("V", "S001"),
            new KeyValuePair<string, string>("V", "S002"),
            new KeyValuePair<string, string>("VI", "S001"),
            new KeyValuePair<string, string>("VI", "S005"),
            new KeyValuePair<string, string>("VII", "S005"),
            new KeyValuePair<string, string>("V", "S009"),
            new KeyValuePair<string, string>("VIII", "S007")
        };

        HashSet<string> uniqueValues = new HashSet<string>(); //унікальні значення 

        foreach (var item in inputList)
        {
            uniqueValues.Add(item.Value);
        }

        Console.WriteLine("UniqueValues: {" + string.Join(", ", uniqueValues) + "}");

        string result = JsonConvert.SerializeObject(uniqueValues);
        string filePath2 = @"C:\кпи\ОП\toLab1(2).txt";

        File.WriteAllText(filePath2, result);
    }
}
*/


/////////////////////////////////////////////////////////////////////////3
/*
class Program
{    
    static void Main()
    {
        Random random= new Random();
        int D = random.Next(-10,10);
        Console.WriteLine("The number: " + D);

        int[] A = Enumerable.Range(1, 20).ToArray();               
        foreach (int num in A)
        {
            Console.WriteLine(num);
        }
        var selectedNumb = from p in A
                             where p.ToString().EndsWith(D.ToString())
                             select p;
        
        List<int> Numbers = new List<int>();
        foreach (int c in selectedNumb)
        {
            Numbers.Add(c);
        }
        if(Numbers.Count > 0)
        {
            Console.WriteLine("The answer: " + Numbers[0]);
        }
        else
            Console.WriteLine("The answer: 0");
    }  
}
*/
