using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Win32;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;

using Microsoft.VisualBasic;

namespace KIM.utils
{
    public static class utilcore
    {
        public static void SettingDataGrid(ref DataGridView dgv)
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


        #region Connection Utilities

        public static bool ExistingRegistryKey(string appKey)
        {
            var _result = false;
            foreach (var _key in Registry.CurrentUser.GetSubKeyNames())
            {
                if (_key == appKey)
                {
                    // read current registry values as supply key
                    _result = ReadAppRegistryConfiguration(appKey);
                    break;
                }
                else
                {
                    _result = false;
                }
            }
            return _result;
        } // end CheckExistingRegistry

        public static bool CreateAppRegistry(string appKey, string companyId, string serverName, string dbName, string dbUser, string dbPassword)
        {
            bool _result = false;
            try
            {
                using (var _rk = Registry.CurrentUser.CreateSubKey(appKey))
                {
                    _rk.SetValue("CompanyId", companyId);
                    _rk.SetValue("ServerName", serverName);
                    _rk.SetValue("DbName", dbName);
                    _rk.SetValue("DbUser", dbUser);
                    _rk.SetValue("DbPassword", dbPassword);
                }
                _result = true;
            }
            catch (Exception ex)
            {
                _result = false;
                throw new Exception("Can't create configuration!", ex);
            }
            return _result;
        }

        public static bool ReadAppRegistryConfiguration(string Key)
        {
            bool _result = false;
            try
            {
                // -- read registry for default server
                using (var _rk = Registry.CurrentUser.OpenSubKey(Key))
                {
                    vars.COMPANY_ID = _rk.GetValue("CompanyId").ToString();
                    vars.SERVER = _rk.GetValue("ServerName").ToString();
                    vars.DBNAME = _rk.GetValue("DbName").ToString();
                    vars.DBUSER = _rk.GetValue("DbUser").ToString();
                    vars.DBPassword = _rk.GetValue("DbPassword").ToString();
                }
                _result = true;
            }
            catch (Exception ex)
            {
                _result = false;
                throw new Exception("Error read configuration!", ex);

            }
            return _result;
        } // end ReadAppRegistryConfiguration

        // classic SQL Connection
        public static string getCurrentConnectionString(string ConnectionName)
        {
            var _connectionString = "";
            var _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // get connection_string collection from app.config
            var _cons = ConfigurationManager.ConnectionStrings;

            for (var i = 0; i <= _cons.Count; i++)
            {
                if (_cons[i].Name == ConnectionName)
                {
                    // get EF connectionString
                    var _efb = new EntityConnectionStringBuilder(_cons[i].ConnectionString);

                    // get classic SQL connectionString
                    var _sqb = new SqlConnectionStringBuilder(_efb.ProviderConnectionString);
                    _connectionString = _sqb.ConnectionString;
                    break;
                }
            }

            return _connectionString;
        } // end GetCurrentConnectionString 


        public static bool UpdateConnectionString(string ConnectionName, string Server, string Database, string UserId,
            string Password)
        {
            bool _result = false;
            var _connectionName = string.Empty;
            var _conString = string.Empty;
            var _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var _cons = ConfigurationManager.ConnectionStrings;
            try
            {
                for (var i = 0; i <= _cons.Count; i++)
                {
                    _connectionName = _cons[i].Name;
                    if (_connectionName == ConnectionName)
                    {
                        // get current connection string
                        _conString = _cons[i].ConnectionString;

                        // get EF connectionString
                        var _efb = new EntityConnectionStringBuilder(_conString);

                        // get classic SQL connectionString
                        var _sqb = new SqlConnectionStringBuilder(_efb.ProviderConnectionString);

                        _sqb.DataSource = Server;
                        _sqb.InitialCatalog = Database;
                        _sqb.UserID = UserId;
                        _sqb.Password = Password;
                        _efb.ProviderConnectionString = _sqb.ConnectionString;

                        // update EF ConnectionString in App.Config
                        _config.ConnectionStrings.ConnectionStrings[_connectionName].ConnectionString = _efb.ConnectionString;

                        // save
                        _config.Save(ConfigurationSaveMode.Modified, true);
                        ConfigurationManager.RefreshSection("connectionStrings");

                        _result = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                _result = false;
                throw new Exception("Can't update ConnectionString in App.Config file", ex);
            }

            return _result;
        } // end UpdateConnectionString

        #endregion





    }
}
