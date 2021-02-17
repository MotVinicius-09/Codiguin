using System;
using System.IO;
using System.Collections.Generic;

namespace CriaRelatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\vinicius.STLSEND\Desktop\lk\CSharp\estudos\HouseOfTheTest";
            string reportFile = @"C:\Users\vinicius.STLSEND\Desktop\lk\CSharp\estudos\HouseOfTheTest\reportFile.txt";

            string[] files = Directory.GetFiles(path);
            List<string> lines = new List<string>();

            foreach (var file in files)
            {
                if (File.Exists(file))
                {
                    using (StreamReader reader = new StreamReader(file))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();

                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                lines.Add(line);
                            }
                        }
                        reader.Close();
                    }
                }
            }
            string[] fileName = new string[lines.Count];
            string[] os = new string[lines.Count];
            string[] fileNum = new string[lines.Count];
            DateTime dateNow = DateTime.Now;
            string[] infos = new string[lines.Count];
            lines.CopyTo(infos);
    
      for (int i = 0; i < infos.Length; i++)
            {
                fileName[i] = infos[i].Substring(0, infos[i].ToUpper().IndexOf(".TXT"));
                os[i] = infos[i].Substring(infos[i].IndexOf("-2021") + 6);
                fileNum[i] = infos[i].Substring(infos[i].ToUpper().IndexOf(".TXT") + 5, infos[i].ToUpper().IndexOf(".TXT") + 9);
            }

            using (StreamWriter line = File.CreateText(reportFile))
            {
                line.WriteLine("RELAÇÃO DE ARQUIVOS                                  PAG:01                 DATA:" + dateNow.ToString("dd/MM/yyyy"));
                line.WriteLine("-------------------------------------------------------------------------------------------");
                line.WriteLine("NOME DO ARQUIVO                                      O.S                         QUANTIDADE");
                for (int i = 0; i < infos.Length; i++)
                {
                    line.WriteLine(fileName[i].PadLeft(5) + os[i].PadLeft(31).PadRight(20) + fileNum[i]);
                }
                line.WriteLine("-------------------------------------------------------------------------------------------");
                line.WriteLine("TOTAL DE DOCUMENTOS                                                                      {0}", lines.Count);
                line.Close();
            }
        }
    }
}
