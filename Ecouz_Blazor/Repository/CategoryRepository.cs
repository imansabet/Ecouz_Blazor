using Ecouz_Blazor.Data;
using Ecouz_Blazor.Repository.IRepository;

namespace Ecouz_Blazor.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public Category Create(Category obj)
        {
            _db.Category.Add(obj);
            _db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var obj = _db.Category.FirstOrDefault(u => u.Id == id);
            if(obj != null)
            {
                _db.Category.Remove(obj);
                return  _db.SaveChanges() > 0;
            }
            return false;
        }

        public IEnumerable<Category> GetAll()
        {
            return _db.Category.ToList();
        }

        public Category Get(int id)
        {
            var obj = _db.Category.FirstOrDefault(u => u.Id == id);
            if (obj != null)
            {
                return new Category();
            }
            return obj;
        }

        public Category Update(Category obj)
        {
            var objFromDb = _db.Category.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb is not null)
            {
                objFromDb.Name = obj.Name;
                _db.Category.Update(objFromDb);
                _db.SaveChanges();
                return objFromDb;
            }
            return obj;
        }
    }
}
