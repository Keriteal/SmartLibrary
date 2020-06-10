using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace LibraryAPI
{
    static class Util
    {
        static public string getMD5(string str)
        {
            var result = "";
            using (MD5 md5hash = MD5.Create())
            {
                byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(str));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                result = sBuilder.ToString();
            }
            return result;
        }

        static public string Read(string key)
        {
            string result = "";
            try
            {
                RegistryKey reg_key = Registry.CurrentUser.CreateSubKey(@"SoftWare/SmartLibrary");
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
    }
}
