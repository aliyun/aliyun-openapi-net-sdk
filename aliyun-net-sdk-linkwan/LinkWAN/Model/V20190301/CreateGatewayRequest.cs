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
    public class CreateGatewayRequest : RpcAcsRequest<CreateGatewayResponse>
    {
        public CreateGatewayRequest()
            : base("LinkWAN", "2019-03-01", "CreateGateway", "linkwan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string city;

		private float? latitude;

		private string description;

		private long? addressCode;

		private string gisCoordinateSystem;

		private string iotInstanceId;

		private float? longitude;

		private string pinCode;

		private string address;

		private string gwEui;

		private long? freqBandPlanGroupId;

		private string district;

		private string name;

		private string communicationMode;

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
				DictionaryUtil.Add(QueryParameters, "City", value);
			}
		}

		public float? Latitude
		{
			get
			{
				return latitude;
			}
			set	
			{
				latitude = value;
				DictionaryUtil.Add(QueryParameters, "Latitude", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public long? AddressCode
		{
			get
			{
				return addressCode;
			}
			set	
			{
				addressCode = value;
				DictionaryUtil.Add(QueryParameters, "AddressCode", value.ToString());
			}
		}

		public string GisCoordinateSystem
		{
			get
			{
				return gisCoordinateSystem;
			}
			set	
			{
				gisCoordinateSystem = value;
				DictionaryUtil.Add(QueryParameters, "GisCoordinateSystem", value);
			}
		}

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

		public float? Longitude
		{
			get
			{
				return longitude;
			}
			set	
			{
				longitude = value;
				DictionaryUtil.Add(QueryParameters, "Longitude", value.ToString());
			}
		}

		public string PinCode
		{
			get
			{
				return pinCode;
			}
			set	
			{
				pinCode = value;
				DictionaryUtil.Add(QueryParameters, "PinCode", value);
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
				DictionaryUtil.Add(QueryParameters, "Address", value);
			}
		}

		public string GwEui
		{
			get
			{
				return gwEui;
			}
			set	
			{
				gwEui = value;
				DictionaryUtil.Add(QueryParameters, "GwEui", value);
			}
		}

		public long? FreqBandPlanGroupId
		{
			get
			{
				return freqBandPlanGroupId;
			}
			set	
			{
				freqBandPlanGroupId = value;
				DictionaryUtil.Add(QueryParameters, "FreqBandPlanGroupId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "District", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string CommunicationMode
		{
			get
			{
				return communicationMode;
			}
			set	
			{
				communicationMode = value;
				DictionaryUtil.Add(QueryParameters, "CommunicationMode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateGatewayResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateGatewayResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
