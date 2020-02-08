# CustomerAPI-.NetCore2.1-Mssql

## Araçlar

.Net Core 2.1

Microsoft SQL Server

Postman

api/customers uzantısıyla ulaşmaya çalıştığımızda __401 Unauthorized__ değeri ile karşılaşırız.Bu hata giriş yapmadığımızı, login işlemi gerçekleştirip token elde etmemiz gerektiğini gösterir.


![Untitled](https://user-images.githubusercontent.com/26170070/74082982-0e9a3080-4a70-11ea-9d95-68954cdeaae6.png)

## REGISTER


Eğer kullanıcı adı ve parolanız yok ise /register uzantısından fotoğrafta gösterildiği şekilde email ve password alanlarına gerekli bilgileri girerek kaydolabilirsiniz.

![image](https://user-images.githubusercontent.com/26170070/74082674-59667900-4a6d-11ea-8821-5fd8603de3b7.png)

Kayıt olduktan sonra __200 OK__ değeri HTTP requestin başarıyla tamamladığımızı gösterir.Alt tarafta kayıt olduğumuz emaili username şeklinde kullanabileceğimizi görüyoruz.

![postmanget](https://user-images.githubusercontent.com/26170070/74082725-ea3d5480-4a6d-11ea-9989-ca5957276f09.png)

Sql tablosuna kayıt ettiğimiz kullanıcının yerleştiğini görebilirsiniz. 

![image](https://user-images.githubusercontent.com/26170070/74083019-7badc600-4a70-11ea-800a-7172f6ab1c1b.png)

## LOGIN

Kayıt olmuş veya önceden bir kaydınız var ise fotoğrafta gösterildiği gibi login yapabilirsiniz.

![Untitled](https://user-images.githubusercontent.com/26170070/74082913-c24ef080-4a6f-11ea-96d5-128f858a25c3.png)


__200 OK__  değeri HTTP requestin başarıyla gerçekleştiğini bildirir.

![postmanget](https://user-images.githubusercontent.com/26170070/74082779-7f404d80-4a6e-11ea-8b11-5e6906d08497.png)

## GET REQUEST
Girişten elde ettigimiz token ile api/customers uzantısına giderken Autherization sekmesinde Type kısmını __Bearer Token__ yaparak elde ettiğimiz __Token__ verisini giriyoruz.

![postmanget](https://user-images.githubusercontent.com/26170070/74082843-0b527500-4a6f-11ea-8d90-60980cbd69c3.png)

__200 OK__  değeri HTTP requestin başarıyla gerçekleştiğini bildirir.

![Untitled](https://user-images.githubusercontent.com/26170070/74082885-7e5beb80-4a6f-11ea-87a3-d443f5d8eba2.png)

## GET REQUEST BY ID

İstediğimiz veriye api/customers/id uzantısına giderek ulaşabiliriz.

![Untitled](https://user-images.githubusercontent.com/26170070/74086458-0fdd5480-4a94-11ea-9364-3ccbb67c1db5.png)


## POST REQUEST

__201 Created__ değeri aldığımızda verimizin sql tablosuna kaydedildiğini anlarız.Id değeri sıralı ve otamatik olarak atanacaktır.

![Untitled](https://user-images.githubusercontent.com/26170070/74085062-5deb5b80-4a86-11ea-84f8-fa3906f7e3d5.png)

![Untitled](https://user-images.githubusercontent.com/26170070/74085114-ce927800-4a86-11ea-890b-69d243e9d1f1.png)

## PUT REQUEST

Verilerimizde güncelleme işlemi yapmak istediğimiste put request yaparak ilgili veriyi değiştirebiliriz.

Verimizin değiştirilmemiş hali.

![image](https://user-images.githubusercontent.com/26170070/74085273-72c8ee80-4a88-11ea-9f3f-8e921eb7d959.png)

![Untitled](https://user-images.githubusercontent.com/26170070/74085164-3f399480-4a87-11ea-8f72-8188cc06d078.png)

__204 No Content__ değeri requestin başarıyla gerçekleştiğini fakat gösterilecek bir değer olmadığını bildirir.

![Untitled](https://user-images.githubusercontent.com/26170070/74085180-8162d600-4a87-11ea-9899-6a2eb1fa78bc.png)

Güncellenen veriyi görmek için id'ye get request yapabiliriz. 

![Untitled](https://user-images.githubusercontent.com/26170070/74085220-ecaca800-4a87-11ea-8c07-79c9de063139.png)

__200 OK__  değeri HTTP requestin başarıyla gerçekleştiğini bildirir.
![image](https://user-images.githubusercontent.com/26170070/74085239-11088480-4a88-11ea-86aa-375c43567b5d.png)

## DELETE REQUEST

Bir veri silmek istediğimizde /api/customer/id uzantısına gidilerek delete request yapıldığında mevcut olarak böyle bir id var ise request gerçekleştirilir.

Aranılan id yok ise __404 NOT FOUND__ değeri ile karşılaşırız.Bu değer belirtilen request kaynağının olmadığını gösterir.

![image](https://user-images.githubusercontent.com/26170070/74086355-1a4b1e80-4a93-11ea-876b-9fce647c549f.png)

![image](https://user-images.githubusercontent.com/26170070/74086405-8b8ad180-4a93-11ea-8af2-a084b7c2316d.png)

Aşağıdaki sql tablosundan işaret ettiğimiz id'deki verinin silinmiş olduğunu görebiliriz. 

![image](https://user-images.githubusercontent.com/26170070/74086372-48c8f980-4a93-11ea-8d87-7e2c90a843ef.png)

