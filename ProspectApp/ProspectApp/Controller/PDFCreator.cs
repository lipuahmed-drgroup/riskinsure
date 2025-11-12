using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProspectApp.Wrappers;
using ProspectApp.View;
using PdfLibrary;
using System.IO;
using System.Data;
using sharpPDF;
using sharpPDF.Tables;
using sharpPDF.Enumerators;


namespace ProspectApp.Controller {
    public class PDFCreator {

        public List<PDFItem> itemsToPrint { get; set; }
        ProspectApp.Controller.Main main;

        CatalogDict catalogDict;
        PageTreeDict pageTreeDict;
        FontDict TimesRoman;
        FontDict TimesItalic;
        InfoDict infoDict;
        Utility pdfUtility = new Utility();
        FileStream file;
        int size;

        Dictionary<int, String> rbs;
        Dictionary<int, String> prems;
        Dictionary<int, String> mnths;
        Dictionary<int, String> proscodes;


        String fName;

        public PDFCreator() {

        }
        public PDFCreator(ProspectApp.Controller.Main main) {
            this.main = main;
            catalogDict = new CatalogDict();
            pageTreeDict = new PageTreeDict();
            TimesRoman = new FontDict();
            TimesItalic = new FontDict();
            infoDict = new InfoDict();
            TimesRoman.CreateFontDict("T1", "Times-Roman");
            TimesItalic.CreateFontDict("T2", "Times-Roman");
            infoDict.SetInfo("Client Printout", "Prospects System", "Risk Insurance");
            fName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6) + @"\ClientReport_" + DateTime.Now.ToString().Replace(' ', '_').Replace('/', '-').Replace(':', '-') + ".pdf";
            file = new FileStream(fName, FileMode.Create);
            size = 0;
            file.Write(pdfUtility.GetHeader("1.5", out size), 0, size);
            file.Close();
            PopHash();
        }

        private void PopHash() {
            rbs = new Dictionary<int, string>();
            DataTable cur = main.GetTable("Prospects_RiskBrokers");
            foreach(DataRow x in cur.Rows) {
                rbs.Add(int.Parse(x["rbID"].ToString().Trim()), x["BrokerName"].ToString().Trim());
            }
            prems = new Dictionary<int, string>();
            cur = main.GetTable("Prospects_Premiums");
            foreach(DataRow x in cur.Rows) {
                prems.Add(int.Parse(x["premID"].ToString().Trim()), x["premium"].ToString().Trim());
            }
            mnths = new Dictionary<int, string>();
            cur = main.GetTable("Prospects_Months");
            foreach(DataRow x in cur.Rows) {
                mnths.Add(int.Parse(x["mID"].ToString().Trim()), x["month"].ToString().Trim());
            }
            proscodes = new Dictionary<int, string>();
            cur = main.GetTable("Prospects_ProsCodes");
            foreach(DataRow x in cur.Rows) {
                proscodes.Add(int.Parse(x["pcID"].ToString().Trim()), x["catDesc"].ToString().Trim());
            }
        }

        public void RecurseList() {
            foreach(PDFItem cur in itemsToPrint) {
                Console.WriteLine(cur.client.cName);
            }
        }


        public void PrintList2() {
            pdfDocument myDoc = new pdfDocument("", "", false);
            int pageNumber = 0;
            foreach (PDFItem cur in itemsToPrint) {
                pageNumber++;
                pdfPage myFirstPage = myDoc.addPage();
                int pageYLoc = 760;
                string toAdd = "PDF Report Printout " + DateTime.Now.ToString() + " Printed By: " + main.ar.brokerName + " Page " + pageNumber + " of " + itemsToPrint.Count + ".";
                myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                toAdd = "Company:";
                pageYLoc -= 20;
                myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                toAdd = cur.client.cName;
                pageYLoc -= 10;
                try {
                    myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourierBold), 8, pdfColor.DarkRed);
                } catch {

                }
                

                toAdd = "Client:";
                pageYLoc -= 20;
                myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                toAdd = cur.client.Name;
                pageYLoc -= 10;
                try {
                    myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                } catch {

                }
                

