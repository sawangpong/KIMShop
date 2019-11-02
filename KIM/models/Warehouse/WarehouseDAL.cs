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
        public DataTable getWarehouses() => _context.WareHouses.OrderBy(o => o.WHCode).ToDataTable();

        public WareHouse getWarehouseById(string whCode) => _context.WareHouses.Find(whCode);

        public int removeWarehouse(string whCode)
        {
            _context.WareHouses.Remove(getWarehouseById(whCode));
            return _context.SaveChanges();
        }

        public int updateWarehouseInfo(WareHouse wareHouse, DataActionMode mode)
        {
            switch (mode)
            {
                case DataActionMode.Add:
                    _context.WareHouses.Add(wareHouse);
                    break;
                case DataActionMode.Edit:
                    var _wh = getWarehouseById(wareHouse.WHCode);
                    _wh.WHName = wareHouse.WHName;
                    break;
            }
            return _context.SaveChanges();
        }
    }
}
