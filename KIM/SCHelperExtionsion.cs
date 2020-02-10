using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace KIM
{
    public static class SCHelperExtionsion
    {
        #region helper extionstion method

        public static bool IsDate(this object value) => Microsoft.VisualBasic.Information.IsDate(value);

        //public static bool IsNumeric(this object value) => Microsoft.VisualBasic.Information.IsNumeric(value);
        public static bool IsNumeric(this string value) => Microsoft.VisualBasic.Information.IsNumeric(value);


        public static void DoubleBuffered(this DataGridView dgv, bool setting=true)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        public static void SettingDataGrid(this DataGridView dgv)
        {
            dgv.BackColor = Color.White;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font.FontFamily, 12, FontStyle.Bold);
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.MultiSelect = false;
            dgv.Dock = DockStyle.Fill;
            dgv.GridColor = SystemColors.ActiveBorder;
            dgv.ReadOnly = true;
        }

        public static decimal ToDecimal(this TextBox text)
        {
            if (!String.IsNullOrEmpty(text.Text) && text.Text.IsNumeric())
            {
                return Convert.ToDecimal(text.Text);
            }
            return 0m;
        }

        public static Int32 ToInt32(this TextBox text)
        {
            if (!String.IsNullOrEmpty(text.Text) && text.Text.IsNumeric())
            {
                return Convert.ToInt32(text.Text);
            }
            return 0;
        }

        public static Int32 ToInt32(this string text)
        {
            if (!String.IsNullOrEmpty(text) && text.IsNumeric())
            {
                return Convert.ToInt32(text);
            }
            return 0;
        }

        public static decimal ToDecimal(this string text)
        {
            if (!String.IsNullOrEmpty(text) && text.IsNumeric())
            {
                return Convert.ToDecimal(text);
            }
            return 0m;
        }

        public static DateTime Num2Date(this decimal NumDate)
        {
            DateTime retDate;
            var sDate = string.Empty;
            try
            {
                sDate = NumDate.ToString();
                retDate = new DateTime(Convert.ToInt32(sDate.Substring(0, 4)), Convert.ToInt32(sDate.Substring(4, 2)),
                    Convert.ToInt32(sDate.Substring(6, 2)));
            }
            catch
            {
                retDate = DateTime.Today;
            }
            return retDate;
        } // end Num2Date

        public static DateTime Num2Date(this string NumDate)
        {
            DateTime retDate;
            var sDate = string.Empty;
            try
            {
                sDate = NumDate;
                retDate = new DateTime(Convert.ToInt32(sDate.Substring(0, 4)), Convert.ToInt32(sDate.Substring(4, 2)),
                    Convert.ToInt32(sDate.Substring(6, 2)));
            }
            catch
            {
                retDate = DateTime.Today;
            }
            return retDate;
        } // end Num2Date

        public static DateTime Num2Date(this int NumDate)
        {
            DateTime retDate;
            var sDate = string.Empty;
            try
            {
                sDate = NumDate.ToString();
                retDate = new DateTime(Convert.ToInt32(sDate.Substring(0, 4)), Convert.ToInt32(sDate.Substring(4, 2)),
                    Convert.ToInt32(sDate.Substring(6, 2)));
            }
            catch
            {
                retDate = DateTime.Today;
            }
            return retDate;
        } // end Num2Date

        public static int Date2Num(this object DateValue)
        {
            var ret = 0;
            try
            {
                var d = Convert.ToDateTime(DateValue);
                var dummy = string.Format("{0}{1}{2}", d.Year, "00".Substring(0, 2 - d.Month.ToString().Length) + d.Month,
                    "00".Substring(0, 2 - d.Day.ToString().Length) + d.Day);
                ret = Convert.ToInt32(dummy);
            }
            catch
            {
                ret = 0;
            }

            return ret;
        } // end Date2Num

        public static int Date2Num(this DateTime DateValue)
        {
            var ret = 0;
            try
            {
                var d = DateValue;
                var dummy = string.Format("{0}{1}{2}", d.Year, "00".Substring(0, 2 - d.Month.ToString().Length) + d.Month, "00".Substring(0, 2 - d.Day.ToString().Length) + d.Day);
                ret = Convert.ToInt32(dummy);
            }
            catch
            {
                ret = 0;
            }

            return ret;
        } // end Date2Num


        public static int Date2Num(this string DateValue)
        {
            var ret = 0;
            try
            {
                var d = Convert.ToDateTime(DateValue);
                var dummy = string.Format("{0}{1}{2}", d.Year, "00".Substring(0, 2 - d.Month.ToString().Length) + d.Month, "00".Substring(0, 2 - d.Day.ToString().Length) + d.Day);
                ret = Convert.ToInt32(dummy);
            }
            catch
            {
                ret = 0;
            }

            return ret;
        } // end Date2Num

        public static DateTime String2Date(this string StringDate)
        {
            DateTime _result = DateTime.Today;
            try
            {
                if(StringDate.IsDate())
                {
                    _result = Convert.ToDateTime(StringDate);
                }
            }
            catch
            {
                throw new Exception("Can't convert string value to datetime value!");
             }

            return _result;
        }

        public static bool IsDate(this DateTime DateValue)
        {
            return Information.IsDate(DateValue);
        }

        public static bool IsDate(this string DateValue)
        {
            return Information.IsDate(DateValue);
        }
        public static string GetMonthName(this int MonthNumber)
        {
            return DateAndTime.MonthName(MonthNumber, false);
        } // end GetMonthName


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
