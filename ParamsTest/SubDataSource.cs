using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsTest
{
    public class SubDataSource
    {
        public DataSet GetData(int id)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Position");

            for (int i = 0; i < 10; i++)
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = id;
                row["Position"] = $"Test position{i.ToString()}";
                dataTable.Rows.Add(row);
            }

            DataSet result = new DataSet();
            result.Tables.Add(dataTable);
            return result;
        }
    }
}
