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
using Aliyun.Acs.Iot;
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class BindLicenseDeviceRequest : RpcAcsRequest<BindLicenseDeviceResponse>
    {
        public BindLicenseDeviceRequest()
            : base("Iot", "2018-01-20", "BindLicenseDevice")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string iotInstanceId;

		private List<string> iotIdLists = new List<string>(){ };

		private string productKey;

		private string licenseCode;

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

		public List<string> IotIdLists
		{
			get
			{
				return iotIdLists;
			}

			set
			{
				iotIdLists = value;
				for (int i = 0; i < iotIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"IotIdList." + (i + 1) , iotIdLists[i]);
				}
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

		public string LicenseCode
		{
			get
			{
				return licenseCode;
			}
			set	
			{
				licenseCode = value;
				DictionaryUtil.Add(QueryParameters, "LicenseCode", value);
			}
		}

        public override BindLicenseDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BindLicenseDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
