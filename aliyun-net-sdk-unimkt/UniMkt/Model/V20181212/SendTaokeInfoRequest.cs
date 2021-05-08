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
    public class SendTaokeInfoRequest : RpcAcsRequest<SendTaokeInfoResponse>
    {
        public SendTaokeInfoRequest()
            : base("UniMkt", "2018-12-12", "SendTaokeInfo", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string productId;

		private string gender;

		private string city;

		private string userId;

		private string mac;

		private string province;

		private string productTitle;

		private string brandId;

		private string sellPrice;

		private string plat;

		private string componentId;

		private string address;

		private string ip;

		private string mediaId;

		private string phone;

		private string v;

		private string environmentType;

		private string district;

		private string imei;

		private string payPrice;

		private string channelId;

		private string age;

		private string status;

		public string ProductId
		{
			get
			{
				return productId;
			}
			set	
			{
				productId = value;
				DictionaryUtil.Add(BodyParameters, "ProductId", value);
			}
		}

		public string Gender
		{
			get
			{
				return gender;
			}
			set	
			{
				gender = value;
				DictionaryUtil.Add(BodyParameters, "Gender", value);
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

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(BodyParameters, "UserId", value);
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
				DictionaryUtil.Add(BodyParameters, "Mac", value);
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

		public string ProductTitle
		{
			get
			{
				return productTitle;
			}
			set	
			{
				productTitle = value;
				DictionaryUtil.Add(BodyParameters, "ProductTitle", value);
			}
		}

		public string BrandId
		{
			get
			{
				return brandId;
			}
			set	
			{
				brandId = value;
				DictionaryUtil.Add(BodyParameters, "BrandId", value);
			}
		}

		public string SellPrice
		{
			get
			{
				return sellPrice;
			}
			set	
			{
				sellPrice = value;
				DictionaryUtil.Add(BodyParameters, "SellPrice", value);
			}
		}

		public string Plat
		{
			get
			{
				return plat;
			}
			set	
			{
				plat = value;
				DictionaryUtil.Add(BodyParameters, "Plat", value);
			}
		}

		public string ComponentId
		{
			get
			{
				return componentId;
			}
			set	
			{
				componentId = value;
				DictionaryUtil.Add(BodyParameters, "ComponentId", value);
			}
		}

		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
				DictionaryUtil.Add(BodyParameters, "Address", value);
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
				DictionaryUtil.Add(BodyParameters, "Ip", value);
			}
		}

		public string MediaId
		{
			get
			{
				return mediaId;
			}
			set	
			{
				mediaId = value;
				DictionaryUtil.Add(BodyParameters, "MediaId", value);
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
				DictionaryUtil.Add(BodyParameters, "Phone", value);
			}
		}

		public string V
		{
			get
			{
				return v;
			}
			set	
			{
				v = value;
				DictionaryUtil.Add(BodyParameters, "V", value);
			}
		}

		public string EnvironmentType
		{
			get
			{
				return environmentType;
			}
			set	
			{
				environmentType = value;
				DictionaryUtil.Add(BodyParameters, "EnvironmentType", value);
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

		public string Imei
		{
			get
			{
				return imei;
			}
			set	
			{
				imei = value;
				DictionaryUtil.Add(BodyParameters, "Imei", value);
			}
		}

		public string PayPrice
		{
			get
			{
				return payPrice;
			}
			set	
			{
				payPrice = value;
				DictionaryUtil.Add(BodyParameters, "PayPrice", value);
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

		public string Age
		{
			get
			{
				return age;
			}
			set	
			{
				age = value;
				DictionaryUtil.Add(BodyParameters, "Age", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SendTaokeInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SendTaokeInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
