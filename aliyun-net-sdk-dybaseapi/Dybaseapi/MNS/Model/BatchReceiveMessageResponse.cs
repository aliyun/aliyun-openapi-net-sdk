using Aliyun.Acs.Dybaseapi.MNS.Model.Internal.MarshallTransformations;
using Aliyun.Acs.Dybaseapi.MNS.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliyun.Acs.Dybaseapi.MNS.Model
{
    public partial class BatchReceiveMessageResponse : WebServiceResponse
    {
        private List<Message> _messages = new List<Message>();

        public List<Message> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }
    }
}
