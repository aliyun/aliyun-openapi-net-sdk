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
using Aliyun.Acs.aliyuncvc.Transform;
using Aliyun.Acs.aliyuncvc.Transform.V20191030;

namespace Aliyun.Acs.aliyuncvc.Model.V20191030
{
    public class RegisterDeviceRequest : RpcAcsRequest<RegisterDeviceResponse>
    {
        public RegisterDeviceRequest()
            : base("aliyuncvc", "2019-10-30", "RegisterDevice", "aliyuncvc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string iP;

		private string mac;

		private string token;

		private string deviceVersion;

		private string sN;

		public string IP
		{
			get
			{
				return iP;
			}
			set	
			{
				iP = value;
				DictionaryUtil.Add(QueryParameters, "IP", value);
			}
		}

		public string Mac
		{
			get
			{
				return mac;
			}
			set	
			{
				mac = value;
				DictionaryUtil.Add(QueryParameters, "Mac", value);
			}
		}

		public string Token
		{
			get
			{
				return token;
			}
			set	
			{
				token = value;
				DictionaryUtil.Add(QueryParameters, "Token", value);
			}
		}

		public string DeviceVersion
		{
			get
			{
				return deviceVersion;
			}
			set	
			{
				deviceVersion = value;
				DictionaryUtil.Add(QueryParameters, "DeviceVersion", value);
			}
		}

		public string SN
		{
			get
			{
				return sN;
			}
			set	
			{
				sN = value;
				DictionaryUtil.Add(QueryParameters, "SN", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RegisterDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RegisterDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
