/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.LinkWAN.Transform;
using Aliyun.Acs.LinkWAN.Transform.V20190301;

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
    public class SendUnicastCommandRequest : RpcAcsRequest<SendUnicastCommandResponse>
    {
        public SendUnicastCommandRequest()
            : base("LinkWAN", "2019-03-01", "SendUnicastCommand", "linkwan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? confirmed;

		private string content;

		private string iotInstanceId;

		private int? maxRetries;

		private string devEui;

		private bool? cleanUp;

		private int? fPort;

		public bool? Confirmed
		{
			get
			{
				return confirmed;
			}
			set	
			{
				confirmed = value;
				DictionaryUtil.Add(QueryParameters, "Confirmed", value.ToString());
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(QueryParameters, "Content", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public int? MaxRetries
		{
			get
			{
				return maxRetries;
			}
			set	
			{
				maxRetries = value;
				DictionaryUtil.Add(QueryParameters, "MaxRetries", value.ToString());
			}
		}

		public string DevEui
		{
			get
			{
				return devEui;
			}
			set	
			{
				devEui = value;
				DictionaryUtil.Add(QueryParameters, "DevEui", value);
			}
		}

		public bool? CleanUp
		{
			get
			{
				return cleanUp;
			}
			set	
			{
				cleanUp = value;
				DictionaryUtil.Add(QueryParameters, "CleanUp", value.ToString());
			}
		}

		public int? FPort
		{
			get
			{
				return fPort;
			}
			set	
			{
				fPort = value;
				DictionaryUtil.Add(QueryParameters, "FPort", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SendUnicastCommandResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SendUnicastCommandResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
