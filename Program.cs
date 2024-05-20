internal class Program
{
    private static void Main(string[] args)
    {
        Arac a1 = new Arac("Opel", "Corsa", 2010, 56000);
        a1.AlisFiyat = 28000;
        a1.SatisFiyat = 32000;
        a1.MaxIndirimTutar = 1500;
        a1.FiyatAta(31000);
        a1.BilgileriGoruntule();
    }
}

class Arac
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public int ModelYil { get; set; }
    public double Km { get; set; }
    public int YakitTip { get; set; }
    public int VitesTip { get; set; }
    public double AlisFiyat { get; set; }
    public double SatisFiyat { get; set; }
    public double MaxIndirimTutar { get; set; }
    public double Fiyat { get; set; }

    public Arac(string marka, string model)
    {
        Marka = marka;
        Model = model;
    }

    public Arac(string marka, string model, int modelYil)
    {
        Marka = marka;
        Model = model;
        ModelYil = modelYil;
    }

    public Arac(string marka, string model, int modelYil, double km) 
    {
        Marka = marka;
        Model = model;
        ModelYil = modelYil;
        Km = km;
    }

    public void BilgileriGoruntule()
    {
        Console.WriteLine($"Marka: {Marka} - Model: {Model} - ModelYil: {ModelYil}");
    }

    public void FiyatAta(int fiyat)
    {
        double fiyatHesap = SatisFiyat - MaxIndirimTutar;
        if(fiyat < fiyatHesap)
        {
            Console.WriteLine("Gecersiz fiyat girisi.");
        }
        else
        {
            Fiyat = fiyat;
            Console.WriteLine("Fiyat Guncellendi.");
        }
    }
}