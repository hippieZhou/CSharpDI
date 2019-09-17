# 摘要說明

這裡的範例程式碼，將會讓學員可以體會與了解 IoC 反轉控制 在程式專案開發上，是如何使用的。在這個目錄下的方案 InversionOfControl，共有2個專案範例 

## 第一個專案

ControOverTheFlowOfAProgram ，這是一個 CLI 的應用程式，並且該專案採用的結構化的循序執行方式設計

## 第二個專案

這個專案將要呈現出流程反轉的作法

InversionTheFlowOfProgram 這是一個 WPF 類別的專案，所做的事情與上面第一個專案相同，不過，在這裡將採用 WPF 的事件驅動的開發框架設計模式，將執行流程反轉過來，我們僅需要定義出當使用者點選 儲存 或者 清除 按鈕的時候，我們需要做甚麼事情。在這樣的開發框架設計架構，就有符合了 Hollywood 原則, “Do not call us, we call You”