# 摘要說明

這裡的範例程式碼，將會體驗當要注入的物件，是個數值型別物件或者是字串，我們要學習，其建構式需要在進行型別對應註冊的時候，指定這些要注入的常數值。在註冊的時候，可以提供 InjectionConstructor /  InjectionProperty 來註明要注入的常數值。另外，也要練習當要進行手動解析注入物件的時候，可以選擇使用不同的物件作為注入依據。

在這個目錄下共有四個目錄

## Starter

這裡將是要大家進行練習前置專案，請各位從這個專案開始進行練習

* 在這裡，ConsoleMessage 類別，實作了 介面 IMessage
* 在 ConsoleMessage 類別內，成員
  * 屬性 Cost(double) : 將會透過屬性注入的方式來取得
  * 屬性(欄位) Name(字串) , Age(整數) ： 要透過建構式注入

## Solution

這個專案將要呈現最後練習結果

* 想要注入非類別型別的物件，我們需要在進行宣告的時候，使用 InjectionConstructor , InjectionProperty 來指定要注入的數值或者字串是甚麼？

## SolutionUsingInjectionContructor

這個專案將要呈現，當我們使用 類別物件的時候，可以使用 typeof(IAnotherInterface) 來指定要注入的相依抽象類別 最後練習結果

這樣的組合，便可以指定適當所需要的建構式，作為產生物件的來源函式

## SolutionResolveOverride

這個專案將要呈現，當我們在宣告型別定義的時候，指定了要注入的常數，不過，當進行解析的時候，想要覆寫這些常識的 最後練習結果

* 在這裡，我們將會在呼叫 Resolve 方法的時候，使用 ParameterOverride , PropertyOverride 來覆寫我們要注入的常數
