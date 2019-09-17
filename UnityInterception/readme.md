# 摘要說明

這裡的範例程式碼，將會體驗使用 IoC 容器的攔截功能，加入進需要注入的物件內。

在這個目錄下共有兩個目錄

## Starter

這裡將是要大家進行練習前置專案，請各位從這個專案開始進行練習

* 在這裡，ConsoleMessage 類別，分別實作了 介面 IMessage
* 在這個介面中，我們將會要實作兩個方法 Write , Empty

## Solution

這個專案將要呈現最後練習結果

在這裡，我們需要來練習 Unity 攔截功能，我們希望能夠在 Write , Empty 這兩個方法被呼叫執行的時候，我們期望能夠在執行該方法前後，插入執行其他指定的方法。

* 我們需要在 Unity Container 中，設定啟用攔截這項擴充功能 `container.AddExtension(new Interception())`
* 在進行註冊抽象與具體實作類別的時候，我們也需要進行攔截行為的設定，告知要啟用 Unity 攔截功能，這裡需要建立 `Interceptor<InterfaceInterceptor>` , `InterceptionBehavior<AppLog>` , `InterceptionBehavior<VirtualLog>` 這三個物件
* 我們需要建立 AppLog、VirtualLog 這兩個類別，不過，需要實作 IInterceptionBehavior 介面
* 由於這兩個類別實作了 IInterceptionBehavior 介面，因此，我們需要定義 `WillExecute` , `GetRequiredInterfaces` , `Invoke` 這三個成員。
* 我們將會在 Invoke 方法中，使用參數 IMethodInvocation ，檢查是否正在執行我們所期望的方法，若是如此，我們將會在 getNext()(input, getNext); 敘述前後，可以插入執行我們想要處理的工作
* 最後，請嘗試執行結果，體驗 Unity 插入的功能

