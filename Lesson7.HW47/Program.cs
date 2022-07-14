// Задача 47
Console.WriteLine("Задача 47");
Console.Write("Введите число m - ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n - ");
int n = int.Parse(Console.ReadLine());
double[,] initM (int m,int n){
    double[,] mas = new double[m,n];
    Random rnd = new Random();
    for(int i = 0; i<m;i++)
    {
        for(int j = 0; j<n;j++)
        {
            mas[i,j] = (double)((int)((rnd.NextDouble()-0.5)*100))/10;
            Console.Write(mas[i,j] + " ");
        }
        Console.WriteLine();
    }
    return mas;
}


initM(m,n);