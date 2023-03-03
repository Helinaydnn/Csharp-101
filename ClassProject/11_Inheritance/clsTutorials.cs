using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Inheritance
{
    internal class clsTutorials
    {
       protected int TutorialId;
       protected string TutorialName;
        public void setTutorial(int pId, string pTutorialName)
        {
            TutorialId = pId;  
            TutorialName = pTutorialName;

        }
        public string getTutorialName()
        {
            return TutorialName;
        }
    }
}
