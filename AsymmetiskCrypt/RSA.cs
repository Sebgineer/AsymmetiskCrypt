using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AsymmetiskCrypt
{
    internal class RSA
    {
        private RSACryptoServiceProvider rsa;

        public RSACryptoServiceProvider myRSA { get { return this.rsa; } }

        public RSA()
        {
            this.rsa = new RSACryptoServiceProvider(2048);
        }

        public byte[] Encryption(byte[] message, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            byte[] encryptedData;
            rsa.ImportParameters(RSAKey);
            encryptedData = rsa.Encrypt(message, DoOAEPPadding);
            return encryptedData;
        }

        public byte[] Decrypt(byte[] data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            byte[] decryptedData;
            rsa.ImportParameters(RSAKey);
            decryptedData = this.rsa.Decrypt(data, DoOAEPPadding);
            return decryptedData;
        }

        public void importParameter(RSAParameters RSAKey)
        {
            rsa.ImportParameters(RSAKey);

        }
    }
}
