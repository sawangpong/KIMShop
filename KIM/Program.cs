using KIM.models.AppSystem;
using KIM.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM
{
    static class Program
    {
        private static bool canRunApplication = true;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start to Setting and Config 
            Start();

            //Application.Run(new Kimshop());
            if (canRunApplication && (vars.USER_ID) > 0)
            {
                Kimshop _kim = new Kimshop();
                Application.Run(_kim);
            }
            else
            {
                throw new Exception("Application can't start, contact your administrator!");
            }
        }


        private static void Start()
        {
            /*
             * 1. Check for exist user profile (registry)
             *    if existing, Load company profile
             *    otherwise, crate company profile and user profile (registry)
             *      
             */

            if (!utilcore.ExistingRegistryKey(vars.APP_KEY))
            {
                // create User Profile configuration
                using (views.Startup.SysConfig _config = new views.Startup.SysConfig(DataActionMode.Create))
                {
                    _config.StartPosition = FormStartPosition.CenterScreen;

                    if (_config.ShowDialog() != DialogResult.OK)
                    {
                        canRunApplication = false;
                        Application.Exit();
                    }
                }
            }
            else if (!utilcore.UpdateConnectionString(vars.SYS_CONN_NAME, vars.SERVER, vars.DBNAME, vars.DBUSER, vars.DBPassword))
            {
                canRunApplication = false;
            }

            // load company profile 
            try
            {
                vars.SYS_PROFILE = new SystemDAL().GetSystemProfile(vars.COMPANY_CODE);
                if (vars.SYS_PROFILE == null)
                {
                    using (views.Tool.SysSetting _setting = new views.Tool.SysSetting("", DataActionMode.Add))
                    {
                        if (_setting.ShowDialog() == DialogResult.Cancel)
                        {
                            canRunApplication = false;
                        }
                    }
                }
                else // found company profile
                {
                    // flusing data with company profile
                    vars.COMPANY_CODE = vars.SYS_PROFILE.CompanyCode;
                    vars.COMP_NAME = vars.SYS_PROFILE.CompanyName;
                    //vars.DBNAME = vars.SYS_PROFILE.DatabaseName;
                    //vars.DBPassword = vars.SYS_PROFILE.DBAdminPassword;
                    //vars.DBUSER = vars.SYS_PROFILE.DBAdmin;
                    //vars.LANG_USE = vars.SYS_PROFILE.DefaultLangCode;
                    //vars.SERVER = vars.SYS_PROFILE.ServerName;
                }
            }
            catch
            {
                canRunApplication = false;
            }

            if (canRunApplication)
            {
                using (views.Startup.Login login = new views.Startup.Login())
                {
                    login.StartPosition = FormStartPosition.CenterScreen;
                    if (login.ShowDialog() == DialogResult.Cancel)
                    {
                        MessageBox.Show("Cancel login", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        canRunApplication = false;
                    }
                    else
                    {
                        vars.USER_ID = login.LogId;
                    }
                }
            }
            else
            {
                MessageBox.Show("Application Can't start, \n \n contact your administrator!!!!","Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
