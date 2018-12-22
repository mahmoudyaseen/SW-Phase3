using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//YASSSEEEN

namespace WindowsFormsApp1.Services
{
    class PostServices
    {
        DataAccess.ItemAccess itemAccess = new DataAccess.ItemAccess();
        DataAccess.QuestionAccess quesAccess = new DataAccess.QuestionAccess();
        public void AddPost(Entity.Item item1 )//add questions
        {
            itemAccess.AddItem(item1);
            //add questions
        }
        public int GetCount()
        {
            return itemAccess.GetNumberOfItems();
        }
        public void AddQues(Entity.Question ques , int Iid)
        {
            quesAccess.AddQuestion(ques, Iid);
        }
        public int QuesNum()
        {
            return quesAccess.GetNumberOfQuestion();
        }

    }
}
