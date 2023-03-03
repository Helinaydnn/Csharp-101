using _14_Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Normal Durum(herşey açık)

        // clsBank bank = new clsBank();
        // bank.AccountNumber = 1234567890;
        // bank.Name = "Santander";
        // bank.Balance = 500;
        //bank.GetBalance();
        // bank.WithdrawAccount();

        #endregion

        #region getter/setter

        //clsBank bankgs = new clsBank();
        //bankgs.SetBalanceCaps(500);
        //Console.WriteLine( $"Balance miktarı : {bankgs.GetBalanceCaps()}");//metodun eğerini geri döndüren get
        #endregion

        #region Eğer sınıfı tasarlarken kapsülleme (encapsulatıon) prensibine uymazsak ne olur?
        //sınıfı tasarlarken c# kapsülleme prensibini takip etmezsek, kullanıcı tarafından verilen verileri gereksinimlerimize
        //göre doğrulayamayız


        //clsBank bank2 = new clsBank();
        ////pozitif bir değerle amount değerini güncelleyeceğim..
        //bank2.Amount = 100;
        //Console.WriteLine($"Bankadaki miktar : {bank2.Amount} PNG Kina");

        //bank2.Amount = -150; //aslında istenmeyen bir durum 
        //Console.WriteLine($"Bankadaki miktar : {bank2.Amount} PNG Kina");
        ////hata yakalama bölümü
        //try
        //{
        //    clsBank bak3 = new clsBank();
        //    int deger;
        //    Console.WriteLine("Lütfen bir değer giriniz...");
        //    deger=Convert.ToInt32(Console.ReadLine()); 
        //    bak3.SetAmount(deger);

        //    Console.WriteLine($"\n\nDüzgün Durum\n\nBankadaki miktar : {bak3.GetAmount()} PNG Kina");

        //    Console.WriteLine("Lütfen bir değer giriniz...");
        //    deger = Convert.ToInt32(Console.ReadLine());

        //    bak3.SetAmount(deger);
        //    Console.WriteLine($"Bankadaki miktar : {bak3.GetAmount()} PNG Kina");
        //catch (Exception hata)
        //{

        //    Console.WriteLine(hata.Message);

        //}
        #endregion

        #region Properties/değişkenlere de uygulanabilir...
        // Özellikler C#'da tanıtılan yeni bir dil özelliğidir. C# 'daki özellikler, değerleri okuyarak ve yazarak bir sınıfın
        // bir alanının veya değişkeninin korunmasına yardımcı olur. İlk yaklaşım, yani ayarlayıcı ve alıcının kendisi iyidir,
        // ancak C# 'daki veri kapsülleme özelliklerle çok daha pürüzsüz olarak gerçekleştirilebilir.


        try
        {
            clsBank bank4 = new clsBank();
            //We cannot access the _Amount Variable directly
            //bank._Amount = 50; //Compile Time Error
            //Console.WriteLine(bank._Amount); //Compile Time Error
            //Setting Positive Value using public Amount Property
            bank4.Amount1 = 10;

            //Setting the Value using public Amount Property
            Console.WriteLine($"Değer : {bank4.Amount1}");

            //Setting Negative Value
            bank4.Amount1 = -150;
            Console.WriteLine($"Değer : {bank4.Amount1}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            clsBank bank5 = new clsBank();
            bank5._Amount2 = 100;
            Console.WriteLine($" Değer : {bank5._Amount2}");// direk değişkenin/propertinin tanımını yazabiliyorum.
            //kendi anlıyor set e gideceğini
            bank5._Amount2 = -5000;
            Console.WriteLine($" Değer : {bank5._Amount2}");// direk değişkenin/propertinin tanımını yazabiliyorum.
            //kendi anlıyor get e gideceğini
        }
        catch 
        {
            Console.WriteLine( "Lütfen pozitif bir sayı girin dedik ya.. ");
           
        }

        #endregion

        Console.ReadKey();
        
    }
}