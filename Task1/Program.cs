// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

// int[] array = new int[4];
// int[] array1 = new int[4] { -4, 3, 4, 1};



int[] array = { -4, 3, 4, 1 };
int num = 3;

bool isExistNum = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        isExistNum = true;
        break;
    }
}
string result = isExistNum ? "Да" : "Нет";
Console.WriteLine(result);