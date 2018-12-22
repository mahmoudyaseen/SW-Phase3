using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//YASSSEEEN

namespace WindowsFormsApp1.Entity
{
    class Item
    {
        int IID;
        string Type;
        string Location;
        DateTime Date;
        string Description;
        byte[] Image;
        List<Question> Questions;
        //List<User> Applicant;
        public Item(int iID , string type, string location , DateTime date , string description , byte[] image)
        {
            IID = iID;
            Type = type;
            Location = location;
            Date = date;
            Description = description;
            Image = image;
            Questions = new List<Question>();
            //Applicant = new List<User>();
        }
        public int getIID() { return IID; }
        public String getType() { return Type; }
        public String getLocation() { return Location; }
        public DateTime getDate() { return Date; }
        public String getDescription() { return Description; }
        public byte[] getImage() { return Image; }
        public void AddAplicant(Question question)
        {
            Questions.Add(question);
        }
        /*public void AddAplicant(User applicant)
        {
            Applicant.Add(applicant);
        }*/
    }
}
