﻿using Microsoft.UI.Xaml;
using System;
using System.IO;
using System.Reflection.Metadata;
using Telerik.ReportViewer.Common;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Import;
using Telerik.Windows.Documents.Fixed.Model;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();


            //string fileName =   @"..\..\..\..\..\PDF\Barcodes Report.pdf";
            //string pdfFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            //MemoryStream stream = new MemoryStream();

            //using (Stream input = File.OpenRead(pdfFilePath))
            //{
            //    input.CopyTo(stream);
            //}

            //PdfFormatProvider provider = new PdfFormatProvider();
            //provider.ImportSettings = PdfImportSettings.ReadOnDemand;
            //RadFixedDocument doc = provider.Import(stream);
            //this.pdfViewer.Document = doc;


            #region Use separate Reporting REST service
            //var engineConnection = new RestServiceConnectionInfo("https://localhost:49169/api/reports/");
            //reportViewer.ReportEngineConnection = engineConnection.ConnectionString;
            //reportViewer.ReportSource = new Telerik.Reporting.UriReportSource()
            //{
            //    Uri= "Orders report.trdx"
            //};
            #endregion

            #region Use local report, keep WinUI-rendering
            string reportFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports/BlankReport.trdx");
            if (File.Exists(reportFilePath))
            {
                reportViewer.ReportSource = new Telerik.Reporting.UriReportSource()
                {
                    Uri = reportFilePath
                };
            }
            #endregion
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //pdfViewer.Print();
        }
    }
}
