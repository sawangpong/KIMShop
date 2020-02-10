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

        public DataTable GetSKUs() => _context.SKUs.OrderBy(o => o.SKUCode).ToDataTable();
        public SKU GetSKUbyId(string skuCode) => _context.SKUs.Find(skuCode);

        public int RemoveSUK(string skuCode)
        {
            _context.SKUs.Remove(GetSKUbyId(skuCode));
            return _context.SaveChanges();
        }

        public int UpdateSKU(SKU sku,DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.SKUs.Add(sku);
                        break;

                    case DataActionMode.Edit:
                        var _sku = GetSKUbyId(sku.SKUCode);
                        _sku.SKUCode = sku.SKUCode;
                        _sku.SKUDetail = sku.SKUDetail;
                        _sku.ConvertFactor = sku.ConvertFactor;
                        break;
                }

                return _context.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }

    }
}
