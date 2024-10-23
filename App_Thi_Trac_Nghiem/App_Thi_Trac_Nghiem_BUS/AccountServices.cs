using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Thi_Trac_Nghiem_DAL.Model;
namespace App_Thi_Trac_Nghiem_BUS
{
    public class AccountServices
    {
        public Model1 context = Services.getInstance().context;

        public static AccountServices instance;

        public static AccountServices gI()
        {
            if(instance == null)
            {
                instance = new AccountServices();
            }
            return instance;
        }

        public Account getAccountLogin(string user)
        {
            return context.Accounts.FirstOrDefault(
                p => p.Username.CompareTo(user) == 0);
        }



    }
}
