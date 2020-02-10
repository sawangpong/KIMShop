using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Warehouse.Inventory
{
    public class StockDAL
    {
        #region Constructor

        private readonly KIMEntities _context;
        public StockDAL()
        {
            _context = new KIMEntities();
        }

        #endregion

        #region StockReceiveHeader

        public DataTable getStockReceives()
        {
            return _context.SKReceiveHs
                            .Select(x => new
                            {
                                x.IsPosted,
                                Posted = x.IsPosted ? "Yes" : "No",
                                x.SK_Code,
                                x.DOC_ID,
                                x.DOC_NUM,
                                x.DocDate,
                                x.Reason,
                                x.ReceiveBy,
                                x.Currency,
                                x.TaxAndClearing,
                                x.TransportCost,
                                x.OtherServices,
                                x.TotalItemCost,
                                x.TotalAmount
                            })
                            .OrderBy(o => o.Posted).ThenBy(o => o.DOC_NUM)
                            .ToDataTable();
        }

        public DataTable getStockReceives(string doc) => _context.SKReceiveHs
                                                            .Select(x => new
                                                            {
                                                                x.IsPosted,
                                                                Posted = x.IsPosted ? "Yes" : "No",
                                                                x.SK_Code,
                                                                x.DOC_ID,
                                                                x.DOC_NUM,
                                                                x.DocDate,
                                                                x.Reason,
                                                                x.ReceiveBy,
                                                                x.Currency,
                                                                x.TaxAndClearing,
                                                                x.TransportCost,
                                                                x.OtherServices,
                                                                x.TotalItemCost,
                                                                x.TotalAmount
                                                            }).Where(x => x.DOC_NUM.Contains(doc))
                                                            .OrderBy(o => o.Posted).ThenBy(o => o.DOC_NUM)
                                                            .ToDataTable();

        public SKReceiveH getStokInfoById(string doc) => _context.SKReceiveHs.Find(doc);

        public int removeStockRec(string doc)
        {
            _context.SKReceiveHs.Remove(getStokInfoById(doc));
            return _context.SaveChanges();
        }

        public int updateStokReceiveH(SKReceiveH stock, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.SKReceiveHs.Add(stock);
                        break;

                    case DataActionMode.Edit:
                        var _stock = getStokInfoById(stock.DOC_NUM);
                        _stock.Currency = stock.Currency;
                        _stock.DocDate = stock.DocDate;
                        _stock.IsPosted = stock.IsPosted;
                        _stock.PostedDate = stock.PostedDate;
                        _stock.PostedBy = stock.PostedBy;
                        _stock.ModifyBy = stock.ModifyBy;
                        _stock.ModifyDate = stock.ModifyDate;
                        _stock.OtherServices = stock.OtherServices;
                        _stock.Reason = stock.Reason;
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
            catch
            {
                return 0;
            }
        }

        public DataTable getStockReceiveReason() => _context.SKReceiveHs
                                                                .Select(x => new
                                                                {
                                                                    x.Reason
                                                                })
                                                                .Distinct()
                                                                .OrderBy(o => o.Reason)
                                                                .ToDataTable();

        #endregion

        #region StockReceiveItem

        public List<SKReceiveItem> GetStockReceivedItemLists(string docId) => _context.SKReceiveItems.Where(x => x.SKR_DOC_NUM == docId).ToList();

        public SKReceiveItem getStockReceiveItem(int id) => _context.SKReceiveItems.Find(id);

        public int UpdateStockReceiveItem(SKReceiveItem item, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.SKReceiveItems.Add(item);
                        break;

                    case DataActionMode.Edit:
                        var _item = getStockReceiveItem(item.SKI_ID);
                        _item.AvgUnitCost = item.AvgUnitCost;
                        _item.SK_Code = item.SK_Code;
                        _item.Currency = item.Currency;
                        _item.SKR_DOC_NUM = item.SKR_DOC_NUM;
                        _item.IsPosted = item.IsPosted;
                        _item.ItemName = item.ItemName;
                        _item.ItemNo = item.ItemNo;
                        _item.ItemTotalAmount = item.ItemTotalAmount;
                        _item.OtherCost = item.OtherCost;
                        _item.Qty = item.Qty;
                        _item.TaxClearing = item.TaxClearing;
                        _item.TotalItemCost = item.TotalItemCost;
                        _item.Transport = item.Transport;
                        _item.Unit = item.Unit;
                        _item.UnitCost = item.UnitCost;
                        break;
                }
                return _context.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }

        public int PostedStockRecivedItems(List<SKReceiveItem> items)
        {
            int _result = 0;
            try
            {
                // Posting (add) all received item to StockItemTransaction
                foreach (SKReceiveItem item in items)
                {
                    DataActionMode _transMode = DataActionMode.Add;
                    SKReceiveH _skH = getStokInfoById(item.SKR_DOC_NUM);
                    SKTRAN _sktrans = new SKTRAN();
                    _sktrans.CreateBy = vars.USER_NAME;
                    _sktrans.CreateDate = DateTime.Now;
                    _sktrans.DOC_DATE = _skH.DocDate;
                    _sktrans.DOC_NUM = _skH.DOC_NUM; _sktrans.CURRENCY = item.Currency;
                    _sktrans.ITEMNAME = item.ItemName;
                    _sktrans.ITEMNO = item.ItemNo;
                    _sktrans.LastUpdate = DateTime.Now;
                    _sktrans.SKT_QTY = item.Qty;
                    _sktrans.SKT_SKR = item.SKI_ID;
                    _sktrans.SKT_STATUS = 1;
                    _sktrans.SKT_U_COST = item.AvgUnitCost;
                    _sktrans.SKT_TOTALCOST = item.ItemTotalAmount;
                    _sktrans.U_PRICE = 0m;
                    _sktrans.U_DISCOUNT = 0m;
                    _sktrans.U_NET_PRICE = 0m;
                    _sktrans.U_VAT = 0m;
                    _sktrans.TOTAL_PRICE = 0m;
                    _sktrans.SK_CODE = item.SK_Code;
                    _sktrans.SK_UNIT = item.Unit;
                    _sktrans.UpdateBy = vars.USER_NAME;

                    _result = UpdateSKTrans(_sktrans, _transMode);
                }
                return _result;
            }
            catch
            {
                return _result;
            }
        }

        #endregion

        #region StockItemTransaction

        public List<SKTRAN> GetSKTranItems(string docNum) => _context.SKTRANS
                                                                      .Where(x => x.DOC_NUM == docNum)
                                                                      .OrderBy(o => o.ITEMNO)
                                                                      .ToList();

        public SKTRAN GetSKTRANByItemNo(string itemNo) => _context.SKTRANS.Single(x => x.ITEMNO == itemNo);
        public SKTRAN GetSKTRANByItemId(int id) => _context.SKTRANS.First(x => x.SKT_SKR == id);
        public bool ExistSKTransItem(string itemNo) => _context.SKTRANS.Any(x => x.ITEMNO == itemNo);
        public int UpdateSKTrans(SKTRAN item, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.SKTRANS.Add(item);
                        break;

                    case DataActionMode.Edit:
                        var _item = GetSKTRANByItemNo(item.ITEMNO);
                        _item.SKT_STATUS = item.SKT_STATUS;
                        _item.CURRENCY = item.CURRENCY;
                        _item.ITEMNAME = item.ITEMNAME;
                        _item.SKT_QTY = item.SKT_QTY;
                        _item.SKT_U_COST = item.SKT_U_COST;
                        _item.SKT_TOTALCOST = item.SKT_TOTALCOST;
                        _item.TOTAL_PRICE = item.TOTAL_PRICE;
                        _item.U_DISCOUNT = item.U_DISCOUNT;
                        _item.U_NET_PRICE = item.U_NET_PRICE;
                        _item.U_PRICE = item.U_PRICE;
                        _item.U_VAT = item.U_VAT;
                        _item.SK_UNIT = item.SK_UNIT;
                        _item.UpdateBy = item.UpdateBy;
                        _item.LastUpdate = item.LastUpdate;
                        break;
                }

                return _context.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }

        #endregion

        #region STOCK BALANCE - SB

        public DataTable GetStockBalance(string filter)
        {
            var _rows = _context.SKTRANS.Where(x => x.ITEMNO.Contains(filter) || x.ITEMNAME.Contains(filter)).ToList();

            var _tr = (from st in _rows
                       group st by new
                       {
                           st.ITEMNO,
                           st.ITEMNAME,
                           st.SK_CODE,
                           st.SK_UNIT,
                           st.CURRENCY,
                           st.LastUpdate
                       } into str
                       select new
                       {
                           SKCode = str.Key.SK_CODE,
                           ItemNo = str.Key.ITEMNO,
                           str.Key.ITEMNAME,
                           str.Key.SK_UNIT,
                           str.Key.CURRENCY,
                           qty = str.Sum(q => q.SKT_QTY),
                           TotalValue = str.Sum(t => t.SKT_TOTALCOST),
                           LastUpdate = str.Max(l => l.LastUpdate)
                       }).ToList();

            var _sb = (from b in _tr
                       group b by new { b.ItemNo, b.ITEMNAME, b.SK_UNIT, b.CURRENCY }
                      into bl
                       select new
                       {
                           bl.Key.ItemNo,
                           bl.Key.ITEMNAME,
                           bl.Key.SK_UNIT,
                           bl.Key.CURRENCY,
                           OnHand = (bl.Where(x => x.SKCode == "SR").Sum(x => x.qty) - bl.Where(x => x.SKCode == "SI").Sum(x => x.qty)),
                           Booking = bl.Where(x => x.SKCode == "BK").Sum(x => x.qty),
                           Available = ((bl.Where(x => x.SKCode == "SR").Sum(x => x.qty) - bl.Where(x => x.SKCode == "SI").Sum(x => x.qty)) - bl.Where(x => x.SKCode == "BK").Sum(x => x.qty)),
                           OnOrder = bl.Where(x => x.SKCode == "SP").Sum(x => x.qty),
                           UnitCost = (bl.Where(x => x.SKCode == "SR").Sum(x => x.qty) - bl.Where(x => x.SKCode == "SI").Sum(x => x.qty)) == 0 ? 0 : (bl.Where(x => x.SKCode == "SR").Sum(x => x.TotalValue) - bl.Where(x => x.SKCode == "SI").Sum(x => x.TotalValue)) / (bl.Where(x => x.SKCode == "SR").Sum(x => x.qty) - bl.Where(x => x.SKCode == "SI").Sum(x => x.qty)),

                           TotalValue = (bl.Where(x => x.SKCode == "SR").Sum(x => x.qty) - bl.Where(x => x.SKCode == "SI").Sum(x => x.qty)) == 0 ? 0 : (bl.Where(x=>x.SKCode == "SR").Sum(x => x.TotalValue) - bl.Where(x => x.SKCode == "SI").Sum(x => x.TotalValue)),
                           LastUpdate = bl.Max(l => l.LastUpdate)
                       }).OrderBy(o => o.ItemNo).ToList();

            return _sb.ToDataTable();
        }

        #endregion

        #region Issue

        public DataTable getStockIssueReason() => _context.SKIssueHs
                                                         .Select(x => new
                                                         {
                                                             x.Reason
                                                         })
                                                         .Distinct()
                                                         .OrderBy(o => o.Reason)
                                                         .ToDataTable();

        public DataTable GetIssues(string filter)
        {
            List<SKIssueH> _issues;
            _issues = String.IsNullOrEmpty(filter)
                ? _context.SKIssueHs.OrderBy(o => o.ISSUE_NUM).ToList()
                : _context.SKIssueHs.Where(x => x.ISSUE_NUM.Contains(filter)).OrderBy(o => o.ISSUE_NUM).ToList();

            return _issues.Select(x => new
            {
                x.IsPosted,
                Posted = x.IsPosted ? "Y" : "N",
                x.SK_Code,
                x.ISSUE_NUM,
                x.IssueDate,
                x.IssuedBy,
                x.Reason,
                x.Currency,
                x.TotalPrice
            }).ToDataTable();
        }

        public SKIssueH GetIssueInfo(string IssueNum) => _context.SKIssueHs.Find(IssueNum);

        public int UpdateStockIssue(SKIssueH issue, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.SKIssueHs.Add(issue);
                        break;

                    case DataActionMode.Edit:
                        var _issue = GetIssueInfo(issue.ISSUE_NUM);
                        _issue.IsPosted = issue.IsPosted;
                        _issue.IssueDate = issue.IssueDate;
                        _issue.IssuedBy = issue.IssuedBy;
                        _issue.ModifyBy = issue.ModifyBy;
                        _issue.ModifyDate = issue.ModifyDate;
                        _issue.PostedBy = issue.PostedBy;
                        _issue.PostedDate = issue.PostedDate;
                        _issue.Reason = issue.Reason;
                        _issue.Remark = issue.Remark;
                        _issue.TotalCost = issue.TotalCost;
                        _issue.TotalPrice = issue.TotalPrice;
                        break;
                }
                return _context.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }

        public int DeleteIssue(string IssueNo)
        {
            _context.SKIssueHs.Remove(GetIssueInfo(IssueNo));
            return _context.SaveChanges();
        }
        #endregion

        #region IssueItems

        public List<SKIssueItem> GetIssueItems(string issueNo) => _context.SKIssueItems
                                                                    .Where(x => x.SKI_ISSUE_NUM == issueNo)
                                                                    .OrderBy(o => o.Id)
                                                                    .ToList();
        public SKIssueItem GetIssueItemInfo(int id) => _context.SKIssueItems.Find(id);

        public int DeleteIssueItem(int id)
        {
            _context.SKIssueItems.Remove(GetIssueItemInfo(id));
            return _context.SaveChanges();
        }

        public int UpdateIssueItem(SKIssueItem item, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.SKIssueItems.Add(item);
                        break;

                    case DataActionMode.Edit:
                        var _item = GetIssueItemInfo(item.Id);
                        _item.Currency  = item.Currency;
                        _item.IsPosted = item.IsPosted;
                        _item.IssueQty = item.IssueQty;
                        _item.ItemId = item.ItemId;
                        _item.ItemName = item.ItemName;
                        _item.ItemNo = item.ItemNo;
                        _item.UnitPrice = item.UnitPrice;
                        _item.UnitCost = item.UnitCost;
                        _item.TotalItemCost = item.TotalItemCost;
                        _item.TotalItemPrice = item.TotalItemPrice;
                        _item.Unit = item.Unit;
                        break;
                }

                return _context.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }

        public int PostedStockIssueItems(List<SKIssueItem> items)
        {
            int _result = 0;
            try
            {
                // Posting (add) all received item to StockItemTransaction
                foreach (SKIssueItem item in items)
                {
                    DataActionMode _transMode = DataActionMode.Add;
                    SKIssueH _issueH = GetIssueInfo(item.SKI_ISSUE_NUM);
                    SKTRAN _sktrans = new SKTRAN();
                    _sktrans.CreateBy = vars.USER_NAME;
                    _sktrans.CreateDate = DateTime.Now;
                    _sktrans.DOC_DATE = _issueH.IssueDate;
                    _sktrans.DOC_NUM = _issueH.ISSUE_NUM; 
                    _sktrans.CURRENCY = item.Currency;
                    _sktrans.ITEMNAME = item.ItemName;
                    _sktrans.ITEMNO = item.ItemNo;
                    _sktrans.LastUpdate = DateTime.Now;
                    _sktrans.SKT_QTY = item.IssueQty;
                    _sktrans.SKT_SKR = item.Id;
                    _sktrans.SKT_STATUS = 1;
                    _sktrans.SKT_U_COST = item.UnitCost;
                    _sktrans.SKT_TOTALCOST = item.TotalItemCost;
                    _sktrans.U_PRICE = item.UnitPrice;
                    _sktrans.U_DISCOUNT = 0m;
                    _sktrans.U_NET_PRICE = item.UnitPrice;
                    _sktrans.U_VAT = 0m;
                    _sktrans.TOTAL_PRICE = item.TotalItemPrice;
                    _sktrans.SK_CODE = item.SK_Code;
                    _sktrans.SK_UNIT = item.Unit;
                    _sktrans.UpdateBy = vars.USER_NAME;

                    _result = UpdateSKTrans(_sktrans, _transMode);
                }
                return _result;
            }
            catch
            {
                return _result;
            }
        }

        #endregion
    }
}
