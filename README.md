# OOP-Kutuphane-Uygulamasi

Bu proje, C# kullanarak basit bir kitap kütüphanesi sistemini simüle etmeyi amaçlamaktadır. Proje, kitapları ve kütüphaneleri temsil eden sınıflarla nesne yönelimli programlamayı (OOP) kullanarak temel işlevleri gerçekleştirmeyi gösterir.

## Özellikler

- **Kitap Sınıfı**: Kitap bilgilerini (kitap adı, yazar adı, ISBN ve sayfa sayısı) saklar ve bu bilgileri ekrana yazdırma yeteneğine sahiptir.
- **KitapKutuphanesi Sınıfı**: Kitapları saklayabilir, ekleyebilir, silebilir ve listeleyebilir. Ayrıca kitapların sayısını sınırlamak için bir kapasite sınırı vardır.

### Kitap Sınıfı

`Kitap` sınıfı aşağıdaki özelliklere sahiptir:

- `kitap_adi`: Kitap adı
- `kitap_yazari`: Kitap yazarı
- `ISBN`: Kitap ISBN numarası
- `sayfa_sayisi`: Kitap sayfa sayısı

`bilgileri_goster()` yöntemi, kitabın tüm bilgilerini ekrana yazdırır.

### KitapKutuphanesi Sınıfı

`KitapKutuphanesi` sınıfı aşağıdaki özelliklere sahiptir:

- `ad`: Kütüphane adı
- `max_kitap_kapasitesi`: Kütüphanenin kitap kapasitesi

#### Yöntemler

- `kitapekle(Kitap kitapeklenecekolan)`: Kütüphaneye yeni bir kitap ekler, eğer kapasite sınırına ulaşılmadıysa.
- `kitapsil(string silinecekISBN)`: Belirtilen ISBN'e sahip kitabı kütüphaneden siler.
- `kitaplariListele()`: Kütüphanedeki tüm kitapları listeler.
- `kitaplariListele(string yazar_adi)`: Belirtilen yazar adına sahip kitapları listeler.

## Kurulum

Projenizi çalıştırmak için .NET Core veya .NET Framework yüklü olduğundan emin olun. Daha sonra proje dosyasını [https://github.com/seher-akbas/OOP-Kutuphane-Uygulamasi.git] adresinden klonlayabilir veya indirebilirsiniz.

### Gereksinimler

- .NET Core SDK veya .NET Framework
- Visual Studio veya benzeri bir IDE

### Çalıştırma

1. Proje dosyasını indirin veya klonlayın.
2. Visual Studio'da projeyi açın.
3. `Program.cs` dosyasındaki `Main` metodunu çalıştırarak uygulamayı başlatın.

