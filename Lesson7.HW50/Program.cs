// Задача 50

Console.WriteLine("Задача 50");

int m = 3;
int n = 4;
int[,] initM (int m,int n){
    int[,] mas = new int[m,n];
    Random rnd = new Random();
    for(int i = 0; i<m;i++)
    {
        for(int j = 0; j<n;j++)
        {
            mas[i,j] = (int)(rnd.NextDouble()*10);
            Console.Write(mas[i,j] + " ");
        }
        Console.WriteLine();
    }
    return mas;
}

int[,] mas = initM(m,n);
Console.WriteLine("Внимание! Нумерация строк и столбцов с 0");
Console.Write("Введите число x - ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите число y - ");
int y = int.Parse(Console.ReadLine());

if((0<=x)&&(x<=m)&&(0<=y)&&(y<=n))
{
    Console.WriteLine("Элемент "+ x + ":"+ y + " равен "+mas[x,y]);
}
else
    Console.WriteLine("Такой элемент не существует");

