using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//YASSSEEEN

namespace WindowsFormsApp1.Entity
{
    class User
    {
        string UserName;
        string Password;
        string Name;
        string Phone;
        List<Item> HisItems;
        public User( string userName , string password , string name , string phone)
        {
            UserName = userName;
            Password = password;
            Name = name;
            Phone = phone;
            HisItems = new List<Item>();
        }
        public string getUserName() { return UserName; }
        public string getPassword() { return Password; }
        public string getName() { return Name; }
        public string getPhone() { return Phone; }
        public void AddItem(Item item)
        {
            HisItems.Add(item);
        }
    }
}
