namespace MatrixTranspose;

class Program
{
    static void Main(string[] args)
    {
        string msg = "Original:\n[";
        int m , n;
        while(!int.TryParse(Console.ReadLine(),out m))
        {
            continue;
        }
        while(!int.TryParse(Console.ReadLine(),out n))
        {
            continue;
        }
        
        int[,] matrixA = new int[m,n];
        
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n;)
            {
                if(int.TryParse(Console.ReadLine(),out int k))
                {
                    matrixA[i,j] = k;
                    msg += $"{k}";
                    if(j != n - 1) msg += " ";
                    j++;
                }
            }
            msg +="]\n";
            if(i != m - 1) msg+="[";
        }
        msg += "Transpose:\n[";

        int[,] matrixAT = new int[n,m];

        for(int k = 0; k < n; k++)
        {
            for(int l = 0; l < m; l++)
            {
                matrixAT[k,l] += matrixA[l,k];
            }
        }

        for(int p = 0; p < n; p++)
        {
            for(int r = 0; r < m; r++)
            {
                msg += $"{matrixAT[p,r]}";
                if(r != m - 1) msg +=" ";
            }
            msg +="]\n";
            if(p != n - 1) msg+="[";
        }
        Console.WriteLine($"{msg}");
    }
}
