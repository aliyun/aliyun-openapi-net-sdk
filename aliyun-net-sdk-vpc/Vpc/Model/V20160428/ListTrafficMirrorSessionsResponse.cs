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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class ListTrafficMirrorSessionsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private string totalCount;

		private List<ListTrafficMirrorSessions_TrafficMirrorSession> trafficMirrorSessions;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public string TotalCount
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

		public List<ListTrafficMirrorSessions_TrafficMirrorSession> TrafficMirrorSessions
		{
			get
			{
				return trafficMirrorSessions;
			}
			set	
			{
				trafficMirrorSessions = value;
			}
		}

		public class ListTrafficMirrorSessions_TrafficMirrorSession
		{

			private string trafficMirrorTargetId;

			private string trafficMirrorSessionId;

			private int? priority;

			private string trafficMirrorTargetType;

			private int? packetLength;

			private string trafficMirrorSessionDescription;

			private string trafficMirrorSessionStatus;

			private bool? enabled;

			private string trafficMirrorSessionBusinessStatus;

			private int? virtualNetworkId;

			private string trafficMirrorFilterId;

			private string trafficMirrorSessionName;

			private string resourceGroupId;

			private List<ListTrafficMirrorSessions_Tag> tags;

			private List<string> trafficMirrorSourceIds;

			public string TrafficMirrorTargetId
			{
				get
				{
					return trafficMirrorTargetId;
				}
				set	
				{
					trafficMirrorTargetId = value;
				}
			}

			public string TrafficMirrorSessionId
			{
				get
				{
					return trafficMirrorSessionId;
				}
				set	
				{
					trafficMirrorSessionId = value;
				}
			}

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string TrafficMirrorTargetType
			{
				get
				{
					return trafficMirrorTargetType;
				}
				set	
				{
					trafficMirrorTargetType = value;
				}
			}

			public int? PacketLength
			{
				get
				{
					return packetLength;
				}
				set	
				{
					packetLength = value;
				}
			}

			public string TrafficMirrorSessionDescription
			{
				get
				{
					return trafficMirrorSessionDescription;
				}
				set	
				{
					trafficMirrorSessionDescription = value;
				}
			}

			public string TrafficMirrorSessionStatus
			{
				get
				{
					return trafficMirrorSessionStatus;
				}
				set	
				{
					trafficMirrorSessionStatus = value;
				}
			}

			public bool? Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}

			public string TrafficMirrorSessionBusinessStatus
			{
				get
				{
					return trafficMirrorSessionBusinessStatus;
				}
				set	
				{
					trafficMirrorSessionBusinessStatus = value;
				}
			}

			public int? VirtualNetworkId
			{
				get
				{
					return virtualNetworkId;
				}
				set	
				{
					virtualNetworkId = value;
				}
			}

			public string TrafficMirrorFilterId
			{
				get
				{
					return trafficMirrorFilterId;
				}
				set	
				{
					trafficMirrorFilterId = value;
				}
			}

			public string TrafficMirrorSessionName
			{
				get
				{
					return trafficMirrorSessionName;
				}
				set	
				{
					trafficMirrorSessionName = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public List<ListTrafficMirrorSessions_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<string> TrafficMirrorSourceIds
			{
				get
				{
					return trafficMirrorSourceIds;
				}
				set	
				{
					trafficMirrorSourceIds = value;
				}
			}

			public class ListTrafficMirrorSessions_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
