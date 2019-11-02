using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Warehouse
{
    public class CategoryDAL
    {
        private readonly KIMEntities _context;
        public CategoryDAL() => _context = new KIMEntities();
        public DataTable getCategories() => _context.Categories.OrderBy(o=>o.CatCode).ToDataTable();
        public DataTable getCategoryByName(string catName) => _context.Categories.Where(x => x.CatName.Contains(catName)).OrderBy(o => o.CatName).ToDataTable();
        public Category getCategoryById(string catCode) => _context.Categories.Find(catCode);

        public int removeCategory(string catCode)
        {
            _context.Categories.Remove(getCategoryById(catCode));
            return _context.SaveChanges();
        }

        public int updateCategory(Category cat, DataActionMode mode)
        {
            switch (mode)
            {
                case DataActionMode.Add:
                    _context.Categories.Add(cat);
                    break;

                case DataActionMode.Edit:
                    var _cat = getCategoryById(cat.CatCode);
                    _cat.CatCode = cat.CatCode;
                    _cat.CatName = cat.CatName;
                    break;
            }

            return _context.SaveChanges();
        }
    }
}
