namespace GryffindorTranscript;

class Program
{
    public enum mgcSubject
    {
        Transformation,
        Potions,
        DADA    //Defense Against Dark Arts
    }
    public enum stdName
    {
        Harry,
        Hermione,
        Ron,
        Neville,
        Luna
    }
    const int subNum = 3;
    const int stdNum = 5;
    const double maxScore = 100;
    const double minScore = 0;

    static void Main(string[] args)
    {
        string msg = $"\n-*-Gryffindor Transcript-*-\n\n";
        double[,] scores = new double[5,3]{
            {85.8, 92.1, 91.9},
            {95, 99.3, 90},
            {70, 62.5, 83.2},
            {65, 75, 70.2},
            {97.3, 88, 80.7}
        };
        
        //Change Enum of StudentName to Array
        var std = new string[stdNum];
        for(int i = 0; i < stdNum ; i++)
        {
            std[i] = $"{Enum.GetName(typeof(stdName), i)}";
        }

        //Find the Best Score and Student of every Subject
        double[] highestScrlist = new double[subNum];
        double hiScr = 0;
        int[] nameMrk1 = new int[stdNum];
        for(int h = 0; h < subNum; h++)  //留意h跟g的意義＆放的位置
        {
            for(int g = 0; g < stdNum; g++)
            {
                if(hiScr < scores[g,h])
                {
                    hiScr = scores[g,h];
                    nameMrk1[h] = g;
                }
            }
            highestScrlist[h] = hiScr;
            hiScr = 0;  //要每一輪重置>>不延續到下一輪
        }
        
        //MSG-Part: Best Score and Student
        msg += $"-*- Best Score and Student -*-\n";
        for(int p = 0; p < subNum; p++)
        {
            msg += $"{Enum.GetName(typeof(mgcSubject), p),-15} : ";         //Subject
            msg += $"{highestScrlist[p],-6} --- ";                          //Best Score of each Subject
            msg += $"{Enum.GetName(typeof(stdName), nameMrk1[p]),-9}\n";    //Stud. who got B.S. on the Sub.
        }

        //Calcualte the Average Score of every student and Rank them
        double[] sum = new double[stdNum];
        double[] avg = new double[stdNum];
        for(int a = 0; a < stdNum; a++)
        {
            for(int b = 0; b < subNum ; b++)
            {
                sum[a] += scores[a,b];
            }
            avg[a] = sum[a] / subNum;
        }
        Array.Sort(avg, std);
        Array.Reverse(avg);
        Array.Reverse(std);
        
        //MSG-Part: Avg. Score and Ranking
        msg += $"\n-*- Average Score and Ranking -*-\n";
        for(int r = 0; r < stdNum; r++)
        {
            msg += $"[{r + 1}] --- ";
            msg += $"{std[r],-9} : ";
            msg += $"{avg[r]:F2}";
            if(avg[r] >= 90) msg += " <Hogwarts 1st-Class Honour>";
            msg += "\n";
        }
        Console.WriteLine(msg);
    }
}

