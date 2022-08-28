// Homework 5 Task 36: Задайте одномерный массив, заполненный случайными числами. (№37)
// Найдите сумму элементов, стоящих на нечётных позициях.  [3, 7, 23, 12] -> 19 
// [-4, -6, 89, 6] -> 0 

int[] array = new int[12];
int sum = 0;

for (int i = 1; i < array.Length; i += 2)
{
    array[i] = new Random().Next(-9, 10);//создали случайн переменую 12 раз
    sum += array[i];
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"сумма элемен. стоящих на нечётных позициях = {sum}");






// cem5 task 37 найти произведение пар чисел в одномерном массиве.Пара - 1-й и последний эл.
// и т.д. результат записать в новом массиве 12345 -> 5 8 3.  6 7 3 6 ->36 21

// int[] arr = { 1, 2, 3, 4, 5 }; //исх масс
// int newLength = arr.Length / 2 + arr.Length % 2;//нов переменная потом создадим нов массив 
// int[] resultArr = new int[newLength];//создаем массив на newLength элементов
// for (int i = 0; i < newLength; i++)
// {
//     resultArr[i] = arr[i] * arr[arr.Length - 1 - i];
// }
// if (arr.Length % 2 == 1)
// {
//     resultArr[resultArr.Length - 1] = arr[arr.Length / 2];//посл эл resultArr записать число с срединным индекс 5/2=2 индекс
// }

// Console.WriteLine(string.Join(", ", resultArr));//выводим резул массив