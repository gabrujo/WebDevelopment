using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWinApp2.DataLayer
{
    interface IEntity
    {  // any class that is ivolved in conversion from a DataTable will provide this method
        void PopulateFields(DataRow dr);
    }
}
