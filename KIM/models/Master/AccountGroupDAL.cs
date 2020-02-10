using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Master
{
    public class AccountGroupDAL
    {
        private readonly KIMEntities _context;
        public AccountGroupDAL() => _context = new KIMEntities();

        public DataTable GetAccountGroups() => _context.AccountGroups.OrderBy(o => o.AccGroup).ToDataTable();

        public AccountGroup GetAccountGroupById(string code) => _context.AccountGroups.Find(code);

        public int RemoveAccountGroup(string code)
        {
            _context.AccountGroups.Remove(GetAccountGroupById(code));
            return _context.SaveChanges();
        }

        public int UpdateAccountGroup(AccountGroup acc, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.AccountGroups.Add(acc);
                        break;

                    case DataActionMode.Edit:
                        var _acc = GetAccountGroupById(acc.AccGroup);
                        _acc.AccGroup = acc.AccGroup;
                        _acc.AccountName = acc.AccountName;
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
