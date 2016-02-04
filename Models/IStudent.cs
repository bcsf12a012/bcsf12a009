using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Notic_board_2.Models;

namespace Notic_board_2.Models
{
   public interface IStudent
    {
      

        List<user_table> getAllStudent();

        void deleteStudent(int? id);
        void AddStudent(user_table obj);

        void EditStudent(user_table obj);

        user_table CheckUserName(string name);
        

            
        



    }
}
