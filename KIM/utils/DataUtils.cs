using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace KIM
{
    public static class DataUtils
    {
        public static async Task<DataTable> ConvertAsyncoDataTable<T>(IEnumerable<T> Items)
        {
            var _tb = new DataTable(typeof(T).Name);
            try
            {
                _tb = await Task.Run(() =>
                {
                    var _t = _tb;
                    var _props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                    foreach (var _prop in _props)
                    {
                        var _propType = _prop.PropertyType;
                        if (_propType.IsGenericType && _propType.GetGenericTypeDefinition().Equals(typeof(Nullable)))
                            _propType = new NullableConverter(_propType).UnderlyingType;
                        _t.Columns.Add(_prop.Name, _propType);
                    }

                    foreach (var _item in Items)
                    {
                        var _values = new object[_props.Length];
                        for (var i = 0; i < _props.Length; i++) _values[i] = _props[i].GetValue(_item, null);
                        _t.Rows.Add(_values);
                    }

                    return _t;
                });
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Can't convert to data table {0} \n {1}", _tb.TableName, ex));
            }
            return _tb;

        } // end ConvertAsyncoDataTable


        public static DataTable ToDataTable<T>(IEnumerable<T> Items)
        {
            var _tb = new DataTable(typeof(T).Name);
            try
            {
                var _props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (var _prop in _props)
                {
                    var _propType = _prop.PropertyType;
                    if (_propType.IsGenericType && _propType.GetGenericTypeDefinition().Equals(typeof(Nullable)))
                        _propType = new NullableConverter(_propType).UnderlyingType;
                    _tb.Columns.Add(_prop.Name, _propType);
                }

                foreach (var _item in Items)
                {
                    var _values = new object[_props.Length];
                    for (var i = 0; i < _props.Length; i++) _values[i] = _props[i].GetValue(_item, null);
                    _tb.Rows.Add(_values);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Can't convert to data table {0} \n\n {1}", _tb.TableName, ex));
            }
            return _tb;
        } // end ToDataTable

        public static IEnumerable<object> ToList(DataTable dt)
        {
            var _data = dt.AsEnumerable().Select(row => new
            {
                Key = (int)row["Key"],
                Value = (string)row["Value"]
            });

            return _data.ToList();
        } // end ToList

        [Description("Sending parameter as Enumerator")]
        public static IEnumerable<KeyValuePair<int, string>> GetValueList<T>() where T : struct
        {
            if (!typeof(T).IsEnum) throw new ArgumentException("Method parameter accept only enum values");
            return
                Enum.GetValues(typeof(T))
                    .Cast<T>()
                    .Select(id => new KeyValuePair<int, string>(Convert.ToInt32(id), id.ToString()))
                    .OrderBy(x => x.Value)
                    .ToList();
        }

        public static T GetFilter<T>(string Title) =>  (T)Convert.ChangeType(GetFilter<string>(Title, string.Empty), Type.GetTypeCode(typeof(T)));
   
        public static T GetFilter<T>(string title, string defaultValue)
        {
            var _typeNeed = InputTypeValue.Text;
            var _value = new object();
            var _resultFilter = string.Empty;

            if (typeof(T) == typeof(string)) _typeNeed = InputTypeValue.Text;
            else _typeNeed = InputTypeValue.Number;

            // call input box
           _resultFilter = Interaction.InputBox(title, "Input", defaultValue ,-1,-1);

            if (string.IsNullOrEmpty(_resultFilter))
                if (_typeNeed == InputTypeValue.Number)
                {
                    _value = 0;
                    return (T)Convert.ChangeType(_value, Type.GetTypeCode(typeof(T)));
                }
                else
                {
                    return (T)Convert.ChangeType(_resultFilter, Type.GetTypeCode(typeof(T)));
                }
            if (Information.IsNumeric(_resultFilter)) _value = Convert.ToInt32(_resultFilter);
            else _value = _resultFilter;
            return (T)Convert.ChangeType(_value, Type.GetTypeCode(typeof(T)));
        } // end GetFilter
    }


    public class EnumWithName<T>
    {
        public string Name { get; set; }

        public int Value { get; set; }

        public string NameValue { get; set; }

        [Description("Parsing Enumerator to Array")]
        public static EnumWithName<T>[] ParseEnum()
        {
            var _list = new List<EnumWithName<T>>();
            foreach (var o in Enum.GetValues(typeof(T)))
                _list.Add(new EnumWithName<T>
                {
                    Name = Enum.GetName(typeof(T), o),
                    Value = (int)Enum.Parse(typeof(T), o.ToString()),
                    NameValue = $"{(int)Enum.Parse(typeof(T), o.ToString())} - {Enum.GetName(typeof(T), o)}"
                });
            return _list.ToArray();
        }
    } // end EnumWithName
}
