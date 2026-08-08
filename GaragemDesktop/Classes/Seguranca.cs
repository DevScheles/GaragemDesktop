using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GaragemDesktop.Classes
{
    public static class Seguranca
    {
        private const int TamanhoSalt = 16;   // 128 bits
        private const int TamanhoHash = 32;   // 256 bits
        private const int Iteracoes = 100_000;

        public static string GerarHash(string senha)
        {
            byte[] salt = new byte[TamanhoSalt];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            byte[] hash = Derivar(senha, salt, Iteracoes, TamanhoHash);

            return string.Format(
                "PBKDF2$SHA256${0}${1}${2}",
                Iteracoes,
                Convert.ToBase64String(salt),
                Convert.ToBase64String(hash)
            );
        }

        public static bool Verificar(string senhaDigitada, string hashArmazenado)
        {
            string[] partes = hashArmazenado.Split('$');

            if (partes.Length != 5)
                return false;

            int iteracoes = int.Parse(partes[2]);
            byte[] salt = Convert.FromBase64String(partes[3]);
            byte[] esperado = Convert.FromBase64String(partes[4]);

            byte[] calculado = Derivar(
                senhaDigitada,
                salt,
                iteracoes,
                esperado.Length
            );

            return ComparacaoSegura(esperado, calculado);
        }

        private static byte[] Derivar(
            string senha,
            byte[] salt,
            int iteracoes,
            int tamanho)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(
                senha,
                salt,
                iteracoes,
                HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(tamanho);
            }
        }

        private static bool ComparacaoSegura(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;

            int diff = 0;

            for (int i = 0; i < a.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }

            return diff == 0;
        }
    }
}

