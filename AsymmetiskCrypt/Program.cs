using System;
using System.Security.Cryptography;
using System.Text;

namespace AsymmetiskCrypt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Encoding.UTF8.GetString(test(Encoding.UTF8.GetBytes("Kagemand"))));
            RSA rsa = new RSA();

            byte[] kage = Encoding.UTF8.GetBytes("Kagemand");
            byte[] crypted = rsa.Encryption(kage, rsa.myRSA.ExportParameters(false), true);
            
            
            byte[] decrypted = rsa.Decrypt(crypted, rsa.myRSA.ExportParameters(false), true);

            Console.WriteLine(Encoding.UTF8.GetString(decrypted));
            
        }

        //static byte[] test(byte[] text)
        //{
        //    byte[] RSAcipherText;
        //    byte[] PlainText;
        //    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
        //    AesManaged aesManaged = new AesManaged();
        //    aesManaged.GenerateKey();
        //    RSAcipherText = rsa.Encrypt(text, true);
        //    return rsa.Decrypt(RSAcipherText, true);
        //}
    }
}
