using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_WPF.MODEL;
using Employee_WPF.DAL;
using Employee_WPF.UI;
using Employee_WPF.BLL;
namespace Employee_WPF.BLL
{
    class MangeBLL
    {
        public Salary search(List<string> list)
        {
            Salary salary = new Salary();
            salary.Id = list[0];
            salary.Name = list[1];
            salary.Sex = list[2];
            salary.Duty = list[3];
            salary.Depart = list[4];
            salary.Num1 = list[5];
            salary.Num2 = list[6];
            salary.Num3 = list[7];
            salary.Num4 = list[8];
            salary.image = list[9];
            return salary;
        }           
    }
}
