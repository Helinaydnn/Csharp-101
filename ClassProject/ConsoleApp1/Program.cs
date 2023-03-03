using ConsoleApp1;

internal class Program:clsMovies // kalıtım(ınheritance)
{
    private static void Main(string[] args)
    {

        #region public
        //clsTutorials tutorials = new clsTutorials();  //classtan örnekleme yaptım, yani nesneyi oluşturdum.
        //tutorials.setTutorial(1, "C# eğitimi");
        //Console.WriteLine( "Eğitim adı : {0}",tutorials.getTutorialName());

        #endregion

        #region private

        //clsStudent student = new clsStudent();
        //student.getName();


        #endregion

        #region protected

        Program program = new Program();
        clsMovies movies = new clsMovies();
        Console.WriteLine($"Movie Name :{program.movieName}");


        #endregion


        Console.ReadKey();  

    }
}