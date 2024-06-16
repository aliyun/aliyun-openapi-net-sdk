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
	public class GetVbrFlowTopNResponse : AcsResponse
	{

		private string requestId;

		private List<GetVbrFlowTopN_VbrFlowlogTopN> virtualBorderRouterFlowlogTopN;

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

		[JsonProperty(PropertyName = "VirtualBorderRouterFlowlogTopN")]
		public List<GetVbrFlowTopN_VbrFlowlogTopN> VirtualBorderRouterFlowlogTopN
		{
			get
			{
				return virtualBorderRouterFlowlogTopN;
			}
			set	
			{
				virtualBorderRouterFlowlogTopN = value;
			}
		}

		public class GetVbrFlowTopN_VbrFlowlogTopN
		{

			private string cloudRegion;

			private string cloudIp;

			private string otherIp;

			private string cloudPort;

			private string otherPort;

			private string protocol;

			private string attachmentId;

			private string virtualBorderRouterId;

			private double? bytes;

			private double? packets;

			private string accountId;

			[JsonProperty(PropertyName = "CloudRegion")]
			public string CloudRegion
			{
				get
				{
					return cloudRegion;
				}
				set	
				{
					cloudRegion = value;
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

			[JsonProperty(PropertyName = "AttachmentId")]
			public string AttachmentId
			{
				get
				{
					return attachmentId;
				}
				set	
				{
					attachmentId = value;
				}
			}

			[JsonProperty(PropertyName = "VirtualBorderRouterId")]
			public string VirtualBorderRouterId
			{
				get
				{
					return virtualBorderRouterId;
				}
				set	
				{
					virtualBorderRouterId = value;
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
		}
	}
}
