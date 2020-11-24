using Microsoft.EntityFrameworkCore;
using PointOfSale.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace PointOfSale.Data.Repositories.Categorys
{
    public interface ICategoryRepository
    {
        Task<CategoryEntity> GetCategoryDetail(int CategoryId);
        Task<IEnumerable<CategoryEntity>> GetCategorysList();
        Task<CategoryEntity> SaveCategoryDetail(CategoryEntity model);
        Task<CategoryEntity> UpdateCategoryDetail(CategoryEntity model);
        Task DeleteCategoryDetail(int id);

    }
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PointOfSaleDbContext _model;
        public CategoryRepository(PointOfSaleDbContext model)
        {
            _model = model;
        }

        public async Task<CategoryEntity> GetCategoryDetail(int CategoryId)
        {
            return await _model.Categories.FindAsync(CategoryId);
        }
        public async Task<IEnumerable<CategoryEntity>> GetCategorysList()
        {
            return await _model.Categories.ToListAsync();
        }
        public async Task<CategoryEntity> SaveCategoryDetail(CategoryEntity model)
        {
            await _model.Categories.AddAsync(model);
            _model.SaveChanges();
            return model;
        }
        public async Task<CategoryEntity> UpdateCategoryDetail(CategoryEntity model)
        {
            _model.Entry(model).State = EntityState.Modified;
            await _model.SaveChangesAsync();
            return model;
        }
        public async Task DeleteCategoryDetail(int id)
        {
            var model = _model.Categories.Find(id);
            _model.Categories.Remove(model);
            await _model.SaveChangesAsync();
        }
    }
}