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

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class ListTransitRouterPeerAttachmentsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? maxResults;

		private string nextToken;

		private List<ListTransitRouterPeerAttachments_TransitRouterAttachment> transitRouterAttachments;

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

		public List<ListTransitRouterPeerAttachments_TransitRouterAttachment> TransitRouterAttachments
		{
			get
			{
				return transitRouterAttachments;
			}
			set	
			{
				transitRouterAttachments = value;
			}
		}

		public class ListTransitRouterPeerAttachments_TransitRouterAttachment
		{

			private string transitRouterAttachmentId;

			private string peerTransitRouterRegionId;

			private long? peerTransitRouterOwnerId;

			private string peerTransitRouterId;

			private string transitRouterAttachmentName;

			private string resourceType;

			private string status;

			private string transitRouterAttachmentDescription;

			private string creationTime;

			private bool? autoPublishRouteEnabled;

			private string transitRouterId;

			private int? bandwidth;

			private string bandwidthPackageId;

			private string regionId;

			private string geographicSpanId;

			private string cenBandwidthPackageId;

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

			public string PeerTransitRouterRegionId
			{
				get
				{
					return peerTransitRouterRegionId;
				}
				set	
				{
					peerTransitRouterRegionId = value;
				}
			}

			public long? PeerTransitRouterOwnerId
			{
				get
				{
					return peerTransitRouterOwnerId;
				}
				set	
				{
					peerTransitRouterOwnerId = value;
				}
			}

			public string PeerTransitRouterId
			{
				get
				{
					return peerTransitRouterId;
				}
				set	
				{
					peerTransitRouterId = value;
				}
			}

			public string TransitRouterAttachmentName
			{
				get
				{
					return transitRouterAttachmentName;
				}
				set	
				{
					transitRouterAttachmentName = value;
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

			public string TransitRouterAttachmentDescription
			{
				get
				{
					return transitRouterAttachmentDescription;
				}
				set	
				{
					transitRouterAttachmentDescription = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public bool? AutoPublishRouteEnabled
			{
				get
				{
					return autoPublishRouteEnabled;
				}
				set	
				{
					autoPublishRouteEnabled = value;
				}
			}

			public string TransitRouterId
			{
				get
				{
					return transitRouterId;
				}
				set	
				{
					transitRouterId = value;
				}
			}

			public int? Bandwidth
			{
				get
				{
					return bandwidth;
				}
				set	
				{
					bandwidth = value;
				}
			}

			public string BandwidthPackageId
			{
				get
				{
					return bandwidthPackageId;
				}
				set	
				{
					bandwidthPackageId = value;
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

			public string GeographicSpanId
			{
				get
				{
					return geographicSpanId;
				}
				set	
				{
					geographicSpanId = value;
				}
			}

			public string CenBandwidthPackageId
			{
				get
				{
					return cenBandwidthPackageId;
				}
				set	
				{
					cenBandwidthPackageId = value;
				}
			}
		}
	}
}
