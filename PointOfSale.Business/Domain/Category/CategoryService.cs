using System.Collections.Generic;
using System.Threading.Tasks;
using PointOfSale.Data.Entities;
using PointOfSale.Data.Repositories.Categorys;
namespace PointOfSale.Business.Domain.Categorys
{
    public interface ICategoryService
    {
        Task<CategoryEntity> GetCategoryDetail(int CategoryId);
        Task<IEnumerable<CategoryEntity>> GetCategorysList();
        Task<CategoryEntity> SaveCategoryDetail(CategoryEntity model);
        Task<CategoryEntity> UpdateCategoryDetail(CategoryEntity model);
        Task DeleteCategoryDetail(int id);
    }
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _CategoryRepository;
        public CategoryService(ICategoryRepository CategoryRepository)
        {
            _CategoryRepository = CategoryRepository;
        }
        public async Task<CategoryEntity> GetCategoryDetail(int CategoryId)
        {
            return await _CategoryRepository.GetCategoryDetail(CategoryId);
        }
        public async Task<IEnumerable<CategoryEntity>> GetCategorysList()
        {
            return await _CategoryRepository.GetCategorysList();
        }
        public async Task<CategoryEntity> SaveCategoryDetail(CategoryEntity model)
        {
           return await _CategoryRepository.SaveCategoryDetail(model);
        }
        public async Task<CategoryEntity> UpdateCategoryDetail(CategoryEntity model)
        {
           return await _CategoryRepository.UpdateCategoryDetail(model);
        }
        public async Task DeleteCategoryDetail(int id)
        {
            await _CategoryRepository.DeleteCategoryDetail(id);
        }
    }
}