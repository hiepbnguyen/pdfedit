using iText.Forms.Xfa;
using iText.Kernel.Pdf;
using iText.Layout;
using iText;
using iText.Forms;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

String inputFileDir = @"C:\Users\hiepn\OneDrive\Desktop\personal-projects\pdfmaker\";
String destFile = @"C:\Users\hiepn\OneDrive\Desktop\personal-projects\pdfmaker\new.pdf";

PdfReader reader = new PdfReader(inputFileDir + "8615.pdf");
PdfWriter writer = new PdfWriter(destFile);
PdfDocument pdfDoc = new PdfDocument(reader, writer);
XfaForm xfa = PdfAcroForm.GetAcroForm(pdfDoc, false).GetXfaForm();
System.Xml.Linq.XDocument domDoc = xfa.GetDomDocument();
Console.WriteLine(domDoc.ToString());