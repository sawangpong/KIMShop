using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace KIM
{
    public static class SCHelperExtionsion
    {
        #region helper extionstion method

        public static bool IsDate(this object value) => Microsoft.VisualBasic.Information.IsDate(value);

        //public static bool IsNumeric(this object value) => Microsoft.VisualBasic.Information.IsNumeric(value);
        public static bool IsNumeric(this string value) => Microsoft.VisualBasic.Information.IsNumeric(value);

        #endregion
            
        #region Database
        public static DataTable ToDataTable<T>(this IEnumerable<T> entity)
        {
            var properties = typeof(T).GetProperties();
            var table = new DataTable();
            foreach (var property in properties)
            {
                var type = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                table.Columns.Add(property.Name, type);
            }

            foreach (var item in entity)
            {
                table.Rows.Add(properties.Select(p => p.GetValue(item) ?? DBNull.Value).ToArray());
            }

            return table;
        } // end ToDataTable
        #endregion
    }
}
