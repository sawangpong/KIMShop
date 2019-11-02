using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Warehouse
{
    public class StockDAL
    {
        private readonly KIMEntities _context;
        public StockDAL()
        {
            _context = new KIMEntities();
        }
        #region StockReceiveHeader

        public DataTable getStockReceives()
        {
            return _context.SKDOCHes
                            .Select(x => new
                            {
                                x.IsPosted,
                                Posted = x.IsPosted ? "Yes" : "No",
                                x.Code,
                                x.DOC_ID,
                                x.DocRef,
                                x.DocDate,
                                x.ReceiveBy,
                                x.Currency,
                                x.TaxAndClearing,
                                x.TransportCost,
                                x.OtherServices,
                                x.TotalItemCost,
                                x.TotalAmount
                            })
                            .OrderBy(o => o.DocRef)
                            .ToDataTable();
        }

        public DataTable getStockReceives(string doc) => _context.SKDOCHes.Where(x => x.DocRef.Contains(doc)).OrderBy(o => o.DocRef).ToDataTable();

        public SKDOCH getStokInfoById(string doc) => _context.SKDOCHes.Find(doc);

        public int removeStockRec(string doc)
        {
            _context.SKDOCHes.Remove(getStokInfoById(doc));
            return _context.SaveChanges();
        }

        public int updateStokDoc(SKDOCH stock, DataActionMode mode)
        {
            switch (mode)
            {
                case DataActionMode.Add:
                    _context.SKDOCHes.Add(stock);
                    break;

                case DataActionMode.Edit:
                    var _stock = getStokInfoById(stock.DocRef);
                    _stock.Currency = stock.Currency;
                    _stock.DocDate = stock.DocDate;
                    _stock.ModifyBy = stock.ModifyBy;
                    _stock.ModifyDate = stock.ModifyDate;
                    _stock.OtherServices = stock.OtherServices;
                    _stock.ReceiveBy = stock.ReceiveBy;
                    _stock.Remark = stock.Remark;
                    _stock.TaxAndClearing = stock.TaxAndClearing;
                    _stock.TotalAmount = stock.TotalAmount;
                    _stock.TotalItemCost = stock.TotalItemCost;
                    _stock.TransportCost = stock.TransportCost;
                    break;
            }

            return _context.SaveChanges();
        }
        #endregion

        #region StockReceiveItem

        public DataTable getStockReceivedItems(string docId) => _context.SKReceiveItems.Where(x => x.DocRef == docId).ToDataTable();

        public SKReceiveItem getStockReceiveItem(int id) => _context.SKReceiveItems.Find(id);


        #endregion

    }
}
