# C# 個人專案作品集

## 簡介
   + 這個倉庫（Repository）包含了我在學習和實踐 C# 過程中的參考課程、資源、建立的各種小型專案以及成果等。
   + 每個專案都展示了不同的 C# 概念和技術，反映了我個人的學習和技能成長歷程。

## 主要使用語言／開發框架

## 主要使用
+ C# 
+ .NET Framework / .NET Core
+ Windows Forms

## 已取得之認證
### freeCodeCamp
1. **[Foundational C# with Microsoft Certification Exam | 微軟基礎 C# 認證]()**  *[2025/02/19]* 

## 學習資源

### 書籍
1. Troelsen, A., Japikse, P. (2022). *Pro C# 10 with .NET 6: Foundational Principles and Practices in Programming*. 美國: Apress.

2. 蔡文龍, 張志成, 何嘉益, 張力元, 歐志信（2022）.*《Visual C# 2022基礎必修課》*. 碁峰出版社. ISBN：9786263242296

### 線上課程

1. Udemy - [Complete C# Course – Beginner to Expert](https://www.udemy.com/course/complete-c-sharp-programming-course-beginner-to-expert/)

### 線上資源

1. [Microsoft Learn - C#](https://learn.microsoft.com/zh-tw/dotnet/csharp/)
   - Microsoft官方提供之 C# 學習課程。
   - **已完成之課程模組請見：**
     - **[我的Microsoft頁面]()**

2. [《Hello 演算法》](https://www.hello-algo.com/zh-hant/)


+ ***以下各專案內容及說明整理中_20250225***
=======

---

## 專案列表

+ ### Windows Forms Apps | 使用者界面應用程式
   1. [Alarm](./Windows%20Forms%20Apps/Alarm/)
      - **定時鬧鈴提醒程式**
        - 程式介面即時顯示目前時間：yyyy年MM月dd日(週x) HH:mm:ss
        - 使用者可透過控制項＆輸入欄，自行設定程式提醒的時間＆提醒訊息的內容。
        - 設定過程中可按下「重置」鈕重新輸入。
        - 預設最快提醒時間是「現在時刻的15秒後」；最晚提醒時間是「現在時刻的7天後」。
        - 按下「設定鬧鈴」鈕開始倒數。
        - 時間到後，可再按下「延後提醒」將鬧鈴延後1分鐘。
      - **使用的主要技術/概念**
        - DateTimePicker日期時間挑選控制項
          - CustomFormat自訂時間顯示格式
        - Timer計時器(Tick事件)
          - 兩組，一組控制鬧鈴，一組讓介面即時顯示現在時間。Interval皆為1000(1秒)。
          - 控制鬧鈴的Timer1：預設關閉，使用者按下設定鬧鈴鈕後才開啟。
          - 計時的Timer2：常開。
        - const變數*3組：MIN_TIME_SECONDS預設15秒、MAX_DAYS_AHEAD預設7天、SNOOZE_MINUTES預設延後1分鐘
        - Button控制項*3組：設定鬧鈴、重置、延後提醒
        - MessageBox：時間到後，顯示使用者自行設定的訊息。
      - 完成日期：2024-09-18

   2. _[Arithmometer](./Windows%20Forms%20Apps/Arithmometer/)
      - **簡易四則運算器**
        - 於三個空格內正確填入數字1、運算符號、數字2後按下確認即可於Label顯示運算結果。
        - 若有輸入錯誤，同樣會在Label顯示錯誤原因（如填入錯誤的運算符號等）。
      - **使用的主要技術/概念**
        - 以選擇結構搭配.TryParse，檢查輸入的數字及運算符是否合乎規則，三者皆正確才會執行運算。
        - 以double變數儲存數字，以順利計算小數。
      - 完成日期：2024-08-26

   3. [ArraySongSearching](./Windows%20Forms%20Apps/ArraySongSearching/)
      - **歌曲排行榜＆搜尋程式**
        - 程式開啟時會顯示熱門歌曲排行榜（虛構）清單，包含「排名」、「歌手名」、「曲名」。
        - 使用者可透過關鍵字（歌手或歌名）進行歌曲搜尋。
        - 可透過介面上的3個排序按鈕（Rank、Singer、Songs）分別進行清單排序（例如以歌手名稱從A開始排序）。
      - **使用的主要技術/概念**
        - Array*3組：分別儲存「歌手名」、「曲名」、「排行」。
        - Label*3組：分別顯示且對應上述三組資料。
        - 關鍵字搜尋（歌手/歌曲）功能
          - 以Button、textBox，加上自訂函式實現。
          - 自訂函式DoSearch()中使用HashSet<int>，以HashSet不允許重複項之特性，避免搜尋結果重複。
        - 以Array.Copy、Array.Sort方法，實現「依歌手名Singer」/「依曲名Songs」/「依排名Rank」排序之按鈕功能。
      - 完成日期：2024-09-09
      - 更新日期：2024-11-09——修正在執行搜尋功能後，Label無法再度回到Default狀態（顯示所有歌曲）之問題。
      - <span style="color: darkorange">未來可改良處：</span>
        - 將目前的資料管理模式改為使用資料庫；或將歌手、歌名、排行整合成同一類別，以List管理。
        - 使用泛型和委託，統一排序的邏輯，簡化程式碼。
        - 將顯示Error的情況獨立一個Label避免混淆。
        - 改以DataGridView而非三組Label顯示清單，美化介面。

   4. [BikeRentCalc](./Windows%20Forms%20Apps/BikeRentCalc/)
      - **共享單車租賃計費程式**
        - 預設為「共享單車月」——單次租借時間≦30分鐘者免費。
        - 費率（未滿30分鐘以30分鐘計）：
          - 單次租借多於30分鐘且少於240分鐘者，超出30分鐘的分鐘數以10元/30分鐘計算。
          - 多於240分鐘且少於/等於480分鐘者：超出240分鐘的分鐘數以20元/30分鐘計算。
          - 多於480分鐘且低於900分鐘（15小時）者：超出480分鐘的分鐘數以40元/分鐘計算。
          - 多於900分鐘：視為超時，不再計算費率，而是顯示超時，請使用者聯繫客服。
      - **使用的主要技術/概念**
        - 以button1_Click及textBox1_KeyPress兩種方法，讓使用者無論點選「確定」鈕或是直接按下Enter鍵皆可執行。
        - 進入計算前，預先以if-else判斷式，判斷使用者輸入之數值，若輸入的數值≦0，或輸入英文等，接會跳出錯誤訊息，且不執行計算。
        - 每次計算前皆會重置租借時間，避免前次輸入之數值延續到下一次的計算。
        - 以if...else if...else多重選擇，輔以Math.Ceiling()方法，計算使用者應繳納之總金額。
        - 各關鍵數字（如費率、計算區間、優惠時間等）皆以const呈現，以利未來可能須調整的情況。
      - 完成日期：2024-08-26
      - 更新日期：2024-11-17
        - 修正Logical Error

   5. [Blackjack - 5-Card Charlie](./Windows%20Forms%20Apps/Blackjack/)
      - **21點遊戲——5-Card Charlie**
        - 5-Card Charlie（五張牌查理／過五關）
        - 【規則】
          - 玩家拿到初始2張手牌後，再連續叫牌3次，手牌達到5張且點數總和沒超過21點(爆牌)者獲勝。
          - A可計為1點或11點。
      - **使用的主要技術/概念**
        - 每次遊戲都Random生成初始2張手牌及後續的每次叫牌。
        - 以5個PictureBox分別直觀顯示手牌牌面。
        - 按下「要牌(Hit)」按鈕後隨機發牌並顯示目前手牌點數總和。
        - (v1.05更新 - 使用LINQ) 若抽到Ace，程式自動判斷以1點或11點計算。
      - 完成日期：2024-09-22
      - 更新日期：2024-11-30
        - 規則完善：若抽到Ace，程式會自動判斷以1點或11點計算。
        - 新增一Label，將遊戲名稱與點數顯示/遊戲進度分開呈現。
        - 新增爆牌時發出Beep提示音。
      - <span style="color: darkorange">未來可改良處：</span>
      - 功能改善以期貼近真實遊戲（如放入兩副牌組等）。
      - 可詳見資料夾內`ROADMAP.md`說明。

+ ### Console Apps | 主控台應用程式
   1. [MatrixTranspose](./Console%20Apps/MatrixTranspose/)
      - 首先讓使用者輸入矩陣的列數(m)與行數(n)，亦即使用者要創建的【矩陣A】將有m×n個元素；接著使用者依序輸入m×n個元素值（皆為整數）。此程式會輸出【矩陣A】及其【轉置(Transpose)矩陣A^T】的內容。
      - 使用的主要技術/概念：
         - 二維陣列操作 (2D Array Manipulation)
         - 輸入驗證與錯誤處理 (Input Validation and Error Handling)
         - 矩陣轉置 - 以雙重for迴圈實現 (Matrix Transposition using Nested for loops)
      - 完成日期：2024/10/06
      - [備註]本練習參考自Computer Skills Foundation之 「[程式設計：資料結構 C#範例試卷](https://www.tqcplus.org.tw/CertificateDetail.aspx?CODE=8waKzIlt/zHpD14ldalaKw==)」

    2.  [DigForTreasure](./Console%20Apps/DigForTreasure/)
      - **模擬線上遊戲模式的簡單尋寶遊戲**
        - 玩家可透過輸入兩數字（代表X,Y座標）來指定要挖掘的地點。
        - 每一格都可能是「空地」、「空的箱子」或「寶藏」；「寶藏」只有一個。
        - 玩家必須在活動結束前成功找到寶藏。
        - 遊戲預設每30秒顯示一次剩餘時間（天數/小時/分鐘）；當剩餘時間少於1分鐘時，則每秒顯示一次「剩餘秒數」。
        - 當「活動結束（時間到）」或是「成功找到寶藏」後，可選擇是否匯出這次的藏寶地圖，並結束遊玩。
      - **使用的主要技術/概念**
        - 為了讓倒數計時不影響玩家輸入，使用 Task.Run() 來執行「倒數計時」，且跟「玩家輸入座標」的主遊戲邏輯平行運作。
        - 採用 async/await，讓程式保持非同步的流暢性，避免阻塞。
        - 「藏寶地圖」以二位陣列呈現，且運用Random填入每一座標位置的狀態（空地/空箱）及「唯一的寶藏」。
        - 用try-catch來處理玩家輸入的座標，避免無效的輸入導致程式崩潰。
        - 以if-else比對玩家輸入的座標及藏寶地圖，並顯示對應的語句。
        - 將「生成/展示藏寶地圖」以CreateMap()和ShowMap()函式分別呈現，增加程式碼易讀性。
        - 聚焦於程式邏輯以及技巧本身，故暫不使用Visual Studio或Unity製作UI介面，僅以簡易Console文字界面進行。
      - 完成日期：2025-01-17
      - <span style="color: darkorange">未來可改良處：</span>
      - 轉以Visual Studio或Unity製作出具備UI之完整遊戲。
      - 藏寶地圖增添「炸彈」等配置，並增加遊戲性與變化性。(例如挖到炸彈則倒數秒數減少10秒；輸入特定數字會有彩蛋等)
      - *待修正潛在風險*
        - 須補足對玩家輸入數值的檢查（如輸入負值／輸入不只兩組數字／輸入非數字等情況）

## 學習目標
前述各項專案及學習，旨在：
- 替未來之密集訓練課程之甄試與學習奠定基礎
- 由淺入深，深入理解 C# 語言特性
- 持續提升程式碼品質與效率
- 探索不同類型的應用開發（桌面、Web、Mobile等）

## 聯繫方式
- LinkedIn: [`我的LinkedIn個人資料連結`]
- Email: [`我的e-mail：`]

## 授權
本倉庫內所有專案均為個人學習和展示用途。
若您對任何專案感興趣或有任何問題，歡迎與我聯繫。

*首次建立：[2024-09-18]*  
*最後更新: [2025-02-25]*
