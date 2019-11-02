using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Warehouse
{
    public class SkuDAL
    {
        private readonly KIMEntities _context;
        public SkuDAL() => _context = new KIMEntities();

        public DataTable getSKUs() => _context.SKUs.OrderBy(o => o.SKUCode).ToDataTable();
        public SKU getSKUbyId(string skuCode) => _context.SKUs.Find(skuCode);

        public int removeSUK(string skuCode)
        {
            _context.SKUs.Remove(getSKUbyId(skuCode));
            return _context.SaveChanges();
        }

        public int updateSKU(SKU sku,DataActionMode mode)
        {
            switch (mode)
            {
                case DataActionMode.Add:
                    _context.SKUs.Add(sku);
                    break;

                case DataActionMode.Edit:
                    var _sku = getSKUbyId(sku.SKUCode);
                    _sku.SKUCode = sku.SKUCode;
                    _sku.SKUDetail = sku.SKUDetail;
                    break;
            }

            return _context.SaveChanges();
        }

    }
}
