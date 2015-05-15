using Northwind.Mvc.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Mvc.Data.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        public Category GetById(int id)
        {
            Category c = null;
            using (northwindEntities ne = new northwindEntities())
            {
                c = ne.Categories.Where(x => x.CategoryID == id).FirstOrDefault();
            }
            return c;
        }

        public IEnumerable<Category> GetAll()
        {
            List<Category> list = new List<Category>();
            using (northwindEntities ne = new northwindEntities())
            {
                list = ne.Categories.ToList();
            }
            return list;
        }

        public void InsertOnSubmit(Category entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteOnSubmit(Category entity)
        {
            throw new NotImplementedException();
        }

        public void SubmitChanges()
        {
            throw new NotImplementedException();
        }
    }
}
