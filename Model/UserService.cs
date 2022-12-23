using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCreatePay.app.Model
{
    public class UserService
    {
        Model2 db = new Model2(); 
        public bool CheckUser(string login, string password)
        {
           return db.Users.Any(w => w.Login == login & w.Password == password);
        }
    }
}
