# 摘要說明

這裡的範例程式碼，使用 App.config 來定義需要註冊的介面與具體實作型別，並且在建立 IoC 容器之後，LoadConfiguration讀取該 XML 相關設定，自動進行 IoC 容器的型別對應註冊

在這個目錄下共有兩個目錄

## Starter

這裡將是要大家進行練習前置專案，請各位從這個專案開始進行練習

在這裡，ConsoleMessage / FileMessage 這兩個類別將會實作 介面 IMessage。我們將會透過 XML 檔案，宣告 當需要使用 IMessage 介面的時候，將會注入 ConsoleMessage 具體實作類別類別

## Solution

這個專案將要呈現最後練習結果

* 請依據簡報中的說明，練習 編輯 App.config 這個檔案內容，在這個檔案中，描述抽象型別與具體實作型別的註冊定義
* 接著，使用這敘述 `new UnityContainer().LoadConfiguration();` 命令 DI 容器，讀取該 XML 檔案的內容，依據 XML 定義的內容，進行型別註冊到 DI Container 內。
* 使用 IUnityContainer.Registrations 屬性值，來查看究竟有那些抽象型別與具體實作類別對應關係，加入到 DI Container 內呢？
* `請試著說明，採用這樣設計的好處是甚麼？`

  >提示：當我們注入 IMessage 介面的時候，需要變更採用 FileMessage 這個具體實作類別，這個時候，會需要處理那些工作與事項呢？
  
