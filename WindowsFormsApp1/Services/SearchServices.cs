using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//YASSSEEEN

namespace WindowsFormsApp1.Services
{
    class SearchServices
    {
        DataAccess.ItemAccess itemAccess = new DataAccess.ItemAccess();
        public List<Entity.Item> SearchBy(string word)
        {
            return itemAccess.GetByAll(word);
        }

        public Entity.Item GetItemByID(int id)
        {
            return itemAccess.GetByID(id);
        }

    }
}
