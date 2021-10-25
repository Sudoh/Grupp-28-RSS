﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace Grupp_28_RSS
{
    class Validering
    {
        public bool StringIsEmpty(string input)
        {
            bool result = false;

            if (input.Equals(""))
            {
                result = true;
            }

            return result;
        }

        public bool ValideraURL(string url)
        {
            string URLValidering = string.Empty;
            try
            {
                System.Text.Encoding enc = System.Text.Encoding.ASCII;
                WebClient obj = new WebClient();
                URLValidering = enc.GetString(obj.DownloadData(url));
            }
            catch (Exception e)
            {
                
                return false;
            }
            return URLValidering.Length != 0 ? true : false;
        }
       
    }
}