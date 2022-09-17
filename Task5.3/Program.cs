// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}
double[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    double[] answer = new double[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.NextDouble()*( maxRandom - minRandom ) + minRandom ;
    }
    return answer;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f2} "+ "\t");
    }
    System.Console.WriteLine();
}
double minArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }

    return min;
}
double maxArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}
const int MIN_ELEMENTS = 0;
const int MAX_ELEMENTS = 100;

int length = Prompt("Введите длину массива > ");
double[] array = GenerateArray(length, MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(array);
double minElementArray = minArray(array);
double maxElementArray = maxArray(array); 
System.Console.WriteLine($"Разность максимального и минимального элементов массива : {(maxElementArray - minElementArray):f2}");
