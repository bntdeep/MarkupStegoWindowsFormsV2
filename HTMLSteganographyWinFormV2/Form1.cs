using HTMLSteganographyWinFormV2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLSteganographyWinFormV2
{
    public partial class Form1 : Form
    {

        XMLFile xmlContainer;
        DOCXFile docxContainer;
        string endOfMessageFlag = "!@#";

        XMLFile HTMLFileWithMessage = new XMLFile();
        DOCXFile DOCXFileWithMessage = new DOCXFile();
        public Form1()
        {
            InitializeComponent();
        }

        private void openHTMLFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Markup files (*.jsp, *.html, *.xml, *.zip)|*.jsp;*.html;*.xml;*.zip";
            openFileDialog.Title = "Select a Container";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int indexOfPoint = openFileDialog.FileName.IndexOf('.');

                string fileExctension = openFileDialog.FileName.Substring(indexOfPoint);

                string filePathToContainer = openFileDialog.FileName;

                if (fileExctension == ".xml")
                {
                    xmlContainer = new XMLFile();

                    xmlContainer.File = new StringBuilder(
                                            FileManager.ReadXMLFile(
                                                        filePathToContainer));

                    containerCapacity.Text = (xmlContainer
                                    .GetContainerCapacity(Convert.ToInt32(bitsInOneSymbolTextBox.Text))
                                    - endOfMessageFlag.Length)
                                    .ToString();

                }
                else if (fileExctension == ".docx")
                {
                    try
                    {
                        FileManager.CopyFileAndChangeExtentionToZip(openFileDialog.FileName);

                        string xmlDocument = FileManager.ReadDocumentFromZipFile("./1.zip");

                        docxContainer = new DOCXFile();
                        docxContainer.document = new XMLFile();
                        docxContainer.document.File = new StringBuilder(xmlDocument);

                        containerCapacity.Text = (docxContainer.document
                            .GetContainerCapacity(Convert.ToInt32(bitsInOneSymbolTextBox.Text))
                            - endOfMessageFlag.Length)
                            .ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в структуре документа");
                        FileManager.DeleteTempArchive("./1.zip");
                    }
                }
                else
                {
                    MessageBox.Show("Указан неверный тип файла");
                }

                openedContainerLabel.Text = filePathToContainer;
            }
        }

        private void embedMessage_TextChanged(object sender, EventArgs e)
        {
            if (docxContainer != null)
            {
                containerCapacity.Text = (docxContainer.document
                    .GetContainerCapacity(Convert.ToInt32(bitsInOneSymbolTextBox.Text))
                    - endOfMessageFlag.Length
                    - embedMessage.Text.Length)
                    .ToString();

            }
            else if (xmlContainer != null)
            {
                containerCapacity.Text = (xmlContainer
                    .GetContainerCapacity(Convert.ToInt32(bitsInOneSymbolTextBox.Text))
                    - endOfMessageFlag.Length
                    - embedMessage.Text.Length)
                    .ToString();
            }
        }

        private void embedMessageButton_Click(object sender, EventArgs e)
        {
            if (xmlContainer != null)
            {
                if (Convert.ToInt32(containerCapacity.Text) >= 0)
                {
                    Embedder.EmbedMessage(xmlContainer, embedMessage.Text,
                                            Convert.ToInt32(bitsInOneSymbolTextBox.Text));

                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    saveFileDialog1.Filter = "txt files (*.html)|*.html|All files (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        FileManager.WriteXMLFile(xmlContainer, saveFileDialog1.FileName);
                        MessageBox.Show("Встраивание завершено");
                    }
                }
                else
                {
                    MessageBox.Show("В контейнере нет места");
                }
            }
            else if (docxContainer != null)
            {
                if (Convert.ToInt32(containerCapacity.Text) >= 0)
                {
                    if(embedMessage.Text.Length == 0)
                    {
                        MessageBox.Show("Введите сообщение");
                        return;
                    }
                    Embedder.EmbedMessage(docxContainer.document, embedMessage.Text,
                                            Convert.ToInt32(bitsInOneSymbolTextBox.Text));
                    FileManager.RemoveDocumentFilefromZipArchive("./1.zip", "word/document.xml");

                    Embedder.AddStegoContainerToArchive("./1.zip", "word/document.xml", docxContainer.document.File.ToString());

                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    saveFileDialog1.Filter = "txt files (*.html)|*.html|All files (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //FileManager.WriteHTMLFile(xmlContainer, saveFileDialog1.FileName);
                        FileManager.CopyFileAndChangeExtentionToDOCX("./1.zip", saveFileDialog1.FileName); //по идее должно катать
                        FileManager.DeleteTempArchive("./1.zip");
                        MessageBox.Show("Встраивание завершено");
                    }
                }
                else
                {
                    MessageBox.Show("В контейнере нет места");
                }
            }


            docxContainer = null;
            xmlContainer = null;
        }

        private void extractMessageFromHTMLButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Markup files (*.html, *.xml, *.docx)|*.html;*.xml;*.docx";
            openFileDialog.Title = "Select a HTML Container";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePathToContainer = openFileDialog.FileName;
                string fileExtention = filePathToContainer.Substring(filePathToContainer.IndexOf('.'));

                if (fileExtention == ".xml")
                {
                    HTMLFileWithMessage.File = new StringBuilder(
                                        FileManager.ReadXMLFile(
                                                    filePathToContainer));

                    string extractedMessage = Extracter.ExtractMessage(HTMLFileWithMessage, Convert.ToInt32(bitsInOneSymbolTextBox.Text));
                    openedContainerLabel.Text = filePathToContainer;
                    extractedMessaageTextBox.Text = extractedMessage;
                }
                else if (fileExtention == ".docx")
                {
                    FileManager.CopyFileAndChangeExtentionToZip(openFileDialog.FileName);

                    string xmlDocument = FileManager.ReadDocumentFromZipFile("./1.zip");

                    DOCXFileWithMessage = new DOCXFile();
                    DOCXFileWithMessage.document = new XMLFile();
                    DOCXFileWithMessage.document.File = new StringBuilder(xmlDocument);

                    string extractedMessage = Extracter.ExtractMessage(DOCXFileWithMessage.document, Convert.ToInt32(bitsInOneSymbolTextBox.Text));
                    openedContainerLabel.Text = filePathToContainer;
                    extractedMessaageTextBox.Text = extractedMessage;
                    FileManager.DeleteTempArchive("./1.zip");
                }


            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileManager.DeleteTempArchive("./1.zip");
        }
    }
}
