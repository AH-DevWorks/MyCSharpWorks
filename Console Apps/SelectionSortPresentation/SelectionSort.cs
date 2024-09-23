namespace SelectionSortPresentation;

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

        SelectionSort_Smallest(ref sortArray);  // 選擇排序法（由小到大）

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
    
    static void SelectionSort_Smallest(ref int[] sourceArray)
    {
        // 外迴圈控制目前陣列最前端的索引值(minIndex)
        for(int i = 0; i < (sourceArray.Length - 1); i++)
        {
            int minIndex = i;

            // 內迴圈檢查陣列內尚未排序之最小資料的索引值
            // 若minIndex指向的資料數值＞尚未排序之陣列範圍內最小資料，則改變minIndex
            for(int j = i + 1; j < sourceArray.Length; j++)
            {
                if(sourceArray[minIndex] > sourceArray[j]) minIndex = j;
            }
            
            // 若尚未排序之陣列內最小資料不在最前端，則交換位置
            if(minIndex != i)
            {
                int temp = sourceArray[minIndex];
                sourceArray[minIndex] = sourceArray[i];
                sourceArray[i] = temp;
            }

            ShowArray(sourceArray,$"\nRound {i+1}");    // 顯示每次大循環之結果
        }
    }
}
