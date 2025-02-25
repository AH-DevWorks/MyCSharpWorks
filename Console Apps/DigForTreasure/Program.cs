namespace DigForTreasure;

class Program
{
    static async Task Main()
    {
        int[,] map = new int[5, 5];
        CreateMap(map, out int rowOfTreasure, out int columnOfTreasure);
        int[,] oriMap = (int[,])map.Clone();
        //測試用
        //Console.WriteLine(rowOfTreasure + " " + columnOfTreasure);
        bool isGameOver = false;
        bool isTreasureFound = false;

        var countdownTask = Task.Run(async () =>
        {
            DateTime DeadLine = new DateTime(2025, 12, 30, 23, 59, 59);
            TimeSpan zero = new TimeSpan(0, 0, 0, 0);
            while (!isGameOver && !isTreasureFound)
            {
                TimeSpan remainTime = DeadLine - DateTime.Now;
                if (remainTime <= zero)
                {
                    Console.WriteLine($"\n～本次尋寶活動已結束～");
                    await Task.Delay(750);
                    Console.WriteLine($"～感謝各位玩家的參與～");
                    isGameOver = true;
                    return;
                }
                if (remainTime.TotalMinutes > 1)
                {
                    Console.WriteLine($"剩餘時間： {remainTime.Days} 天 {remainTime.Hours} 小時 {remainTime.Minutes:D2} 分鐘...");
                    for (int i = 0; i < 30; i++)
                    {
                        if (isTreasureFound == true) return;
                        await Task.Delay(1000);
                    }
                }
                else
                {
                    Console.WriteLine($"剩餘時間： {remainTime.Seconds:D2} 秒...");
                    await Task.Delay(1000);
                }
            }
        });

        while (!isGameOver && !isTreasureFound)
        {
            if (isGameOver) break;

            Console.WriteLine("--- 請輸入要挖掘的座標:(x y) ---");
            Console.WriteLine($"*兩數字中間請以半形空格隔開*");

            string input = Console.ReadLine();

            //待增加input檢查//

            try
            {
                if (isGameOver) break;

                string[] parts = input.Split(' ');
                int chosenRow = int.Parse(parts[0]);
                int chosenCol = int.Parse(parts[1]);

                if (chosenRow == rowOfTreasure && chosenCol == columnOfTreasure)
                {
                    Console.WriteLine($"[!] 挖到寶藏了！！！");
                    isTreasureFound = true;
                }
                else if (map[chosenRow, chosenCol] == 1)
                {
                    Console.WriteLine($"可惜，只挖到一個空箱子...");
                    map[chosenRow, chosenCol] = 0;
                }
                else
                {
                    Console.WriteLine($"……什麼都沒挖到QQ");
                }

                /*
                if (chosenRow == 537 && chosenCol == 537)
                {
                    TryOverFlow();
                }
                else if (chosenRow == rowOfTreasure && chosenCol == columnOfTreasure)
                {
                    Console.WriteLine($"[!] 挖到寶藏了！！！");
                    isTreasureFound = true;
                }
                else if (map[chosenRow, chosenCol] == 1)
                {
                    Console.WriteLine($"可惜，只挖到一個空箱子...");
                    map[chosenRow, chosenCol] = 0;
                }
                else
                {
                    Console.WriteLine($"……什麼都沒挖到QQ");
                }
                */
            }
            catch
            {
                Console.WriteLine($"[錯誤!] 無效的座標");
            }
        }

        await countdownTask;

        if (isTreasureFound)
        {
            Console.WriteLine($"恭喜成功找到寶藏！");
            Console.WriteLine($"(Y) : 顯示這次的藏寶地圖\n(任意鍵) : 離開遊戲");
            if (Console.ReadLine().ToLower() == "y")
            {
                ShowMap(oriMap);
                Console.WriteLine($"\n--- 按下任意鍵即可結束遊戲 ---");
                Console.ReadLine();
            }
        }
        else if (isGameOver)
        {
            Console.WriteLine($"很遺憾地未能成功找到寶藏。");
            Console.WriteLine($"(Y) : 顯示這次的藏寶地圖\n(任意鍵) : 離開遊戲");
            if (Console.ReadLine().ToLower() == "y")
            {
                ShowMap(oriMap);
                Console.WriteLine($"\n--- 按下任意鍵即可結束遊戲 ---");
                Console.ReadLine();
            }
        }
    }

    static void CreateMap(int[,] map, out int rowOfTreasure, out int columnOfTreasure)
    {
        Random random = new Random();
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                map[i, j] = random.Next(0, 2);
            }
        }
        rowOfTreasure = random.Next(0, map.GetLength(0));
        columnOfTreasure = random.Next(0, map.GetLength(1));
        map[rowOfTreasure, columnOfTreasure] = 9;
    }
    static void ShowMap(int[,] map)
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                switch (map[i, j])
                {
                    case 0:
                        Console.Write("空地 | ");
                        break;
                    case 1:
                        Console.Write($"空箱 | ");
                        break;
                    default:
                        Console.Write($"寶藏 | ");
                        break;
                }
            }
            Console.WriteLine($"\n\b\b---------------------------------");
        }
    }

    //可增添彩蛋（Overflow）
    /*static void TryOverFlow()
    {
        try
        {
            Console.WriteLine($"\n嗯……？好像挖到什麼軟綿綿的東西……");
            Task.Delay(750).Wait();
            int max = int.MaxValue;
            int result = checked(max++);
        }
        catch
        {
            Console.WriteLine($"「嗚咿呀哈嘎嘎！！！」\n忽然跳出一隻奇怪的...兔子(?)");
        }

        int uncheckedResult = unchecked(int.MaxValue + 1);
        Console.WriteLine($"兔子(?)在會場大鬧，並且扔下了一張意義不明的紙條：[{uncheckedResult}]");
        Task.Delay(1000).Wait();
        Console.WriteLine($"\n...那個到底是怎麼回事？");
        Task.Delay(350).Wait();
        Console.WriteLine($"算了，還是快點回去繼續挖寶吧...\n");
    }*/
}
