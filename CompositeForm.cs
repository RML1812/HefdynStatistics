using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace HefdynApp
{
    public partial class CompositeForm : Form
    {
        private readonly string sheetsIndexPath = "Sheets Index.txt";

        public CompositeForm()
        {
            InitializeComponent();
            LoadCompositeData();
        }

        private void LoadCompositeData()
        {
            var sheetNames = File.ReadAllLines(sheetsIndexPath).Where(name => name != "None");
            var results = sheetNames.Select(sheetName => new
            {
                Index = sheetName,
                TotalResult = CalculateCompositeResult(sheetName)
            });

            foreach (var result in results)
            {
                compositeDataGridView.Rows.Add(result.Index, result.TotalResult);
            }

            var total = results.Sum(r => r.TotalResult);
            totalResultLabel.Text = $"Total: {total}";
        }

        private double CalculateCompositeResult(string sheetName)
        {
            double totalResult = 0.0;
            string filePath = $"{sheetName}.xlsx";

            using (FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                IWorkbook workbook = new XSSFWorkbook(inputStream);
                ISheet sheetNaik = workbook.GetSheet("APPRECIATION");
                ISheet sheetTurun = workbook.GetSheet("DEPRECIATION");

                totalResult = (CalculateSubTotal(sheetNaik) + CalculateSubTotal(sheetTurun)) / 2;
            }

            return totalResult;
        }

        private double CalculateSubTotal(ISheet sheet)
        {
            double total = 0.0;
            for (int i = 1; i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                if (row != null && row.GetCell(5) != null)
                {
                    total += row.GetCell(5).NumericCellValue;
                }
            }
            return total;
        }
    }
}