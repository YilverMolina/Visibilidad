using SemillerosUA.Models.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SemillerosUA.Models.Clases
{
    public class GeneralMethods
    {
        public GeneralMethods()
        {

        }

        //public List<Object> getList(DataTable dt)
        //{
        //    Parametro[] parameters = new Parametro[dt.Columns.Count];

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {

        //    }
        //    List<> list =
        //}

        public static object[,] Convert(DataTable dt)
        {
            var rows = dt.Rows;
            int rowCount = rows.Count;
            int colCount = dt.Columns.Count;
            var result = new object[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                var row = rows[i];
                for (int j = 0; j < colCount; j++)
                {
                    result[i, j] = row[j];
                }
            }

            return result;
        }
    }
}