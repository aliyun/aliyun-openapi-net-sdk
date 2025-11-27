using Aliyun.Acs.Dybaseapi.MNS.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Aliyun.Acs.Dybaseapi.MNS.Model
{
    public class BatchDeleteFailException : AliyunServiceException
    {
        private List<BatchDeleteErrorItem> _errorItems = new List<BatchDeleteErrorItem>();

        public BatchDeleteFailException() : base(MNSErrorCode.BatchDeleteFail)
        {
            this.ErrorCode = MNSErrorCode.BatchDeleteFail;
        }

        public List<BatchDeleteErrorItem> ErrorItems
        {
            get { return this._errorItems; }
            set { this._errorItems = value; }
        }
    }

    public class BatchDeleteErrorItem
    {
        private string _errorCode;
        private string _errorMessage;
        private string _receiptHandle;

        public BatchDeleteErrorItem()
        {
        }

        public BatchDeleteErrorItem(string errorCode, string errorMessage, string receiptHandle)
        {
            this._errorCode = errorCode;
            this._errorMessage = errorMessage;
            this._receiptHandle = receiptHandle;
        }

        public override string ToString()
        {
            return string.Format("ErrorCode is {0}, ErrorMessage is {1}, ReceiptHandle is {2}",
                _errorCode, _errorMessage, _receiptHandle);
        }

        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        public string ReceiptHandle
        {
            get { return this._receiptHandle; }
            set { this._receiptHandle = value; }
        }
    }
}
