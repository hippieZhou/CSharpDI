# 摘要說明

這裡的範例程式碼，將會體驗如何安裝與使用 .NET Core  之 IoC Container、建立介面與類別、安裝 .NET Core  之 NuGet 套件、使用 .NET Core  IoC Container 進行註冊與解析
確認是否可以進行深層注入、練習因為需求變更，需要從 ConsoleMessage 替換 FileMessage 之過程

在這個目錄下共有兩個目錄

## Starter

這裡將是要大家進行練習前置專案，請各位從這個專案開始進行練習

在這裡，ConsoleMessage / FileMessage 這兩個類別將會實作 介面 IMessage ，不過，在 FileMessage 類別中，我們也會參考用到 ILog 這個介面，然而，將會透過 FileMessage 建構式來取得 ILog 的具體實作物件；類別 Log 將會實作 ILog 這個介面。

因此，當我們透過 DI Container 取得 ConsoleMessage 物件的時候，DI Container 僅僅會產生 ConsoleMessage 物件，但是，當我們要取得 FileMessage 物件的時候，除了會產生 FileMessage 物件，並且同時會幫我們注入 Log 類別的物件到 FileMessage 物件內。

## Solution

這個專案將要呈現最後練習結果

* 請練習安裝 .NET Core  DI Container 容器之 NuGet 套件，並且練習如何透過這個 DI 容器進行抽象型別與具體實作類別的註冊動作，接著，透過 DI Container 提供的解析方法，取出所指定介面的具體實作類別
* `請分別嘗試進行 ConsoleMessage 與 FileMessage 的註冊與解析，確認 Log 物件會在解析 FileMessage 的時候，也一併注入到該物件內`。

## 注意事項

* `在進行型別註冊時候，使用 AddTransient / AddScoped / AddSingleton 這三者有何不同呢？`
* 若同一個介面，如 IMessage，註冊了兩個不同具體實作類別，當進行 IMessage 型別解析的時候，會發生甚麼問題呢？
* 如何確認深層注入有成功執行呢？
* 如何確認多次解析 IMessage 抽象型別的具體實作物件，是否都是同一個物件呢？
