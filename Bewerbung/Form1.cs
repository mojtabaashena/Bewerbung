using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bewerbung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateResume_Click(object sender, EventArgs e)
        {
            try
            {
                wordApp = new Microsoft.Office.Interop.Word.Application { Visible = true };
                if(chbResume.Checked) ExportPdfFile(txtResumePath.Text);
                if (chbCoverLetter.Checked)ExportPdfFile(txtCoverLetterPath.Text);
                if (chbCertificates.Checked) ExportPdfFile(txtCetrficatesPath.Text);

                wordApp.Quit();
                releaseObject(wordApp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Microsoft.Office.Interop.Word.Application wordApp;

        private void ExportPdfFile(string FileName)
        {
            try
            {
                
                Microsoft.Office.Interop.Word.Document aDoc = wordApp.Documents.Open(string.Format("{0}\\{1}", txtBaseFolderPath.Text, FileName), ReadOnly: false, Visible: true);

                FileName = System.IO.Path.GetFileNameWithoutExtension(FileName);
                for (int i = 0; i < 20; i++)
                {
                    FileName = FileName.Replace("-V" + i.ToString(), ""); 
                }
                if (System.IO.File.Exists(string.Format("{0}\\{1}.pdf", txtBaseFolderPath.Text, FileName)))
                    System.IO.File.Delete(string.Format("{0}\\{1}.pdf", txtBaseFolderPath.Text, FileName));

                aDoc.Activate();

                ReplaceFields(aDoc);

                aDoc.SaveAs2(string.Format("{0}\\{1}.pdf", txtBaseFolderPath.Text, FileName), Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatPDF);

                aDoc.Close();


                releaseObject(aDoc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void ReplaceFields(Microsoft.Office.Interop.Word.Document doc)
        {
            
            try
            {
                foreach (Microsoft.Office.Interop.Word.ContentControl ff in doc.ContentControls)
                {
                    if (ff.Title == "Company")
                    {
                        ff.Range.Text = txtCompanyName.Text;
                    }
                    else if (ff.Title == "Company Address")
                    {
                        ff.Range.Text = txtCompanyAddress.Text;
                    }
                    else if (ff.Title == "Subject")
                    {
                        ff.Range.Text = txtJobTitel.Text; 
                    }
                    else if (ff.Title == "Author")
                    {
                        if (txtPortal.Text != "") ff.Range.Text = txtPortal.Text;
                    }
                }

            }
            finally
            {
                
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                //TODO
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                object misValue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(txtOutputFilePath.Text);
                Microsoft.Office.Interop.Excel.Worksheet xlResaultDataSheet;
                xlResaultDataSheet = xlWorkBook.Sheets[1];

                Microsoft.Office.Interop.Excel.Range xlRange = xlResaultDataSheet.UsedRange;


                xlResaultDataSheet.Cells[xlRange.Rows.Count + 1, 2] = dtApplicationDate.Value;
                xlResaultDataSheet.Cells[xlRange.Rows.Count + 1, 3] = cmbType.Text;
                xlResaultDataSheet.Cells[xlRange.Rows.Count + 1, 4] = txtJobTitel.Text;
                xlResaultDataSheet.Cells[xlRange.Rows.Count + 1, 5] = txtCompanyName.Text;
                xlResaultDataSheet.Cells[xlRange.Rows.Count + 1, 6] = txtCompanyEmail.Text;
                xlResaultDataSheet.Cells[xlRange.Rows.Count + 1, 7] = txtURL.Text;
                xlResaultDataSheet.Cells[xlRange.Rows.Count + 1, 8] = txtDesrip.Text;

                xlWorkBook.Save();

                xlWorkBook.Close();


                releaseObject(xlWorkBook);

                xlApp.Quit();
                releaseObject(xlApp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == button1) txtURL.Text = "";
            txtJobTitel.Text = "";
            txtCompanyName.Text = "";
            txtCompanyAddress.Text = ""; 
            txtCompanyEmail.Text = "";
            txtDesrip.Text = "";
            dtApplicationDate.Value = System.DateTime.Now; 
        }

        private void btnParseURL_Click(object sender, EventArgs e)
        {
            try
            {
                button1_Click(sender, e); 

                var url = txtURL.Text;

                if  (txtURL.Text.ToLower().Contains("https"))
                    System.Net.ServicePointManager.SecurityProtocol = (System.Net.SecurityProtocolType)3072;
                //System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Ssl3;

                var web = new HtmlAgilityPack.HtmlWeb();
                var doc = web.Load(url);
                lblPrompt.Text = "";
                if (txtURL.Text.ToLower().Contains("jobvector.de"))
                {
                    txtJobTitel.Text = doc.DocumentNode.SelectNodes("//*[@id='vacancy_head']/div/h1").First().InnerText;
                    txtCompanyName.Text = doc.DocumentNode.SelectNodes("//*[@id='vacancy_vacancy']/div/div[3]/div[2]/div/div/a").First().InnerText.Replace(" &nbsp;", "").Trim();
                    txtCompanyAddress.Text = doc.DocumentNode.SelectNodes("//*[@id='vacancy_vacancy']/div/div[3]/div[2]/div/div/span").First().InnerText.Replace(" &nbsp;", "").Trim();
                    txtPortal.Text = "Jobvector";
                    cmbType.Text = "Jobvector";
                }
                else if (txtURL.Text.ToLower().Contains("linkedin.com"))
                {
                    txtJobTitel.Text = doc.DocumentNode.SelectNodes(".//*[@class='topcard__title']").First().InnerText;
                    txtCompanyName.Text = doc.DocumentNode.SelectNodes("//*[@class='topcard__org-name-link topcard__flavor--black-link']").First().InnerText.Replace(" &nbsp;", "").Trim();
                    txtCompanyAddress.Text = doc.DocumentNode.SelectNodes("//*[@class='topcard__flavor topcard__flavor--bullet']").First().InnerText.Replace(" &nbsp;", "").Trim();
                    txtPortal.Text = "LinkedIn";
                    cmbType.Text = "LinkedIn";
                }
                else if (txtURL.Text.ToLower().Contains("xing.com"))
                {
                    txtPortal.Text = "Xing";
                    cmbType.Text = "Xing";

                    txtJobTitel.Text = doc.DocumentNode.SelectNodes(".//*[contains(@class,'headlineSkins-xxlarge-text-fc9f783e')]").First().InnerText;
                    txtCompanyName.Text = doc.DocumentNode.SelectNodes("//*[@class='topcard__org-name-link topcard__flavor--black-link']").First().InnerText.Replace(" &nbsp;", "").Trim();
                    txtCompanyAddress.Text = doc.DocumentNode.SelectNodes("//*[@class='topcard__flavor topcard__flavor--bullet']").First().InnerText.Replace(" &nbsp;", "").Trim();
                    
                }
            }
            catch (Exception ex)
            {
                lblPrompt.Text = ex.Message;
            }
            
            //

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Configuration.AppSettingsReader appconfig = new System.Configuration.AppSettingsReader();
            txtBaseFolderPath.Text = appconfig.GetValue("BaseFolderPath", typeof(string)).ToString();
            txtResumePath.Text = appconfig.GetValue("ResumePath", typeof(string)).ToString();
            txtCoverLetterPath.Text = appconfig.GetValue("CoverLetterPath", typeof(string)).ToString();
            txtCetrficatesPath.Text = appconfig.GetValue("CetrficatesPath", typeof(string)).ToString();
            txtOutputFilePath.Text = appconfig.GetValue("OutputFilePath", typeof(string)).ToString();
        }

        private void BtnExportPDF_Click(object sender, EventArgs e)
        {
            //using TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerator;
            TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerateConfig pdfGenerateConfig = new TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerateConfig();
            
            TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerator.GeneratePdf(txtURL.Text , pdfGenerateConfig).Save("d:\\sdaasdasd.pdf") ;

            //string html = File.ReadAllText("input.htm");
            //TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerator.PdfDocument pdf = PdfGenerator.GeneratePdf(html, PageSize.Letter);
            //pdf.Save("document.pdf");
        }
    }


}

