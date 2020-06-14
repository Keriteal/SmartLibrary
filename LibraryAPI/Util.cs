using System;
using System.Text;
using Microsoft.Win32;

namespace LibraryAPI
{
    public static class Util
    {
        #region 注册表读取
        static public string Read(string key)
        {
            string result = "";
            try
            {
                RegistryKey reg_key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\SmartLibrary");
                var obj = reg_key.GetValue(key);
                if (obj != null)
                {
                    result = (string)reg_key.GetValue(key);
                }
                reg_key.Close();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        #endregion
        #region 注册表写入
        static public bool Write(string key, string value)
        {
            try
            {
                RegistryKey reg_key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\SmartLibrary");
                reg_key.SetValue(key, value);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        #endregion
    }
}
