# 摘要說明

這裡的範例程式碼，在這個練習中，您將要學習這兩件技能：使用 IUnityContainer.RegisterTypes 根據自動搜尋組件內的型別與相關設定，自動進行 IoC 容器的型別對應註冊、另外，可以使用 IUnityContainer.Registrations 屬性值， 來查看該 IoC 容器內的型別對應註冊項目清單


在這個目錄下共有兩個目錄

## Starter

這裡將是要大家進行練習前置專案，請各位從這個專案開始進行練習

在這裡，ConsoleMessage 類別將會實作 介面 IMessage。

## Solution

這個專案將要呈現最後練習結果

* 請練習使用 IUnityContainer.RegisterTypes 方法，自動掃描所指定的組件內容，根據不同引數設定，自動掃描組件內的所有型別，進而判斷與加入抽象介面型別與具體實作類別的對應關係，並且使用預設的注入物件生命週期
* 使用 IUnityContainer.Registrations 屬性值，來查看究竟有那些抽象型別與具體實作類別對應關係，加入到 DI Container 內呢？
