using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Master
{
    public class VendorDAL
    {
        private readonly KIMEntities _context;
        public VendorDAL() => _context = new KIMEntities();

        public DataTable GetVendors(string vendorCode)
        {
            var _vendor = (from v in _context.Vendors.AsEnumerable()
                           orderby v.VendorCode
                           select new
                           {
                               v.Isactive,
                               Active = v.Isactive ? "Y" : "N",
                               Status = Enum.GetName(typeof(VendorStatus), v.Status),
                               v.VendorCode,
                               v.VendorName,
                               Address = v.Address + ", " + v.City + ", " + v.Province,
                               v.Country,
                               v.ContactName,
                               v.mobile,
                               v.Tel,
                               v.Fax,
                               v.Currency
                           }).ToList();

            if (String.IsNullOrEmpty(vendorCode))
            {
                return _vendor.ToDataTable();
            }
            else
            {
                return _vendor.Where(x => x.VendorCode.Contains(vendorCode)).ToDataTable();
            }
        }

        public DataTable GetVendorList(string filter)
        {
            if (String.IsNullOrEmpty(filter))
            {
                return _context.Vendors
                    .Select(x => new
                    {
                        x.VendorCode,
                        x.VendorName
                    }).OrderBy(o => o.VendorName)
                    .ToDataTable();
            }
            else
            {
                return _context.Vendors
                    .Where(x => x.VendorCode.Contains(filter) || x.VendorName.Contains(filter))
                    .Select(x => new
                    {
                        x.VendorCode,
                        x.VendorName
                    }).OrderBy(o => o.VendorName)
                    .ToDataTable();
            }
        }

        public DataTable GetVendorByName(string vendorName) => _context.Vendors.Where(x => x.VendorName.Contains(vendorName)).OrderBy(o => o.VendorName).ToDataTable();

        public data.Vendor GetVendorById(string vendorCode) => _context.Vendors.Find(vendorCode);

        public int RemoveVendor(string vendorCode)
        {
            _context.Vendors.Remove(GetVendorById(vendorCode));
            return _context.SaveChanges();
        }

        public int UpdateVendor(Vendor vendor, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.Vendors.Add(vendor);
                        break;

                    case DataActionMode.Edit:
                        var _vendor = GetVendorById(vendor.VendorCode);
                        _vendor.Address = vendor.Address;
                        _vendor.City = vendor.City;
                        _vendor.ContactName = vendor.ContactName;
                        _vendor.Country = vendor.Country;
                        _vendor.Currency = vendor.Currency;
                        _vendor.email = vendor.email;
                        _vendor.Fax = vendor.Fax;
                        _vendor.Isactive = vendor.Isactive;
                        _vendor.mobile = vendor.mobile;
                        _vendor.Province = vendor.Province;
                        _vendor.Status = vendor.Status;
                        _vendor.Tel = vendor.Tel;
                        _vendor.VendorName = vendor.VendorName;
                        _vendor.VendorType = vendor.VendorType;
                        _vendor.website = vendor.website;
                        _vendor.Zipcode = vendor.Zipcode;
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
