// Задача со звездочкой: Заполнить массив четной длины таким образом, чтобы 
// значение элемента массива повторялось ровно 2 раза.
// 1,1,2,3,3,2,4,5,4,5
// или
// 1,1,2,2,4,4,5,5
// или
// 1,2,3,3,2,1

int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number*2;
    }
    throw new Exception("Вы ввели не число");
}
int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length - 1; i+=2)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1);
        answer[i + 1] = answer[i];
    }
    return answer;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}
const int MIN_ELEMENTS = 0;
const int MAX_ELEMENTS = 100;

int length = Prompt("Введите  половину длины массива > ");
int[] array = GenerateArray(length, MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(array);

