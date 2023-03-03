using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Inheritance
{
    internal class clsSubTutorial:clsTutorials //üst sınıf olan clsTutorialsdan miras aldırttım.
        //alt sınıf olan clssubtutorials da olmayan bir metodu daha önceden yazılmış
        //ama farklı bir sınıfta durumlarında kullanabilmek için 
    {
        public void renameTutorial(string pNewName)
        {
          TutorialName = pNewName;

        }



    }
}
