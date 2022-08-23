
int x = 1;
Console.Write("Write number N: ");
int y = int.Parse(Console.ReadLine());
for (int z = x; z <= y; z++)
{
    if (z % 2 == 0)
    {
        Console.Write(z + " ");
    }
}
Console.ReadKey();





