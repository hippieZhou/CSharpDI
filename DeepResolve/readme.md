# 摘要說明

這裡的範例程式碼，將會體驗如何進行當要注入的物件過多，導致建構式參數過多，也造成程式碼閱讀上困擾；我們可以透過 Facade pattern 與配合深層解析，達到減少建構式參數的問題、另外，可以使用方法注入的方式來減少建構式參數的使用量。

在這個目錄下共有兩個目錄

## Starter

這裡將是要大家進行練習前置專案，請各位從這個專案開始進行練習

* 在這裡，共有四個 Dependency1~4 類別，分別實作了 介面 IDependency1~4(可以從簡報檔案中的 UML 類別關聯圖看出)
* Infrastructure 類別也實作了 IInfrastructure 介面
* 在 Infrastructure 類別內，分別透過建構式要注入四個介面 IDependency1~4 之具體實作類別的物件
* ViewModel 類別將會相依於 IInfrastructure 介面，並且透過建構式注入的方式，取得 IInfrastructure 的實作物件

  >在此，`ViewModel 並沒有實作任何界面`

## Solution

這個專案將要呈現最後練習結果

* 請試著使用 Unity DI Container，分別安裝該 DI 容器需要的 NuGet 套件、建立 DI 容器物件、進行型別對應註冊
* 在這裡，我們並沒有註冊 ViewModel 這個類別會與哪個抽象介面對應在一起，請嘗試看看是否可以直接解析出這個類別的物件呢？
* `請看看輸出結果，確認再這樣階層相依架構下的關係，是否相關物件都會如期注入進來呢？`
