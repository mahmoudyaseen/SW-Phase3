using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//YASSSEEEN

namespace WindowsFormsApp1.Services
{
    class VerificationServices
    {
        DataAccess.UserAccess userAccess = new DataAccess.UserAccess();
        public bool VerifyData(string userName , string password)
        {
            if (userAccess.GetUserPassword(userName) == password)
                return true;
            else
                return false;
        }
        public bool verifyUserName(string userName)
        {
            string pass = userAccess.GetUserPassword(userName);
            if (pass == null)
                return false;
            else
                return true;
        }
        public void SetNewUser(Entity.User user1)
        {
            userAccess.SetNewUser(user1);
        }
    }
}
