using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Warehouse
{
    public class WarehouseDAL
    {
        private readonly KIMEntities _context;
        public WarehouseDAL() => _context = new KIMEntities();
        public List<WareHouse> GetWarehouses() => _context.WareHouses.OrderBy(o => o.WHCode).ToList();

        public WareHouse GetWarehouseById(string Code) => _context.WareHouses.Find(Code);

        public int RemoveWarehouse(string Code)
        {
            _context.WareHouses.Remove(GetWarehouseById(Code));
            return _context.SaveChanges();
        }

        public int UpdateWarehouse(WareHouse wh, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.WareHouses.Add(wh);
                        break;
                    case DataActionMode.Edit:
                        var _wh = GetWarehouseById(wh.WHCode);
                        _wh.WHName = wh.WHName;
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
