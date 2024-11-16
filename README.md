﻿# C# 個人專案作品集

## 簡介
   + 這個倉庫（Repository）包含了我在學習和實踐 C# 編碼過程中建立的各種小型專案。
   + 每個專案都展示了不同的 C# 概念和技術，反映了我個人的學習和技能成長歷程。


<<<<<<< HEAD
+ ***以下各專案內容及說明整理中_20241026***
=======

---

## 專案列表

+ ### Windows Forms Apps | 使用者界面應用程式
   1. [Alarm](./項目1連結)
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

   2. _[Arithmometer](./項目2連結)
      - **簡易四則運算器**
        - 於三個空格內正確填入數字1、運算符號、數字2後按下確認即可於Label顯示運算結果。
        - 若有輸入錯誤，同樣會在Label顯示錯誤原因（如填入錯誤的運算符號等）。
      - **使用的主要技術/概念**
        - 以選擇結構搭配.TryParse，檢查輸入的數字及運算符是否合乎規則，三者皆正確才會執行運算。
        - 以double變數儲存數字，以順利計算小數。
      - 完成日期：2024-08-26

   3. [ArraySongSearching](./項目3連結)
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

   4. [專案名稱 1](./項目1連結)
      - 簡述
      - 使用的主要技術/概念
      - 完成日期：YYYY-MM-DD

   5. [專案名稱 1](./項目1連結)
      - 簡述
      - 使用的主要技術/概念
      - 完成日期：YYYY-MM-DD

   6. [專案名稱 1](./項目1連結)
      - 簡述
      - 使用的主要技術/概念
      - 完成日期：YYYY-MM-DD

=======
   1. [專案名稱 1](./項目1連結)
      - 簡述
      - 使用的主要技術/概念
      - 完成日期：YYYY-MM-DD

   2. [專案名稱 2](./項目2連結)
      - 簡述
      - 使用的主要技術/概念
      - 完成日期：YYYY-MM-DD

   3. [專案名稱 3](./項目3連結)
      - 簡述
      - 使用的主要技術/概念
      - 完成日期：YYYY-MM-DD

+ ### Console Apps | 主控台應用程式
   1. [MatrixTranspose](./項目1連結)
      - 首先讓使用者輸入矩陣的列數(m)與行數(n)，亦即使用者要創建的【矩陣A】將有m×n個元素；接著使用者依序輸入m×n個元素值（皆為整數）。此程式會輸出【矩陣A】及其【轉置(Transpose)矩陣A^T】的內容。
      - 使用的主要技術/概念：
         - 二維陣列操作 (2D Array Manipulation)
         - 輸入驗證與錯誤處理 (Input Validation and Error Handling)
         - 矩陣轉置 - 以雙重for迴圈實現 (Matrix Transposition using Nested for loops)
      - 完成日期：2024/10/06
      - [備註]本練習參考自Computer Skills Foundation之 「[程式設計：資料結構 C#範例試卷](https://www.tqcplus.org.tw/CertificateDetail.aspx?CODE=8waKzIlt/zHpD14ldalaKw==)」


## 主要使用語言／開發框架：
=======
      - [備註]本練習參考自Computer Skills Foundation之「程式設計：資料結構 C#範例試卷」: https://www.tqcplus.org.tw/CertificateDetail.aspx?CODE=8waKzIlt/zHpD14ldalaKw==


## 主要使用語言：
+ C# 
+ .NET Framework / .NET Core
+ Windows Forms


## 學習資源

### 書籍
1. Troelsen, A., Japikse, P. (2022). *Pro C# 10 with .NET 6: Foundational Principles and Practices in Programming*. 美國: Apress.

2. 蔡文龍, 張志成, 何嘉益, 張力元, 歐志信（2022）.*《Visual C# 2022基礎必修課》*. 碁峰出版社. ISBN：9786263242296

3. 李馨（2022）. *《從零開始學Visual C# 2022 程式設計》*. 博碩文化出版社. ISBN：9786263336742

### 線上課程

1. Udemy - [Complete C# Course – Beginner to Expert](https://www.udemy.com/course/complete-c-sharp-programming-course-beginner-to-expert/)

2. 
=======
1. 蔡文龍, 張志成, 何嘉益, 張力元, 歐志信（2022）.*《Visual C# 2022基礎必修課》*. 碁峰出版社. ISBN：9786263242296

2. 李馨（2022）. *《從零開始學Visual C# 2022 程式設計》*. 博碩文化出版社. ISBN：9786263336742

### 線上課程

1. Udemy - [課程名稱](課程連結)
   + `簡述` 

### 線上資源

1. [Microsoft Learn - C# 教學課程](https://learn.microsoft.com/zh-tw/dotnet/csharp/)
   - Microsoft官方提供之 C# 學習課程。
   - **已完成之課程模組請見：[`link`]**


## 學習目標
前述各項專案及學習，旨在：
- 替未來之密集訓練課程之甄試與學習奠定基礎
- 由淺入深，深入理解 C# 語言特性
- 持續提升程式碼品質與效率
- 探索不同類型的應用開發（桌面、Web、Mobile等）
- 轉職成為正式工程師

## 未來計劃
- **投身於可發揮相關技能之職場**
- 適時補足非資工本科系所欠缺之知識與技能
- 持續學習新的 C# 特性和最佳實踐
- 嘗試更複雜和大型的專案

## 聯繫方式
- LinkedIn: [`我的LinkedIn個人資料連結`]
- Email: [`我的e-mail：`]

## 授權
本倉庫內所有專案均為個人學習和展示用途。
若您對任何專案感興趣或有任何問題，歡迎與我聯繫。

*首次建立：[2024/09/18]*  
*最後更新: [2024/10/26]*
