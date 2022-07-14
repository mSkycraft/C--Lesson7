// Задача 52
int m = 3;
int n = 4;
Random rnd = new Random();

int[,] initmas(int m,int n){
    int[,] imas = new int[m,n];
    for(int i = 0; i<m;i++)
    {
        for(int j = 0; j<n;j++)
        {
            imas[i,j] = rnd.Next(1,10);
            Console.Write(imas[i,j] + " ");
        }
        Console.WriteLine();
    }
    return imas;
}


void sred(int[,] imas){
    Console.Write("Сред.арифметическое по столбцам - ");
    for(int j = 0; j<n;j++)
        {
        int sum = 0;
        for(int i = 0; i<m;i++)
        {   
            sum = sum + imas[i,j];
        }
        Console.Write(sum/m+ "; ");
    }
    Console.WriteLine();
}


sred(initmas(m,n));