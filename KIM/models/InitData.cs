using KIM.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models
{
    public class InitData
    {
        private readonly KIMEntities _context;
        public InitData()
        {
            _context = new KIMEntities();
        }

        public int InitUOM()
        {
            List<UOM> _uoms = new List<UOM>();
            _uoms.Add(new UOM() { UOMName = "Gram", Factor = 1m });
            _uoms.Add(new UOM() { UOMName = "KG", Factor = 1m });

            foreach(var _u in _uoms)
            {
                _context.UOMs.Add(_u);
            }
            return _context.SaveChanges();
        }

        public int InitSKU()
        {
            List<SKU> _skus = new List<SKU>();
            _skus.Add(new SKU() { SKUCode = "PC", SKUDetail = "Only one Peice" });
            _skus.Add(new SKU() { SKUCode = "EA", SKUDetail = "Only one each" });
            _skus.Add(new SKU() { SKUCode = "PACK", SKUDetail = "Standard Pack" });
            _skus.Add(new SKU() { SKUCode = "PACK5", SKUDetail = "5 PC/PACK" });
            _skus.Add(new SKU() { SKUCode = "BOX", SKUDetail = "Only one Box" });
            _skus.Add(new SKU() { SKUCode = "BOT", SKUDetail = "Only one Botton" });
            _skus.Add(new SKU() { SKUCode = "DOZ", SKUDetail = "12 PC" });

            foreach (var _sku in _skus)
            {
                _context.SKUs.Add(_sku);
            }
            return _context.SaveChanges();
        }

        public int InitCurrency()
        {
            List<Currency> _currencies = new List<Currency>();
            _currencies.Add(new Currency() { CURCode = "THB", CURdetail = "Thai Bath" });
            _currencies.Add(new Currency() { CURCode = "USD", CURdetail = "Amarican Dollar" });
            _currencies.Add(new Currency() { CURCode = "KMR", CURdetail = "Cambodia Rell" });
            foreach (var _c in _currencies)
            {
                _context.Currencies.Add(_c);
            }
            return _context.SaveChanges();
        }

        public int InitCreditTerm()
        {
            List<CreditTerm> _credits = new List<CreditTerm>();
            _credits.Add(new CreditTerm() { CRCode = "COD", CRTerm = "CASH ON DELIVERY" });
            _credits.Add(new CreditTerm() { CRCode = "15DAY", CRTerm = "PAYMENT AFTER DELIVERY 15 DAYS" });
            _credits.Add(new CreditTerm() { CRCode = "30DAY", CRTerm = "PAYMENT AFTER DELIVERY 30 DAYS" });
            _credits.Add(new CreditTerm() { CRCode = "TT", CRTerm = "TRANSFER MONEY TO ACCOUT" });

            foreach(var _c in _credits)
            {
                _context.CreditTerms.Add(_c);
            }
            return _context.SaveChanges();
        }

        public int InitWarehouse()
        {
            List<WareHouse> _whs = new List<WareHouse>();
            _whs.Add(new WareHouse() { WHCode = "WHSHOP", WHName ="Warehouse at Shop"});
            _whs.Add(new WareHouse() { WHCode = "WH2", WHName = "Other Warehouse" });

            foreach(var _wh in _whs)
            {
                _context.WareHouses.Add(_wh);
            }
            return _context.SaveChanges();
        }
    }
}
