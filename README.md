## Unity Version(5.10.1)

* new PerRequestLifetimeManager()在同一個Http請求範圍內共享同一個物件，不論Unity容器Reslove方法幾次，只要在同一個Http請求內都會回傳同一個物件
