using System;
using System.Text;

namespace PastelECia.Security
{
    public class Criptografia
    {
        private static string Decode(string encode)
        {
            if (encode == null)
                return string.Empty;

            byte[] encodeByte = Convert.FromBase64String(encode);

            if (encodeByte != null && encodeByte.Length > 0)
                return ASCIIEncoding.UTF8.GetString(encodeByte);

            return string.Empty;
        }

        private static string Encode(string toEncode)
        {
            if (toEncode == null)
                return string.Empty;

            byte[] toEncodeByte = ASCIIEncoding.UTF8.GetBytes(toEncode);

            if (toEncodeByte != null && toEncodeByte.Length > 0)
                return Convert.ToBase64String(toEncodeByte);

            return string.Empty;
        }

        public string Criptografar(string informacao, string chave)
        {
            if (string.IsNullOrEmpty(informacao) || string.IsNullOrEmpty(chave))
                return string.Empty;

            var encodeInfo = Encode(informacao);
            var encodeComChave = string.Concat(chave, "=====", encodeInfo);
            var encodeInfoChave = Encode(encodeComChave);

            return Encode(encodeInfoChave);
        }

        public string Descriptografar(string informacao, string chave)
        {
            try
            {
                if (string.IsNullOrEmpty(informacao) || string.IsNullOrEmpty(chave))
                    return string.Empty;

                var decodeInfo = Decode(informacao);
                var decode2x = Decode(decodeInfo);

                string[] separador = { "=====" };
                int count = 2;

                var separadorInformacao = decode2x.Split(separador, count, StringSplitOptions.None);

                if (separadorInformacao[0].ToString() == chave)
                    return Decode(separadorInformacao[1].ToString());
            }
            catch
            {
                throw;
            }

            return string.Empty;
        }
    }
}
