using System;
class Program
{
    static void Main() // Oyuncu Oluşturma
    {
     Oyuncu oyuncu = new Oyuncu();
        oyuncu.Isim = "Kahraman";
        oyuncu.Can = 100;
        oyuncu.Seviye = 1;
        // Dusman Olusturma
        Dusman dusman = new Dusman();
        dusman.Isim = "Goblin";
        dusman.Can = 50;
        dusman.Hasar = 10;
        Console.WriteLine("Oyuncu Başladı");
        while (oyuncu.Can > 0 && dusman.Can > 0)
        {
            Console.WriteLine("1 - Saldir");
            Console.WriteLine("2 - Kaç");
            Console.WriteLine("Seciminiz:");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                int oyuncuHasari = HasarVer(10);
                dusman.Can -= oyuncuHasari;
                Console.WriteLine($"(oyuncu {oyuncuHasari} hasar verdi.");            

            }
            else if (secim == "2")
            {
                Console.WriteLine("Oyuncu kaçti!");
                return;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim.");
                continue;
            }
            // Dusman Saldirisi
            if (dusman.Can > 0)
            {
                oyuncu.Can -= dusman.Hasar;
                Console.WriteLine($"Dusman {dusman.Hasar} hasar verdi.");

            }
            Console.WriteLine("Durum:");
            oyuncu.Bilgi();
            dusman.Bilgi();


        }  
        // Oyun Sonu
        if (oyuncu.Can > 0)
        {
            Console.WriteLine("Oyuncu Kazandi!");
            oyuncu.SeviyeAtla();
            Console.WriteLine($"Yeni Seviye: {oyuncu.Seviye}");


        }
        else
        {
            Console.WriteLine("Kaybettiniz.");

        }
        
    }
    static int HasarVer(int guc)
    {
        return guc;

    }

}


class Karakter
{
    public string Isim;
    public int Can;
    public void Bilgi()
    {
        Console.WriteLine($"{Isim} - Can: {Can}");
    }
    public virtual void Saldir()
    {
        Console.WriteLine("Karakter saldirdi.");}

    
   
}
class Oyuncu : Karakter
{
    public int Seviye;
    public void SeviyeAtla()
    {
        Seviye++;

        
    }

}

class Dusman : Karakter
{
    public int Hasar;       
}





