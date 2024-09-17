namespace PageCalc
{
    internal class Program
    {
        const int MaxPage = 9999;
        static void Main(string[] args)
        {
            Console.WriteLine("\n---印刷落版計算器---\n");
            while (true)
            {
                // 讓使用者輸入特定頁數（輸入0結束程式）
                Console.Write("請輸入特定頁碼（輸入0結束程式）：");
                if (!int.TryParse(Console.ReadLine(), out int targetPage))
                {
                    Console.WriteLine("\n請輸入有效的整數。\n");
                    continue;
                }

                // 如果使用者輸入0，結束程式
                if (targetPage == 0)
                {
                    Console.WriteLine("\n程式結束。");
                    Thread.Sleep(500);
                    break;
                }

                // 檢查是否為負數
                if (targetPage < 0 || targetPage > MaxPage)
                {
                    Console.WriteLine("\n請輸入介於 1 到 9999 之間的正整數。\n");
                    continue;
                }

                // 計算並輸出結果
                CalculateAndPrintResult(targetPage);
            }
        }
        static void CalculateAndPrintResult(int targetPage)
        {
            // 計算台數
            int signature = (targetPage - 1) / 16 + 1;

            // 計算落版在A版或B版
            char printingPlate = CalculatePrintingPlate(targetPage);

            // 輸出結果。方便使用者複製結果到另一表單，因此不使用表格或其他美化形式呈現。
            Console.WriteLine($"第{targetPage}頁：{signature}，{printingPlate}\n");
        }

        static char CalculatePrintingPlate(int targetPage)
        {
            // 每16頁一循環的AB版順序
            char[] orderCycle = { 'A', 'B', 'B', 'A', 'A', 'B', 'B', 'A', 'A', 'B', 'B', 'A', 'A', 'B', 'B', 'A' };

            // 根據循環順序計算落版位置
            return orderCycle[(targetPage - 1) % 16];
        }
    }
}
