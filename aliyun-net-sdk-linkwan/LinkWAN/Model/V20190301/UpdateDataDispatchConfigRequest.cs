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
    public class UpdateDataDispatchConfigRequest : RpcAcsRequest<UpdateDataDispatchConfigResponse>
    {
        public UpdateDataDispatchConfigRequest()
            : base("LinkWAN", "2019-03-01", "UpdateDataDispatchConfig", "linkwan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string uplinkTopic;

		private bool? debugSwitch;

		private string productType;

		private string productName;

		private string dataDispatchDestination;

		private string uplinkRegionName;

		private string productKey;

		private string nodeGroupId;

		public string UplinkTopic
		{
			get
			{
				return uplinkTopic;
			}
			set	
			{
				uplinkTopic = value;
				DictionaryUtil.Add(QueryParameters, "UplinkTopic", value);
			}
		}

		public bool? DebugSwitch
		{
			get
			{
				return debugSwitch;
			}
			set	
			{
				debugSwitch = value;
				DictionaryUtil.Add(QueryParameters, "DebugSwitch", value.ToString());
			}
		}

		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

		public string ProductName
		{
			get
			{
				return productName;
			}
			set	
			{
				productName = value;
				DictionaryUtil.Add(QueryParameters, "ProductName", value);
			}
		}

		public string DataDispatchDestination
		{
			get
			{
				return dataDispatchDestination;
			}
			set	
			{
				dataDispatchDestination = value;
				DictionaryUtil.Add(QueryParameters, "DataDispatchDestination", value);
			}
		}

		public string UplinkRegionName
		{
			get
			{
				return uplinkRegionName;
			}
			set	
			{
				uplinkRegionName = value;
				DictionaryUtil.Add(QueryParameters, "UplinkRegionName", value);
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public string NodeGroupId
		{
			get
			{
				return nodeGroupId;
			}
			set	
			{
				nodeGroupId = value;
				DictionaryUtil.Add(QueryParameters, "NodeGroupId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateDataDispatchConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateDataDispatchConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
