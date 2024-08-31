using Ecouz_Blazor.Data;

namespace Ecouz_Blazor.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public Category Create(Category obj);
        public Category Update(Category obj);
        public bool Delete(int id);
        public Category Gett(int id);
        public IEnumerable<Category> GetAll();
    }
}
