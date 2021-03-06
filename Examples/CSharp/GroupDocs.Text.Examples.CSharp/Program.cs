﻿using GroupDocs.Text_for_.NET.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDocs.Text_for_.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un-comment to apply license 
            //Common.ApplyLicense();

            #region TextExtractors

            //Extracting email attachments
            //DocumentTextExtractor.EmailsExtractor.ExtractEmailAttachments("The butterfly effect.msg");
            //DocumentTextExtractor.EmailsExtractor.ExtractTextFromEmailAttachmentsUsingContainer("The butterfly effect.msg");

            //Extracting onenote text
            //DocumentTextExtractor.OneNoteDocument.ExtractOneNoteDocument("The butterfly effect.one");

            //Opening password protected one note sections
            //DocumentTextExtractor.OneNoteDocument.OpenPasswordProtectedOneNoteSection("password protected note.one");

            //Extracting pdf text
            //DocumentTextExtractor.PdfDocument.ExtractPdfDocument("The butterfly effect.pdf");
            //DocumentTextExtractor.PdfDocument.ExtractTextFromPdfPortfolios("Portfolio.pdf");

            //Extracting slides text
            //DocumentTextExtractor.PresentationDocument.ExtractPresentationDocument("The butterfly effect.pptx");

            //Extracting the entire sheet
            //DocumentTextExtractor.SpreadsheetDocument.ExtractEntireSheet("The butterfly effect.xlsx");
            //Extracting the sheet by the rows
            //DocumentTextExtractor.SpreadsheetDocument.ExtractSheetByRows("The butterfly effect.xlsx");
            //Extracting the selected columns
            //DocumentTextExtractor.SpreadsheetDocument.ExtractSelectedColumns("The butterfly effect.xlsx");
            //Extracting selected rows and columns
            //DocumentTextExtractor.SpreadsheetDocument.ExtractSelectedColumnsAndRows("The butterfly effect.xlsx"); 

            //Extracting text from word page (formatted)
            //DocumentTextExtractor.TextDocument.ExtractEntireWordPage("The butterfly effect.docx");
            //Extracting formatted/tabled text from word
            //DocumentTextExtractor.TextDocument.FormattingTable("The butterfly effect.docx");
            //Extracting text with markdown text format, at the moment bullets are supported
            //DocumentTextExtractor.TextDocument.ExtractingWithMarkdown("The butterfly effect.docx");
            //Extracting text with html text format
            //DocumentTextExtractor.TextDocument.HtmlTextFormating("The butterfly effect.docx");

            //Extracting text from epub file(feature supported by version 17.02 or greater)
            //Extracts a line of characters from epub document
            //DocumentTextExtractor.Epub.ExtractALine("sample.epub");
            //Extracts all characters from epub document
            //DocumentTextExtractor.Epub.ExtractAllCharacters("sample.epub");
            //searches text in an epub file using regex
            //DocumentTextExtractor.Epub.SearchTextUsingRegex("sample.epub");
            //searches text in an epub document
            //DocumentTextExtractor.Epub.SearchText("sample.epub");
            //extracts highlight in epub file
            //DocumentTextExtractor.Epub.ExtractHighlight("Epub_file_with_highlighted_text.epub");
            //Detects epub media type
            //DocumentTextExtractor.Epub.DetectEpubMediaType("sample.epub");

            //Extracting text from fb2 file(feature supported by version 17.05 or greater)
            //DocumentTextExtractor.Fb2.ExtractWholeText("sample.fb2");
            //Extracting text by line from fb2 file(feature supported by version 17.05 or greater)
            //DocumentTextExtractor.Fb2.ExtractTextByLine("sample.fb2");
            //extracts highlight in fb2 file(feature supported by version 17.05 or greater)
            //DocumentTextExtractor.Fb2.ExtractHighlights("fb2_file_with_highlighted_text.fb2");
            //search text with regular expresion(feature supported by version 17.05 or greater)
            //DocumentTextExtractor.Fb2.SearchTextWithRegex("sample.fb2");
            //search text in fb2 files(feature supported by version 17.05 or greater)
            //DocumentTextExtractor.Fb2.SearchText("sample.fb2");
            //Detect fb2 media type(feature supported by version 17.05 or greater)
            //DocumentTextExtractor.Fb2.DetectMediaType("sample.fb2");
            //Extract Formatted text from fb2 files(feature supported by version 17.06 or greater)
            //DocumentTextExtractor.Fb2.ExtractFormattedText("sample.fb2");

            //Extract Text from DOT files(feature supported by version 17.07 or greater)
            //DocumentTextExtractor.Dot.ExtractText("Complex.dot");

            //Extract a line of Text from CHM files(feature supported by version 17.8.0 or greater)
            //DocumentTextExtractor.Chm.ExtractALine("sample.chm");
            //Extract all characters from CHM files(feature supported by version 17.8.0 or greater)
            //DocumentTextExtractor.Chm.ExtractAllCharacters("sample.chm");
            //Detect media type of CHM files(feature supported by version 17.9.0 or greater)
            //DocumentTextExtractor.Chm.DetectChmMediaType("sample.chm");

            #endregion

            #region MetadataExtractors
            //Extracting metadata from cells
            //MetaDataExtractor.CellsMetadata.ExtractMetadataFromCells("The butterfly effect.xlsx");
            //Extracting metadata from slides
            //MetaDataExtractor.SlidesMetadata.ExtractMetadataFromSlides("The butterfly effect.pptx");
            //Extracting metadata from words
            //MetaDataExtractor.WordsMetaData.ExtractMetadataFromWords("The butterfly effect.docx");
            //Extracting metadata from pdf documents
            //MetaDataExtractor.PdfMetaData.ExtractMetadataFromPdf("The butterfly effect.pdf");
            //Extracting metadata from emails
            //MetaDataExtractor.EmailMetaData.ExtractMetadataFromEmails("The butterfly effect.msg");
            //Extract metadata of any supported file formatted document using extractor factory
            //MetaDataExtractor.UsingExtractorFactory("The butterfly effect.pptx");
            //Extracts metadata from an epub file
            //MetaDataExtractor.EpubMetaData.ExtractMetadata("sample.epub");
            //Extracts Metadata Using Complex Metadata Extractor
            //MetaDataExtractor.EpubMetaData.ExtractMetadataUsingComplexMetadataExtractor("sample.epub");
            //Shows usage of extractor class
            //MetaDataExtractor.ExtractClassUsage("The butterfly effect.docx");
            //Extracts metadata from fb2 files
            //MetaDataExtractor.Fb2Metadata.ExtractMetadata("sample.fb2");
            #endregion

            #region ContainerExtractor
            //Extracting from OST
            //ContainerExtractor.ExtractFromOstContainer("sample.ost");
            //Enumerating all entities 
            //ContainerExtractor.EnumeratingAllEntities();
            //Enumerate all files in archive folder
            //ContainerExtractor.EnumerateAllArchivedFiles("zipcontainer.zip");
            //Read concrete file in a zip archive
            //ContainerExtractor.ReadConcreteFile("zipcontainer.zip");
            //Detect Zip Media Type
            //ContainerExtractor.DetectZipMediaType("zipcontainer.zip");
            //Retrieve emails using Entity property(feature is supported in version 17.9.0)
            //ContainerExtractor.RetrieveEmailsUsingEntity();
            //Retrieve an email using OpenEntityStream method(feature is supported in version 17.9.0)
            //ContainerExtractor.RetrieveEmailUsingOpenEntityStream();
            #endregion

            #region OtherOperations
            //Creating a concrete extractor
            //DocumentTextExtractor.SpreadsheetDocument.ConcreteExtractor("The butterfly effect.xlsx");
            //Extract all
            //OtherOperations.ExtractAllFromCells("The butterfly effect.xlsx");
            //Pass media type and encoding to the created extractor
            //DocumentTextExtractor.PassEncodingToCreatedExtractor("The butterfly effect.xlsx");
            //Extracting Password protected documents
            //DocumentTextExtractor.PasswordProtectedDocumentExtractor("Password protected document.docx");
            //Creates a container from a file or stream
            //DocumentTextExtractor.CreatingContainerUsingExtractorFactory("The butterfly effect.xlsx");
            //Extract highlights  from documents
            //DocumentTextExtractor.ExtractHighlight("doc with highlighted text.docx");
            //DocumentTextExtractor.ExtractHighlightWithLimitedWordsCount("doc with highlighted text.docx",5);
            //DocumentTextExtractor.ExtractHighlightTillStartOrEndOfLine("doc with highlighted text.docx");
            //Search text in a document
            //DocumentTextExtractor.SearchTextInDocuments("The butterfly effect.docx");
            //Search whole word in documents
            //DocumentTextExtractor.SearchWholeWord("The butterfly effect.docx");
            //Use all highlight extraction modes with search functionality
            //DocumentTextExtractor.UseExtractionModesWithSearch("doc with highlighted text.docx");
            //Extract formatted highlights from word document
            //DocumentTextExtractor.ExtractFormattedHighlights("doc with highlighted text.docx");
            //Implement IPageExtractor interface
            //DocumentTextExtractor.ImplementIpageExtractorInterface("The butterfly effect.docx");
            #endregion

            #region Tools
            //Detecting encoding by BOM
            //Tools.EncodingDetection.ExtractEncodingByBOM("Encoding detection.txt");
            //Detecting encoding by BOM and the content (if BOM is not presented)
            //Tools.EncodingDetection.ExtractEncodingByContentAndBOM("Encoding detection.txt");
            //Implements INotificationReceiver for extractors and does amual exception handling, to test the notification provide an invalid file name or something that can throw an exception so that a message can be logged
            //Tools.logger.LoggerWithManualExceptionHandling("The butterfly effect.xlsx");
            //Implements INotificationReceiver for extractors. To test the notification provide an invalid file name or something that can throw an exception so that a message can be logged
            //Tools.logger.LoggerWithManualExceptionHandling("The butterfly effect.xlsx");
            #endregion

            #region BusinessCases

            //count the statistic of word's occurrences in the document
            //WordStatistic.FindMaxWordLength("The butterfly effect.xlsx", "The butterfly effect.pptx");
            // view the content of the file in Console
            //ExtractText.ViewContentInConsole("The butterfly effect.xlsx");

            #endregion
            #region Structured Text Extraction
            //Extracting hyperlinks from document(feature supported by version 17.04 or greater)
            //DocumentTextExtractor.TextDocument.ExtractHyperlinksFromDocument("The butterfly effect.docx");
            //Extracting structured text from a spread sheet(feature supported by version 17.04 or greater)
            //DocumentTextExtractor.SpreadsheetDocument.ExtractStructuredText("The butterfly effect.xlsx");
            //Extracting top-level lists from presentation document(feature supported by version 17.04 or greater)
            //DocumentTextExtractor.PresentationDocument.ExtractTopLevelLists("The butterfly effect.pptx");
            //Extracting headers from document(feature supported by version 17.04 or greater)
            //DocumentTextExtractor.TextDocument.ExtractHeadersFromDocument("The butterfly effect.docx");
            //Extracting hyperlinks from emails(feature supported by version 17.04 or greater)
            //DocumentTextExtractor.EmailsExtractor.ExtractEmailHyperlinks("The butterfly effect.msg");
            //Extracting formatted text from Epub files(feature supported by version 17.05 or greater)
            //DocumentTextExtractor.Epub.ExtractFormattedText("sample.epub");
            //Extracting section title from Epub files(feature supported by version 17.05 or greater)
            //DocumentTextExtractor.Epub.ExtractSectionTitle("sample.epub");
            //ExtractText section title from fb2 files(feature supported by version 17.05 or greater)
            //DocumentTextExtractor.Fb2.ExtractSectionTitle("sample.fb2");
            #endregion
            Console.ReadKey();
        }
    }
}
