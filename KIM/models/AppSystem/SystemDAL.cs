using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.AppSystem
{
    public class SystemDAL
    {
        private readonly KIMEntities _context;

        public SystemDAL() => _context = new KIMEntities();

        public DataTable GetLanguageTable()
        {
            DataTable _dt = new DataTable();
            _dt.Columns.Add(new DataColumn("LangCode", typeof(System.String)));
            _dt.Columns.Add(new DataColumn("LanguageName", typeof(System.String)));

            DataRow _dr = _dt.NewRow();
            _dr["LangCode"] = "EN";
            _dr["LanguageName"] = "English";
            _dt.Rows.Add(_dr);

            _dr = _dt.NewRow();
            _dr["LangCode"] = "KH";
            _dr["LanguageName"] = "ភាសាខ្មែរ។";
            _dt.Rows.Add(_dr);

            return _dt;
        }

        public List<SysProfile> GetProfiles(string code) => _context.SysProfiles
                                                            .Where(x=>x.CompanyCode.Contains(code))
                                                            .OrderBy(o => o.CompanyName)
                                                            .ToList();

        //public SysProfile GetSystemProfile(string code) => _context.SysProfiles.Find(code);
        public SysProfile GetSystemProfile(string code) => _context.SysProfiles.SingleOrDefault(x => x.CompanyCode == code.Trim());

        public int UpdateSystemProfile(SysProfile profile, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.SysProfiles.Add(profile);
                        break;

                    case DataActionMode.Edit:
                        var _profile = GetSystemProfile(profile.CompanyCode);
                        _profile.Address = profile.Address;
                        _profile.AllowNagativeInventory = profile.AllowNagativeInventory;
                        _profile.CompanyName = profile.CompanyName;
                        _profile.ContactName = profile.ContactName;
                        _profile.Country = profile.Country;
                        _profile.CreditDuration = profile.CreditDuration;
                        _profile.CreditLimit = profile.CreditLimit;
                        _profile.DatabaseName = profile.DatabaseName;
                        _profile.DBAdmin = profile.DBAdmin;
                        _profile.DBAdminPassword = profile.DBAdminPassword;
                        _profile.DefaultLangCode = profile.DefaultLangCode;
                        _profile.DefaultWeightUOM = profile.DefaultWeightUOM;
                        _profile.DefaultWH = profile.DefaultWH;
                        _profile.HomeCurrency = profile.HomeCurrency;
                        _profile.ImageLocation = profile.ImageLocation;
                        _profile.PaymentTerm = profile.PaymentTerm;
                        _profile.ProfitMarkupRate = profile.ProfitMarkupRate;
                        _profile.ServerName = profile.ServerName;
                        _profile.SourceCurrency = profile.SourceCurrency;
                        _profile.TaxID = profile.TaxID;
                        _profile.TelFax = profile.TelFax;
                        _profile.VATRate = profile.VATRate;
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
