using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.data.dummy
{
    public static class DeliveryAddrOption
    {
        public static DataTable getDeliveryAddrOptions()
        {
            DataTable _dt = new DataTable();
            _dt.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
            _dt.Columns.Add(new DataColumn("Value", Type.GetType("System.Int32")));

            _dt.Rows.Add("Same as customer address", 0);
            _dt.Rows.Add("Add Delivery Address", 1);
            _dt.AcceptChanges();
            _dt.DefaultView.Sort = "Value ASC";
            return _dt;
        }

    }
}
