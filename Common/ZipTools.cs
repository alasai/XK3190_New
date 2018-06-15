/*************************************************************************************
    * 类 名 称：       ZipTool
    * 命名空间：       Common
    * 文 件 名：       ZipTool
    * 创建时间：       2017/6/2 10:06:15
    * 作    者：        未知
    * 说   明：        解压和压缩
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace YIEternalMIS.Common
{

    public class ZipTools
    {
        #region 压缩解压自符串

        public static string ZipString(string unCompressedString)
        {

            byte[] bytData = System.Text.Encoding.UTF8.GetBytes(unCompressedString);
            MemoryStream ms = new MemoryStream();
            Stream s = new GZipStream(ms, CompressionMode.Compress);
            s.Write(bytData, 0, bytData.Length);
            s.Close();
            byte[] compressedData = (byte[])ms.ToArray();
            return System.Convert.ToBase64String(compressedData, 0, compressedData.Length);
        }

        public static string UnzipString(string unCompressedString)
        {
            System.Text.StringBuilder uncompressedString = new System.Text.StringBuilder();
            byte[] writeData = new byte[4096];

            byte[] bytData = System.Convert.FromBase64String(unCompressedString);
            int totalLength = 0;
            int size = 0;

            Stream s = new GZipStream(new MemoryStream(bytData), CompressionMode.Decompress);
            while (true)
            {
                size = s.Read(writeData, 0, writeData.Length);
                if (size > 0)
                {
                    totalLength += size;
                    uncompressedString.Append(System.Text.Encoding.UTF8.GetString(writeData, 0, size));
                }
                else
                {
                    break;
                }
            }
            s.Close();
            return uncompressedString.ToString();
        }

        //Demo
        //string abc = ZipString(txtCompressString.Text.Trim());
        //string Result = UnzipString(abc);

        #endregion

        #region 压缩解压数据集

        public static byte[] CompressionDataSet(DataSet dsOriginal)
        {
            if (dsOriginal == null) return null;
            dsOriginal.RemotingFormat = SerializationFormat.Binary;
            BinaryFormatter bFormatter = new BinaryFormatter();
            MemoryStream mStream = new MemoryStream();
            bFormatter.Serialize(mStream, dsOriginal);
            byte[] bytes = mStream.ToArray();
            MemoryStream oStream = new MemoryStream();
            DeflateStream zipStream = new DeflateStream(oStream, CompressionMode.Compress);
            zipStream.Write(bytes, 0, bytes.Length);
            zipStream.Flush();
            zipStream.Close();
            return oStream.ToArray();
        }

        public static DataSet DecompressionDataSet(byte[] bytes)
        {
            if (bytes == null) return null;
            MemoryStream mStream = new MemoryStream(bytes);
            mStream.Seek(0, SeekOrigin.Begin);
            DeflateStream unZipStream = new DeflateStream(mStream, CompressionMode.Decompress, true);
            DataSet dsResult = new DataSet();
            dsResult.RemotingFormat = SerializationFormat.Binary;
            BinaryFormatter bFormatter = new BinaryFormatter();
            dsResult = (DataSet)bFormatter.Deserialize(unZipStream);
            return dsResult;
        }

        #endregion

        #region 压缩解压文件

        public static void CompressFile(string sourceFile, string destinationFile)
        {
            if (!File.Exists(sourceFile)) throw new FileNotFoundException();
            FileStream sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read, FileShare.Read);

            byte[] buffer = new byte[sourceStream.Length];
            int checkCounter = sourceStream.Read(buffer, 0, buffer.Length);
            if (checkCounter != buffer.Length) throw new ApplicationException();
            FileStream destinationStream = new FileStream(destinationFile, FileMode.OpenOrCreate, FileAccess.Write);

            using (GZipStream compressedStream = new GZipStream(destinationStream, CompressionMode.Compress, true))
            {
                compressedStream.Write(buffer, 0, buffer.Length);
            }
        }

        public static void DecompressFile(string sourceFile, string destinationFile)
        {
            if (!File.Exists(sourceFile)) throw new FileNotFoundException();
            FileStream sourceStream = new FileStream(sourceFile, FileMode.Open);

            byte[] quartetBuffer = new byte[4];
            int position = (int)sourceStream.Length - 4;
            sourceStream.Position = position;
            sourceStream.Read(quartetBuffer, 0, 4);
            sourceStream.Position = 0;
            int checkLength = BitConverter.ToInt32(quartetBuffer, 0);
            byte[] buffer = new byte[checkLength + 100];
            GZipStream decompressedStream = new GZipStream(sourceStream, CompressionMode.Decompress, true);
            int total = 0;
            for (int offset = 0; ; )
            {
                int bytesRead = decompressedStream.Read(buffer, offset, 100);
                if (bytesRead == 0) break;
                offset += bytesRead;
                total += bytesRead;
            }
            FileStream destinationStream = new FileStream(destinationFile, FileMode.Create);
            destinationStream.Write(buffer, 0, total);
        }

        //DEMO
        //private void btnCommpress_Click(object sender, EventArgs e)
        //{
        //    string sourceFile = Application.StartupPath + @"\MTLOperatelog.txt";
        //    string destinationFile = Application.StartupPath + @"\abc.rar";
        //    CompressFile(sourceFile, destinationFile);
        //}

        //private void btnDecompressFile_Click(object sender, EventArgs e)
        //{
        //    string sourceFile = Application.StartupPath + @"\abc.rar";
        //    string destinationFile = Application.StartupPath + @"\abc.txt";
        //    DecompressFile(sourceFile, destinationFile);
        //}


        #endregion

        #region 压缩解压Ilist

        public static byte[] CompressionArrayList(IList DataOriginal)
        {
            if (DataOriginal == null) return null;
            BinaryFormatter bFormatter = new BinaryFormatter();
            MemoryStream mStream = new MemoryStream();
            bFormatter.Serialize(mStream, DataOriginal);
            byte[] bytes = mStream.ToArray();
            MemoryStream oStream = new MemoryStream();
            DeflateStream zipStream = new DeflateStream(oStream, CompressionMode.Compress);
            zipStream.Write(bytes, 0, bytes.Length);
            zipStream.Flush();
            zipStream.Close();
            //
            return oStream.ToArray();
        }

        public static IList DecompressionArrayList(byte[] bytes)
        {
            if (bytes == null) return null;
            MemoryStream mStream = new MemoryStream(bytes);
            mStream.Seek(0, SeekOrigin.Begin);
            DeflateStream unZipStream = new DeflateStream(mStream, CompressionMode.Decompress, true);
            IList dsResult = null;
            BinaryFormatter bFormatter = new BinaryFormatter();
            dsResult = (IList)bFormatter.Deserialize(unZipStream);
            return dsResult;
        }
        #endregion

        #region 压缩解压object

        public static byte[] CompressionObject(object DataOriginal)
        {
            if (DataOriginal == null) return null;
            BinaryFormatter bFormatter = new BinaryFormatter();
            MemoryStream mStream = new MemoryStream();
            bFormatter.Serialize(mStream, DataOriginal);
            byte[] bytes = mStream.ToArray();
            MemoryStream oStream = new MemoryStream();
            DeflateStream zipStream = new DeflateStream(oStream, CompressionMode.Compress);
            zipStream.Write(bytes, 0, bytes.Length);
            zipStream.Flush();
            zipStream.Close();
            return oStream.ToArray();
        }

        public static object DecompressionObject(byte[] bytes)
        {
            if (bytes == null) return null;
            MemoryStream mStream = new MemoryStream(bytes);
            mStream.Seek(0, SeekOrigin.Begin);
            DeflateStream unZipStream = new DeflateStream(mStream, CompressionMode.Decompress, true);
            object dsResult = null;
            BinaryFormatter bFormatter = new BinaryFormatter();
            dsResult = (object)bFormatter.Deserialize(unZipStream);
            return dsResult;
        }
        #endregion
    }
}

