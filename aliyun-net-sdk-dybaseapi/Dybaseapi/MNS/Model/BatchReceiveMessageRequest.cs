using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliyun.Acs.Dybaseapi.MNS.Model
{
    public partial class BatchReceiveMessageRequest : SimpleMNSRequest
    {
        private uint _batchSize;
        private uint? _waitSeconds;

        public BatchReceiveMessageRequest(uint batchSize)
        {
            this._batchSize = batchSize;
        }

        public BatchReceiveMessageRequest(uint batchSize, uint waitSeconds)
        {
            this._batchSize = batchSize;
            this._waitSeconds = waitSeconds;
        }

        public bool IsSetWaitSeconds()
        {
            return this._waitSeconds.HasValue;
        }

        public uint WaitSeconds
        {
            get { return this._waitSeconds.GetValueOrDefault(); }
            set { this._waitSeconds = value; }
        }

        public uint BatchSize
        {
            get { return this._batchSize; }
            set { this._batchSize = value; }
        }
    }
}
