// Задача:
// Задать массис из N положительных чисел 
// и найти в нем сумму двузначных элементов

int[] elements = new int[10];
int sum = 0;
int index = 0;
int length = elements.Length;

while (index < length)
{
    int current = Random.Shared.Next(30);
    elements[index] = current;
    Console.WriteLine(elements[index]);

    if (current >= 10 && current <= 99)
    {
        sum = sum + current;
    }
    index = index + 1;
}

Console.WriteLine("---");
Console.WriteLine(sum);
