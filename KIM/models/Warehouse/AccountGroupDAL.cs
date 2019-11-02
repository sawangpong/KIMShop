using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Warehouse
{
    public class AccountGroupDAL
    {
        private readonly KIMEntities _context;
        public AccountGroupDAL() => _context = new KIMEntities();

        public DataTable getAccountGroups() => _context.AccountGroups.OrderBy(o => o.AccGroup).ToDataTable();

        public AccountGroup getAccountGroupById(string code) => _context.AccountGroups.Find(code);

        public int removeAccountGroup(string code)
        {
            _context.AccountGroups.Remove(getAccountGroupById(code));
            return _context.SaveChanges();
        }

        public int updateAccountGroup(AccountGroup acc, DataActionMode mode)
        {
            switch (mode)
            {
                case DataActionMode.Add:
                    _context.AccountGroups.Add(acc);
                    break;

                case DataActionMode.Edit:
                    var _acc = getAccountGroupById(acc.AccGroup);
                    _acc.AccGroup = acc.AccGroup;
                    _acc.AccountName = acc.AccountName;
                    break;
            }
            return _context.SaveChanges();
        }

    }
}
