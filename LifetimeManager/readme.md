# 摘要說明

這裡的範例程式碼，將會體驗IoC Container 容器會負責建立所需要的實作物件，當然，也需要關注如何釋放所產生的物件。在本練習中，我們將會使用 Unity 物件生命週期管理類別，告知 IoC 容易要如何建立與釋放物件
。

在這個目錄下共有兩個目錄

## Starter

這裡將是要大家進行練習前置專案，請各位從這個專案開始進行練習

* 在這裡，ConsoleMessage 類別，分別實作了 介面 IMessage

## Solution

這個專案將要呈現最後練習結果

* 我們需要在執行 RegisterType 方法時候，要針對抽象型別與季體實作類別進行測測的時候，使用具名註冊的方式(因為，在這個練習中，僅有一個抽象介面與一個實作該介面的型別)，分別使用 TransientLifetimeManager , ContainerControlledLifetimeManager 這兩個生命週期物件，看看他們所呈現出來的效果