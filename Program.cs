// Методы
// 1. Метод создания массива строк
// 2. Метод заполнения массива строк случайными символами
// 3. Метод печати массива строк
// 4. Метод печати двух массивов одинаковой длины рядом

// 1. Метод создания массива строк
string[] CreateArrayStrings(int size)
{
    return new string[size];
}

// 2. Метод заполнения массива строк случайными символами
void FillArrayStrings(string[] text, string selectChar,
                        int lengthItemMin, int lengthItemMax)
{
    int size = text.Length;
    int count = selectChar.Length;
    for (int i = 0; i < size; i++)
    {
        int lengthItem = new Random().Next(lengthItemMin, lengthItemMax + 1);
        for (int j = 0; j < lengthItem; j++)
        {
            text[i] += selectChar[new Random().Next(0, count)];
        }
    }
}

// 3. Метод печати массива строк
void PrintArrayStrings(string[] text)
{
    int size = text.Length;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine(text[i]);
    }
}

// 4. Метод печати двух массивов одинаковой длины рядом
void Print2ArrayStrings(string[] text, string[] text2)
{
    int size = text.Length;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"{text[i],15}{text2[i],19}");
    }
}