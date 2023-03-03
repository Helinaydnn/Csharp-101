using _13_Constructor;

internal class Program
{
    private static void Main(string[] args)
    {

        //açıklamalar

        #region Standart yapı

        //clsTest test = new clsTest();
        //Console.WriteLine($"i değeri {test.i} - s değeri {test.s} - b değeri  {test.b}");

        #endregion
        //constructor türleri
        //parameterized constructor---> parametreli
        //copy constructor----> copy contructor
        //static constructor---------> static >
        //private constructor-------> private >

        #region default/parametresiz
        //bu kurucular, bir programcı tarafından açıkca tanımlanabilir
        //veya sınıf altında açık(explicity) bir kurucu olmaası nedeniyle

        //clsEmployee emp1 = new clsEmployee();//kullanıcı tanımlı constructor örneği
        //emp1.DisplayEmployee();

        //clsEmployee emp2 = new clsEmployee();
        //emp2.DisplayEmployee();

        #endregion

        #region Parametreli Ctor lar
        // Nesneyi kullanıcı tarafından verilen değerlerle dinamik olarak başlatmak istiyorsak veya bir sınıfın her bir örneğini
        // farklı bir değerler kümesiyle başlatmak istiyorsak, C#'ta Parameterized Constructor'ı kullanmamız gerekir.
        // Bu oluşturucular yalnızca programcılar tarafından tanımlanır. Yani, basit bir ifadeyle, geliştirici tarafından verilen
        // parametrelere sahip kurucu C#'ta Parametreli Yapıcı olarak tanımlanır.
        //
        // Yararı Nedir?
        // 
        // Parametreli bir kurucunun yardımıyla, sınıfın her bir örneğini farklı bir değerler kümesiyle başlatabiliriz.
        // Bu, parametreli yapıcı kullanarak, sınıfta oluşturulan farklı örneklerde farklı bir değer kümesi depolayabileceğimiz
        // anlamına gelir. Yani her nesneyi farklı değerlerle başlatabilme imkanı vermesidir.

        //clsParametized prm1=new clsParametized(10);
        //prm1.Display();

        //clsParametized prm2=new clsParametized(20);
        //prm2.Display();

        //clsParametized prm3 = new clsParametized(30);
        //prm3.Display();
        #endregion
        #region Copy ctor
        //aynı değerlere sahip birden fazla örnek/nesne oluşturulması istendiği durumlarda kullanılmalıdır (copy ctor)
        //bu durumlarda copy ctor yapıcısı aynı sınıfı üzerine parametre olarak alır.

        clsCopy obj1=new clsCopy(10);
        obj1.Display();

        clsCopy obj2 = new clsCopy(obj1);
        obj2.Display();
        #endregion


        Console.ReadKey();

    }
}