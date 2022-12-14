// Методы
// 1. Метод создания массива строк
// 2. Метод заполнения массива строк случайными символами
// 3. Метод печати массива строк
// 4. Метод печати двух массивов одинаковой длины рядом
// 5. Метод удаления из массива строк цифр
// 6. Метод подсчета количества пустых строк
// 7. Метод удаления из массива пустых элементов

#region Методы    
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

// 5. Метод удаления из массива строк цифр
string[] RemoveNumbersFromArrayStrings(string[] text)
{
    int size = text.Length;
    string[] result = new string[size];
    int lengthItem = 0;
    for (int i = 0; i < size; i++)
    {
        lengthItem = text[i].Length;
        for (int j = 0; j < lengthItem; j++)
        {
            if (!(text[i][j] >= '0' && text[i][j] <= '9'))
            {
                result[i] += text[i][j];
            }
        }
    }
    return result;
}

// 6. Метод подсчета количества пустых строк
int CountEmptyItems(string[] text)
{
    int count = 0;
    int size = text.Length;
    for (int i = 0; i < size; i++)
    {
        if (text[i] == null)
        {
            count++;
        }
    }
    return count;
}

// 7. Метод удаления из массива пустых элементов
string[] RemoveEmptyItems(string[] text, int countNull)
{
    int size = text.Length;
    string[] result = new string[size - countNull];
    int correctItem = 0;
    for (int i = 0; i < size; i++)
    {
        if (text[i] != null)
        {
            result[i - correctItem] = text[i];
        }
        else correctItem++;
    }
    return result;
}
#endregion Методы

string chars = "abcdefghigklnopqrstuvwxyzFORNDLQCUM1234567890";
string[] text = CreateArrayStrings(7);
FillArrayStrings(text, chars, 4, 12);
string[] result = RemoveNumbersFromArrayStrings(text);
int nullStrings = CountEmptyItems(result);
if (nullStrings > 0)
{
    string[] resultEnd = RemoveEmptyItems(result, nullStrings);
    Console.WriteLine("Исходный массив:");
    PrintArrayStrings(text);
    Console.WriteLine("\nМассив без цифр:");
    PrintArrayStrings(resultEnd);
}
else
{
    Console.WriteLine("Исходный массив -> Массив без цифр");
    Print2ArrayStrings(text, result);
}