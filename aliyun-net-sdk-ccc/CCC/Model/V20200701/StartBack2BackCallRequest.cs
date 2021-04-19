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
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20200701;

namespace Aliyun.Acs.CCC.Model.V20200701
{
    public class StartBack2BackCallRequest : RpcAcsRequest<StartBack2BackCallResponse>
    {
        public StartBack2BackCallRequest()
            : base("CCC", "2020-07-01", "StartBack2BackCall", "CCC", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string callee;

		private string broker;

		private string userId;

		private string deviceId;

		private string additionalBroker;

		private string tags;

		private int? timeoutSeconds;

		private string caller;

		private string instanceId;

		public string Callee
		{
			get
			{
				return callee;
			}
			set	
			{
				callee = value;
				DictionaryUtil.Add(QueryParameters, "Callee", value);
			}
		}

		public string Broker
		{
			get
			{
				return broker;
			}
			set	
			{
				broker = value;
				DictionaryUtil.Add(QueryParameters, "Broker", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

		public string DeviceId
		{
			get
			{
				return deviceId;
			}
			set	
			{
				deviceId = value;
				DictionaryUtil.Add(QueryParameters, "DeviceId", value);
			}
		}

		public string AdditionalBroker
		{
			get
			{
				return additionalBroker;
			}
			set	
			{
				additionalBroker = value;
				DictionaryUtil.Add(QueryParameters, "AdditionalBroker", value);
			}
		}

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
			}
		}

		public int? TimeoutSeconds
		{
			get
			{
				return timeoutSeconds;
			}
			set	
			{
				timeoutSeconds = value;
				DictionaryUtil.Add(QueryParameters, "TimeoutSeconds", value.ToString());
			}
		}

		public string Caller
		{
			get
			{
				return caller;
			}
			set	
			{
				caller = value;
				DictionaryUtil.Add(QueryParameters, "Caller", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override StartBack2BackCallResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartBack2BackCallResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
