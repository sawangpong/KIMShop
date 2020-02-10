using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using KIM.utils;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Master
{
    public class CustomerDAL
    {
        private readonly KIMEntities _context;
        public CustomerDAL() => _context = new KIMEntities();

        #region Customer Info

        public DataTable getCustomers()
        {
            var _cust = (from x in _context.Customers.AsEnumerable()
                         orderby x.ContactName
                         select new
                         {
                             Active = x.Active ? "Y" : "N",
                             Class = Enum.GetName(typeof(CustomerType), x.CustomerType),
                             Status = Enum.GetName(typeof(CustomerStatus), x.Status),
                             Credit = x.CreditTerm,
                             x.CustomerCode,
                             x.CompanyName,
                             addr = x.Address + ", " + x.City + ", " + x.Province,
                             x.Country,
                             x.Phone,
                             x.ContactName,
                             x.Mobile,
                             x.Currency
                         }).ToDataTable();

            return _cust;
        }

        public DataTable getCustomersByCode(string code)
        {
            var _cust = (from x in _context.Customers.AsEnumerable()
                         where x.CustomerCode.Contains(code)
                         orderby x.ContactName
                         select new
                         {
                             Active = x.Active ? "Y" : "N",
                             Class = Enum.GetName(typeof(CustomerType), x.CustomerType),
                             Status = Enum.GetName(typeof(CustomerStatus), x.Status),
                             Credit = x.CreditTerm,
                             x.CustomerCode,
                             x.CompanyName,
                             addr = x.Address + ", " + x.City + ", " + x.Province,
                             x.Country,
                             x.Phone,
                             x.ContactName,
                             x.Mobile,
                             x.Currency
                         }).ToDataTable();

            return _cust;
        }

        public DataTable getCustomers(string code) => _context.Customers.Where(x => x.CustomerCode.Contains(code)).OrderBy(o => o.CompanyName).ToDataTable();

        public Customer getCustomerByCode(string code) => _context.Customers.Find(code);

        public int updateCustomer(Customer customer, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.Customers.Add(customer);
                        break;

                    case DataActionMode.Edit:
                        var _customer = _context.Customers.Find(customer.CustomerCode);
                        _customer.Active = customer.Active;
                        _customer.Address = customer.Address;
                        _customer.Balance = customer.Balance;
                        _customer.City = customer.City;
                        _customer.CompanyName = customer.CompanyName;
                        _customer.ContactName = customer.ContactName;
                        _customer.Country = customer.Country;
                        _customer.Creditlimit = customer.Creditlimit;
                        _customer.CreditTerm = customer.CreditTerm;
                        _customer.Currency = customer.Currency;
                        _customer.CustomerType = customer.CustomerType;
                        _customer.DeliveryAddress = customer.DeliveryAddress;
                        _customer.Email = customer.Email;
                        _customer.Fax = customer.Fax;
                        _customer.Industry = customer.Industry;
                        _customer.Mobile = customer.Mobile;
                        _customer.Phone = customer.Phone;
                        _customer.Province = customer.Province;
                        _customer.Status = customer.Status;
                        _customer.TaxCode = customer.TaxCode;
                        _customer.Website = customer.Website;
                        _customer.Zipcode = customer.Zipcode;
                        break;

                    case DataActionMode.Delete:
                        _context.Customers.Remove(_context.Customers.Find(customer.CustomerCode));
                        break;
                }

                return _context.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }

        public int removeCustomer(string code)
        {
            _context.Customers.Remove(getCustomerByCode(code));
            return _context.SaveChanges();
        }

        #endregion

        #region Delivery Address

        public DataTable getDeliveryList(string code) => _context.DeliveryAddrs
                                                                .Where(x => x.CustCode == code)
                                                                .Select(x => new
                                                                {
                                                                    x.id,
                                                                    addr = x.Address + ", "
                                                                            + x.City + ", "
                                                                            + x.Province + ", "
                                                                            + x.Country,
                                                                    x.ContactName
                                                                })
                                                                .OrderBy(o => o.id)
                                                                .ToDataTable();

        public List<DeliveryAddr> getFullDeliveryList(string code) => _context.DeliveryAddrs.Where(x => x.CustCode == code).ToList();

        public DeliveryAddr getAddrById(int id) => _context.DeliveryAddrs.Find(id);

        public int updateDeliveryAddr(DeliveryAddr addr, DataActionMode mode)
        {
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.DeliveryAddrs.Add(addr);

                        break;

                    case DataActionMode.Edit:
                        var _addr = getAddrById(addr.id);
                        _addr.Address = addr.Address;
                        _addr.City = addr.City;
                        _addr.ContactName = addr.ContactName;
                        _addr.Country = addr.Country;
                        _addr.email = addr.email;
                        _addr.fax = addr.fax;
                        _addr.mobile = addr.mobile;
                        _addr.phone = addr.phone;
                        _addr.Province = addr.Province;
                        _addr.Zipcode = addr.Zipcode;
                        break;
                }

                return _context.SaveChanges();
            }
            catch
            {
                return 0;
            }

        }

        public int removeDeliveryAddr(int id)
        {
            _context.DeliveryAddrs.Remove(getAddrById(id));
            return _context.SaveChanges();
        }


        #endregion


    }
}
