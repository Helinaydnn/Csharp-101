using ClassProject;

internal class Program
{
    private static void Main(string[] args)
    {


          //Daily Workout 01
         //   Bir kütühanedeki kitapların sayfa sayısını gösteren bir programcık yapılacaktır
         //   .Bunun için clsBook adlı bir sınıf oluşturabilirsiniz.
         //   Bu sınıfın "numPages" adı verilen uygun türde bir property'si bulunmalıdır. 
         //   Bu sınıfın içersinde ayrıca kitabın sayfa sayısını geriye döndürecek "getPageNumber" isimli bir metod bulunacaktır.

         //   Program çalıştırıldığında öncelikle 20 sayfalık bir kitap oluştursun. 
         //   Bu işlemi yapabilmesi için gerekli olan sınıfın "constructor(yapıcı)" metodudur.
         //   Bu konuda internette bir araştırma yaparak bunun hakkında bilgi sahibi olabilir, 
         //   nasıl kullanılabileceği konusunda bir fikir sahibi olabilirsiniz.

         //  Bundan ayrı olarak yine "constructor" metoduyla 64 sayfalık bir kitap oluşturulacaktır. 
         //   Bu class'ın ismi de clsBigBook olsun.

         //        İstenen şeyler :
         //      - Bir kitap oluşturun ve sayfa sayısını gösterin
         //      - 24 sayfalık bir kitap oluşturun ve sayfa sayısını gösterin
         //      - Fazla sayfalı bir kitap oluşturun ve sayfa sayısını gösterin.


         // Not : Aslında kitap oluşturma dediğimiz burada sadece kitap sayfalarını belirlemek türünden bir durum olacaktır.

        clsBook clsBook = new clsBook();
        Console.WriteLine("Kitabın Id si "+ clsBook.KitapId);
        Console.WriteLine("Kitabın Sayfa Sayısı "+ clsBook.numPages);
        Console.ReadKey();  
    }   
}