namespace FlexibleRandomArrayGenerator;

class Program
{
    static void Main(string[] args)
    {
        int[] inputArray = new int[3];
        Console.WriteLine("Plese enter 3 numbers:");
        Console.WriteLine("1) Array Length | 2) Maximum Value | 3) Minimum Value");
        Console.WriteLine("Note: If Max < Min, they will be swapped automatically.");

        UserInput(ref inputArray);

        var outputArray = SetRndNum(inputArray[0], inputArray[1], inputArray[2]);

        ShowArray(outputArray);
    }
    
    static int[] UserInput(ref int[] array)
    {
        for(int i = 0; i < array.Length;)
        {
            bool validNum = int.TryParse(Console.ReadLine(), out int k);
            if(validNum)
            {
                if(i == 0 && k < 0) 
                {
                    Console.WriteLine("Error: Length of the Array must more than 0.");
                    continue;
                }
                array[i] = k;
                i++;
            }
            else 
            {
                Console.WriteLine("Error: Please enter vaild number.");
            }
        }
        return array;
    }

    static int[] SetRndNum(int arrayLength, int Maximum, int Minimum)
    {
        if(Maximum < Minimum)
        {
            int t = Maximum;
            Maximum = Minimum;
            Minimum = t;
        }
        int[] randomArray = new int[arrayLength];
        Random random = new Random();
        for(int m = 0; m < arrayLength; m++)
        {
            randomArray[m] = random.Next(Minimum, Maximum + 1);
        }
        return randomArray;
    }
    
    static void ShowArray(int[] sourceArray)
    {
        Console.Write("The Random Array:\n[");
        for(int n = 0; n < sourceArray.Length; n++)
        {
            Console.Write($"{sourceArray[n]}, ");
        }
        Console.Write("\b\b]");
    }
}
