
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF.PDF
{
    class PDFWriter
    {
        string path;
        const string FontPath = @"C:\Users\anton\Google Drive\wpf_original (1)\WPF_ONLINE\PDF\GE_SS_Unique_Light.otf";

        PdfPTable table = new PdfPTable(1346);
        enum FamilyData_Titles {FamilyName = 182, Adress = 594,Telephone = 115,
            count = 65,EcnomicCondition = 83,living = 71, LastVisit = 121};

        enum FamilyMemberData_Titles {Name = 184,Relative = 98,BirthDate= 118,Requirment = 190,
        Job = 189 , SocialCondition = 116,Confessionpriest = 178, Baptism = 83 , mobile = 127 ,
        WithFamily = 64 }

        Document doc;

        PdfWriter writ;
      

        public PDFWriter(string path)
        {
            this.path = path;
         
            table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            doc = new Document(PageSize.A4, 7, 7, 5, 5);

            writ = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();
        
        }

        private void FamilyHeadTemplate()
        {
            try
            {
                //    table.RunDirection = PdfWriter.RUN_DIRECTION_RTL
                int index=0;
                int column = 0;
                //for (int row = 0; row < 1; row++)
                {
                   
                    {
                     
                        {
                            PdfPCell newcell = AddNewCellToTable("اسم رب الاسرة", (int)FamilyData_Titles.FamilyName);

                            column += (int)FamilyData_Titles.FamilyName;///183
                            
                          
                        }
                        ////// ----> column =184

                        {
                            PdfPCell newcell = AddNewCellToTable("العنوان", (int)FamilyData_Titles.Adress);
                            column += (int)FamilyData_Titles.Adress;

                        }

                        /////// column = 779

                        {
                            PdfPCell newcell = AddNewCellToTable("تليفون 1 ", (int)FamilyData_Titles.Telephone);
                            column += (int)FamilyData_Titles.Telephone;

                           
                        }

                        {
                            PdfPCell newcell = AddNewCellToTable("تليفون 2 ", (int)FamilyData_Titles.Telephone);
                            column += (int)FamilyData_Titles.Telephone;
                            index += column;
                        }


                        {
                            PdfPCell newcell = AddNewCellToTable("العدد", (int)FamilyData_Titles.count);
                            column += (int)FamilyData_Titles.count;
                            index += column;
                        }

                        {
                            PdfPCell newcell = AddNewCellToTable("الحالة الاقتصادية", (int)FamilyData_Titles.EcnomicCondition);
                            column += (int)FamilyData_Titles.EcnomicCondition;
                            index += column;
                        }

                        {
                            PdfPCell newcell = AddNewCellToTable("السكن", (int)FamilyData_Titles.living);
                            column += (int)FamilyData_Titles.living;
                            index += column;
                        }

                        {
                            PdfPCell newcell = AddNewCellToTable("اخر زيارة", (int)FamilyData_Titles.LastVisit);
                            column += (int)FamilyData_Titles.LastVisit;
                            index += column;

                        }
                        {
                            // PdfPCell newcell = AddNewCellToTable("سيبسيب",1000- (int)Titles.FamilyName);
                            //column += (int)Titles.Telephone;
                            //index += column;
                            //MessageBox.Show("Column 3 created");

                        }

                        //   MessageBox.Show(column.ToString());


                       

                    }
                }



                ///reverse pdf writer direction
                //string fontLoc = @"P:\Projects\OfflineWpf\WPF\Fonts\A_Nefel_Sereke.ttf";  // make sure to have the correct path to the font file
                //BaseFont bf = BaseFont.CreateFont(fontLoc, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                //Font f = new Font(bf, 12);

                //PdfPCell cell = new PdfPCell(new Phrase(String.Format("اخر زيارة"),f));
                //BaseColor color = new BaseColor(188, 188, 188);
                //cell.BackgroundColor = color;
                //cell.Colspan = 1157;

                //table.AddCell(cell);

                //for (int row = 0; row < 5; row++)
                //{
                //    for (int column = 0; column < 6; column++)
                //    {
                //        table.AddCell(new Phrase("Row " + row.ToString() + " Col " + column.ToString()));
                //    }
                //}
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         
        } 

        public void FamilyHeadDataFiller(string FamilyName, string Adress, string Telephone1, string Telephone2, 
                                  string CountNumber, string EcnomicCondition, 
                                  string LivingPlace, string LastVisit)
        {

            FamilyHeadTemplate();


            //////////////FamilyName////////////////////////
            if (FamilyName == null)
            {  PdfPCell newcell = AddNewCellToTable("", (int)FamilyData_Titles.FamilyName);}
            else
            {PdfPCell newcell = AddNewCellToTable(FamilyName, (int)FamilyData_Titles.FamilyName);}
            
            
            ////////////////////Adress////////////////////////
            if (Adress==null)
            { PdfPCell newcell = AddNewCellToTable("", (int)FamilyData_Titles.Adress); }
            else { PdfPCell newcell = AddNewCellToTable(Adress, (int)FamilyData_Titles.Adress); }


            ////////////////////////telephone1//////////////////////////
            if(Telephone1==null)
            { PdfPCell newcell = AddNewCellToTable("", (int)FamilyData_Titles.Telephone); }
            else
            { PdfPCell newcell = AddNewCellToTable(Telephone1, (int)FamilyData_Titles.Telephone); }


            //////////////telephon2////////////////////////
            if(Telephone2==null)
            { PdfPCell newcell = AddNewCellToTable("", (int)FamilyData_Titles.Telephone); }
            else
            { PdfPCell newcell = AddNewCellToTable(Telephone2, (int)FamilyData_Titles.Telephone); }

            
            ///////////CountNumber///////////////////////////////////
            if(CountNumber==null)
            { PdfPCell newcell = AddNewCellToTable("", (int)FamilyData_Titles.count); }
            else
            { PdfPCell newcell = AddNewCellToTable(CountNumber, (int)FamilyData_Titles.count); }


            //////////////EcnomicCondition//////////////////////////
            if(EcnomicCondition==null)
            { PdfPCell newcell = AddNewCellToTable("", (int)FamilyData_Titles.EcnomicCondition); }
            else
            { PdfPCell newcell = AddNewCellToTable(EcnomicCondition, (int)FamilyData_Titles.EcnomicCondition); }



            //////////////////////LivingPlace////////////////////////
            if (LivingPlace == null)
            {PdfPCell newcell = AddNewCellToTable("", (int)FamilyData_Titles.living);}
            else
            { PdfPCell newcell = AddNewCellToTable(LivingPlace, (int)FamilyData_Titles.living); }


            //////////////////////LastVisit/////////////////////////////////
            if (LastVisit == null)
            { PdfPCell newcell = AddNewCellToTable("", (int)FamilyData_Titles.LastVisit); }
            else
            { PdfPCell newcell = AddNewCellToTable(LastVisit, (int)FamilyData_Titles.LastVisit); }

            doc.Add(table);
            doc.Close();

        }


        private PdfPCell AddNewCellToTable(string pharase,int columnspan)
        {

         
           

          
            BaseFont baseFont = BaseFont.CreateFont(FontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font f1 = new Font(baseFont, 6);
            ///reverse pdf writer direction




            Paragraph tempphrase = new Paragraph(String.Format(pharase), f1);
            
            PdfPCell tempcell = new PdfPCell();
            BaseColor color1 = new BaseColor(188, 188, 188);

            tempcell.BackgroundColor = color1;

            tempcell.Colspan = columnspan;

            tempcell.HorizontalAlignment = Element.ALIGN_MIDDLE;

            tempcell.Phrase = tempphrase;


            table.AddCell(tempcell);
       
          
            //writ.Close();
            return tempcell;








        }

    }
}
