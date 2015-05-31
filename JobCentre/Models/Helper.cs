using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobCentre.Models
{
    public static class Helper
    {
        public static string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\App_Data\LaborExchange.mdf;Integrated Security=True;Connect Timeout=30";

        public static List<string> DataTableToStringList(DataTable dt, bool firstColumn = true)
        {
            List<string> professions = new List<string>();
            if (firstColumn)
            {
                foreach (DataRow i in dt.AsEnumerable())
                {
                    professions.Add(i[0].ToString());
                }
            }
            else
            {
                foreach (DataRow i in dt.AsEnumerable())
                {
                    professions.Add(i[0].ToString() + " : " + i[1].ToString());
                }
            }
            return professions;
        }

        internal static bool TryParse(string data, out int emplId)
        {
            try
            {
                emplId = Int32.Parse(data.Split(':')[0]);
            }
            catch {
                emplId = -1;
                return false;
            }
            return true;
        }
    }
}
