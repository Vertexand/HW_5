//  Homework 5 Task 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.  [3 7 22 2 78] -> 76 


double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)//1 var
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}
double[] arr = FillArrayWithRandomNumbers(5, -10, 12);
Console.WriteLine(string.Join(", ", arr));

double max = arr[0];
double min = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
}
Console.WriteLine($"разница между макс. и мин. элементами массива = {max - min}");





// double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)//мечта
// {
//     double[] array = new double[size];
//     Random random = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = random.Next(leftRange, rightRange + 1);
//     }
//     return array;
// }
// double[] arr = FillArrayWithRandomNumbers(5, -10, 12);
// Console.WriteLine(string.Join(", ", arr));

// double Max = arr[0];
// for (int i = 1; i < arr.Length; i++)
// {
//     if (arr[i] > Max)// это цикл
//     {
//         Max = arr[i];
//     else
//         {
//             double Min = arr[i]; //как  сделать чтобы сработал только раз
//         }
//     }
//     else if (arr[i] < Min;)    // и это цикл
//     {
//     Min = arr[i];   // скобки ?
// }
// Console.WriteLine($"разница между макс. и мин. элементами массива = {Max - Min}");
// }

