                toAdd = "Assigned Broker:";
                pageYLoc -= 20;
                myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                toAdd = rbs[cur.client.rbID].ToString();
                pageYLoc -= 10;
                try {
                    myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourierBold), 8, pdfColor.DarkRed);
                } catch {

                }
                

                toAdd = "Assigned Prospect Codes";
                pageYLoc -= 20;
                myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                foreach (ProsCode.CustProsCode dn in cur.proscodes) {
                    toAdd = "Code: " + proscodes[dn.pcID];
                    pageYLoc -= 10;
                    try {
                        myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                    } catch {

                    }
                    
                }

                toAdd = "Sales Approach Entry Details";
                pageYLoc -= 20;
                myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                foreach (SAMDBEntry sam in cur.samdbEntries) {
                    toAdd = "Year: " + sam.year + ", Finalized: " + (sam.isClosed ? "Yes" : "No") + ", Last Updated: " + sam.LastUpdated.ToShortDateString() + ", Broker: " + rbs[sam.rbID] + ".";
                    pageYLoc -= 10;
                    try {
                        myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                    } catch {

                    }
                    
                }

                toAdd = "Insurance Details";
                pageYLoc -= 20;
                myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                foreach (InsuranceDetail ins in cur.insdetList) {
                    toAdd = "Due Month: " + mnths[ins.mID] + ", Broker: " + rbs[ins.rbID] + ", Person: " + ins.broPerson + ", Company: " + ins.broCompany + ", Premium: " + prems[ins.premID] + ".";
                    pageYLoc -= 10;
                    try {
                        myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                    } catch {

                    }
                    
                }

                toAdd = "Discussion Note Details";
                pageYLoc -= 20;
                myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                foreach (ClientDiscNote dn in cur.discnoteList) {
                    if (dn.dNote.Length < 60) {
                        toAdd = "Date: " + dn.dDate.ToShortDateString() + ", Broker: " + rbs[dn.rbID] + ", Note: " + dn.dNote + ".";
                        pageYLoc -= 10;
                        try {
                            myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                        } catch {

                        }
                        
                    } else {
                        String curNote = dn.dNote;
                        List<String> splitNote = new List<String>();
                        while (curNote.Length > 0) {
                            if (curNote.Length > 120) {
                                splitNote.Add(curNote.Substring(0, 120));
                                curNote = curNote.Remove(0, 120);
                            } else {
                                splitNote.Add(curNote.Substring(0, curNote.Length));
                                curNote = curNote.Remove(0, curNote.Length);
                            }

                        }
                        toAdd = "Date: " + dn.dDate.ToShortDateString() + ", Broker: " + rbs[dn.rbID] + ", Note: ";
                        pageYLoc -= 10;
                        myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                        foreach (String x in splitNote) {
                            toAdd = x;
                            pageYLoc -= 10;
                            try {
                                myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                            } catch {
                            
                            }
                            
                        }

                    }
                }

                toAdd = "Follow Up's";
                pageYLoc -= 20;
                myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                foreach (FollowUp dn in cur.followups) {
                    toAdd = "Date To Followup: " + dn.folDate.ToShortDateString() + " Completed: " + (dn.doneDate != DateTime.MinValue ? dn.doneDate.ToShortDateString() : " No") + ".";
                    pageYLoc -= 10;
                    myFirstPage.addText(toAdd, 20, pageYLoc, myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black);
                }
                /*
                //Table's creation
                pdfTable myTable = new pdfTable(myDoc
                    // Border size
                    , 1
                    // Border color
                    , pdfColor.DarkBlue
                    , 20
                    // Header Style
                    , new pdfTableStyle(myDoc.getFontReference(predefinedFont.csHelvetivaBoldOblique), 12, pdfColor.Black, pdfColor.LightCyan)
                    // Row's Style
                    , new pdfTableStyle(myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black, pdfColor.White)
                    // Alternate Row's Style
                    , new pdfTableStyle(myDoc.getFontReference(predefinedFont.csCourier), 8, pdfColor.Black, pdfColor.LightYellow)
                    );
                //Set table's position
                myTable.coordX = 100;
                myTable.coordY = 600;
                //Create table's header
                myTable.tableHeader.addColumn(60, predefinedAlignment.csRight);
                myTable.tableHeader.addColumn(150, predefinedAlignment.csCenter);
                myTable.tableHeader.addColumn(100, predefinedAlignment.csLeft);
                myTable.tableHeader.addColumn(150, predefinedAlignment.csLeft);
                myTable.tableHeader[0].addText("id");
                myTable.tableHeader[1].addText("user");
                myTable.tableHeader[2].addText("tel");
                myTable.tableHeader[3].addText("email");
                // Create table's rows
                pdfTableRow myRow = myTable.createRow();
                myRow[0].addText("1");
                myRow[1].addText("Andrew Red");
                myRow[2].addText("898-0210989");
                myRow[3].addText("Andrew.red@sharppdf.net");
                myTable.addRow(myRow);
                myRow = myTable.createRow();
                myRow[0].addText("2");
                myRow[1].addText("Andrew Green");
                myRow[2].addText("298-55109");
                myRow[3].addText("Andrew.green@sharppdf.net");
                myTable.addRow(myRow);
                myRow = myTable.createRow();
                myRow[0].addText("3");
                myRow[1].addText("Andrew White");
                myRow[2].addText("24-5510943");
                myRow[3].addText("Andrew.white@sharppdf.net");
                myTable.addRow(myRow);
                //Add the table in the page object
                myFirstPage.addTable(myTable);
                // Add test rectangle left
                myFirstPage.drawRectangle(0, 0, 50, myFirstPage.height, pdfColor.DarkBlue, pdfColor.DarkBlue);
                myTable = null;
                 */
            }
            myDoc.createPDF(fName);
            System.Diagnostics.Process.Start(fName);
        }

        public void PrintList()
        {
            int pageNumber = 0;
            foreach (PDFItem cur in itemsToPrint)
            {
                pageNumber++;
                //Create a Page Dictionary , this represents a visible page
                PageDict page = new PageDict();
                ContentDict content = new ContentDict();
                //The page size object will hold all the page size information
                PageSize pSize = new PageSize(612, 792);
                pSize.SetMargins(10, 10, 10, 10);
                page.CreatePage(pageTreeDict.objectNum, pSize);
                pageTreeDict.AddPage(page.objectNum);
                page.AddResource(TimesRoman, content.objectNum);
                //Create a Text And Table Object that present the elements in the page
                TextAndTables textAndtable = new TextAndTables(pSize);
                //Add text to the page
                String toAdd;
                uint pageYLoc = 10;

                toAdd = "PDF Report Printout " + DateTime.Now.ToString() + " Printed By: " + main.ar.brokerName + " Page " + pageNumber + " of " + itemsToPrint.Count + ".";
                textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);

                toAdd = "Company:";
                pageYLoc += 20;
                textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                toAdd = cur.client.cName;
                pageYLoc += 10;
                textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);

                toAdd = "Client:";
                pageYLoc += 20;
                textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                toAdd = cur.client.Name;
                pageYLoc += 10;
                textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);

                toAdd = "Assigned Broker:";
                pageYLoc += 20;
                textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                toAdd = rbs[cur.client.rbID].ToString();
                pageYLoc += 10;
                textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);

                toAdd = "Assigned Prospect Codes";
                pageYLoc += 20;
                textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                foreach (ProsCode.CustProsCode dn in cur.proscodes)
                {
                    toAdd = "Code: " + proscodes[dn.pcID];
                    pageYLoc += 10;
                    textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                }

                toAdd = "Sales Approach Entry Details";
                pageYLoc += 20;
                textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                foreach (SAMDBEntry sam in cur.samdbEntries)
                {
                    toAdd = "Year: " + sam.year + ", Finalized: " + (sam.isClosed ? "Yes" : "No") + ", Last Updated: " + sam.LastUpdated.ToShortDateString() + ", Broker: " + rbs[sam.rbID] + ".";
                    pageYLoc += 10;
                    textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                }

                toAdd = "Insurance Details";
                pageYLoc += 20;
                textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                foreach (InsuranceDetail ins in cur.insdetList)
                {
                    toAdd = "Due Month: " + mnths[ins.mID] + ", Broker: " + rbs[ins.rbID] + ", Person: " + ins.broPerson + ", Company: " + ins.broCompany + ", Premium: " + prems[ins.premID] + ".";
                    pageYLoc += 10;
                    textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                }

                toAdd = "Discussion Note Details";
                pageYLoc += 20;
                textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                foreach (ClientDiscNote dn in cur.discnoteList)
                {
                    if (dn.dNote.Length < 60)
                    {
                        toAdd = "Date: " + dn.dDate.ToShortDateString() + ", Broker: " + rbs[dn.rbID] + ", Note: " + dn.dNote + ".";
                        pageYLoc += 10;
                        textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                    }
                    else
                    {
                        String curNote = dn.dNote;
                        List<String> splitNote = new List<String>();
                        while (curNote.Length > 0)
                        {
                            if (curNote.Length > 120)
                            {
                                splitNote.Add(curNote.Substring(0, 120));
                                curNote = curNote.Remove(0, 120);
                            }
                            else
                            {
                                splitNote.Add(curNote.Substring(0, curNote.Length));
                                curNote = curNote.Remove(0, curNote.Length);
                            }
                            
                        }
                        toAdd = "Date: " + dn.dDate.ToShortDateString() + ", Broker: " + rbs[dn.rbID] + ", Note: ";
                        pageYLoc += 10;
                        textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                        foreach (String x in splitNote)
                        {
                            
                                toAdd = x;
                            
                            pageYLoc += 10;
                            textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                        }

                    }
                }

                    toAdd = "Follow Up's";
                    pageYLoc += 20;
                    textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                    foreach (FollowUp dn in cur.followups)
                    {
                        toAdd = "Date To Followup: " + dn.folDate.ToShortDateString() + " Completed: " + (dn.doneDate != DateTime.MinValue ? dn.doneDate.ToShortDateString() : " No") + ".";
                        pageYLoc += 10;
                        textAndtable.AddText(35, pageYLoc, toAdd, 10, "T1", Align.LeftAlign);
                    }

                    //Create the array for alignment value.
                    //This is specified for text in each column 
                    //of the table, here we have two columns
                    Align[] align = new Align[2];
                    align[0] = Align.LeftAlign;
                    align[1] = Align.LeftAlign;
                    //Specify the color for the cell and the line
                    ColorSpec cellColor = new ColorSpec(100, 100, 100);
                    ColorSpec lineColor = new ColorSpec(98, 200, 200);
                    //Fill in the parameters for the table
                    TableParams table = new TableParams(2, 200, 200);
                    table.yPos = 700;
                    table.xPos = 100;
                    table.rowHeight = 20;

                    //Set the parameters of this table
                    textAndtable.SetParams(table, cellColor, Align.CenterAlign, 3);
                    //Repeat till we require the number of rows.
                    //After drawing table and text add them to the page 
                    content.SetStream(textAndtable.EndTable(lineColor));
                    content.SetStream(textAndtable.EndText());
                    size = 0;
                    file = new FileStream(fName, FileMode.Append);
                    file.Write(page.GetPageDict(file.Length, out size), 0, size);
                    file.Write(content.GetContentDict(file.Length, out size), 0, size);
                    file.Close();
                }
            //

                file = new FileStream(fName, FileMode.Append);
                file.Write(catalogDict.GetCatalogDict(pageTreeDict.objectNum, file.Length, out size), 0, size);
                file.Write(pageTreeDict.GetPageTree(file.Length, out size), 0, size);
                file.Write(TimesRoman.GetFontDict(file.Length, out size), 0, size);
                file.Write(TimesItalic.GetFontDict(file.Length, out size), 0, size);
                file.Write(infoDict.GetInfoDict(file.Length, out size), 0, size);
                file.Write(pdfUtility.CreateXrefTable(file.Length, out size), 0, size);
                file.Write(pdfUtility.GetTrailer(catalogDict.objectNum, infoDict.objectNum, out size), 0, size);
                file.Close();
                System.Diagnostics.Process.Start(fName);
            }
        

        public class PDFItem {
            public ClientProspect client { get; set; }
            public String brokerName { get; set; }
            public List<InsuranceDetail> insdetList { get; set; }
            public List<ClientDiscNote> discnoteList { get; set; }
            public List<SAMDBEntry> samdbEntries { get; set; }
            public List<ProsCode.CustProsCode> proscodes { get; set; }
            public List<FollowUp> followups { get; set; }

            public PDFItem() {

            }
        }
    }
}
