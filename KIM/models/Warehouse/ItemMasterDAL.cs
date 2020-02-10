using KIM.data;
using KIM.models.Warehouse.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Warehouse
{
    public class ItemMasterDAL
    {
        private readonly KIMEntities _context;
        public ItemMasterDAL() => _context = new KIMEntities();

        public DataTable getItemMasters() => _context.ItemMasters.OrderBy(o => o.ItemNo).ToDataTable();

        public DataTable getItemMasters(string filter)
        {
            var _vendor = _context.ItemMasters
                .Select(x => new
                {
                    x.InActive,
                    x.IsStockItem,
                    StockItem = x.IsStockItem ? "Y" : "N",
                    x.ItemId,
                    x.ItemNo,
                    x.ItemName,
                    x.StockUnit,
                    x.UnitWeight,
                    x.WeightUnit,
                    x.CatCode,
                    x.Warehouse,
                    x.MinQty,
                    x.MaxQty,
                    x.ReorderQty,
                    x.VendorId
                }).ToList();

            if (String.IsNullOrEmpty(filter))
            {
                return _vendor.ToDataTable();
            }
            else
            {
                return _vendor
                        .Where(x => x.ItemNo.Contains(filter) || x.ItemName.Contains(filter))
                        .OrderBy(o => o.ItemNo)
                        .ToDataTable();
            }
        }

        public DataTable getItemMastersByName(string itemName) => _context.ItemMasters.Where(x => x.ItemName.Contains(itemName)).OrderBy(o => o.ItemNo).ToDataTable();

        public ItemMaster getItemMasterById(string itemNo) => _context.ItemMasters.Find(itemNo);

        public decimal GetItemPrice(string itemNo) => _context.ItemMasters.Find(itemNo).UnitSellPrice;

        public int updateItemMaster(ItemMaster item, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.ItemMasters.Add(item);
                        break;

                    case DataActionMode.Edit:
                        var _item = getItemMasterById(item.ItemNo);
                        _item.AccGroup = item.AccGroup;
                        _item.AvgUnitCost = item.AvgUnitCost;
                        _item.Brand = item.Brand;
                        _item.Currency = item.Currency;
                        _item.CatCode = item.CatCode;
                        _item.ImageLocate = item.ImageLocate;
                        _item.InActive = item.InActive;
                        _item.IsStockItem = item.IsStockItem;
                        _item.ItemName = item.ItemName;
                        _item.ItemNo = item.ItemNo;
                        _item.MaxQty = item.MaxQty;
                        _item.MinQty = item.MinQty;
                        _item.ModifyBy = item.ModifyBy;
                        _item.ModifyDate = item.ModifyDate;
                        _item.ReorderQty = item.ReorderQty;
                        _item.StockUnit = item.StockUnit;
                        _item.UnitWeight = item.UnitWeight;
                        _item.VendorId = item.VendorId;
                        _item.Warehouse = item.Warehouse;
                        _item.WeightFactor = item.WeightFactor;
                        _item.WeightUnit = item.WeightUnit;
                        _item.UnitSellPrice = item.UnitSellPrice;
                        _item.Dimension = item.Dimension;
                        break;
                }

                return _context.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }

        public int UpdateLastUnitCost(string itemNo)
        {
            int _result = 0;
            DataTable _skBalance = new StockDAL().GetStockBalance(itemNo);
            foreach (DataRow dr in _skBalance.Rows)
            {
                var _item = getItemMasterById(dr["ItemNo"].ToString());
                _item.AvgUnitCost = Convert.ToDecimal(dr["UnitCost"].ToString());
                _item.ModifyBy = vars.USER_NAME;
                _item.ModifyDate = DateTime.Now;
            }

            return _context.SaveChanges();
        }

        public int removeItemMaster(string itemNo)
        {
            _context.ItemMasters.Remove(getItemMasterById(itemNo));
            return _context.SaveChanges();
        }
    }

    public class ItemMasterPicDAL
    {
        #region constructor

        private readonly KIMEntities _context;
        public ItemMasterPicDAL() => _context = new KIMEntities();

        #endregion

        public ItemMasterPic getItemPictureById(string id) => _context.ItemMasterPics.Find(id);

        public int updateItemMasterPic(ItemMasterPic item, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.ItemMasterPics.Add(item);
                        break;

                    case DataActionMode.Edit:
                        var _item = getItemPictureById(item.ItemNo);
                        _item.ItemPic = item.ItemPic;
                        break;
                }
                return _context.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }

        public int removeItemMasterPic(string id)
        {
            _context.ItemMasterPics.Remove(getItemPictureById(id));
            return _context.SaveChanges();
        }

    }
}
