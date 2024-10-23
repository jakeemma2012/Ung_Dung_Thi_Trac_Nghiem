using App_Thi_Trac_Nghiem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Thi_Trac_Nghiem_BUS
{
    public class StudentServices
    {
        public Model1 context = Services.getInstance().context;
        public static StudentServices instance;

        public static StudentServices gI()
        {
            if(instance == null)
                instance = new StudentServices();
            return instance;
        }

        public List<Student> getAllStudent()
        {
            return context.Students.ToList();
        }
    }
}
