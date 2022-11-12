Console.Clear();
void InputMatrix(string[] array)
{
    Console.WriteLine("===========================");
       for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Введите {i+1}-ый элемент массива:");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine("===========================");
}

void AutoInputMatrix(string[] array)
{
    string[] example = {"Chita", "Yes", "1234", "Boston", "87", "-3", "23", "Class", "Bus", "Pen", "Police", "GIT", "Fount", "Ten", "Nine", "One", "Two", "Six", "Death", "365", "Status", "World", "Dust"};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = example[new Random().NextInt64(0,example.GetLength(0)-1)];
    }
    Console.WriteLine("===========================");
}
Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] matrix = new string [n];
Console.Write("Вводим массив в ручную? (y/n) ");
string m = Console.ReadLine();
if (m == "y")
    InputMatrix(matrix);
else
    AutoInputMatrix(matrix);
Console.Write("Полученный массив: [");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if(i==0)
    Console.Write(matrix[i]);
    else
    Console.Write("," + matrix[i]);
}
Console.WriteLine("]");
Console.WriteLine("===========================");
n=0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (matrix[i].Length < 4)
    n++;   
}
string[] resalt = new string [n];
n=0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (matrix[i].Length < 4)
    {
        resalt[n]=matrix[i];
        n++;
    }
}
Console.Write("Итоговый массив: [");
for (int i = 0; i < resalt.GetLength(0); i++)
{
    if (i == 0)
        Console.Write(resalt[i]);
    else
        Console.Write("," + resalt[i]);
}
Console.WriteLine("]");
Console.WriteLine("===========================");