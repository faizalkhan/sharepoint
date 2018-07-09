using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerDataEntryScreen
{
    public class CommonCode
    {
        public bool CheckValidation(string Customername)
        {
            if (Customername.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
