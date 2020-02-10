using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Tool
{
    public class UOMDAL
    {
        private readonly KIMEntities _context;
        public UOMDAL() => _context = new KIMEntities();
        public DataTable GetUOMs() => _context.UOMs.OrderBy(o => o.UOMName).ToDataTable();

        public UOM GetUOMById(string name) => _context.UOMs.Find(name);

        public decimal GetUnitFactor(string unit) => _context.UOMs.Find(unit).Factor;

        public int RemoveUOM(string name)
        {
            _context.UOMs.Remove(GetUOMById(name));
            return _context.SaveChanges();
        }

        public int UpdateUOM(UOM uom, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.UOMs.Add(uom);
                        break;

                    case DataActionMode.Edit:
                        var _uom = GetUOMById(uom.UOMName);
                        _uom.UOMName = uom.UOMName;
                        _uom.Factor = uom.Factor;
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
