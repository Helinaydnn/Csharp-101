using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class clsTutorials
    {
        int TutorialId;
        string TutorialName;
        public void setTutorial(int pId, string pTutorialName)
        {
            this.TutorialId = pId;  
            this.TutorialName = pTutorialName;

        }
        public string getTutorialName()
        {
            return this.TutorialName;
        }
    }
}
