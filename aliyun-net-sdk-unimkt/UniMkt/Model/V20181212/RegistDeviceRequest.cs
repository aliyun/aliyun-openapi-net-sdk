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
using Aliyun.Acs.UniMkt.Transform;
using Aliyun.Acs.UniMkt.Transform.V20181212;

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
    public class RegistDeviceRequest : RpcAcsRequest<RegistDeviceResponse>
    {
        public RegistDeviceRequest()
            : base("UniMkt", "2018-12-12", "RegistDevice", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string firstScene;

		private string detailAddr;

		private string city;

		private string deviceType;

		private string locationName;

		private string province;

		private string district;

		private string deviceName;

		private string deviceModelNumber;

		private string secondScene;

		private string floor;

		private string channelId;

		private string outerCode;

		public string FirstScene
		{
			get
			{
				return firstScene;
			}
			set	
			{
				firstScene = value;
				DictionaryUtil.Add(BodyParameters, "FirstScene", value);
			}
		}

		public string DetailAddr
		{
			get
			{
				return detailAddr;
			}
			set	
			{
				detailAddr = value;
				DictionaryUtil.Add(BodyParameters, "DetailAddr", value);
			}
		}

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
				DictionaryUtil.Add(BodyParameters, "City", value);
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

		public string LocationName
		{
			get
			{
				return locationName;
			}
			set	
			{
				locationName = value;
				DictionaryUtil.Add(BodyParameters, "LocationName", value);
			}
		}

		public string Province
		{
			get
			{
				return province;
			}
			set	
			{
				province = value;
				DictionaryUtil.Add(BodyParameters, "Province", value);
			}
		}

		public string District
		{
			get
			{
				return district;
			}
			set	
			{
				district = value;
				DictionaryUtil.Add(BodyParameters, "District", value);
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

		public string DeviceModelNumber
		{
			get
			{
				return deviceModelNumber;
			}
			set	
			{
				deviceModelNumber = value;
				DictionaryUtil.Add(BodyParameters, "DeviceModelNumber", value);
			}
		}

		public string SecondScene
		{
			get
			{
				return secondScene;
			}
			set	
			{
				secondScene = value;
				DictionaryUtil.Add(BodyParameters, "SecondScene", value);
			}
		}

		public string Floor
		{
			get
			{
				return floor;
			}
			set	
			{
				floor = value;
				DictionaryUtil.Add(BodyParameters, "Floor", value);
			}
		}

		public string ChannelId
		{
			get
			{
				return channelId;
			}
			set	
			{
				channelId = value;
				DictionaryUtil.Add(BodyParameters, "ChannelId", value);
			}
		}

		public string OuterCode
		{
			get
			{
				return outerCode;
			}
			set	
			{
				outerCode = value;
				DictionaryUtil.Add(BodyParameters, "OuterCode", value);
			}
		}

        public override RegistDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RegistDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
