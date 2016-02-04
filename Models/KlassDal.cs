using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notic_board_2.Models
{
    public class KlassDal:IKlass
    {

        public List<string> GetKlass(string term)
        {
            using (Notice_boardEntities2 db = new Notice_boardEntities2())
            {

             return db.Klasses.Where(x => x.Name.Contains(term)).Select(y => y.Name).ToList();
            }
        }

        public void addKlass(Klass obj)
        {
            using (Notice_boardEntities2 db = new Notice_boardEntities2()) 
            {

                db.Klasses.Add(obj);
                db.SaveChanges();
            
            }
        }

        public void deleteKlass(int id)
        {
            using (Notice_boardEntities2 db = new Notice_boardEntities2())
            {

                var q=db.Klasses.SingleOrDefault(x=>x.Id == id);
                db.Klasses.Remove(q);
                db.SaveChanges();

            }
        }

        public void editKlass(Klass obj)
        {
            using (Notice_boardEntities2 db = new Notice_boardEntities2())
            {

                obj.Name = obj.Name;
                obj.Degree = obj.Degree;
                obj.Date = DateTime.Today;
                db.SaveChanges();
            }

        }

        public List<Klass> getAllKlass()
        {
            using (Notice_boardEntities2 db = new Notice_boardEntities2())
            {
                return db.Klasses.ToList();
            }

        }

     public Klass CheckklassName(string klassName)
        {
            using (Notice_boardEntities2 db = new Notice_boardEntities2())
            {
                return db.Klasses.SingleOrDefault(x => x.Name == klassName);
            }
        }

        public Klass getOneKlass(int? id)
        {
            using (Notice_boardEntities2 db = new Notice_boardEntities2())
            {
                return db.Klasses.SingleOrDefault(x => x.Id == id);
            }
        }
    }
}