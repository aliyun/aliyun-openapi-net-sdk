using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Http
{
    public class HttpRequestTest
    {
        [Fact]
        public void Instance()
        {
            HttpRequest instance;

            instance = new HttpRequest();
            Assert.Null(instance.Url);
            Assert.Null(instance.Headers);

            instance = new HttpRequest("https://www.alibabacloud.com");
            Assert.Equal("https://www.alibabacloud.com", instance.Url);
            Assert.Empty(instance.Headers); // 会初始化为空字典，不为null

            instance = new HttpRequest("https://www.alibabacloud.com", null);
            Assert.Equal("https://www.alibabacloud.com", instance.Url);
            Assert.Null(instance.Headers); // 不会初始化为空字典，为null

            Dictionary<string, string> tmpHeaders = new Dictionary<string, string>
            { { "Content-MD5", "md5" },
                { "Content-Length", "length" },
                { "Content-Type", "text/json" }
            };
            instance = new HttpRequest("https://www.alibabacloud.com", tmpHeaders);
            UnmarshallerContext context = new UnmarshallerContext();
            context.ResponseDictionary = instance.Headers;
            Assert.Equal("md5", context.StringValue("Content-MD5"));
            Assert.Equal("https://www.alibabacloud.com", instance.Url);
        }

        [Fact]
        public static HttpRequest SetContent()
        {
            Dictionary<string, string> tmpHeaders = new Dictionary<string, string>
            { { "Content-MD5", "md5" },
                { "Content-Length", "length" },
                { "Content-Type", "text/json" }
            };
            HttpRequest instance = new HttpRequest("https://www.alibabacloud.com", tmpHeaders);
            instance.Method = MethodType.GET;
            Assert.Equal(MethodType.GET, instance.Method);

            // when content is null
            instance.SetContent(null, "UTF-8", FormatType.JSON);
            Assert.Null(instance.Content);

            // When content is not null
            byte[] content = Encoding.ASCII.GetBytes("someString");
            instance.SetContent(content, "UTF-8", FormatType.JSON);
            Assert.NotNull(instance.Content);
            Assert.Equal(content, instance.Content);

            // when formatType is null
            instance.SetContent(content, "UTF-8", null);
            Assert.NotNull(instance.Content);
            Assert.Equal(content, instance.Content);
            Assert.Equal(FormatType.JSON, instance.ContentType);

            return instance;
        }

        [Fact]
        public void TimeoutInMilliSeconds()
        {
            HttpRequest instance = new HttpRequest();
            int timeout = 100;
            instance.timeoutInMilliSeconds = 100;
            Assert.Equal(timeout, instance.timeoutInMilliSeconds);
        }

        [Fact]
        public void ConnectTimeoutTest()
        {
            HttpRequest instance = new HttpRequest();
            instance.SetConnectTimeoutInMilliSeconds(1024);

            Assert.Equal(1024, instance.connectTimeout);

            instance.SetReadTimeoutInMilliSeconds(2048);
            Assert.Equal(2048, instance.readTimeout);
        }

        [Fact]
        public void RequestIgnoreCertificateTest()
        {
            HttpRequest instance = new HttpRequest();

            instance.SetHttpsInsecure();
            Assert.False(instance.IgnoreCertificate);

            instance.SetHttpsInsecure(true);
            Assert.True(instance.IgnoreCertificate);
        }

        [Fact]
        public void RequestCertificateChainTest()
        {
            HttpRequest instance = new HttpRequest();
            X509CertificateCollection x509CertificateCollection = new X509CertificateCollection();
            
            instance.SetHTTPSCAs(x509CertificateCollection);
            Assert.Equal(x509CertificateCollection, instance.RequestX509CertificateCollection);
        }

        [Fact]
        public void GetRequestCertificateCollection()
        {
            string homePath = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ?
                Environment.GetEnvironmentVariable("HOME") + "/" :
                Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%") + "\\";

            var ecdsa = ECDsa.Create(); // generate asymmetric key pair
            var req = new CertificateRequest("cn=foobar", ecdsa, HashAlgorithmName.SHA256);
            var cert = req.CreateSelfSigned(DateTimeOffset.Now, DateTimeOffset.Now.AddYears(5));
            // Create PFX (PKCS #12) with private key
            File.WriteAllBytes(homePath + "mycert.pfx", cert.Export(X509ContentType.Pfx, "password"));
            // Create Base 64 encoded CER (public key only)
            File.WriteAllText(homePath + "mycert.cer",
                "-----BEGIN CERTIFICATE-----\r\n" +
                Convert.ToBase64String(cert.Export(X509ContentType.Cert), Base64FormattingOptions.InsertLineBreaks) +
                "\r\n-----END CERTIFICATE-----");

            X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
            x509Certificate2Collection.Import(homePath + "mycert.cer", homePath + "mycert.pfx", X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet);

            HttpRequest instance = new HttpRequest();
            instance.SetHttpsClientKey(homePath + "mycert.pfx", homePath + "mycert.cer");

            File.Delete(homePath + "mycert.cer");
            File.Delete(homePath + "mycert.pfx");

            Assert.Equal(x509Certificate2Collection, instance.RequestX509CertificateCollection);
        }
    }
}
