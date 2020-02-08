# CustomerAPI-.NetCore2.1-Mssql

## Araçlar

.Net Core 2.1

Microsoft SQL Server

Postman

api/customers uzantısıyla ulaşmaya çalıştığımızda __401 Unauthorized__ değeri ile karşılaşırız.Bu hata giriş yapmadığımızı, login işlemi gerçekleştirip token elde etmemiz gerektiğini gösterir.


![Untitled](https://user-images.githubusercontent.com/26170070/74082982-0e9a3080-4a70-11ea-9d95-68954cdeaae6.png)



Eğer kullanıcı adı ve parolanız yok ise /register uzantısından fotoğrafta gösterildiği şekilde email ve password alanlarına gerekli bilgileri girerek kaydolabilirsiniz.

![image](https://user-images.githubusercontent.com/26170070/74082674-59667900-4a6d-11ea-8821-5fd8603de3b7.png)

Kayıt olduktan sonra __200 OK__ değeri işlemimizi başarıyla tamamladığımızı gösterir.Alt tarafta kayıt olduğumuz emaili username şeklinde kullanabileceğimizi görüyoruz.

![postmanget](https://user-images.githubusercontent.com/26170070/74082725-ea3d5480-4a6d-11ea-9989-ca5957276f09.png)

Sql tablosuna kayıt ettiğimiz kullanıcının yerleştiğini görebilirsiniz. 

![image](https://user-images.githubusercontent.com/26170070/74083019-7badc600-4a70-11ea-800a-7172f6ab1c1b.png)


Kayıt olmuş veya önceden bir kaydınız var ise fotoğrafta gösterildiği gibi login yapabilirsiniz.

![Untitled](https://user-images.githubusercontent.com/26170070/74082913-c24ef080-4a6f-11ea-96d5-128f858a25c3.png)


__200 OK__ değeri işlemimizi başarıyla tamamladığımızı gösterir. 

![postmanget](https://user-images.githubusercontent.com/26170070/74082779-7f404d80-4a6e-11ea-8b11-5e6906d08497.png)

Girişten elde ettigimiz token ile api/customers uzantısına giderken Autherization sekmesinde Type kısmını __Bearer Token__ yaparak elde ettiğimiz __Token__ verisini giriyoruz.

![postmanget](https://user-images.githubusercontent.com/26170070/74082843-0b527500-4a6f-11ea-8d90-60980cbd69c3.png)

__200 OK__ değeri işlemimizi başarıyla tamamladığımızı,verilere ulaştığımızı gösterir. 

![Untitled](https://user-images.githubusercontent.com/26170070/74082885-7e5beb80-4a6f-11ea-87a3-d443f5d8eba2.png)

