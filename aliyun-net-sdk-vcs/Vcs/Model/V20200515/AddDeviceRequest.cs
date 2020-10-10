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
using Aliyun.Acs.Vcs;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class AddDeviceRequest : RpcAcsRequest<AddDeviceResponse>
    {
        public AddDeviceRequest()
            : base("Vcs", "2020-05-15", "AddDevice")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string deviceSite;

		private string corpId;

		private string gbId;

		private string bitRate;

		private string deviceDirection;

		private string deviceAddress;

		private string deviceType;

		private string deviceResolution;

		private string vendor;

		private string deviceName;

		public string DeviceSite
		{
			get
			{
				return deviceSite;
			}
			set	
			{
				deviceSite = value;
				DictionaryUtil.Add(BodyParameters, "DeviceSite", value);
			}
		}

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public string GbId
		{
			get
			{
				return gbId;
			}
			set	
			{
				gbId = value;
				DictionaryUtil.Add(BodyParameters, "GbId", value);
			}
		}

		public string BitRate
		{
			get
			{
				return bitRate;
			}
			set	
			{
				bitRate = value;
				DictionaryUtil.Add(BodyParameters, "BitRate", value);
			}
		}

		public string DeviceDirection
		{
			get
			{
				return deviceDirection;
			}
			set	
			{
				deviceDirection = value;
				DictionaryUtil.Add(BodyParameters, "DeviceDirection", value);
			}
		}

		public string DeviceAddress
		{
			get
			{
				return deviceAddress;
			}
			set	
			{
				deviceAddress = value;
				DictionaryUtil.Add(BodyParameters, "DeviceAddress", value);
			}
		}

		public string DeviceType
		{
			get
			{
				return deviceType;
			}
			set	
			{
				deviceType = value;
				DictionaryUtil.Add(BodyParameters, "DeviceType", value);
			}
		}

		public string DeviceResolution
		{
			get
			{
				return deviceResolution;
			}
			set	
			{
				deviceResolution = value;
				DictionaryUtil.Add(BodyParameters, "DeviceResolution", value);
			}
		}

		public string Vendor
		{
			get
			{
				return vendor;
			}
			set	
			{
				vendor = value;
				DictionaryUtil.Add(BodyParameters, "Vendor", value);
			}
		}

		public string DeviceName
		{
			get
			{
				return deviceName;
			}
			set	
			{
				deviceName = value;
				DictionaryUtil.Add(BodyParameters, "DeviceName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
