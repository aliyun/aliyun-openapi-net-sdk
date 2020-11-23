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
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20190307;

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
    public class DescribeDeviceInfoRequest : RpcAcsRequest<DescribeDeviceInfoResponse>
    {
        public DescribeDeviceInfoRequest()
            : base("Cloudauth", "2019-03-07", "DescribeDeviceInfo", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string userDeviceId;

		private int? pageSize;

		private string expiredStartDay;

		private int? currentPage;

		private string deviceId;

		private string bizType;

		private string expiredEndDay;

		public string UserDeviceId
		{
			get
			{
				return userDeviceId;
			}
			set	
			{
				userDeviceId = value;
				DictionaryUtil.Add(QueryParameters, "UserDeviceId", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string ExpiredStartDay
		{
			get
			{
				return expiredStartDay;
			}
			set	
			{
				expiredStartDay = value;
				DictionaryUtil.Add(QueryParameters, "ExpiredStartDay", value);
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
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

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value);
			}
		}

		public string ExpiredEndDay
		{
			get
			{
				return expiredEndDay;
			}
			set	
			{
				expiredEndDay = value;
				DictionaryUtil.Add(QueryParameters, "ExpiredEndDay", value);
			}
		}

        public override DescribeDeviceInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDeviceInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
