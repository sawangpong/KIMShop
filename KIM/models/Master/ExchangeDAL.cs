using KIM.data;
using KIM.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Master
{
    public class ExchangeDAL
    {
        private readonly KIMEntities _context;

        public ExchangeDAL() => _context = new KIMEntities();

        #region class helper
        public DataTable getExchangeByCurrency(string code, int yearExchange)
        {
            return _context.Exchanges
                .Where(x => x.CURCode == code && x.ExchDate.Year == yearExchange)
                .OrderByDescending(o => o.ExchDate)
                .ToDataTable();
        }

        public int deleteExchangeRecord(int id)
        {
            _context.Exchanges.Remove(getExchangeInfo(id));
            return _context.SaveChanges();
        }
        public Exchange getExchangeInfo(int id) => _context.Exchanges.Find(id);

        public int updateExchange(Exchange exchange)
        {
            try
            {
                if (exchange.Id == 0)
                {
                    _context.Exchanges.Add(exchange);
                }
                else
                {
                    var _ex = getExchangeInfo(exchange.Id);
                    _ex.ExchDate = exchange.ExchDate;
                    _ex.ExchRate = exchange.ExchRate;
                    _ex.ExpireDate = exchange.ExpireDate;
                    _ex.SpreadDay = exchange.SpreadDay;
                }

                return _context.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }

        public DataTable getExchangeYear() => _context.Exchanges
                                                        .Select(x => new
                                                        {
                                                            y = x.ExchDate.Year
                                                        }).Distinct()
                                                        .OrderByDescending(o => o.y)
                                                        .ToDataTable();


        #endregion
    }
}
