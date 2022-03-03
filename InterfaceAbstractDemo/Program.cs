using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

//Senaryomuz: Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
//Starbucks ve Nero firması için çalışıyoruz.
//İki firmada müşterilerini veri tabanına kaydetmek istiyor.
//Starbucks müşterilerini kaydederken mutlaka mernis doğrulaması istiyor. Nero müşterilerini kaydederken böyle bir şey istemiyor.
//Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.


BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
customerManager.Save(new Customer { DateOfBirth = new DateTime(2002, 3, 17), FirstName = "Burcu", LastName = "Taş", Id = 1, NationalityId = "1234567890" });


//Program 'MernisServiceAdapter.cs' projesinde hata veriyo ama engin hocanın yaptıklarını uyguladım.




