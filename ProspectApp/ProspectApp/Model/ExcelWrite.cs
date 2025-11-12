using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelLibrary.SpreadSheet;

namespace ProspectApp.Model {
    class ExcelWrite {
        public String filePointer { get; set; }
        public int ColumnNumberMax { get; set; }
        private int CurrentColumnNum;
        public int RowCountMax { get; set; }
        private int CurrentRowNum;

        Workbook wb;
        Worksheet ws;

        public void Setup() {
            CurrentColumnNum = 0;
            CurrentRowNum = 0;
            wb = new Workbook();
            ws = new Worksheet("SomeName");
        }

        public void Finish() {
            for(int i = 0; i < 100000; i++) {
                ws.Cells[CurrentRowNum, CurrentColumnNum] = new Cell(" ");
                if(CurrentColumnNum != ColumnNumberMax) {
                    CurrentColumnNum++;
                } else {
                    CurrentColumnNum = 0;
                    CurrentRowNum++;
                }
            }
            wb.Worksheets.Add(ws);
            wb.Save(filePointer);

        }

        public void Write(String value) {
            ws.Cells[CurrentRowNum, CurrentColumnNum] = new Cell(value);
            if(CurrentColumnNum != ColumnNumberMax) {
                CurrentColumnNum++;
            } else {
                CurrentColumnNum = 0;
                CurrentRowNum++;
            }
        }

    }
}
