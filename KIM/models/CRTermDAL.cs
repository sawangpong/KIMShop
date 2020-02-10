using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models
{
    public class CRTermDAL
    {
        private readonly KIMEntities _context;
        public CRTermDAL() => _context = new KIMEntities();

        public DataTable getCreditTerms() => _context.CreditTerms.OrderBy(o => o.CRCode).ToDataTable();

        public CreditTerm getCreditTermByCode(string crcode) => _context.CreditTerms.Find(crcode);

        public int updateCreditTerm(CreditTerm cr, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.CreditTerms.Add(cr);
                        break;

                    case DataActionMode.Edit:
                        var _cr = getCreditTermByCode(cr.CRCode);
                        _cr.CRTerm = cr.CRTerm;

                        break;
                }

                return _context.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }

        public int removeCreditTerm(string crCode)
        {
            _context.CreditTerms.Remove(getCreditTermByCode(crCode));
            return _context.SaveChanges();
        }
    }
}
