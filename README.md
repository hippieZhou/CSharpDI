#  .NET/C# 開發實戰 掌握相依性注入的觀念與開發技巧

## 練習專案說明

|專案名稱|專案說明|備註|
|-|-|-|
|[DIExperience](DIExperience/readme.md)|第一次體驗有無相依性注入與使用DI容器的用法|共有2個專案範例 :在第一個專案中，Tutorial， Phase1 傳統緊密耦合開發方式 / Phase2 將具體實作類別解耦合成為介面，但使用手動注入方式 / Phase3 使用 DI Container 容器，自動進行註冊與解析。最後，還有一個 TutorialMVC 為一個 ASP.NET MVC 5 的專案，並且搭配使用 Unity ( DI 容器 ) 提供相依性注入服務|
|[InversionOfControl](InversionOfControl/readme.md)|程式執行流程反轉控制 Inversion of Control 之情境練習|共有兩個專案，分別是：主控制台應用專案 ControOverTheFlowOfAProgram 與 WPF 的 GUI 事件驅動專案 InversionTheFlowOfProgram|
|[InversionOfControlOO](InversionOfControlOO/readme.md)|物件導向設計之反轉控制 Inversion of Control 之情境練習|練習如何在物件導向設計中進行反轉控制、學習工廠方法之設計模式的用法|
|[DependencyInversion](DependencyInversion/readme.md)|相依反轉原則 DIP 之情境練習|違反 DIP 的例子 與 使用抽象型別解決此一問題|
|[PoorManDI](PoorManDI/readme.md)|窮人 DI (或稱 Pure DI) 練習|設計出一個 DI 機制，具有註冊抽象型別與具體型別能力，並且可以解析出抽象型別的具體實作物件|
|[FirstUnity](FirstUnity/readme.md)|DI 容器的使用 : Unity|(`體驗使用五種 DI / IoC Container 容器用法`) 體驗如何安裝與使用 Unity 之 IoC Container|
|[FirstAutofac](FirstAutofac/readme.md)|DI 容器的使用 : Autofac|(`體驗使用五種 DI / IoC Container 容器用法`) 體驗如何安裝與使用 Autofac 之 IoC Container|
|[FirstStructureMap](FirstStructureMap/readme.md)|DI 容器的使用 : StructureMap|(`體驗使用五種 DI / IoC Container 容器用法`) 體驗如何安裝與使用 StructureMap 之 IoC Container|
|[FirstNinject](FirstNinject/readme.md)|DI 容器的使用 : Ninject|(`體驗使用五種 DI / IoC Container 容器用法`) 體驗如何安裝與使用 StructureMap 之 IoC Ninject|
|[FirstNetCore](FirstNetCore/readme.md)|DI 容器的使用 : .NET Core|(`體驗使用五種 DI / IoC Container 容器用法`) 體驗如何安裝與使用 .NET Core 之 IoC Ninject|
|[UnityAutoRegistration](UnityAutoRegistration/readme.md)|Unity IoC 容器 型別對應自動註冊|(`三種型別對應註冊方法`) 使用 IUnityContainer. RegisterTypes 根據自動搜尋組件內的型別與相關設定，自動進行 IoC 容器的型別對應註冊|
|[UnityConfigurationXML](UnityConfigurationXML/readme.md)|Unity IoC 容器 使用 XML 註冊型別對應|(`三種型別對應註冊方法`) 使用 App.config 來定義需要註冊的介面與具體實作型別，並且在建立 IoC 容器之後，LoadConfiguration讀取該 XML 相關設定，自動進行 IoC 容器的型別對應註冊|
|[UnityDI](UnityDI/readme.md)|三種相依性注入的使用操作練習 : Unity(使用 C# Attribute)|體驗如何使用 `C# 屬性 (Attribute)` 做到這三種注入(建構式、屬性、方法)的用法|
|[UnityDIByRegisterType](UnityDIByRegisterType/readme.md)|三種相依性注入的使用操作練習 : Unity(params InjectionMember[])|體驗如何 `透過型別對應註冊 API` 做到這三種注入(建構式、屬性、方法)的用法|
|[DeepResolve](DeepResolve/readme.md)|深層解析練習 : Unity|透過 Facade pattern 與配合深層解析，達到減少建構式參數的問題|
|[RegisterTypeNamed](RegisterTypeNamed/readme.md)|具名註冊與解析 : Unity|使用具名註冊與解析技術，在進行註冊與解析的時候，指定一個名稱  / 使用 IUnityContainer. Registrations 查看該 IoC 容器內的註冊項目清單|
|[MultiConstructor](MultiConstructor/readme.md)|多建構函式的對應Unity|在本練習中，將會想要指定類別內多個建構式的其中一個，作為預設注入使用的建構函式|
|[InjectingValue](InjectingValue/readme.md)|建構式參或屬性數需要有常數: Unity|當要注入的物件，是個數值型別物件或者是字串，我們要學習，其建構式需要在進行型別對應註冊的時候，指定這些要注入的常數值|
|[InjectingValueOverride](InjectingValueOverride/readme.md)|解析時候，覆寫要注入物件|ParameterOverride PropertyOverride DependencyOverride 使用練習|
|[InjectingObject](InjectingObject/readme.md)|註冊既有物件 : Unity|在本練習中，我們將會注入我們自己產生的物件到建構式內|
|[LifetimeManager](LifetimeManager/readme.md)|不同物件生命週期管理練習 : Unity|在本練習中，我們將會使用 Unity 物件生命週期管理類別，告知 IoC 容易要如何建立與釋放物件|
|[UnityInterception](UnityInterception/readme.md)|注入物件之攔截練習 : Unity|在本練習中，將會使用 IoC 容器的攔截功能，加入進需要注入的物件內|
|ASPNETMVC5Unity|在 ASP.NET MVC 5 中使用相依性注入 : Unity|本練習將會建立一個 ASP.NET MVC 5 專案，並且使用 Unity IoC Container 來實作相依性注入開發|
|ASPWebFormsUnity|在 ASP.NET Web.Forms 中使用相依性注入 : Unity|本練習將會建立一個 ASP.NET Web Form 專案，並且使用 Unity IoC Container 來實作相依性注入開發|
|DependencyInjectionSample|ASP.NET Core 服務存留期和註冊選項|了解 ASP.NET Core 的生命週期使用方式|
|-|-|-|
||||

## 其他補充說明範例
|專案名稱|專案說明|備註|
|-|-|-|
|ConcreteClass|正多邊形之週長與面積 使用類別|實作練習 ： 類別繼承、抽象類別繼承、介面實作|
|AbstractClass|正邊形之週長與面積 抽象類別|實作練習 ： 類別繼承、抽象類別繼承、介面實作|
|InterfaceImplementation|正多邊形之週長與面積 使用介面|實作練習 ： 類別繼承、抽象類別繼承、介面實作|
|InterfaceExplicitImp|||
|InterfaceExplicitImp|實作介面 / 明確介面實作 練習|在此練習中，分別使用 實作介面 與 以明確方式實作介面 兩個操作，了解這兩者介面實作的差異|
|ServiceLocatorDependencyInjection|服務定位與手動相依性注入練習|體驗本課程的精神，本練習共需要開發三個專案來演練|
||||



