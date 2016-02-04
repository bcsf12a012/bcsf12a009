using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Notic_board_2.Models
{
    public class StudentDal:IStudent
    {



      public  user_table CheckUserName(string name)
        {
            using (Notice_boardEntities2 db = new Notice_boardEntities2())
            {
                return db.user_table.SingleOrDefault(x2 => x2.User_name == name);
            }
        }
        public List<user_table> getAllStudent()
        {
            throw new NotImplementedException();
        }

        public void deleteStudent(int? id)
        {
            throw new NotImplementedException();
        }

        public void AddStudent(user_table obj)
        {
            throw new NotImplementedException();
        }

        public void EditStudent(user_table obj)
        {
            throw new NotImplementedException();
        }
    }
}