using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NLog;
using NPOI.Util;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using NPOI.SS.Formula.Functions;
using static HefdynApp.MainForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace HefdynApp
{
    public partial class MainForm : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly string sheetsIndexPath = "Sheets Index.txt";

        public MainForm()
        {
            InitializeComponent();
            StreamWriter writer = new StreamWriter(sheetsIndexPath, true);
            writer.Close();
            if (new FileInfo(sheetsIndexPath).Length == 0)
            {
                WriteNewSheet("None");
            }
            try
            {
                FirstPopulate();
            }
            catch (IOException ex)
            {
                Logger.Error(ex, "Error initializing sheets");
            }
            RefreshSheets();
            sheetsName.SelectedItem = "None";
        }

        private void WriteNewSheet(string sheetName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(sheetsIndexPath, true))
                {
                    writer.WriteLine(sheetName);
                    writer.Close();
                }
            }
            catch (IOException ex)
            {
                Logger.Error(ex, "Error writing new sheet");
            }
        }

        public class Index
        {
            public string Name { get; set; }
            public double Result { get; set; }

            public Index(string name, double result)
            {
                Name = name;
                Result = result;
            }
        }

        private void btnAddNaik_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateNumberOnly(txtDataNaik))
                {
                    return;
                }

                if (txtWeightNaik.Enabled)
                {
                    if (!ValidateNumberOnly(txtWeightNaik))
                    {
                        return;
                    }
                }

                double data = double.Parse(txtDataNaik.Text);
                string date = txtDateNaik.Text;
                double weight = string.IsNullOrEmpty(txtWeightNaik.Text) ? 0.0 : double.Parse(txtWeightNaik.Text);
                string filePath = $"{sheetsName.SelectedItem}.xlsx";

                using (FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(inputStream);
                    ISheet sheet = workbook.GetSheet("APPRECIATION");

                    int newRowNum = sheet.LastRowNum + 1;
                    IRow newRow = sheet.CreateRow(newRowNum);
                    UpdateCell(newRow, 0, date);
                    UpdateCell(newRow, 1, data);
                    if (newRowNum > 1)
                    {
                        UpdateCell(newRow, 2, weight);
                    }

                    using (FileStream outputStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(outputStream);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error adding new data");
            }

            RefreshNaik();
        }

        private void btnEditNaik_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateNumberOnly(txtDataNaik))
                {
                    return;
                }

                if (txtWeightNaik.Enabled)
                {
                    if (!ValidateNumberOnly(txtWeightNaik))
                    {
                        return;
                    }
                }

                DataGridViewRow selectedRow = jTableNaik.SelectedRows[0];
                int selectIndex = selectedRow.Index + 1;

                double data = double.Parse(txtDataNaik.Text);
                string date = txtDateNaik.Text;
                double weight = string.IsNullOrEmpty(txtWeightNaik.Text) ? 0.0 : double.Parse(txtWeightNaik.Text);
                string filePath = $"{sheetsName.SelectedItem}.xlsx";

                using (FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(inputStream);
                    ISheet sheet = workbook.GetSheet("APPRECIATION");

                    IRow newRow = sheet.CreateRow(selectIndex);
                    UpdateCell(newRow, 0, date);
                    UpdateCell(newRow, 1, data);
                    if (selectIndex > 1)
                    {
                        UpdateCell(newRow, 2, weight);
                    }

                    using (FileStream outputStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(outputStream);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error editing data");
            }

            RefreshNaik();
        }

        private void btnDeleteNaik_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = jTableNaik.SelectedRows[0];
                int selectIndex = selectedRow.Index + 1;
                string filePath = $"{sheetsName.SelectedItem}.xlsx";

                using (FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(inputStream);
                    ISheet sheet = workbook.GetSheet("APPRECIATION");

                    if (selectIndex >= 0)
                    {
                        sheet.RemoveRow(sheet.GetRow(selectIndex));
                        if (selectIndex < sheet.LastRowNum)
                        {
                            sheet.ShiftRows(selectIndex + 1, sheet.LastRowNum, -1);
                        }
                    }

                    using (FileStream outputStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(outputStream);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error deleting data");
            }

            RefreshNaik();
        }

        private void RefreshNaik()
        {
            btnEditNaik.Enabled = false;
            btnDeleteNaik.Enabled = false;
            btnAddNaik.Enabled = true;
            txtDataNaik.Text = "";
            txtWeightNaik.Text = "";
            txtDateNaik.Text = "";
            RefreshSheets();
        }

        private void btnAddTurun_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateNumberOnly(txtDataTurun))
                {
                    return;
                }

                if (txtWeightTurun.Enabled)
                {
                    if (!ValidateNumberOnly(txtWeightTurun))
                    {
                        return;
                    }
                }

                double data = double.Parse(txtDataTurun.Text);
                string date = txtDateTurun.Text;
                double weight = string.IsNullOrEmpty(txtWeightTurun.Text) ? 0.0 : double.Parse(txtWeightTurun.Text);
                string filePath = $"{sheetsName.SelectedItem}.xlsx";

                using (FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(inputStream);
                    ISheet sheet = workbook.GetSheet("DEPRECIATION");

                    int newRowNum = sheet.LastRowNum + 1;
                    IRow newRow = sheet.CreateRow(newRowNum);
                    UpdateCell(newRow, 0, date);
                    UpdateCell(newRow, 1, data);
                    UpdateCell(newRow, 2, weight);

                    using (FileStream outputStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(outputStream);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error adding new data");
            }

            RefreshTurun();
        }

        private void btnEditTurun_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateNumberOnly(txtDataTurun))
                {
                    return;
                }

                if (txtWeightTurun.Enabled)
                {
                    if (!ValidateNumberOnly(txtWeightTurun))
                    {
                        return;
                    }
                }

                DataGridViewRow selectedRow = jTableTurun.SelectedRows[0];
                int selectIndex = selectedRow.Index + 1;

                double data = double.Parse(txtDataTurun.Text);
                string date = txtDateTurun.Text;
                double weight = string.IsNullOrEmpty(txtWeightTurun.Text) ? 0.0 : double.Parse(txtWeightTurun.Text);
                string filePath = $"{sheetsName.SelectedItem}.xlsx";

                using (FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(inputStream);
                    ISheet sheet = workbook.GetSheet("DEPRECIATION");

                    IRow newRow = sheet.CreateRow(selectIndex);
                    UpdateCell(newRow, 0, date);
                    UpdateCell(newRow, 1, data);
                    UpdateCell(newRow, 2, weight);

                    using (FileStream outputStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(outputStream);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error editing data");
            }

            RefreshTurun();
        }

        private void btnDeleteTurun_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = jTableTurun.SelectedRows[0];
                int selectIndex = selectedRow.Index + 1;
                string filePath = $"{sheetsName.SelectedItem}.xlsx";

                using (FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(inputStream);
                    ISheet sheet = workbook.GetSheet("DEPRECIATION");

                    if (selectIndex >= 0)
                    {
                        sheet.RemoveRow(sheet.GetRow(selectIndex));
                        if (selectIndex < sheet.LastRowNum)
                        {
                            sheet.ShiftRows(selectIndex + 1, sheet.LastRowNum, -1);
                        }
                    }

                    using (FileStream outputStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(outputStream);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error deleting data");
            }

            RefreshTurun();
        }

        private void RefreshTurun()
        {
            btnEditTurun.Enabled = false;
            btnDeleteTurun.Enabled = false;
            btnAddTurun.Enabled = true;
            txtDataTurun.Text = "";
            txtWeightTurun.Text = "";
            txtDateTurun.Text = "";
            RefreshSheets();
        }

        private void RefreshSheets()
        {
            if (sheetsName.GetItemText(sheetsName.SelectedItem).Equals("None"))
            {
                btnRename.Enabled = false;
                btnRemove.Enabled = false;

                txtDateNaik.Enabled = false;
                txtDataNaik.Enabled = false;
                txtWeightNaik.Enabled = false;
                btnAddNaik.Enabled = false;
                btnEditNaik.Enabled = false;
                btnDeleteNaik.Enabled = false;

                txtDateTurun.Enabled = false;
                txtDataTurun.Enabled = false;
                txtWeightTurun.Enabled = false;
                btnAddTurun.Enabled = false;
                btnEditTurun.Enabled = false;
                btnDeleteTurun.Enabled = false;

                labelTotal.Text = "...";
                labelSubNaik.Text = "...";
                labelSubTurun.Text = "...";

                jTableNaik.Rows.Clear();
                jTableNaik.Refresh();
                jTableTurun.Rows.Clear();
                jTableTurun.Refresh();

                return;
            }

            txtDateNaik.Enabled = true;
            txtDataNaik.Enabled = true;
            txtWeightNaik.Enabled = true;
            btnAddNaik.Enabled = true;

            txtDateTurun.Enabled = true;
            txtDataTurun.Enabled = true;
            txtWeightTurun.Enabled = true;
            btnAddTurun.Enabled = true;

            txtSheetsName.Text = "";
            txtDataNaik.Text = "";
            txtWeightNaik.Text = "";
            txtDateNaik.Text = "";
            txtDataTurun.Text = "";
            txtWeightTurun.Text = "";
            txtDateTurun.Text = "";

            btnRename.Enabled = true;
            btnRemove.Enabled = true;

            try
            {
                string filePath = $"{sheetsName.SelectedItem}.xlsx";

                if (!File.Exists(filePath))
                {
                    CreateNewWorkbook(filePath);
                }

                using (FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(inputStream);
                    ISheet sheetNaik = workbook.GetSheet("APPRECIATION");
                    ISheet sheetTurun = workbook.GetSheet("DEPRECIATION");

                    RefreshSheetData(sheetNaik, jTableNaik, "NAIK");
                    RefreshSheetData(sheetTurun, jTableTurun, "TURUN");

                    using (FileStream outputStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(outputStream);
                    }

                    labelSubNaik.Text = SubTotal(sheetNaik, sheetNaik.LastRowNum).ToString();
                    labelSubTurun.Text = SubTotal(sheetTurun, sheetTurun.LastRowNum).ToString();
                    labelTotal.Text = ((SubTotal(sheetNaik, sheetNaik.LastRowNum) + SubTotal(sheetTurun, sheetTurun.LastRowNum)) / 2).ToString();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error refreshing sheets");
            }
        }

        public double Rate0(ISheet sh, int newRowNum, string arah)
        {
            double current = sh.GetRow(newRowNum).GetCell(1).NumericCellValue;
            double prev = sh.GetRow(newRowNum - 1).GetCell(1).NumericCellValue;
            double res = 0.0;

            if (arah.Equals("NAIK"))
            {
                res += (current - prev) / prev;
            }
            else if (arah.Equals("TURUN"))
            {
                res += (prev - current) / current;
            }
            return 1 + res;
        }

        public double Rate(ISheet sh, int totalRowNum, string arah)
        {
            double res = 0.0;
            for (int i = 1; i < totalRowNum; i++)
            {
                res += Rate0(sh, i + 1, arah);
            }
            return res / (totalRowNum - 1);
        }

        public double Change(ISheet sh, int newRowNum, string arah, int totalRowNum)
        {
            double rate = Rate(sh, totalRowNum, arah);
            double rate0 = Rate0(sh, newRowNum, arah);

            double res = (rate0 - rate) / rate;

            return 1 + res;
        }

        public double Result(ISheet sh, int newRowNum, string arah, int totalRowNum)
        {
            double weight = sh.GetRow(newRowNum).GetCell(2).NumericCellValue;

            double res = Change(sh, newRowNum, arah, totalRowNum) * weight;
            if (res <= 0)
            {
                res = 0.01;
            }

            return res;
        }

        public double SubTotal(ISheet sh, int totalRowNum)
        {
            double res = 0.0;
            for (int i = 1; i <= totalRowNum; i++)
            {
                if (i > 1)
                {
                    res += sh.GetRow(i).GetCell(5).NumericCellValue;
                }
            }

            return res / (totalRowNum - 1);
        }

        public void UpdateCell(IRow newRow, int cell, double update)
        {
            ICell newCell = newRow.CreateCell(cell);
            newCell.SetCellValue(update);
        }

        public void UpdateCell(IRow newRow, int cell, string update)
        {
            ICell newCell = newRow.CreateCell(cell);
            newCell.SetCellValue(update);
        }

        private void RefreshSheetData(ISheet sheet, DataGridView table, string direction)
        {
            if (table.Columns.Count == 0)
            {
                table.Columns.Add("DATE", "DATE");
                table.Columns.Add("DATA", "DATA");
                table.Columns.Add("WEIGHT", "WEIGHT");
                table.Columns.Add("CHANGE", "CHANGE");
                table.Columns.Add("RATE", "RATE");
                table.Columns.Add("RESULT", "RESULT");

                table.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.ReadOnly = true);
                table.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            }

            int totalRowNum = sheet.LastRowNum;
            DataGridViewRowCollection rows = table.Rows;
            rows.Clear();

            if (totalRowNum == 0)
            {
                if (table == jTableNaik)
                {
                    txtWeightNaik.Enabled = false;
                }
                if (table == jTableTurun)
                {
                    txtWeightTurun.Enabled = false;
                }
            }

            for (int i = 1; i <= totalRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                DataGridViewRow newRow = new DataGridViewRow();
                for (int j = 0; j <= 5; j++)
                {
                    if (i > 1 && j == 3)
                    {
                        UpdateCell(row, 3, Rate0(sheet, i, direction));
                        UpdateCell(row, 4, Change(sheet, i, direction, totalRowNum));
                        UpdateCell(row, 5, Result(sheet, i, direction, totalRowNum));
                    }
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    ICell excelCell = row.GetCell(j);

                    if (excelCell != null)
                    {
                        cell.Value = excelCell.ToString();
                    }
                    else
                    {
                        cell.Value = string.Empty;
                    }
                    newRow.Cells.Add(cell);
                }
                rows.Add(newRow);
            }
        }

        private void CreateNewWorkbook(string filePath)
        {
            using (FileStream outputStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();
                ISheet sheetNaik = workbook.CreateSheet("APPRECIATION");
                ISheet sheetTurun = workbook.CreateSheet("DEPRECIATION");

                IRow rowNaik = sheetNaik.CreateRow(0);
                IRow rowTurun = sheetTurun.CreateRow(0);

                UpdateCell(rowNaik, 0, "DATE");
                UpdateCell(rowNaik, 1, "DATA");
                UpdateCell(rowNaik, 2, "WEIGHT");
                UpdateCell(rowNaik, 3, "CHANGE");
                UpdateCell(rowNaik, 4, "RATE");
                UpdateCell(rowNaik, 5, "RESULT");

                UpdateCell(rowTurun, 0, "DATE");
                UpdateCell(rowTurun, 1, "DATA");
                UpdateCell(rowTurun, 2, "WEIGHT");
                UpdateCell(rowTurun, 3, "CHANGE");
                UpdateCell(rowTurun, 4, "RATE");
                UpdateCell(rowTurun, 5, "RESULT");

                workbook.Write(outputStream);
            }
        }

        private void FirstPopulate()
        {
            List<string> sheetNames = new List<string>();
            using (StreamReader reader = new StreamReader(sheetsIndexPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    sheetNames.Add(line);
                }
            }

            sheetsName.DataSource = sheetNames;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFileName(txtSheetsName))
            {
                return;
            }

            string sheetName = txtSheetsName.Text;
            WriteNewSheet(sheetName);
            PopulateSheet(sheetName);
            RefreshSheets();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFileName(txtSheetsName))
                {
                    return;
                }

                string oldName = sheetsName.SelectedItem.ToString();
                string newName = txtSheetsName.Text;
                txtSheetsName.Text = "";

                File.Move($"{oldName}.xlsx", $"{newName}.xlsx");

                ReplaceSheetNameInIndex(oldName, newName);
                PopulateSheet(newName);
                RefreshSheets();
            }
            catch (IOException ex)
            {
                Logger.Error(ex, "Error renaming sheet");
            }
        }

        private void ReplaceSheetNameInIndex(string oldName, string newName)
        {
            string[] lines = File.ReadAllLines(sheetsIndexPath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Equals(oldName))
                {
                    lines[i] = newName;
                    break;
                }
            }
            File.WriteAllLines(sheetsIndexPath, lines);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedSheet = sheetsName.SelectedItem.ToString();
                File.Delete($"{selectedSheet}.xlsx");

                List<string> sheetNames = new List<string>(File.ReadAllLines(sheetsIndexPath));
                sheetNames.Remove(selectedSheet);

                File.WriteAllLines(sheetsIndexPath, sheetNames.ToArray());
                FirstPopulate();
                RefreshSheets();
            }
            catch (IOException ex)
            {
                Logger.Error(ex, "Error removing sheet");
            }
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            try
            {
                CompositeForm jFramePopUp = new CompositeForm();
                jFramePopUp.ShowDialog();
            }
            catch (IOException ex)
            {
                Logger.Error(ex, "Error computing composite result");
            }
        }

        private void PopulateSheet(string chosen)
        {
            List<string> sheetNames = new List<string>(File.ReadAllLines(sheetsIndexPath));
            sheetsName.DataSource = sheetNames;
            sheetsName.SelectedItem = chosen;
        }

        private void sheetsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSheets();
        }

        private void dgGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void jTableNaik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                txtDateNaik.Text = jTableNaik.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
                txtDataNaik.Text = jTableNaik.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
                txtWeightNaik.Text = jTableNaik.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;
                btnAddNaik.Enabled = false;
                btnEditNaik.Enabled = true;
                btnDeleteNaik.Enabled = true;
                txtWeightNaik.Enabled = true;

                if (e.RowIndex == 0)
                {
                    txtWeightNaik.Enabled = false;
                }
            }
        }


        private void jTableTurun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                txtDateTurun.Text = jTableTurun.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
                txtDataTurun.Text = jTableTurun.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
                txtWeightTurun.Text = jTableTurun.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;
                btnAddTurun.Enabled = false;
                btnEditTurun.Enabled = true;
                btnDeleteTurun.Enabled = true;
                txtWeightTurun.Enabled = true;

                if (e.RowIndex == 0)
                {
                    txtWeightTurun.Enabled = false;
                }
            }
        }

        private void btnRefreshNaik_Click(object sender, EventArgs e)
        {
            RefreshNaik();
        }

        private void btnRefreshTurun_Click(object sender, EventArgs e)
        {
            RefreshTurun();
        }

        private bool ValidateNumberOnly(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text.Contains('.'))
            {
                MessageBox.Show("Please use ',' as the decimal separator. '.' is not allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }

            var culture = new CultureInfo("fr-FR");

            if (double.TryParse(textBox.Text, NumberStyles.Float, culture, out _))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a valid number. Use ',' for the decimal separator.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
        }

        private bool ValidateFileName(System.Windows.Forms.TextBox textBox)
        {
            string fileName = textBox.Text;
            char[] invalidChars = Path.GetInvalidFileNameChars();

            if (fileName.IndexOfAny(invalidChars) >= 0)
            {
                MessageBox.Show("The filename contains invalid characters.", "Invalid Filename", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("The filename cannot be empty or whitespace.", "Invalid Filename", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }

            return true;
        }
    }
}