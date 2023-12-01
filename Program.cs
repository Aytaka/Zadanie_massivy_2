//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

Console.Clear();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 101); 
Console.WriteLine(string.Join(", ", array));

int flag = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0) {
        flag++;
    }
    
}

Console.WriteLine(flag);