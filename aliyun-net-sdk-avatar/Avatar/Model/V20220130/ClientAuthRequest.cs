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
using Aliyun.Acs.avatar;
using Aliyun.Acs.avatar.Transform;
using Aliyun.Acs.avatar.Transform.V20220130;

namespace Aliyun.Acs.avatar.Model.V20220130
{
    public class ClientAuthRequest : RpcAcsRequest<ClientAuthResponse>
    {
        public ClientAuthRequest()
            : base("avatar", "2022-01-30", "ClientAuth")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string deviceId;

		private string deviceType;

		private string license;

		private string appId;

		private long? tenantId;

		private string deviceInfo;

		[JsonProperty(PropertyName = "DeviceId")]
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

		[JsonProperty(PropertyName = "DeviceType")]
		public string DeviceType
		{
			get
			{
				return deviceType;
			}
			set	
			{
				deviceType = value;
				DictionaryUtil.Add(QueryParameters, "DeviceType", value);
			}
		}

		[JsonProperty(PropertyName = "License")]
		public string License
		{
			get
			{
				return license;
			}
			set	
			{
				license = value;
				DictionaryUtil.Add(QueryParameters, "License", value);
			}
		}

		[JsonProperty(PropertyName = "AppId")]
		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		[JsonProperty(PropertyName = "TenantId")]
		public long? TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
				DictionaryUtil.Add(QueryParameters, "TenantId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DeviceInfo")]
		public string DeviceInfo
		{
			get
			{
				return deviceInfo;
			}
			set	
			{
				deviceInfo = value;
				DictionaryUtil.Add(QueryParameters, "DeviceInfo", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ClientAuthResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ClientAuthResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
