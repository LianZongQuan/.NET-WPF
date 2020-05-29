using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_WPF.DAL;

namespace Employee_WPF.BLL
{
    class Longin
    {
        SQLManger SQLManger = new SQLManger();
        public bool longin(string str1, string str2)
        {
            return SQLManger.SQLlongin(str1,str2);
        }
    }
}
