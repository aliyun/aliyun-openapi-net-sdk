using System;
using System.Globalization;
using System.Text;
using Aliyun.Acs.Dybaseapi.MNS.Model;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.Handlers;
using Aliyun.Acs.Dybaseapi.MNS.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Internal
{
    /// <summary>
    /// This handler validates response returned by MNS.
    /// </summary>
    internal class ResponseValidationHandler : GenericHandler
    {
        /// <summary>
        /// Validates the response returned by MNS.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        protected override void PostInvoke(IExecutionContext executionContext)
        {
            return;
            /*
            var request = executionContext.RequestContext.Request;
            var response = executionContext.ResponseContext.Response;
            ReceiveMessageResponse receiveMessageResponse = response as ReceiveMessageResponse;
            if (receiveMessageResponse != null)
            {
                ValidateReceiveMessage(receiveMessageResponse);
            }

            SendMessageResponse sendMessageResponse = response as SendMessageResponse;
            SendMessageRequest sendMessageRequest = request.OriginalRequest as SendMessageRequest;
            if (sendMessageRequest != null && sendMessageResponse != null)
            {
                ValidateSendMessage(sendMessageRequest, sendMessageResponse);
            }
            */
        }

        public static string CalculateMD5(string message)
        {
            var messageBytes = Encoding.UTF8.GetBytes(message);
            return CalculateMD5(messageBytes);
        }
        public static string CalculateMD5(byte[] bytes)
        {
            var md5Hash = CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(bytes);
            var calculatedMd5 = BitConverter.ToString(md5Hash).Replace("-", string.Empty).ToLower(CultureInfo.InvariantCulture);
            return calculatedMd5;
        }
        public static bool CompareMD5(string message, string md5FromService)
        {
            var calculatedMd5 = CalculateMD5(message);
            return (string.Equals(calculatedMd5, md5FromService, StringComparison.OrdinalIgnoreCase));
        }
       
        public static void ValidateMD5(string message, string md5FromService)
        {
            if (!CompareMD5(message, md5FromService))
                throw new MD5ValidateException("MD5 hash mismatch");
        }
       
        public static void ValidateMD5(string message, string messageId, string md5FromService)
        {
            if (!CompareMD5(message, md5FromService))
                throw new MD5ValidateException(string.Format(CultureInfo.InvariantCulture, "MD5 hash mismatch for message id {0}", messageId));
        }
        public static void ValidateMD5(string message, string messageId, string md5FromService, string receiptHandle)
        {
            if (!CompareMD5(message, md5FromService))
                throw new MD5ValidateException(string.Format(CultureInfo.InvariantCulture, "MD5 hash mismatch for message id {0}", messageId), receiptHandle);
        }
        public static void ValidateMD5(Message message)
        {
            ValidateMD5(message.Body, message.Id, message.BodyMD5, message.ReceiptHandle);
        }

        public static void ValidateReceiveMessage(ReceiveMessageResponse response)
        {
            if (response != null && response.Message != null)
            {
                ValidateMD5(response.Message);
            }
        }
    }
}
