namespace MergeSortPresentation;

class Program
{
    static void Main(string[] args)
    {
        List<int> dataList = InputData();
        ShowListMsg(DivideAndConquer(dataList), "Output List");
    }

    static List<int> InputData()
    {
        List<int> inputList = new List<int>();
        int listLength = 0;
        Console.WriteLine("Please enter the list length. (> 0)");
        bool numMoreThanZero = false;
        while (!numMoreThanZero)
        {
            numMoreThanZero = int.TryParse(Console.ReadLine(), out listLength) && listLength > 0;
            if (!numMoreThanZero) Console.WriteLine("Please enter vaild number.");
        }
        Console.WriteLine($"List Length: {listLength}.\n");

        Console.WriteLine("Please enter any integer numbers.");
        for (int i = 0; i < listLength;)
        {
            bool validNumber = int.TryParse(Console.ReadLine(), out int num);
            if (validNumber)
            {
                inputList.Add(num);
                i++;
            }
            else
            {
                Console.WriteLine("Please enter vaild number.");
            }
        }

        ShowListMsg(inputList, "Input List");

        return inputList;
    }

    static List<int> DivideAndConquer(List<int> originalList)
    {
        if (originalList.Count == 1) return originalList;

        int medium = originalList.Count / 2;

        List<int> leftList = new List<int>();
        List<int> rightList = new List<int>();

        for (int i = 0; i < medium; i++) leftList.Add(originalList[i]);
        for (int i = medium; i < originalList.Count; i++) rightList.Add(originalList[i]);

        // List<int> sortedLeftList = DivideAndConquer(leftList);
        // List<int> sortedRightList = DivideAndConquer(rightList);
        leftList = DivideAndConquer(leftList);
        rightList = DivideAndConquer(leftList);

        return Merge(sortedLeftList, sortedRightList);
    }

    static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> temp = new List<int>();

        while (left.Count > 0 && right.Count > 0)
        {
            if (left[0] > right[0])
            {
                temp.Add(right[0]);
                right.RemoveAt(0);
            }
            else
            {
                temp.Add(left[0]);
                left.RemoveAt(0);
            }
        }

        if (left.Count != 0)
        {
            for (int i = 0; i < left.Count; i++) temp.Add(left[i]);
        }

        if (right.Count != 0)
        {
            for (int i = 0; i < right.Count; i++) temp.Add(right[i]);
        }

        return temp;
    }

    static void ShowListMsg(List<int> theList, string listName)
    {
        Console.Write($"\n>>{listName}:\n[");
        foreach (int n in theList)
        {
            Console.Write($"{n}, ");
        }
        Console.WriteLine("\b\b]");
    }

    /*
    Merge Sort的工作過程：

    1. 初始列表：[5, 2, 8, 1, 9]

    2. 第一次分割：
       - 左邊：[5, 2]
       - 右邊：[8, 1, 9]

    3. 處理左邊 [5, 2]：
       - 進一步分割成 [5] 和 [2]
       - 因為都是單個元素，直接合併排序成 [2, 5]
       - 這部分完成後暫時停在這裡

    4. 處理右邊 [8, 1, 9]：
       - 分割成 [8] 和 [1, 9]
       - [8] 是單個元素，不動
       - [1, 9] 繼續分割成 [1] 和 [9]，然後合併成 [1, 9]
       - 最後 [8] 和 [1, 9] 合併成 [1, 8, 9]

    5. 最後一步：
       - 合併左邊的 [2, 5] 和右邊的 [1, 8, 9]
       - 最終結果：[1, 2, 5, 8, 9]
    */
}
