namespace BubbleSortPresentation;

class Program
{
    static void Main(string[] args)
    {
        const int ArraySize = 5;

        int[] oriArray = new int[ArraySize];
        Console.WriteLine($"Input {ArraySize} numbers:");
        
        // 使用者輸入原始陣列資料(int)
        for(int i = 0; i < ArraySize;)
        {
            // 限制使用者僅能輸入整數數字
            if(int.TryParse(Console.ReadLine(),out int k))
            {
                oriArray[i] = k;
                i++;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
        Console.WriteLine();
        ShowArray(oriArray, "Original Array");  // 顯示原始資料

        int[] sortArray = new int[ArraySize];
        Array.Copy(oriArray, sortArray, ArraySize); // 複製一陣列用於BubbleSort

        BubbleSort(ref sortArray);  // 氣泡排序法

        Console.WriteLine();
        ShowArray(sortArray, "Sorted Array");   // 顯示最後排序完畢之資料
    }
    
    static void ShowArray(int[] array, string msg)
    {
        Console.Write($"{msg}:\n[");
        for(int j = 0; j < array.Length ; j++)
        {
            Console.Write($"{array[j]}, ");
            if(j == array.Length - 1) Console.Write("\b\b]");
        }
    }
    
    static void BubbleSort(ref int[] sourceArray)
    {
        // 外迴圈控制循環數
        for(int i = 1; i < sourceArray.Length; i++)
        {
            // 內迴圈控制每循環內相鄰兩數比較
            for(int j = 0; j < (sourceArray.Length -i); j++)
            {
                // 若左側值>右側值，兩數交換
                if(sourceArray[j] > sourceArray[j + 1])
                {
                    int temp = sourceArray[j];
                    sourceArray[j] = sourceArray[j + 1];
                    sourceArray[j + 1] = temp;
                }
            }
            ShowArray(sourceArray, $"\n第{i}次循環");   // 顯示每次大循環之結果
        }
    }
}
