//  Homework 5 Task 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.  [3 7 22 2 78] -> 76 

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
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
Console.WriteLine(string.Join(", ", arr));// вывод исходного массива
