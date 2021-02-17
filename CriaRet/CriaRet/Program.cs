using System;
using System.IO;
using ClosedXML.Excel;
using OfficeOpenXml;

namespace CriaRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            int numAleat1;
            int numAleat2;
            int os;
            int quantArq;
            string fileNameAut = "";
            string fileNamePen = "";
            string pathName;
            for (int i = 0; i < 5; i++)
            {
                numAleat1 = n.Next(1000000, 9999999);
                numAleat2 = n.Next(1000000, 9999999);
                os = n.Next(1000, 9999);
                quantArq = n.Next(1000, 9999);
                fileNameAut = "A" + "_" + numAleat1 + "_" + numAleat2 + ".TXT";
                pathName = @"C:\HouseOfTheTest\" + os + ".RET";
                CriaRetAut(os, quantArq, fileNameAut, pathName);


            }

            for (int i = 0; i < 5; i++)
            {
                numAleat1 = n.Next(1000000, 9999999);
                numAleat2 = n.Next(1000000, 9999999);
                os = n.Next(1000, 9999);
                quantArq = n.Next(1000, 9999);
                fileNamePen = "P" + "_" + numAleat1 + "_" + numAleat2 + ".TXT";
                pathName = @"C:\HouseOfTheTest\" + os + ".RET";
                CriaRetPen(os, quantArq, fileNamePen, pathName);
            }
        }

        public static void CriaRetAut(int os, int quantArq, string corpArq, string pathName)
        {
            for (int i = 0; i < 5; i++)
            {
                StreamWriter aut = File.CreateText(pathName);
                aut.WriteLine(corpArq + ";" + quantArq + ";" + os + ";");
                aut.Close();
            }


        }

        public static void CriaRetPen(int os, int quantArq, string corpArq, string pathName)
        {
            for (int i = 0; i < 5; i++)
            {
                StreamWriter pen = File.CreateText(pathName);
                pen.WriteLine(corpArq + ";" + quantArq + ";" + os + ";");
                pen.Close();
            }
        }


    }
}
