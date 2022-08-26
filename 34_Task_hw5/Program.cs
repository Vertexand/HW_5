// Задача 34: Задайте массив, заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве. [345, 897, 568, 234] -> 2 

int[] array = new int[6];
int col = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    col+=1;

}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"кол-во чётных чисел в массиве = {col}");

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива. 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма полож чисел равна 29, сумма отр=  -20. 
// int[] array = new int[12];
// int sumPositive = 0;
// int sumNegative = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     if (array[i] > 0)
//     {
//         sumPositive = sumPositive + array[i];
//         // sumPositive += array[i];
//     }
//     else
//     {
//         sumNegative += array[i];
//     }
// }
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine($"сумма полож. эл. массива = {sumPositive}");
// Console.WriteLine($"сумма отр. эл. массива = {sumNegative}");