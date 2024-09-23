namespace InsertionSortPresentation;

class Program
{
    static void Main(string[] args)
    {
        const int ArraySize = 7;

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
        Array.Copy(oriArray, sortArray, ArraySize); // 複製一陣列用於SelectionSort

        InsertionSort(ref sortArray);  // 插入排序法

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
    
    static void InsertionSort(ref int[] sourceArray)
    {
        // 迴圈控制目前陣列最前端的索引值(minIndex)
        // 第一筆資料(0)預設已定位，故i從1開始
        for(int i = 1; i < sourceArray.Length; i++)
        {
            int j = i;

            // 把未排序的第一筆資料往前依序跟已排序的各資料進行比較，直到插入至正確位置
            // 將j > 0寫在運算子&&前面，避免sourceArray[j-1]導致IndexOutOfRangeException錯誤
            while(j > 0 && sourceArray[j - 1] > sourceArray[j]) 
            {
                int temp = sourceArray[j];
                sourceArray[j] = sourceArray[j - 1];
                sourceArray[j - 1] = temp;
                j--;  // 持續往前比較到已排序的第一筆資料為止
            }
            ShowArray(sourceArray,$"\nRound {i}");    // 顯示每次大循環之結果
        }
    }
}
