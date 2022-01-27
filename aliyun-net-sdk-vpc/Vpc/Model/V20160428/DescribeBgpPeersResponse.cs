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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeBgpPeersResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeBgpPeers_BgpPeer> bgpPeers;

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

		public List<DescribeBgpPeers_BgpPeer> BgpPeers
		{
			get
			{
				return bgpPeers;
			}
			set	
			{
				bgpPeers = value;
			}
		}

		public class DescribeBgpPeers_BgpPeer
		{

			private string name;

			private string description;

			private string bgpPeerId;

			private string bgpGroupId;

			private string peerIpAddress;

			private string peerAsn;

			private string authKey;

			private string routerId;

			private string bgpStatus;

			private string status;

			private string keepalive;

			private string localAsn;

			private string hold;

			private string isFake;

			private string routeLimit;

			private string regionId;

			private bool? enableBfd;

			private string ipVersion;

			private int? bfdMultiHop;

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

			public string BgpPeerId
			{
				get
				{
					return bgpPeerId;
				}
				set	
				{
					bgpPeerId = value;
				}
			}

			public string BgpGroupId
			{
				get
				{
					return bgpGroupId;
				}
				set	
				{
					bgpGroupId = value;
				}
			}

			public string PeerIpAddress
			{
				get
				{
					return peerIpAddress;
				}
				set	
				{
					peerIpAddress = value;
				}
			}

			public string PeerAsn
			{
				get
				{
					return peerAsn;
				}
				set	
				{
					peerAsn = value;
				}
			}

			public string AuthKey
			{
				get
				{
					return authKey;
				}
				set	
				{
					authKey = value;
				}
			}

			public string RouterId
			{
				get
				{
					return routerId;
				}
				set	
				{
					routerId = value;
				}
			}

			public string BgpStatus
			{
				get
				{
					return bgpStatus;
				}
				set	
				{
					bgpStatus = value;
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

			public string Keepalive
			{
				get
				{
					return keepalive;
				}
				set	
				{
					keepalive = value;
				}
			}

			public string LocalAsn
			{
				get
				{
					return localAsn;
				}
				set	
				{
					localAsn = value;
				}
			}

			public string Hold
			{
				get
				{
					return hold;
				}
				set	
				{
					hold = value;
				}
			}

			public string IsFake
			{
				get
				{
					return isFake;
				}
				set	
				{
					isFake = value;
				}
			}

			public string RouteLimit
			{
				get
				{
					return routeLimit;
				}
				set	
				{
					routeLimit = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public bool? EnableBfd
			{
				get
				{
					return enableBfd;
				}
				set	
				{
					enableBfd = value;
				}
			}

			public string IpVersion
			{
				get
				{
					return ipVersion;
				}
				set	
				{
					ipVersion = value;
				}
			}

			public int? BfdMultiHop
			{
				get
				{
					return bfdMultiHop;
				}
				set	
				{
					bfdMultiHop = value;
				}
			}
		}
	}
}
