using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports_DAL
{
    public class RptCtl
    {
        public DataSet GetDataTreeLst()
        {
            string DBFileName = Application.StartupPath + "\\EmployeesGroups.xml";
            DataSet dataSet = new DataSet();
            if (DBFileName != "")
            {
                DataSet l = new DataSet();
                dataSet.ReadXml(DBFileName);
                return dataSet;
            }
            return null;
        }
    }
}