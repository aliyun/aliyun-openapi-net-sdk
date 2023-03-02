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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.ltl;
using Aliyun.Acs.ltl.Transform;
using Aliyun.Acs.ltl.Transform.V20190510;

namespace Aliyun.Acs.ltl.Model.V20190510
{
    public class RegisterDeviceGroupRequest : RpcAcsRequest<RegisterDeviceGroupResponse>
    {
        public RegisterDeviceGroupRequest()
            : base("ltl", "2019-05-10", "RegisterDeviceGroup")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ltl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ltl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string authorizeType;

		private string apiVersion;

		private string remark;

		private string productKey;

		private string deviceGroupName;

		private string bizChainId;

		[JsonProperty(PropertyName = "AuthorizeType")]
		public string AuthorizeType
		{
			get
			{
				return authorizeType;
			}
			set	
			{
				authorizeType = value;
				DictionaryUtil.Add(QueryParameters, "AuthorizeType", value);
			}
		}

		[JsonProperty(PropertyName = "ApiVersion")]
		public string ApiVersion
		{
			get
			{
				return apiVersion;
			}
			set	
			{
				apiVersion = value;
				DictionaryUtil.Add(QueryParameters, "ApiVersion", value);
			}
		}

		[JsonProperty(PropertyName = "Remark")]
		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		[JsonProperty(PropertyName = "ProductKey")]
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

		[JsonProperty(PropertyName = "DeviceGroupName")]
		public string DeviceGroupName
		{
			get
			{
				return deviceGroupName;
			}
			set	
			{
				deviceGroupName = value;
				DictionaryUtil.Add(QueryParameters, "DeviceGroupName", value);
			}
		}

		[JsonProperty(PropertyName = "BizChainId")]
		public string BizChainId
		{
			get
			{
				return bizChainId;
			}
			set	
			{
				bizChainId = value;
				DictionaryUtil.Add(QueryParameters, "BizChainId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RegisterDeviceGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RegisterDeviceGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
