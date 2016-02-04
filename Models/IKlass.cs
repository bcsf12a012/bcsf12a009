using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notic_board_2.Models;

namespace Notic_board_2.Models
{
   public interface IKlass
    {
        List<string> GetKlass(string term);
        void addKlass(Klass obj);
        void deleteKlass(int id);
        void editKlass(Klass obj);
        List<Klass> getAllKlass();
        Klass getOneKlass(int? id);




        Klass CheckklassName(string klassName);


    }
}
