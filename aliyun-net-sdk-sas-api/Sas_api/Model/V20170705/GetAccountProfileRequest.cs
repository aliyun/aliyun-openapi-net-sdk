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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Sas_api.Transform;
using Aliyun.Acs.Sas_api.Transform.V20170705;
using System.Collections.Generic;

namespace Aliyun.Acs.Sas_api.Model.V20170705
{
    public class GetAccountProfileRequest : RpcAcsRequest<GetAccountProfileResponse>
    {
        public GetAccountProfileRequest()
            : base("Sas_api", "2017-07-05", "GetAccountProfile")
        {
        }

		private string deviceIdMd5;

		private int? carrier;

		private string os;

		private string phone;

		private string requestUrl;

		private string ip;

		private string userAgent;

		private int? connectionType;

		private int? sensType;

		private int? deviceType;

		private long? accessTimestamp;

		private int? businessType;

		public string DeviceIdMd5
		{
			get
			{
				return deviceIdMd5;
			}
			set	
			{
				deviceIdMd5 = value;
				DictionaryUtil.Add(QueryParameters, "DeviceIdMd5", value);
			}
		}

		public int? Carrier
		{
			get
			{
				return carrier;
			}
			set	
			{
				carrier = value;
				DictionaryUtil.Add(QueryParameters, "Carrier", value.ToString());
			}
		}

		public string Os
		{
			get
			{
				return os;
			}
			set	
			{
				os = value;
				DictionaryUtil.Add(QueryParameters, "Os", value);
			}
		}

		public string Phone
		{
			get
			{
				return phone;
			}
			set	
			{
				phone = value;
				DictionaryUtil.Add(QueryParameters, "Phone", value);
			}
		}

		public string RequestUrl
		{
			get
			{
				return requestUrl;
			}
			set	
			{
				requestUrl = value;
				DictionaryUtil.Add(QueryParameters, "RequestUrl", value);
			}
		}

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
				DictionaryUtil.Add(QueryParameters, "Ip", value);
			}
		}

		public string UserAgent
		{
			get
			{
				return userAgent;
			}
			set	
			{
				userAgent = value;
				DictionaryUtil.Add(QueryParameters, "UserAgent", value);
			}
		}

		public int? ConnectionType
		{
			get
			{
				return connectionType;
			}
			set	
			{
				connectionType = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionType", value.ToString());
			}
		}

		public int? SensType
		{
			get
			{
				return sensType;
			}
			set	
			{
				sensType = value;
				DictionaryUtil.Add(QueryParameters, "SensType", value.ToString());
			}
		}

		public int? DeviceType
		{
			get
			{
				return deviceType;
			}
			set	
			{
				deviceType = value;
				DictionaryUtil.Add(QueryParameters, "DeviceType", value.ToString());
			}
		}

		public long? AccessTimestamp
		{
			get
			{
				return accessTimestamp;
			}
			set	
			{
				accessTimestamp = value;
				DictionaryUtil.Add(QueryParameters, "AccessTimestamp", value.ToString());
			}
		}

		public int? BusinessType
		{
			get
			{
				return businessType;
			}
			set	
			{
				businessType = value;
				DictionaryUtil.Add(QueryParameters, "BusinessType", value.ToString());
			}
		}

        public override GetAccountProfileResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return GetAccountProfileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}