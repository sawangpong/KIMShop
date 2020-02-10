using KIM.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Order
{
	public class OrderDAL
	{
		private readonly KIMEntities _context;
		public OrderDAL()
		{
			_context = new KIMEntities();
		}

		#region Class helper

		public DataTable GetOrderByStatus(ActionStatus orderStatus) => _context.OrderHHs.AsEnumerable()
													.Where(x => x.OrderStatus == (int)orderStatus)
													.Select(x => new
													{
														x.OrderId,
														x.CustomerCode,
														x.CustomerName,
														x.OrderDate,
														x.Duedate,
														x.Currency,
														x.OrderAmount
													}).OrderBy(o => o.OrderId).ToDataTable();

		public DataTable GetAllActiveOrders() => _context.OrderHHs.AsEnumerable()
													.Where(x => x.OrderStatus == (int)ActionStatus.Active)
													.Select(x => new
													{
														x.OrderId,
														x.CustomerCode,
														x.CustomerName,
														x.OrderDate,
														x.Duedate,
														x.Currency,
														x.OrderAmount
													}).OrderBy(o => o.OrderId).ToDataTable();

		public OrderHH GetOrderById(string orderId) => _context.OrderHHs.Find(orderId);

		public int AddOrUpdateOrder(OrderHH order, DataActionMode mode)
		{
			switch (mode)
			{
				case DataActionMode.Add:
					_context.OrderHHs.Add(order);
					break;

				case DataActionMode.Edit:
					var _order = GetOrderById(order.OrderId);
					_order.CollectionDate = order.CollectionDate;
					_order.CreditTerm = order.CreditTerm;
					_order.Currency = order.Currency;
					_order.CustomerCode = order.CustomerCode;
					_order.CustomerName = order.CustomerName;
					_order.DeliveryAddr = order.DeliveryAddr;
					_order.Duedate = order.Duedate;
					_order.InvoiceDate = order.InvoiceDate;
					_order.InvoiceNo = order.InvoiceNo;
					_order.ModifyBy = order.ModifyBy;
					_order.ModifyDate = order.ModifyDate;
					_order.OrderAmount = order.OrderAmount;
					_order.OrderDate = order.OrderDate;
					_order.OrderStatus = order.OrderStatus;
					break;
			}
			return _context.SaveChanges();
		}

		public int DeleteOrder(string orderId)
		{
			_context.OrderHHs.Remove(GetOrderById(orderId));
			return _context.SaveChanges();
		}

		#endregion

	}


	
}
