using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_polymorphism
{
    internal class clsTutorials
    {
       protected int TutorialId;
       protected string TutorialName;
        protected string TutorialDescripton;
        public void setTutorial(int pId, string pTutorialName)
        {
            TutorialId = pId;
            TutorialName = pTutorialName;

        }
        public void setTutorial(string pTutorialName)
        {
           
            TutorialName = pTutorialName;

        }
        public void setTutorial(int PId,string pTutorialName,string pDesc)
        {
            TutorialId = PId;
            TutorialName = pTutorialName;
            TutorialDescripton = pDesc;

        }
        public string getTutorialName()
        {
            return TutorialName+" "+TutorialId;
        }
    }
}
