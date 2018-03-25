using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using HTMLSteganographyWinFormV2.Models;

namespace HTMLSteganographyWinFormV2
{
    class FileManager
    {

        private static readonly string tempArchiveStorage = "./1.zip";
        private static readonly string xmlFileContainsMainMarkup = "word/document.xml";

        public static string ReadXMLFile(string path)
        {
            return File.ReadAllText(path);
        }

        public static void WriteXMLFile(XMLFile XMLFile, string path)
        {
            File.WriteAllText(path, XMLFile.File.ToString());
        }
        
        public static void CopyFileAndChangeExtentionToZip(String file)
        {
            File.Copy(file, Path.ChangeExtension(tempArchiveStorage, ".zip"));
        }
        public static void CopyFileAndChangeExtentionToDOCX(String file, string fileDestination)
        {
            File.Copy(file, Path.ChangeExtension(fileDestination, ".docx"),true);
        }
        public static void DeleteTempArchive(string tempArchive)
        {
            File.Delete(tempArchive);
        }

        public static string ReadDocumentFromZipFile(String filePath)
        {
            String fileContents = "";
            try
            {
                if (System.IO.File.Exists(filePath))
                {

                    System.IO.Compression.ZipArchive apcZipFile = System.IO.Compression.ZipFile.Open(filePath, System.IO.Compression.ZipArchiveMode.Read);
                    foreach (System.IO.Compression.ZipArchiveEntry entry in apcZipFile.Entries)
                    {
                        if (entry.FullName == xmlFileContainsMainMarkup)
                        {
                            System.IO.Compression.ZipArchiveEntry zipEntry = apcZipFile.GetEntry(entry.FullName);

                            using (System.IO.StreamReader sr = new System.IO.StreamReader(zipEntry.Open()))
                            {
                                fileContents = sr.ReadToEnd();
                            }
                        }
                    }
                    apcZipFile.Dispose();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return fileContents;
        }

        public static void RemoveDocumentFilefromZipArchive(string archivename, string removingDocument)
        {
            using (Stream stream = File.Open(archivename, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Update, false, null))
                {
                    ZipArchiveEntry entry = archive.GetEntry(removingDocument);
                    if (entry != null)
                    {
                        entry.Delete();
                    }
                }
            }
        }
    }
}
