using _11_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {

        clsSubTutorial altsinif = new clsSubTutorial();  //clssubtutorialdan tutorial adında bir nesne oluşturuyoruz.
        
        altsinif.renameTutorial(".Net Tutorials from Linkedin..");//çağırdığım bu metot alt sınıfta
        Console.WriteLine(altsinif.getTutorialName());
        //12.satıra geldiğimde yazmak için getTutorialName metodunu çağırıyorum.
        //Ama aslında bu metot üst sınıfta. alt sınıfın sanki bir metoduymuş gibi çağırabiliyorum
        //miras almasından dolayı..


        Console.ReadKey();  
    }
}