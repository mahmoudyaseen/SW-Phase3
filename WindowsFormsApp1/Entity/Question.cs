using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//YASSSEEEN

namespace WindowsFormsApp1.Entity
{
    class Question
    {
        int QID;
        string Ques;
        Answer answer;
        public Question(int qID , string ques )
        {
            QID = qID;
            Ques = ques;
        }
        public string getQues() { return Ques; }
    }
}
