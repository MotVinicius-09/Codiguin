using System;
using System.IO;

namespace NewFileConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string id = "";
            string user = "";
            string passw = "";
            string FileName = @"C:\Users\lprog\source\FileTest.txt";
            string ConDD = "Data Source=#BD#;Initial Catalog=SOP_DEV;Persist Security Info=True;User ID=##;Password=##";
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\lprog\source\Test.txt");

            if (!System.IO.File.Exists(FileName))
            {
                System.IO.File.Create(FileName).Close();
            }

            while ((line = file.ReadLine()) != null)
            {
                if(line.Contains("ID"))
                {
                    id = line.Substring(line.IndexOf("=") + 1).Trim();
                }
                else if (line.Contains("User"))
                {
                    user = line.Substring(line.IndexOf("=") + 1).Trim();
                }
                else if (line.Contains("Passw"))
                {
                    passw = line.Substring(line.IndexOf("=") + 1).Trim();
                }
            }

            ConDD = ConDD.Replace("#BD#", id);
            ConDD = ConDD.Replace("ID=##", "ID= " + user);
            ConDD = ConDD.Replace("Password=##", "Password= " + passw);

            


            StreamWriter text = File.CreateText(FileName);
            text.WriteLine(ConDD);
            text.Close();
        }
    }
}
