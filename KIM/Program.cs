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
            Start();

            //Application.Run(new Kimshop());
            if (canRunApplication && (vars.USER_ID) > 0)
            {
                Application.Run(new Kimshop());
            }
            else
            {
                throw new Exception("Application can't start, contact your administrator!");
            }

        }


        private static void Start()
        {
            using(var lang = new views.Startup.AppLang())
            {
                lang.StartPosition = FormStartPosition.CenterScreen;
                if(lang.ShowDialog() == DialogResult.OK)
                {
                    if (!utilcore.ExistingRegistryKey(vars.APP_KEY))
                    {
                        using (views.Startup.SysConfig _sysConfig = new views.Startup.SysConfig(DataActionMode.Create))
                        {
                            if (_sysConfig.ShowDialog() == DialogResult.Cancel)
                            {
                                MessageBox.Show("Cancel update to System Configuration", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                canRunApplication = false;
                            }
                        }
                    }
                    else if (!utilcore.UpdateConnectionString(vars.SYS_CONN_NAME, vars.SERVER, vars.DBNAME, vars.DBUSER, vars.DBPassword))
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
                }
            }
        }
    }
}
