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
	public class GetTransitRouterFlowTopNResponse : AcsResponse
	{

		private string requestId;

		private List<GetTransitRouterFlowTopN_TrFlowlogTopN> transitRouterFlowTopN;

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

		[JsonProperty(PropertyName = "TransitRouterFlowTopN")]
		public List<GetTransitRouterFlowTopN_TrFlowlogTopN> TransitRouterFlowTopN
		{
			get
			{
				return transitRouterFlowTopN;
			}
			set	
			{
				transitRouterFlowTopN = value;
			}
		}

		public class GetTransitRouterFlowTopN_TrFlowlogTopN
		{

			private string accountId;

			private string cenId;

			private string thisRegion;

			private string thisIp;

			private string thisPort;

			private string otherRegion;

			private string otherIp;

			private string otherPort;

			private string protocol;

			private string startTime;

			private string endTime;

			private double? packets;

			private double? bytes;

			private string bandwithPackageId;

			[JsonProperty(PropertyName = "AccountId")]
			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

			[JsonProperty(PropertyName = "CenId")]
			public string CenId
			{
				get
				{
					return cenId;
				}
				set	
				{
					cenId = value;
				}
			}

			[JsonProperty(PropertyName = "ThisRegion")]
			public string ThisRegion
			{
				get
				{
					return thisRegion;
				}
				set	
				{
					thisRegion = value;
				}
			}

			[JsonProperty(PropertyName = "ThisIp")]
			public string ThisIp
			{
				get
				{
					return thisIp;
				}
				set	
				{
					thisIp = value;
				}
			}

			[JsonProperty(PropertyName = "ThisPort")]
			public string ThisPort
			{
				get
				{
					return thisPort;
				}
				set	
				{
					thisPort = value;
				}
			}

			[JsonProperty(PropertyName = "OtherRegion")]
			public string OtherRegion
			{
				get
				{
					return otherRegion;
				}
				set	
				{
					otherRegion = value;
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

			[JsonProperty(PropertyName = "StartTime")]
			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			[JsonProperty(PropertyName = "EndTime")]
			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			[JsonProperty(PropertyName = "Packets")]
			public double? Packets
			{
				get
				{
					return packets;
				}
				set	
				{
					packets = value;
				}
			}

			[JsonProperty(PropertyName = "Bytes")]
			public double? Bytes
			{
				get
				{
					return bytes;
				}
				set	
				{
					bytes = value;
				}
			}

			[JsonProperty(PropertyName = "BandwithPackageId")]
			public string BandwithPackageId
			{
				get
				{
					return bandwithPackageId;
				}
				set	
				{
					bandwithPackageId = value;
				}
			}
		}
	}
}
