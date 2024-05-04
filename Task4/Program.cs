// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

int num;
Console.WriteLine("Введите трехзначное число:");
num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];
int index = array.Length - 1;

while (num != 0)
{
    array[index] = num % 10;
    num /= 10;
    index--;
}
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
