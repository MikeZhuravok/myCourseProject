using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobCentre.Models
{
    public static class Exporter
    {
        private static Microsoft.Office.Interop.Excel.Application xlApp;
        private static Workbook xlWorkbook;
        private static Worksheet xlWorksheet;
        private static Range c1, c2, xlRange;

        public static void ToExcel(DataGridView source, System.Drawing.Color headInteriorColor,
        System.Drawing.Color headFontColor, int headFontSize, int mainFontSize, string columnToSum)
        {
            xlApp =
            new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                throw new NullReferenceException("Microsoft Excel is not properly installed.");
            }
            xlApp.Visible = true;

            xlWorkbook = xlApp.Workbooks.Add(Type.Missing);
            xlWorksheet = (Worksheet)xlWorkbook.Worksheets.get_Item(1);

            string[] columnNames = new string[source.Columns.Count];
            for (int i = 0; i < source.Columns.Count; i++)
            {
                columnNames[i] = source.Columns[i].HeaderText;
            }

            c1 = (Range)xlWorksheet.Cells[1, 1];
            c2 = (Range)xlWorksheet.Cells[1, columnNames.Length];
            xlRange = xlWorksheet.get_Range(c1, c2);
            xlRange.Value = columnNames;
            if (headFontSize > 0 && headFontSize <= 72)
            {
                xlRange.Font.Size = headFontSize;
            }
            xlRange.Interior.Color =
            System.Drawing.ColorTranslator.ToOle(headInteriorColor);
            xlRange.Font.Color =
            System.Drawing.ColorTranslator.ToOle(headFontColor);

            string[,] matrix = new string[source.Rows.Count + 1, source.Columns.Count];
            for (int i = 0; i < source.Rows.Count; i++)
            {
                for (int j = 0; j < source.Columns.Count; j++)
                {
                    matrix[i, j] = source.Rows[i].Cells[j].Value.ToString();
                }
            }

            if (source.Rows.Count != 0)
            {
                c1 = (Range)xlWorksheet.Cells[2, 1];
                c2 = (Range)xlWorksheet.Cells[matrix.GetLength(0), matrix.GetLength(1)];
                xlRange = xlWorksheet.get_Range(c1, c2);

                xlRange.Value = matrix;
                if (mainFontSize > 0 && mainFontSize <= 72)
                {
                    xlRange.Font.Size = headFontSize;
                }
            }
            if (columnToSum != null)
            {
                int number = -1;
                for (int i = 0; i < source.Columns.Count; i++)
                {
                    if (source.Columns[i].HeaderText == columnToSum)
                    {
                        number = i;
                        break;
                    }
                }
                if (number > -1)
                {
                    c2 = (Range)xlWorksheet.Cells[c2.Row + 1, c2.Column];
                    decimal sum = 0;
                    for (int i = 0; i < source.Rows.Count; i++)
                    {
                        sum += (decimal)source.Rows[i].Cells[number].Value;
                    }
                    c2.Value = sum;
                    c2.Interior.Color =
                    System.Drawing.ColorTranslator.ToOle(headInteriorColor);
                    c2.Font.Color =
                    System.Drawing.ColorTranslator.ToOle(headFontColor);
                    if (headFontSize > 0 && headFontSize <= 72)
                    {
                        c2.Font.Size = headFontSize;
                    }
                }

            }
            xlRange.EntireColumn.AutoFit();
        }
    }
}
