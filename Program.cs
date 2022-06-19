








Console.WriteLine("Введите слова через запятую или пробел:  ");
string str = Convert.ToString(Console.ReadLine());
Console.WriteLine("Укажите до какого количества символов нужно вывести из строки:  ");
int simbol = int.Parse(Console.ReadLine());
Console.WriteLine();

void SelectWord(string text, int count)
{
    string[] words = text.Split(',');
    int min = words.Select(words => words.Length).Min();
    min = count;
    foreach (string word in words)
    {
        if (word.Length <= min)
        {
            Console.Write(word + " ");
        }
    }
}
SelectWord(str, simbol);