# 摘要說明

這裡的範例程式碼，將會進行 SOLID 的其中一個原則，相依反轉原則 DIP違反原則練習 。

在這個目錄下共有兩個目錄

## Starter

這裡將是要大家進行練習前置專案，請各位從這個專案開始進行練習

在這裡，我們已經將 Email , Notification 類別設計在專案內，在 Notification 類別內，我們將會建立一個 new Email 類別 (第 19 行)，讓 Notification 和 Email 兩個類別造成耦合關係，接下來我們將要將這兩個類別，套用 DIP 原則

## Solution

這個專案將要呈現最後練習結果

複習一下 DIP 原則

當 A 模組使用 B 模組的情況下，我們稱 A 為高階模組，B 為低階模組。

高階模組不應該依賴於低階模組，兩者都該依賴抽象介面

相依於抽象，而不是具體實作

* 我們將 Email 類別抽象化，也就是要建立一個 IMessage 介面，請練習使用 Visual Studio 2017 的類別抽取成介面的重構方法
* 接著要讓 Email 類別實作 IMessage 介面
* 修正 Notification 類別，在這個類別，不要相依於低階模組 (Email)，而要相依於抽象介面 (IMessage)，並且建立一個建構函式，當要建立 Notification 物件的時候，可以透過該類別的建構函式來注入 IMessage 介面型別物件
* 請檢視與確認這樣的設計是否有符合 DIP 原則
