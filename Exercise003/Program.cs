int A = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");
int result = ProdNumbers(A);
Console.WriteLine($"{A} -> {result}");
////////////////////
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

int ProdNumbers(int number)
{
    int prod = 1;
    while (number > 0)
    {
        prod *= number;
        number--;
    }
    return prod;
}

/*Console.Write("[");
int count = 0;
while (count < 7)
{
    count++;
    Console.Write(new Random().Next(0,2));
    Console.Write(", ");
}
Console.Write(new Random().Next(0,2));
Console.WriteLine("]");*/



//////////////////////
/*
Console.Clear();
int[] RandomArray = new int[8];

ArrayRand(RandomArray);

Write(RandomArray);



void ArrayRand(int[] RandomArray)
{
for (int i = 0; i < RandomArray.Length; i++)
  {
    RandomArray[i] = Rand(0,2);
  }
  
}


int Rand(int a,int b)
{
  return new Random().Next(a, b);
}

void Write(int[] RandomArray)
{
  Console.Write("{");
  for (int i = 0; i < RandomArray.Length; i++)
  {
    if (i + 1 == RandomArray.Length)
    {
      Console.Write($"{RandomArray[i]}");
    }
    else
    {
      Console.Write($"{RandomArray[i]}, ");
    }
  }
  Console.Write("}");
}*/