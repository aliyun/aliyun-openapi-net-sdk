using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Aliyun.Acs.Dybaseapi.MNS.Runtime;

namespace Aliyun.Acs.Dybaseapi.MNS.Util
{
    public interface ICryptoUtil
    {
        string HMACSign(string data, string key, SigningAlgorithm algorithmName);
        byte[] HMACSignBinary(byte[] data, byte[] key, SigningAlgorithm algorithmName);

        byte[] ComputeMD5Hash(byte[] data);
        byte[] ComputeMD5Hash(Stream steam);
    }

    public static partial class CryptoUtilFactory
    {
        static CryptoUtil util = new CryptoUtil();

        public static ICryptoUtil CryptoInstance
        {
            get { return util; }
        }

        partial class CryptoUtil : ICryptoUtil
        {
            public string HMACSign(string data, string key, SigningAlgorithm algorithmName)
            {
                var binaryData = Encoding.UTF8.GetBytes(data);
                return HMACSign(binaryData, key, algorithmName);
            }

            public string HMACSign(byte[] data, string key, SigningAlgorithm algorithmName)
            {
                if (String.IsNullOrEmpty(key))
                    throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");

                if (data == null || data.Length == 0)
                    throw new ArgumentNullException("data", "Please specify data to sign.");

                // KeyedHashAlgorithm algorithm = KeyedHashAlgorithm.Create(algorithmName.ToString().ToUpper(CultureInfo.InvariantCulture));
                // compatible
                KeyedHashAlgorithm algorithm = null;

                switch (algorithmName) {
                    case SigningAlgorithm.HmacSHA1:
                        algorithm = new HMACSHA1();
                        break;
                    case SigningAlgorithm.HmacSHA256:
                        algorithm = new HMACSHA256();
                        break;
                }

                if (null == algorithm)
                    throw new InvalidOperationException("Please specify a KeyedHashAlgorithm to use.");

                try
                {
                    algorithm.Key = Encoding.UTF8.GetBytes(key);
                    byte[] bytes = algorithm.ComputeHash(data);
                    return Convert.ToBase64String(bytes);
                }
                finally
                {
                    algorithm.Clear();
                }
            }

            public byte[] ComputeMD5Hash(byte[] data)
            {
                byte[] hashed = MD5.Create().ComputeHash(data);
                return hashed;
            }

            public byte[] ComputeMD5Hash(Stream steam)
            {
                byte[] hashed = MD5.Create().ComputeHash(steam);
                return hashed;
            }

            public byte[] HMACSignBinary(byte[] data, byte[] key, SigningAlgorithm algorithmName)
            {
                if (key == null || key.Length == 0)
                    throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");

                if (data == null || data.Length == 0)
                    throw new ArgumentNullException("data", "Please specify data to sign.");

                KeyedHashAlgorithm algorithm = KeyedHashAlgorithm.Create(algorithmName.ToString().ToUpper(CultureInfo.InvariantCulture));
                if (null == algorithm)
                    throw new InvalidOperationException("Please specify a KeyedHashAlgorithm to use.");

                try
                {
                    algorithm.Key = key;
                    byte[] bytes = algorithm.ComputeHash(data);
                    return bytes;
                }
                finally
                {
                    algorithm.Clear();
                }
            }

        }
    }
}