using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public  class CategoryManager
    {
        GenericRepository<Category> repository = new GenericRepository<Category>();
        public List<Category> GetAll()
        {
            return repository.GetAll();
        }

        public void Add(Category category)
        {

            if (category.CategoryName == "" || category.CategoryName.Length <= 3 ||
                category.CategoryDescription == "" || category.CategoryName.Length >= 51)
            {
                //Hata mesajı
            }
            else
            {
                repository.Add(category);
            }
        }

    }
}
