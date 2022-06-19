//Написать программу,которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello","2","world",":-)"]->["2",":-)"]
// ["1234","1567","-2","computer science",] ->["-2"]
// ["Russia","Denmark","Kazan",] ->[]


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





