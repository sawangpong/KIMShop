using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using KIM.utils;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models
{
	public class CurrencyDAL
	{
		private readonly KIMEntities _context;

        public CurrencyDAL() => _context = new KIMEntities();
	
		public DataTable getCurrencies() => _context.Currencies.OrderBy(o => o.CURCode).ToDataTable();

		public Currency getCurrencyByName(string name) => _context.Currencies.Find(name);

		public int addCurrency(Currency currency)
		{
			_context.Currencies.Add(currency);
			return _context.SaveChanges();
		}

		public int updateCurrency(Currency currency)
		{
			var _currency = getCurrencyByName(currency.CURCode);
			_currency.CURdetail = currency.CURdetail;

			return _context.SaveChanges();
		}

        public int removeCurrency(string name)
        {
            _context.Currencies.Remove(getCurrencyByName(name));
            return _context.SaveChanges();
        }
	}
}
