using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reports_DAL;
using System.Data;

namespace Reports_BCL
{
    public class Rptctl_BCL
    {
        private RptCtl gObjRptCtl_DAL = new RptCtl();
        public DataSet GetDataTreeList()
        {
            return gObjRptCtl_DAL.GetDataTreeLst();
        }
    }
}
