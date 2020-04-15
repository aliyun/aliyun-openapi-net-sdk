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

namespace Aliyun.Acs.Netana.Model.V20181018
{
	public class DescribeNetworkAnalyticsPacketLossResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeNetworkAnalyticsPacketLoss_PacketLossInfo> packetLossInfos;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
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
			}
		}

		public List<DescribeNetworkAnalyticsPacketLoss_PacketLossInfo> PacketLossInfos
		{
			get
			{
				return packetLossInfos;
			}
			set	
			{
				packetLossInfos = value;
			}
		}

		public class DescribeNetworkAnalyticsPacketLoss_PacketLossInfo
		{

			private string inBoundTotalPacket;

			private string outBoundTotalPacket;

			private string dataType;

			private string dateTime;

			private string ip;

			private DescribeNetworkAnalyticsPacketLoss_Country country;

			private DescribeNetworkAnalyticsPacketLoss_Province province;

			private DescribeNetworkAnalyticsPacketLoss_Carrier carrier;

			public string InBoundTotalPacket
			{
				get
				{
					return inBoundTotalPacket;
				}
				set	
				{
					inBoundTotalPacket = value;
				}
			}

			public string OutBoundTotalPacket
			{
				get
				{
					return outBoundTotalPacket;
				}
				set	
				{
					outBoundTotalPacket = value;
				}
			}

			public string DataType
			{
				get
				{
					return dataType;
				}
				set	
				{
					dataType = value;
				}
			}

			public string DateTime
			{
				get
				{
					return dateTime;
				}
				set	
				{
					dateTime = value;
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
				}
			}

			public DescribeNetworkAnalyticsPacketLoss_Country Country
			{
				get
				{
					return country;
				}
				set	
				{
					country = value;
				}
			}

			public DescribeNetworkAnalyticsPacketLoss_Province Province
			{
				get
				{
					return province;
				}
				set	
				{
					province = value;
				}
			}

			public DescribeNetworkAnalyticsPacketLoss_Carrier Carrier
			{
				get
				{
					return carrier;
				}
				set	
				{
					carrier = value;
				}
			}

			public class DescribeNetworkAnalyticsPacketLoss_Country
			{

				private string countryCode;

				private string countryCn;

				private string countryEn;

				public string CountryCode
				{
					get
					{
						return countryCode;
					}
					set	
					{
						countryCode = value;
					}
				}

				public string CountryCn
				{
					get
					{
						return countryCn;
					}
					set	
					{
						countryCn = value;
					}
				}

				public string CountryEn
				{
					get
					{
						return countryEn;
					}
					set	
					{
						countryEn = value;
					}
				}
			}

			public class DescribeNetworkAnalyticsPacketLoss_Province
			{

				private string provinceCode;

				private string provinceCn;

				private string provinceEn;

				public string ProvinceCode
				{
					get
					{
						return provinceCode;
					}
					set	
					{
						provinceCode = value;
					}
				}

				public string ProvinceCn
				{
					get
					{
						return provinceCn;
					}
					set	
					{
						provinceCn = value;
					}
				}

				public string ProvinceEn
				{
					get
					{
						return provinceEn;
					}
					set	
					{
						provinceEn = value;
					}
				}
			}

			public class DescribeNetworkAnalyticsPacketLoss_Carrier
			{

				private string carrierCode;

				private string carrierCn;

				private string carrierEn;

				public string CarrierCode
				{
					get
					{
						return carrierCode;
					}
					set	
					{
						carrierCode = value;
					}
				}

				public string CarrierCn
				{
					get
					{
						return carrierCn;
					}
					set	
					{
						carrierCn = value;
					}
				}

				public string CarrierEn
				{
					get
					{
						return carrierEn;
					}
					set	
					{
						carrierEn = value;
					}
				}
			}
		}
	}
}
