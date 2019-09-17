# 摘要說明

這裡的範例程式碼，將會體驗如何進行相依性注入設計中，我們可以採用 建構式、屬性、方法的方式來注入具體實作物件、在這個練習中，讓我們來體驗如何在註冊階段，宣告 使用這三種注入的用法。

在這個目錄下共有兩個目錄

## Starter

這裡將是要大家進行練習前置專案，請各位從這個專案開始進行練習

在這裡，共有四個型別(可以從簡報檔案中的 UML 類別關聯圖看出)：

* Company 類別實作了 ICompany 介面。
* Employee 類別實作了 IEmployee 介面。
* 在具體實作類別 Employee ，共有三個型別為 ICompany 屬性，也就是說， Employee 類別 相依於 ICompany 介面。

## Solution

這個專案將要呈現最後練習結果

* 底下的不同注入具體實作物件，請使用 `IUnityContainer.RegisterType` 方法的參數，來進行設計指定三種注入方法要如何進行
* 請練習將 Employee 類別內型別為 ICompany 的 ConstructorInjectionCompany 成員，設計成為使用 DI 容器的建構式注入方式來注入具體實作物件。
 
  > 建立 `InjectionConstructor` 類別的物件來指定建構式注入條件
* 請練習將 Employee 類別內型別為 ICompany 的 PropertyInjectionCompany 成員，設計成為使用 DI 容器的屬性注入方式，產生該屬性需要的具體實作物件。
 
  > 建立 `InjectionProperty` 類別的物件來指定建構式注入條件
* 請練習將 Employee 類別內型別為 ICompany 的 PropertyInjectionCompany 成員，設計成為使用 DI 容器的方法注入方式，產生該屬性需要的具體實作物件。
 
  > 建立 `InjectionMethod` 類別的物件來指定建構式注入條件

## 注意事項

* `當使用不同 DI Container 注入機制，取得具體實作類別物件，此時，所取得的物件是同一個 (Singleton) 還是都是不同的物件呢？`
