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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.nis.Model.V20211216
{
	public class GetInternetTupleResponse : AcsResponse
	{

		private string requestId;

		private List<GetInternetTuple_DataItem> data;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Data")]
		public List<GetInternetTuple_DataItem> Data
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

		public class GetInternetTuple_DataItem
		{

			private string beginTime;

			private string direction;

			private string instanceId;

			private string accessRegion;

			private string cloudIp;

			private string cloudPort;

			private string otherIp;

			private string otherPort;

			private string protocol;

			private string cloudCountry;

			private string cloudProvince;

			private string cloudCity;

			private string cloudIsp;

			private string cloudProduct;

			private string otherCountry;

			private string otherProvince;

			private string otherCity;

			private string otherIsp;

			private string otherProduct;

			private double? rtt;

			private double? byteCount;

			private double? packetCount;

			private double? outOrderCount;

			private double? retranCount;

			private double? inByteCount;

			private double? outByteCount;

			private double? inPacketCount;

			private double? outPacketCount;

			private double? inOutOrderCount;

			private double? outOutOrderCount;

			private double? inRetranCount;

			private double? outRetranCount;

			private double? retransmitRate;

			[JsonProperty(PropertyName = "BeginTime")]
			public string BeginTime
			{
				get
				{
					return beginTime;
				}
				set	
				{
					beginTime = value;
				}
			}

			[JsonProperty(PropertyName = "Direction")]
			public string Direction
			{
				get
				{
					return direction;
				}
				set	
				{
					direction = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceId")]
			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			[JsonProperty(PropertyName = "AccessRegion")]
			public string AccessRegion
			{
				get
				{
					return accessRegion;
				}
				set	
				{
					accessRegion = value;
				}
			}

			[JsonProperty(PropertyName = "CloudIp")]
			public string CloudIp
			{
				get
				{
					return cloudIp;
				}
				set	
				{
					cloudIp = value;
				}
			}

			[JsonProperty(PropertyName = "CloudPort")]
			public string CloudPort
			{
				get
				{
					return cloudPort;
				}
				set	
				{
					cloudPort = value;
				}
			}

			[JsonProperty(PropertyName = "OtherIp")]
			public string OtherIp
			{
				get
				{
					return otherIp;
				}
				set	
				{
					otherIp = value;
				}
			}

			[JsonProperty(PropertyName = "OtherPort")]
			public string OtherPort
			{
				get
				{
					return otherPort;
				}
				set	
				{
					otherPort = value;
				}
			}

			[JsonProperty(PropertyName = "Protocol")]
			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			[JsonProperty(PropertyName = "CloudCountry")]
			public string CloudCountry
			{
				get
				{
					return cloudCountry;
				}
				set	
				{
					cloudCountry = value;
				}
			}

			[JsonProperty(PropertyName = "CloudProvince")]
			public string CloudProvince
			{
				get
				{
					return cloudProvince;
				}
				set	
				{
					cloudProvince = value;
				}
			}

			[JsonProperty(PropertyName = "CloudCity")]
			public string CloudCity
			{
				get
				{
					return cloudCity;
				}
				set	
				{
					cloudCity = value;
				}
			}

			[JsonProperty(PropertyName = "CloudIsp")]
			public string CloudIsp
			{
				get
				{
					return cloudIsp;
				}
				set	
				{
					cloudIsp = value;
				}
			}

			[JsonProperty(PropertyName = "CloudProduct")]
			public string CloudProduct
			{
				get
				{
					return cloudProduct;
				}
				set	
				{
					cloudProduct = value;
				}
			}

			[JsonProperty(PropertyName = "OtherCountry")]
			public string OtherCountry
			{
				get
				{
					return otherCountry;
				}
				set	
				{
					otherCountry = value;
				}
			}

			[JsonProperty(PropertyName = "OtherProvince")]
			public string OtherProvince
			{
				get
				{
					return otherProvince;
				}
				set	
				{
					otherProvince = value;
				}
			}

			[JsonProperty(PropertyName = "OtherCity")]
			public string OtherCity
			{
				get
				{
					return otherCity;
				}
				set	
				{
					otherCity = value;
				}
			}

			[JsonProperty(PropertyName = "OtherIsp")]
			public string OtherIsp
			{
				get
				{
					return otherIsp;
				}
				set	
				{
					otherIsp = value;
				}
			}

			[JsonProperty(PropertyName = "OtherProduct")]
			public string OtherProduct
			{
				get
				{
					return otherProduct;
				}
				set	
				{
					otherProduct = value;
				}
			}

			[JsonProperty(PropertyName = "Rtt")]
			public double? Rtt
			{
				get
				{
					return rtt;
				}
				set	
				{
					rtt = value;
				}
			}

			[JsonProperty(PropertyName = "ByteCount")]
			public double? ByteCount
			{
				get
				{
					return byteCount;
				}
				set	
				{
					byteCount = value;
				}
			}

			[JsonProperty(PropertyName = "PacketCount")]
			public double? PacketCount
			{
				get
				{
					return packetCount;
				}
				set	
				{
					packetCount = value;
				}
			}

			[JsonProperty(PropertyName = "OutOrderCount")]
			public double? OutOrderCount
			{
				get
				{
					return outOrderCount;
				}
				set	
				{
					outOrderCount = value;
				}
			}

			[JsonProperty(PropertyName = "RetranCount")]
			public double? RetranCount
			{
				get
				{
					return retranCount;
				}
				set	
				{
					retranCount = value;
				}
			}

			[JsonProperty(PropertyName = "InByteCount")]
			public double? InByteCount
			{
				get
				{
					return inByteCount;
				}
				set	
				{
					inByteCount = value;
				}
			}

			[JsonProperty(PropertyName = "OutByteCount")]
			public double? OutByteCount
			{
				get
				{
					return outByteCount;
				}
				set	
				{
					outByteCount = value;
				}
			}

			[JsonProperty(PropertyName = "InPacketCount")]
			public double? InPacketCount
			{
				get
				{
					return inPacketCount;
				}
				set	
				{
					inPacketCount = value;
				}
			}

			[JsonProperty(PropertyName = "OutPacketCount")]
			public double? OutPacketCount
			{
				get
				{
					return outPacketCount;
				}
				set	
				{
					outPacketCount = value;
				}
			}

			[JsonProperty(PropertyName = "InOutOrderCount")]
			public double? InOutOrderCount
			{
				get
				{
					return inOutOrderCount;
				}
				set	
				{
					inOutOrderCount = value;
				}
			}

			[JsonProperty(PropertyName = "OutOutOrderCount")]
			public double? OutOutOrderCount
			{
				get
				{
					return outOutOrderCount;
				}
				set	
				{
					outOutOrderCount = value;
				}
			}

			[JsonProperty(PropertyName = "InRetranCount")]
			public double? InRetranCount
			{
				get
				{
					return inRetranCount;
				}
				set	
				{
					inRetranCount = value;
				}
			}

			[JsonProperty(PropertyName = "OutRetranCount")]
			public double? OutRetranCount
			{
				get
				{
					return outRetranCount;
				}
				set	
				{
					outRetranCount = value;
				}
			}

			[JsonProperty(PropertyName = "RetransmitRate")]
			public double? RetransmitRate
			{
				get
				{
					return retransmitRate;
				}
				set	
				{
					retransmitRate = value;
				}
			}
		}
	}
}
