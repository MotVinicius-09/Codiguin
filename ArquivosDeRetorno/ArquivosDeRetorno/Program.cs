using System;

namespace ArquivosDeRetorno
{
    public class Program
    {
        static void Main(string[] args)
        {
            string lines = System.IO.File.ReadAllText(@"C:/Testes/Teste.txt");
            string[] tConfig = lines.Split("\r\n");

            string idPc = tConfig[0].Substring(tConfig[0].IndexOf('=') + 1).Trim();
            string user = tConfig[1].Substring(tConfig[1].IndexOf('=') + 1).Trim();
            string passw = tConfig[2].Substring(tConfig[2].IndexOf('=')+ 1).Trim();

            Console.WriteLine("ID: " + idPc);
            Console.WriteLine("User: " + user);
            Console.WriteLine("Passwrod: " +passw);

        }
    }
}
