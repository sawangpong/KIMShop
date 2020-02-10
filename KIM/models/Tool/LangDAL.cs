using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Tool
{
    public class LangDAL
    {
        private readonly KIMEntities _context;
        public LangDAL()
        {
            _context = new KIMEntities();
        }

        public List<LangDict> GetLanguages() => _context.LangDicts.OrderBy(o => o.Keyword).ToList();

        public DataTable GetLanguageByCode(string code)
        {
            DataTable _result = new DataTable(); ;
            switch (code)
            {
                case "EN":
                    _result = _context.LangDicts.Select(x => new
                    {
                        x.Keyword,
                        x.EN_text
                    }).OrderBy(o => o.Keyword).ToDataTable();
                    break;
                case "KH":
                    _result = _context.LangDicts.Select(x => new
                    {
                        x.Keyword,
                        x.KH_text
                    }).OrderBy(o => o.Keyword).ToDataTable();
                    break;
                case "TH":
                    _result = _context.LangDicts.Select(x => new
                    {
                        x.Keyword,
                        x.TH_text
                    }).OrderBy(o => o.Keyword).ToDataTable();
                    break;
            }

            return _result;
        }



        public LangDict GetLanguage(string key) => _context.LangDicts.Find(key);

        public int UpdateLanguageDict(LangDict lang, DataActionMode mode)
        {
            switch (mode)
            {
                case DataActionMode.Add:
                    _context.LangDicts.Add(lang);
                    break;

                case DataActionMode.Edit:
                    var _lang = GetLanguage(lang.Keyword);
                    _lang.KH_text = lang.KH_text;
                    _lang.EN_text = lang.EN_text;
                    _lang.TH_text = lang.TH_text;
                    break;
            }

            return _context.SaveChanges();
        }

        public int RemoveLangDict(string key)
        {
            _context.LangDicts.Remove(GetLanguage(key));
            return _context.SaveChanges();
        }

    }
}
