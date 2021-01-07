using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handling
{
    public class Enumberable
    {
        private static DataRow[] Enumberable1(DataTable dt, DataGridViewCellEventArgs dv, string s,DataGridView gridView,int index)
        {
            int i = dv.RowIndex;//lấy vị trí hàng được click
            DataGridViewRow selectRow = gridView.Rows[index];
            IEnumerable<DataRow> query = dt.AsEnumerable().Where
                 (
                     row =>
                     (
                        i == -1 ? true : row.Field<string>(s).Contains(selectRow.Cells[0].Value.ToString())
                     )

                 ); ;
            DataTable o = query.CopyToDataTable<DataRow>();
            DataRow[] u = o.Select();
            return u;
        }
    }
}
