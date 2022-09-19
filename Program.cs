// Из массива строк, формировать другой массив строк, в который брать как элементы только строки с длинной 3 и менее.
// Если длина 0 или больше 3-х, то не брать элементы

int colmas;
while (true)
{
    Console.WriteLine("Введите количество элементов массива строк: ");
    colmas = Convert.ToInt32(Console.ReadLine());
    if (colmas > 0) break;
    else
    {
        Console.WriteLine("Некорректное число! Повторите ввод!");
        Console.WriteLine("Для прерывания программы нажмите `CTRL + C`");
    }
}

string[] UserMasAdd(int lenghtMas)
{
    string[] nowMas = new string[lenghtMas];
    for (int i = 0; i < nowMas.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива:");
        nowMas[i] = Console.ReadLine();
    }
    return nowMas;
}

void PrintArray(string[] res1)
{
    Console.Write($"[ ");
    for (int i = 0; i < res1.Length; i++)
    {
        if (i < res1.Length - 1) Console.Write($"{res1[i]}, ");
        else Console.Write($"{res1[i]} ");
    }
    Console.Write($"]");
}

string[] newUserMas = UserMasAdd(colmas);
PrintArray(newUserMas);

string[] FormattedStringArray(string[] firstMas)
{

    int irow = 0;
    for (int i = 0; i < firstMas.Length; i++)
    {
        if (firstMas[i].Length > 0 && firstMas[i].Length < 4)
            irow++;
    }

    string[] formattedMas = new string[irow];
    int j = 0;
    for (int i = 0; i < firstMas.Length; i++)
    {
        if (firstMas[i].Length > 0 && firstMas[i].Length < 4)
        {
            formattedMas[j] = firstMas[i];
            j++;
        }
    }
    return formattedMas;
}

string[] completeMas = FormattedStringArray(newUserMas);
Console.Write(" -> ");
PrintArray(completeMas);