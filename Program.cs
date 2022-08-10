Console.WriteLine("Введите количество элементов строкового массива");
int value = Convert.ToInt32(Console.ReadLine());
string [] headArray = new string [value];
Console.WriteLine("Введите элементы строкового массива");
int count = 0;

for (int i = 0; i < headArray.Length; i++)
{
    headArray[i] = Console.ReadLine();
    if (headArray[i].Length <= 3)
    {
        count++;
    }
}
Console.WriteLine($"Сформированный строковый массив: [{String.Join(" : ", headArray)}]");
Console.WriteLine();
Console.WriteLine($"Количество элементов меньше трех символов равно: {count}");
Console.WriteLine();

string [] newArray = new string [count];
int j = 0;
for (int i = 0; i < headArray.Length; i++)
{
    if (headArray[i].Length <= 3)
    {
        newArray[j] = headArray[i];
         j++;
    }
}
Console.WriteLine($"Сформированный строковый массив: [{String.Join(" : ", newArray)}]");
Console.WriteLine();

