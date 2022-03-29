// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

int[] WriteArray(int length)
{
    int[] arr = new int[length];
    for(int i = 0; i < arr.Length; i++)
    {
     arr[i] = Prompt($"Введите {i+1}e число из {arr.Length}: ");
    }
    return arr;
}

int[] array = WriteArray(5);
Console.Write($"Вы ввели: ");
PrintArray(array);

int sum = 0;
int sumNeg = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0) sum++;
    if(array[i] < 0) sumNeg++;
}
Console.WriteLine($"Всего положительных чисел: {sum}; отрицательных: {sumNeg}; нулей: {array.Length - (sum+sumNeg)}");