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
	public class GetUserLicenseResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private GetUserLicense_Data data;

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

		public GetUserLicense_Data Data
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

		public class GetUserLicense_Data
		{

			private string oui;

			private long? gatewayTupleLimit;

			private long? gatewayTupleCount;

			private long? nodeTupleLimit;

			private long? nodeTupleCount;

			private long? gatewayLimit;

			private long? gatewayCount;

			private long? localJoinPermissionLimit;

			private long? localJoinPermissionCount;

			private long? nodeLimit;

			private long? nodeCount;

			private long? roamingJoinPermissionLimit;

			private long? roamingJoinPermissionCount;

			private long? gatewayTupleFreeLimit;

			private long? nodeTupleFreeLimit;

			private long? gatewayFreeLimit;

			private long? localJoinPermissionFreeLimit;

			private long? roamingJoinPermissionFreeLimit;

			private long? nodeFreeLimit;

			private long? relayLimit;

			private long? relayCount;

			private long? gatewayPrePayCount;

			private long? nodeTupleRelayLimit;

			private long? nodeTupleRelayCount;

			private long? nodeTupleStandardLimit;

			private long? nodeTupleStandardCount;

			private long? gatewayTupleHybridLimit;

			private long? gatewayTupleHybridCount;

			private long? gatewayTupleSingleChannelLimit;

			private long? gatewayTupleSingleChannelCount;

			private long? gatewayTupleStandardLimit;

			private long? gatewayTupleStandardCount;

			private long? gatewayDingTalkCount;

			private long? gatewayDingTalkLimit;

			private long? gatewayProfessionalCount;

			private long? gatewayProfessionalLimit;

			public string Oui
			{
				get
				{
					return oui;
				}
				set	
				{
					oui = value;
				}
			}

			public long? GatewayTupleLimit
			{
				get
				{
					return gatewayTupleLimit;
				}
				set	
				{
					gatewayTupleLimit = value;
				}
			}

			public long? GatewayTupleCount
			{
				get
				{
					return gatewayTupleCount;
				}
				set	
				{
					gatewayTupleCount = value;
				}
			}

			public long? NodeTupleLimit
			{
				get
				{
					return nodeTupleLimit;
				}
				set	
				{
					nodeTupleLimit = value;
				}
			}

			public long? NodeTupleCount
			{
				get
				{
					return nodeTupleCount;
				}
				set	
				{
					nodeTupleCount = value;
				}
			}

			public long? GatewayLimit
			{
				get
				{
					return gatewayLimit;
				}
				set	
				{
					gatewayLimit = value;
				}
			}

			public long? GatewayCount
			{
				get
				{
					return gatewayCount;
				}
				set	
				{
					gatewayCount = value;
				}
			}

			public long? LocalJoinPermissionLimit
			{
				get
				{
					return localJoinPermissionLimit;
				}
				set	
				{
					localJoinPermissionLimit = value;
				}
			}

			public long? LocalJoinPermissionCount
			{
				get
				{
					return localJoinPermissionCount;
				}
				set	
				{
					localJoinPermissionCount = value;
				}
			}

			public long? NodeLimit
			{
				get
				{
					return nodeLimit;
				}
				set	
				{
					nodeLimit = value;
				}
			}

			public long? NodeCount
			{
				get
				{
					return nodeCount;
				}
				set	
				{
					nodeCount = value;
				}
			}

			public long? RoamingJoinPermissionLimit
			{
				get
				{
					return roamingJoinPermissionLimit;
				}
				set	
				{
					roamingJoinPermissionLimit = value;
				}
			}

			public long? RoamingJoinPermissionCount
			{
				get
				{
					return roamingJoinPermissionCount;
				}
				set	
				{
					roamingJoinPermissionCount = value;
				}
			}

			public long? GatewayTupleFreeLimit
			{
				get
				{
					return gatewayTupleFreeLimit;
				}
				set	
				{
					gatewayTupleFreeLimit = value;
				}
			}

			public long? NodeTupleFreeLimit
			{
				get
				{
					return nodeTupleFreeLimit;
				}
				set	
				{
					nodeTupleFreeLimit = value;
				}
			}

			public long? GatewayFreeLimit
			{
				get
				{
					return gatewayFreeLimit;
				}
				set	
				{
					gatewayFreeLimit = value;
				}
			}

			public long? LocalJoinPermissionFreeLimit
			{
				get
				{
					return localJoinPermissionFreeLimit;
				}
				set	
				{
					localJoinPermissionFreeLimit = value;
				}
			}

			public long? RoamingJoinPermissionFreeLimit
			{
				get
				{
					return roamingJoinPermissionFreeLimit;
				}
				set	
				{
					roamingJoinPermissionFreeLimit = value;
				}
			}

			public long? NodeFreeLimit
			{
				get
				{
					return nodeFreeLimit;
				}
				set	
				{
					nodeFreeLimit = value;
				}
			}

			public long? RelayLimit
			{
				get
				{
					return relayLimit;
				}
				set	
				{
					relayLimit = value;
				}
			}

			public long? RelayCount
			{
				get
				{
					return relayCount;
				}
				set	
				{
					relayCount = value;
				}
			}

			public long? GatewayPrePayCount
			{
				get
				{
					return gatewayPrePayCount;
				}
				set	
				{
					gatewayPrePayCount = value;
				}
			}

			public long? NodeTupleRelayLimit
			{
				get
				{
					return nodeTupleRelayLimit;
				}
				set	
				{
					nodeTupleRelayLimit = value;
				}
			}

			public long? NodeTupleRelayCount
			{
				get
				{
					return nodeTupleRelayCount;
				}
				set	
				{
					nodeTupleRelayCount = value;
				}
			}

			public long? NodeTupleStandardLimit
			{
				get
				{
					return nodeTupleStandardLimit;
				}
				set	
				{
					nodeTupleStandardLimit = value;
				}
			}

			public long? NodeTupleStandardCount
			{
				get
				{
					return nodeTupleStandardCount;
				}
				set	
				{
					nodeTupleStandardCount = value;
				}
			}

			public long? GatewayTupleHybridLimit
			{
				get
				{
					return gatewayTupleHybridLimit;
				}
				set	
				{
					gatewayTupleHybridLimit = value;
				}
			}

			public long? GatewayTupleHybridCount
			{
				get
				{
					return gatewayTupleHybridCount;
				}
				set	
				{
					gatewayTupleHybridCount = value;
				}
			}

			public long? GatewayTupleSingleChannelLimit
			{
				get
				{
					return gatewayTupleSingleChannelLimit;
				}
				set	
				{
					gatewayTupleSingleChannelLimit = value;
				}
			}

			public long? GatewayTupleSingleChannelCount
			{
				get
				{
					return gatewayTupleSingleChannelCount;
				}
				set	
				{
					gatewayTupleSingleChannelCount = value;
				}
			}

			public long? GatewayTupleStandardLimit
			{
				get
				{
					return gatewayTupleStandardLimit;
				}
				set	
				{
					gatewayTupleStandardLimit = value;
				}
			}

			public long? GatewayTupleStandardCount
			{
				get
				{
					return gatewayTupleStandardCount;
				}
				set	
				{
					gatewayTupleStandardCount = value;
				}
			}

			public long? GatewayDingTalkCount
			{
				get
				{
					return gatewayDingTalkCount;
				}
				set	
				{
					gatewayDingTalkCount = value;
				}
			}

			public long? GatewayDingTalkLimit
			{
				get
				{
					return gatewayDingTalkLimit;
				}
				set	
				{
					gatewayDingTalkLimit = value;
				}
			}

			public long? GatewayProfessionalCount
			{
				get
				{
					return gatewayProfessionalCount;
				}
				set	
				{
					gatewayProfessionalCount = value;
				}
			}

			public long? GatewayProfessionalLimit
			{
				get
				{
					return gatewayProfessionalLimit;
				}
				set	
				{
					gatewayProfessionalLimit = value;
				}
			}
		}
	}
}
