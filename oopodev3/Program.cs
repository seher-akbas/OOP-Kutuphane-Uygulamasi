internal class Program
{
    private static void Main(string[] args)
    {

        //int[] int_array = new[] { 1, 2, 3, 4 };
        //int[] int_array2 = new int [4];
        //arraylerde elaman sildigimizde null olarak atanır legth degismez

        //List <int> int_list = new List <int> (); // kurucu fonksiyon cağırır gibi listeyi cağırıyoruz
        //int_list.Add (11);
        //int_list.Add(12); // listeye ekleme yaptık 
        //int_list.Add(13);
        //int_list.Add(14);
        //int_list[2] =23; // indeksi değiştirmek için
        //int_list.Remove (13); // degeri silmek için
        //int_list.RemoveAt(2); //indeksi silmek için
        //length değişir 1 azalır

        Kitap kitap = new Kitap("hobbit","JRR Tolkien","123456",500);
        








    }
}
class Kitap
{
    public Kitap(string kitap_adi, string kitap_yazari, string ISBN, int sayfa_sayisi) 
    {
        this.kitap_adi=kitap_adi;
        this.kitap_yazari = kitap_yazari;
        this.ISBN = ISBN;
        this.sayfa_sayisi = sayfa_sayisi;

    }
    public string kitap_adi, kitap_yazari, ISBN;
    public int sayfa_sayisi;
    public void bilgileri_goster()
    {
        Console.WriteLine("Kitap adi : " + kitap_adi + "kitap yazari : " + kitap_yazari + "ISBN : " + ISBN + "sayfa sayisi" + sayfa_sayisi);
    }

}
class KitapKutuphanesi

{ public KitapKutuphanesi(string ad,int max_kitap_kapasitesi)
    {
        this.ad=ad;
        this.max_kitap_kapasitesi = max_kitap_kapasitesi;
    }

    string ad;
    private int max_kitap_kapasitesi;
    List<Kitap> kitaplar = new List<Kitap>();

    void kitapekle(Kitap kitapeklenecekolan)
    {
       // kitaplar.Add(kitapeklenecekolan);
       if(kitaplar.Count < max_kitap_kapasitesi)
        {

        }
    }
    void kitapsil(string silinecekISBN)
    {
        
        for (int list_index = 0; list_index<kitaplar.Count; list_index++)
        {
            Kitap mevcut_kitap = kitaplar[list_index];

            if (mevcut_kitap.ISBN == silinecekISBN)
            {
                kitaplar.Remove(mevcut_kitap);
                break;
            }
        }
    }
    void kitaplariListele()
    {
        foreach(Kitap mevcut_kitap  in kitaplar)
        {
            mevcut_kitap.bilgileri_goster();
        }
    }
    void kitaplariListele(string yazar_adi)
    {
        foreach (Kitap mevcut_kitap in kitaplar)
        {
            if (mevcut_kitap.kitap_yazari == yazar_adi)
            {
                mevcut_kitap.bilgileri_goster();
            }
        }
    }

}