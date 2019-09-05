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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class AddAgentDeviceRequest : RpcAcsRequest<AddAgentDeviceResponse>
    {
        public AddAgentDeviceRequest()
            : base("CCC", "2017-07-05", "AddAgentDevice")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string remark;

		private string clientPort;

		private string instanceId;

		private string clientIp;

		private string browserVersion;

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(BodyParameters, "Remark", value);
			}
		}

		public string ClientPort
		{
			get
			{
				return clientPort;
			}
			set	
			{
				clientPort = value;
				DictionaryUtil.Add(QueryParameters, "ClientPort", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string ClientIp
		{
			get
			{
				return clientIp;
			}
			set	
			{
				clientIp = value;
				DictionaryUtil.Add(QueryParameters, "ClientIp", value);
			}
		}

		public string BrowserVersion
		{
			get
			{
				return browserVersion;
			}
			set	
			{
				browserVersion = value;
				DictionaryUtil.Add(BodyParameters, "BrowserVersion", value);
			}
		}

        public override AddAgentDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddAgentDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
