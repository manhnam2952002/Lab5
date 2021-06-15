using System;
using System.IO;

namespace FinallyStmt
{
    internal class FinallyDemo
    {
        public static void Main(string[] args)
        {
            FileStream outStream = null;
            FileStream inStream = null;
            try
            {
                //file ghi du lieu
                outStream = File.OpenWrite("DestinationFile.txt");
                //filr doc du lieu
                inStream = File.OpenRead("BogusInputFile.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (outStream != null)
                {
                    outStream.Close();
                    Console.WriteLine("outStream closed!");
                }

                if (inStream != null)
                {
                    inStream.Close();
                    Console.WriteLine("inStream closed !");
                }
            }
        }
    }
}