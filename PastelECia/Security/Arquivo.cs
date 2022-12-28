using System.IO;

namespace PastelECia.Security
{
    public class Arquivo
    {
        public static string Read(string caminho)
        {
            string read = string.Empty;

            using (var fs = new FileStream(caminho, FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                read = leitor.ReadString();
            }

            return read;
        }

        public static void Write(string caminho, string text)
        {
            using (var fs = new FileStream(caminho, FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(text);
            }
        }
    }
}
