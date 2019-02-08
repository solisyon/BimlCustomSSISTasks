using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;

namespace oh22is.DTS.Task.ZIP
{
    public class Compress
    {

        public Compress(string Input, string Output, string FileFolder, decimal ZipLevel, string Password, int AesKeySize, bool Zip64)
        {
            FileStream fsOut = System.IO.File.Create(Output);
            ZipOutputStream zipStream = new ZipOutputStream(fsOut);
            zipStream.SetLevel(9); //0-9, 9 being the highest level of compression

            if (FileFolder == "FOLDER")
            {
                int folderOffset = Input.Length + (Input.EndsWith("\\") ? 0 : 1);
                CompressFolder(Input, zipStream, folderOffset, AesKeySize, Zip64);
            }
            else
            {
                CompressFile(Input, zipStream, Input.Length, AesKeySize, Zip64);
            }

            zipStream.IsStreamOwner = true; // Makes the Close also Close the underlying stream
            zipStream.Close();
        }

        private void CompressFolder(string path, ZipOutputStream zipStream, int folderOffset, int AesKeySize, bool Zip64)
        {
            string[] files = Directory.GetFiles(path);
            foreach (string filename in files)
            {
                CompressFile(filename, zipStream, folderOffset, AesKeySize, Zip64);
            }
            string[] folders = Directory.GetDirectories(path);
            foreach (string folder in folders)
            {
                CompressFolder(folder, zipStream, folderOffset, AesKeySize, Zip64);
            }
        }

        private void CompressFile(string filename, ZipOutputStream zipStream, int folderOffset, int AesKeySize, bool Zip64)
        {
            FileInfo fi = new FileInfo(filename);

            // Makes the name in zip based on the folder
            string entryName = filename.Substring(folderOffset);

            // Removes drive from name and fixes slash direction
            entryName = ZipEntry.CleanName(entryName);
            ZipEntry newEntry = new ZipEntry(entryName);

            // Note the zip format stores 2 second granularity
            newEntry.DateTime = fi.LastWriteTime;

            // Specifying the AESKeySize triggers AES encryption. Allowable values are 0 (off), 128 or 256.
            // A password on the ZipOutputStream is required if using AES.
            //
            //  CONVERT
            //

            newEntry.AESKeySize = AesKeySize;

            // To permit the zip to be unpacked by built-in extractor in WinXP and Server2003, WinZip 8, Java, and other older code,
            // you need to do one of the following: Specify UseZip64.Off, or set the Size.
            // If the file may be bigger than 4GB, or you do not need WinXP built-in compatibility, you do not need either,
            // but the zip will be in Zip64 format which not all utilities can understand.
            //   zipStream.UseZip64 = UseZip64.Off;
            newEntry.Size = fi.Length;

            zipStream.PutNextEntry(newEntry);

            byte[] buffer = new byte[4096];
            using (FileStream streamReader = System.IO.File.OpenRead(filename))
            {
                StreamUtils.Copy(streamReader, zipStream, buffer);
            }
            zipStream.CloseEntry();
        }
    }
}
