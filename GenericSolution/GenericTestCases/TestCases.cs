using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.DirectoryServices;
using Microsoft.Win32;
using System.Security;
using System.Management;

namespace GenericTestCases
{    
    //Commented by 
    class TestCases
    {
        //tesint
        public bool IsSqlServerRunning()
        {
            try
            {
                ServiceController controller = new ServiceController("MSSQLSERVER");
                string status = controller.Status.ToString();
                if (status.Equals("Running"))
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool Is64Bit()
        {
            if (Environment.Is64BitOperatingSystem)
                return true;
            else
                return false;

        }
        public bool IsMSMQInstalledAndRunning()
         {
             try
             {
                ServiceController controller = new ServiceController("Message Queuing");
                string status = controller.Status.ToString();
                if (status.Equals("Running"))
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
    }//

        public bool IsDotNetFramework3_5Installed()
        {
        string s = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v3.5";
            string sk = "Version";
            object df ="Test" ;
            try
            {
                object vsver = Registry.GetValue(s, sk,df);
                if (vsver != null)
                    return true;
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool IsSilverLightInstalled()
        {
            try
            {
                string key = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Silverlight";
                string subkey = "Version";
                object df = "Test";
                object ov = Registry.GetValue(key, subkey, df);
                if (ov != null)
                    return true;
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

     

    }
}
  
  