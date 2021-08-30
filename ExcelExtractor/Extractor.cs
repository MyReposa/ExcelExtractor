using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace ExcelExtractor
{
    public class Extractor
    {
        Application excelApp;
        Workbook currentWorkbook;
        double markingColor;
        string sourcePath;
        Logger logger;
        List<TranslationItem> translationItems = new List<TranslationItem>();

        public Extractor(Logger logger, string sourcePath, bool isYellow, bool isOrange, bool isRed, bool isDarkred)
        {
            this.logger = logger;
            this.sourcePath = sourcePath;

            if (isYellow == true)
            {
                markingColor = 65535;
            }
            else if (isOrange == true)
            {
                markingColor = 49407;
            }
            else if (isRed == true)
            {
                markingColor = 255;
            }
            else if (isDarkred == true)
            {
                markingColor = 192;
            }
        }

        public void Work()
        {
            logger.Log($"Reading Excel file:\r\n{sourcePath}");
            excelApp = new Application();

            try
            {
                this.currentWorkbook = excelApp.Workbooks.Open(sourcePath, false, false);
            }
            catch (Exception error)
            {
                logger.Log(error.Message);
                excelApp.Quit();
                return;
            }

            int numberOfTranslationItems = 0;

            foreach (Worksheet currentWorksheet in currentWorkbook.Worksheets)
            {
                if (currentWorksheet.Visible == XlSheetVisibility.xlSheetHidden)
                {
                    logger.Log($"Hidden sheet found: \"{currentWorksheet.Name}\". It will be ignored!");
                    continue;
                }
                logger.Log($"Reading worksheet: {currentWorksheet.Name}\r\n" +
                           $"Rows: {currentWorksheet.UsedRange.Rows.Count}\r\n" +
                           $"Columns: {currentWorksheet.UsedRange.Columns.Count}\r\n" +
                           $"Cells: {currentWorksheet.UsedRange.Cells.Count}\r\n\r\n" +
                           $"Please wait...");
                foreach (Range currentRow in currentWorksheet.UsedRange.Rows)
                {
                    if (currentRow.Hidden == true)
                    {
                        //logger.Log($"Hidden row found: \"{currentRow.Row}\". It will be ignored!");
                        continue;
                    }

                    if (excelApp.WorksheetFunction.CountA(currentRow) == 0)
                    {
                        //logger.Log($"Empty row found: \"{currentRow.Row}\". It will be ignored!");
                        continue;
                    }

                    //logger.Log($"Now processing row: {currentRow.Row}");

                    foreach (Range currentCell in currentRow.SpecialCells(XlCellType.xlCellTypeConstants))
                    {
                        if (currentCell.Interior.Color == markingColor && currentCell.Value != null)
                        {
                            TranslationItem itemToAdd = new TranslationItem();
                            itemToAdd.worksheetName = currentWorksheet.Name;
                            itemToAdd.sourceText = currentCell.Value;
                            itemToAdd.translatedText = itemToAdd.sourceText;
                            itemToAdd.row = currentCell.Row;
                            itemToAdd.column = currentCell.Column;
                            numberOfTranslationItems++;

                            this.translationItems.Add(itemToAdd);
                        }
                    }
                }
            }

            logger.Log($"Done reading. Now extracting to new file...");
            currentWorkbook.Close(false);
            currentWorkbook = excelApp.Workbooks.Add();
            Worksheet exportedWorksheet = currentWorkbook.Worksheets.Item[1];
            exportedWorksheet.Name = "To translate";
            exportedWorksheet.Cells[1, 1].Value = "Sheet";
            exportedWorksheet.Cells[1, 1].Font.Bold = true;
            exportedWorksheet.Columns[1].ColumnWidth = 50;

            exportedWorksheet.Cells[1, 2].Value = "Column";
            exportedWorksheet.Cells[1, 2].Font.Bold = true;
            exportedWorksheet.Columns[2].ColumnWidth = 8;

            exportedWorksheet.Cells[1, 3].Value = "Row";
            exportedWorksheet.Cells[1, 3].Font.Bold = true;
            exportedWorksheet.Columns[3].ColumnWidth = 8;

            exportedWorksheet.Cells[1, 4].Value = "Source text";
            exportedWorksheet.Cells[1, 4].Font.Bold = true;
            exportedWorksheet.Columns[4].ColumnWidth = 100;

            exportedWorksheet.Cells[1, 5].Value = "Translated text";
            exportedWorksheet.Cells[1, 5].Font.Bold = true;
            exportedWorksheet.Columns[5].ColumnWidth = 100;

            foreach (TranslationItem item in translationItems)
            {
                exportedWorksheet.Cells[translationItems.IndexOf(item) + 2, 1].Value = item.worksheetName;
                exportedWorksheet.Cells[translationItems.IndexOf(item) + 2, 2].Value = item.column;
                exportedWorksheet.Cells[translationItems.IndexOf(item) + 2, 3].Value = item.row;
                exportedWorksheet.Cells[translationItems.IndexOf(item) + 2, 4].Value = item.sourceText;
                exportedWorksheet.Cells[translationItems.IndexOf(item) + 2, 5].Value = item.translatedText;
            }

            string workPath = Path.GetDirectoryName(sourcePath);
            string fileName = Path.GetFileNameWithoutExtension(sourcePath) + "_PREP.xlsx";
            string saveFile = Path.Combine(workPath, fileName);
            try
            {
                currentWorkbook.SaveAs(saveFile);
            }
            catch
            {

            }
            currentWorkbook.Close();

            logger.Log($"Job's done!\r\n\r\nTotal number of extracted items: {numberOfTranslationItems}\r\n\r\nPlease find file with extracted data here:\r\n{saveFile}");

            excelApp.Quit();
        }
    }
}
