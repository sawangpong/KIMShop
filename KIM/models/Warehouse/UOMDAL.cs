using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Warehouse
{
    public class UOMDAL
    {
        private readonly KIMEntities _context;
        public UOMDAL() => _context = new KIMEntities();

        public DataTable getUOMs() => _context.UOMs.OrderBy(o => o.UOMName).ToDataTable();

        public UOM getUOMById(string name) => _context.UOMs.Find(name);

        public decimal getUnitFactor(string unit) => _context.UOMs.Find(unit).Factor;

        public int removeUOM(string name)
        {
            _context.UOMs.Remove(getUOMById(name));
            return _context.SaveChanges();
        }

        public int updateUOM(UOM uom,DataActionMode mode)
        {
            switch (mode)
            {
                case DataActionMode.Add:
                    _context.UOMs.Add(uom);
                    break;

                case DataActionMode.Edit:
                    var _uom = getUOMById(uom.UOMName);
                    _uom.UOMName = uom.UOMName;
                    _uom.Factor = uom.Factor;
                    break;
            }
            return _context.SaveChanges();
        }
 
    }
}
