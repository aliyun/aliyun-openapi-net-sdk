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

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class ListTransitRouterMulticastGroupsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? maxResults;

		private string nextToken;

		private List<ListTransitRouterMulticastGroups_TransitRouterMulticastGroup> transitRouterMulticastGroups;

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

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

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

		public List<ListTransitRouterMulticastGroups_TransitRouterMulticastGroup> TransitRouterMulticastGroups
		{
			get
			{
				return transitRouterMulticastGroups;
			}
			set	
			{
				transitRouterMulticastGroups = value;
			}
		}

		public class ListTransitRouterMulticastGroups_TransitRouterMulticastGroup
		{

			private string groupIpAddress;

			private string transitRouterAttachmentId;

			private string vSwitchId;

			private string networkInterfaceId;

			private string peerTransitRouterMulticastDomainId;

			private string status;

			private bool? groupSource;

			private bool? groupMember;

			private string memberType;

			private string sourceType;

			private string resourceType;

			private long? resourceOwnerId;

			private string resourceId;

			private string connectPeerId;

			public string GroupIpAddress
			{
				get
				{
					return groupIpAddress;
				}
				set	
				{
					groupIpAddress = value;
				}
			}

			public string TransitRouterAttachmentId
			{
				get
				{
					return transitRouterAttachmentId;
				}
				set	
				{
					transitRouterAttachmentId = value;
				}
			}

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public string NetworkInterfaceId
			{
				get
				{
					return networkInterfaceId;
				}
				set	
				{
					networkInterfaceId = value;
				}
			}

			public string PeerTransitRouterMulticastDomainId
			{
				get
				{
					return peerTransitRouterMulticastDomainId;
				}
				set	
				{
					peerTransitRouterMulticastDomainId = value;
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
				}
			}

			public bool? GroupSource
			{
				get
				{
					return groupSource;
				}
				set	
				{
					groupSource = value;
				}
			}

			public bool? GroupMember
			{
				get
				{
					return groupMember;
				}
				set	
				{
					groupMember = value;
				}
			}

			public string MemberType
			{
				get
				{
					return memberType;
				}
				set	
				{
					memberType = value;
				}
			}

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public long? ResourceOwnerId
			{
				get
				{
					return resourceOwnerId;
				}
				set	
				{
					resourceOwnerId = value;
				}
			}

			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
				}
			}

			public string ConnectPeerId
			{
				get
				{
					return connectPeerId;
				}
				set	
				{
					connectPeerId = value;
				}
			}
		}
	}
}
