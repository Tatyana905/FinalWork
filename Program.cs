Console.WriteLine("Введите данные через пробел");
string[] Array = Console.ReadLine().Split(' ').ToArray();
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3) count++;
}
string[] result = new string[count];
for (int i = 0; i < result.Length; i++)
{
    for (int j = 0; j < Array.Length; j++)
    {
        if (Array[j].Length <= 3 && Array[j] != string.Empty)
        {
            result[i] = Array[j];
            Array[j] = string.Empty;
            break;
        }
    }
    Console.Write($"{result[i]} ");
}