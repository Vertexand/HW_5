// homework 5 Задача 35: Задайте одномерный массив из 123 случайных чисел. (№32,33) Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99]. Пример для массива из 5, а не 123 элементов. В своём решении сделайте 
// для 123 [5, 18, 123, 6, 2] -> 1  [1, 2, 3, 6, 2] -> 0  [10, 11, 12, 13, 14] -> 5 


int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}
int[] arr = FillArrayWithRandomNumbers(123, 1, 124);
Console.WriteLine(string.Join(", ", arr));// вывод исходного массива

// void ColOfArrayElements(123, 10, 100); //(int[] array)
int[] array =  FillArrayWithRandomNumbers(123, 10, 100); //(int[] array)
int col = 0;
{
    for (int i = 0; i < arr.Length; i++)
    {
        // array[i] =  arr(10, 100);
        // if (10 < array[i] < 100)
            col += 1;
    }
}
Console.WriteLine($"Всего элементов массива из отрезка [10,99] = {col}");



// int[] array = FillArrayWithRandomNumbers(123, 10, 100);// вар
// // int[] array = arr;
// int col = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     // 10 < array[i] <100;
//     // // int[] array = FillArrayWithRandomNumbers(123, 10, 100);
//             col += 1;
// }
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine($"Всего элементов массива из отрезка [10,99] = {col}");


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]  cem 5 cek 1.17 

// int[] arr = FillArrayWithRandomNumbers(10, -10, 10);
// Console.WriteLine(string.Join(", ", arr));// вывод исходного массива
// SwapSignOfArrayElements(arr);
// Console.WriteLine(string.Join(", ", arr));//вывод результир массива

// int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange) //длина массива, границы для рандомного значения
// {                //заполнить массива случ образом -  метод
//     int[] array = new int[size];
//     Random random = new Random();//выделим память под random 1 раз 
//    // тип данных Ran, перемен ran
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = random.Next(leftRange, rightRange + 1); //
//     }
//     return array;
// }
// void SwapSignOfArrayElements(int[] array) //менять знак из множ элем, так только с массивами не с обычн числ
// {
//     for(int i=0; i<array.Length; i++)
//     {
//         array[i] = -array[i];// array[i] = array[i]*-1;
//     }
// // } 

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// 4; массив [6, 7, 19, 345, 3] -> нет  3; массив [6, 7, 19, 345, 3] -> да  ТОЛЬКО ОДИН РАЗ 

// int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange) //длина массива, границы для рандомного значения
// {
//     int[] array = new int[size];
//     Random random = new Random();//выделим память под random 1 раз 
//     // тип данных Ran, перемен ran
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = random.Next(leftRange, rightRange + 1); //
//     }
//     return array;
// }
// int[] arr = FillArrayWithRandomNumbers(10, -10, 10);
// Console.WriteLine(string.Join(", ", arr));// вывод исходного массива
// Console.WriteLine("какое число должно встретиться?");
// int number = Convert.ToInt32(Console.ReadLine());
// bool result = IsNumberInArray(arr, number);
// if(result==true)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// bool IsNumberInArray(int[] array, int findNumber)  //так назвали method
// // bool a = true;
// // a = false;
// {
//     bool flag = false; // т.е элем нет, иначе true
//     for(int i=0; i<array.Length; i++)
//     {
//         if (array[i] == findNumber)
//         {
//             flag=true; //искомый эл найден
//             break;
//         }
//     }
//     return flag;
// }
