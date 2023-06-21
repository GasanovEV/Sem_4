int A = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");
int result = CountNumber(A);

Console.WriteLine($"{A} -> {result}");
///////////////////////////////////////

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);
    }
}

int CountNumber(int number)
{
    int i = 0;

    while (number > 0)
    {
        number = number / 10;
        i++;
    }
    return i;
}