using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Attentio.Infrastructure.Helpers
{
    public class SpreadsheetHelper
    {
        public string FileName { get; set; }

        public SpreadsheetDocument Document { get; set; }

        public SpreadsheetHelper(string fileName, string sheetName)
        {
            FileName = fileName;
            Document = SpreadsheetDocument.Create(FileName, SpreadsheetDocumentType.Workbook);
        }

        public SpreadsheetHelper(string fileName, IEnumerable<string> sheetName)
        {
            FileName = fileName;
            Document = SpreadsheetDocument.Create(FileName, SpreadsheetDocumentType.Workbook);
        }

        private Cell CheckCell(string col, uint row)
        {
            throw new NotImplementedException();
        }
    }
}
