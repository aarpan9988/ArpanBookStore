using ArpansBooks.DataAccess.Repository.IRepository;
using ArpansBooks.Models;
using ArpanBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArpansBooks.DataAccess.Repository
{
    public class CategoryRepository: Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;      // get the db instance using the constructor and DI 
        public CategoryRepository(ApplicationDbContext db) : base (db)   // use hot keys C-T-O-R to build the constructor
        {
            _db = db;
            
        }

        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.ID == category.ID);
            if(objFromDb !=null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
            throw new NotImplementedException();
        }
    }
}
