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
   public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        
        private readonly ApplicationDbContext _db;      // get the db instance using the constructor and DI 
        public CoverTypeRepository(ApplicationDbContext db) : base(db)   // use hot keys C-T-O-R to build the constructor
        {
            _db = db;

        }
        public void Update(CoverType covertype)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.ID == covertype.ID);
            if (objFromDb != null)
            {
                objFromDb.Name = covertype.Name;

            }
            throw new NotImplementedException();
        }
    }
}
