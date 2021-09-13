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

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
	public class ListActiveGatewaysResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<ListActiveGateways_Gateway> data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<ListActiveGateways_Gateway> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListActiveGateways_Gateway
		{

			private string gwEui;

			private string name;

			private string description;

			private string city;

			private string district;

			private string address;

			private long? addressCode;

			private string gisCoordinateSystem;

			private float? longitude;

			private float? latitude;

			private long? freqBandPlanGroupId;

			private string communicationMode;

			private string onlineState;

			private string chargeStatus;

			public string GwEui
			{
				get
				{
					return gwEui;
				}
				set	
				{
					gwEui = value;
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
				}
			}

			public string OnlineState
			{
				get
				{
					return onlineState;
				}
				set	
				{
					onlineState = value;
				}
			}

			public string ChargeStatus
			{
				get
				{
					return chargeStatus;
				}
				set	
				{
					chargeStatus = value;
				}
			}
		}
	}
}
