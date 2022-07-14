// Задача доп.

//Console.Write("Введите число m - ");
//int m = int.Parse(Console.ReadLine());
//Console.Write("Введите число n - ");
//int n = int.Parse(Console.ReadLine());
int m = 4;
int n = 3;
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

void dop(int[,] imas){
    bool flagUP = true;
    bool flagDOWN = true;
    for(int i = 0; i<imas.GetLength(1);i++)
    {
        flagDOWN = true;
        flagUP = true;
        for(int j = 0; j<imas.GetLength(0)-1;j++)
        {
            if(imas[j,i]<imas[j+1,i])
                flagDOWN = false;
            if(imas[j,i]>imas[j+1,i])
                flagUP = false;
        }
        if(flagDOWN == true)
            Console.Write("Down ");
        else if(flagUP == true)
            Console.Write("UP ");
        else
            Console.Write("- ");
        
    }
    Console.WriteLine();
}


dop(initM(m,n));