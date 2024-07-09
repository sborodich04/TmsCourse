using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

static void task1(string text)
{
    string[] str = text.Split(' ');
    int Max = 0;
    int Index = 0;
    for (int i = 0; i < str.Length; i++)
    {
        int currmax = 0;
        for (int k = 0; k < str[i].Length; k++)
        {
            if (char.IsNumber(str[i][k]))
            {
                currmax++;

            }
        }
        if (currmax > Max)
        {
            Max = currmax;
            Index = i;
        }
    }
    Console.WriteLine("Наибольше цифр в слове " + str[Index]);
    Console.ReadKey(true);
}

static void task2(string text)
{
    string[] words = text.Split(new string[] { " ", "\r\n", "\t" }, StringSplitOptions.RemoveEmptyEntries);
    string maxlength = "";
    for (int i = 0; i < words.Length; i++)
        if (maxlength.Length < words[i].Length) maxlength = words[i];

    int count = 0;
    foreach (string x in words)
    {
        if (x == maxlength) ++count;
    }
    Console.WriteLine("Самое длинное слово: {0}\nПовторяется: {1}", maxlength, count);
    Console.ReadKey(true);
}

static void task3(string text)
{
    string[] str = text.Split(' ');
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == "0") str[i] = "ноль";
        else if (str[i] == "1") str[i] = "один";
        else if (str[i] == "2") str[i] = "два";
        else if (str[i] == "3") str[i] = "три";
        else if (str[i] == "4") str[i] = "четыре";
        else if (str[i] == "5") str[i] = "пять";
        else if (str[i] == "6") str[i] = "шесть";
        else if (str[i] == "7") str[i] = "семь";
        else if (str[i] == "8") str[i] = "восемь";
        else if (str[i] == "9") str[i] = "девять";
    }
    string result = string.Join(' ', str);
    Console.WriteLine(result);
    Console.ReadKey(true);
}

static void task4(string text)
{
    var str = text;
    var pattern1 = @"[^\.\?\!][\w ]+\?";
    var pattern2 = @"[^\.\?\!][\w ]+\!";
    var matches1 = Regex.Matches(str, pattern1);
    var matches2 = Regex.Matches(str, pattern2);
    foreach (Match item in matches1) Console.WriteLine(item.ToString().TrimStart());
    foreach (Match item in matches2) Console.WriteLine(item.ToString().TrimStart());
    Console.ReadKey(true);
}

static void task5(string text)
{
    string[] sentences = text.Split(new[] { '.', '!', '?' });
    foreach (string sentence in sentences)
    {
        if (!sentence.Contains(','))
            Console.WriteLine(sentence.Trim());
    }
    Console.ReadKey(true);
}

static void task6(string text)
{
    foreach (Match match in Regex.Matches(text, @"\b([A-zА-яЁё])[A-zА-яЁё]+?\1\b")) Console.WriteLine(match.Value);
    Console.ReadKey(true);
}
 
string path = "C:\\Users\\USER\\Desktop\\TmsCourse.txt";
string text = File.ReadAllText(path);
bool @try = true;
while (@try)
{
    Console.WriteLine("Make a choice: \n" + "1. Fing word with max number\n" + "2. Find the longest word and determine how many times it appears in the text\n" + "3. Replace the numbers from 0 to 9 with the words “zero”, “one”, ..., “nine”.\n" + "4. Display first interrogative and then exclamatory sentences..\n" + "5. Display only sentences that do not contain commas.\n" + "6. Find words starting and ending with the same letter.\n" + "7. Exit\n");
    int menu = Convert.ToInt32(Console.ReadLine());
    switch (menu)
    {
        case 1:
            task1(text);
            break;
        case 2:
            task2(text);
            break;
        case 3:
            task3(text);
            break;
        case 4:
            task4(text);
            break;
        case 5:
            task5(text);
            break;
        case 6:
            task6(text);
            break;
        case 7:
            @try = false;
            break;
    }
}
