using System;
using System.IO;
using System.Collections.Generic;

namespace CriaRelatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\HouseOfTheTest";
            string reportFile = @"C:\HouseOfTheTest\reportFile.txt";

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

            string[] infos = new string[lines.Count];
            string[] fileName = new string[infos.Length];
            int[] os = new int[infos.Length];
            int[] fileQuant = new int[infos.Length];
            DateTime dateNow = DateTime.Now;
            lines.CopyTo(infos);

            int sumFile = 0;
            for (int i = 0; i < infos.Length; i++)
            {
                string fileLine = infos[i];
                string[] arqLine = fileLine.Split(';');
                string file = arqLine[0];
                int quant = int.Parse(arqLine[1]);
                int osLine = int.Parse(arqLine[3]);
                fileName[i] = file;
                fileQuant[i] = quant;
                sumFile += fileQuant[i];
                os[i] = osLine;
                Array.Clear(arqLine, 0, arqLine.Length);
            }

            int contPag = 1;
            int cont = 0;
            int totalPags = infos.Length / 15 + 1;
            using (StreamWriter line = File.CreateText(reportFile))
            {

                while (contPag <= totalPags)
                {
                    line.WriteLine("RELAÇÃO DE ARQUIVOS                                                  PAG:{0}                                                 DATA:" + dateNow.ToString("dd/MM/yyyy"), contPag);
                    line.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------");
                    line.WriteLine("NOME DO ARQUIVO                                                               O.S                                             QUANTIDADE");
                    contPag++;
                    int contLin = 0;
                    while (cont < infos.Length)
                    {
                        line.WriteLine("{0}                     {1,22:D7}                               {2,22:D10}",fileName[cont].Length <= 40 ?fileName[cont].PadRight(40,' ') : fileName[cont].Substring(0,40),os[cont],fileQuant[cont]);
                        cont++;
                        contLin++;
                        if (contLin == 15)
                        {
                            break;
                        }
                    }
                    line.WriteLine("");
                    line.WriteLine("");
                    line.WriteLine("");
                    line.WriteLine("");
                    line.WriteLine("");
                }
                line.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------");
                line.WriteLine("TOTAL DE DOCUMENTOS:                                                                                                                  {0}", sumFile);
                line.Close();
            }
        }
    }
}
