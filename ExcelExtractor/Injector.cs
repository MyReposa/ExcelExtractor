using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace ExcelExtractor
{
    public class Injector
    {
        Application excelApp;
        Workbook currentWorkbook;
        string sourcePath;
        string translatedPath;
        Logger logger;
        List<TranslationItem> translationItems = new List<TranslationItem>();

        public Injector(Logger logger, string sourcePath, string translatedPath)
        {
            this.logger = logger;
            this.sourcePath = sourcePath;
            this.translatedPath = translatedPath;

        }

        public void Work()
        {
            logger.Log($"Reading translated Excel file:\r\n{translatedPath}");
            excelApp = new Application();

            try
            {
                this.currentWorkbook = excelApp.Workbooks.Open(translatedPath);
            }
            catch (Exception error)
            {
                logger.Log(error.Message);
                excelApp.Quit();
                return;
            }

            int numberOfTranslationItems = 0;
            foreach (Range row in currentWorkbook.Worksheets[1].UsedRange.Rows)
            {
                if (row.Row == 1)
                {
                    continue;
                }

                try
                {
                    TranslationItem itemToAdd = new TranslationItem();
                    itemToAdd.worksheetName = row.Cells[1, 1].Value;
                    itemToAdd.column = (int)row.Cells[1, 2].Value;
                    itemToAdd.row = (int)row.Cells[1, 3].Value;
                    itemToAdd.sourceText = row.Cells[1, 4].Value;
                    itemToAdd.translatedText = row.Cells[1, 5].Value;
                    translationItems.Add(itemToAdd);
                    numberOfTranslationItems++;
                }

                catch (Exception error)
                {
                    logger.Log(error.Message);
                    excelApp.Quit();
                    return;
                }
            }
            currentWorkbook.Close();

            logger.Log($"Done reading. Now opening source file:\r\n{sourcePath}");
            try
            {
                this.currentWorkbook = excelApp.Workbooks.Open(sourcePath);
            }
            catch (Exception error)
            {
                logger.Log(error.Message);
                excelApp.Quit();
                return;
            }

            logger.Log($"Done. Injecting data...");

            foreach (TranslationItem item in translationItems)
            {
                currentWorkbook.Worksheets[item.worksheetName].Cells[item.row, item.column].Value = item.translatedText;
            }

            currentWorkbook.Save();
            logger.Log($"Job's done!\r\n\r\nTotal number of changes: {numberOfTranslationItems}\r\n\r\nPlease find updated file here:\r\n{sourcePath}");
            currentWorkbook.Close();
            excelApp.Quit();
        }
    }
}
