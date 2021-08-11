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
	public class ListTransitRouterVpcAttachmentsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? maxResults;

		private string nextToken;

		private List<ListTransitRouterVpcAttachments_TransitRouterAttachment> transitRouterAttachments;

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

		public List<ListTransitRouterVpcAttachments_TransitRouterAttachment> TransitRouterAttachments
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

		public class ListTransitRouterVpcAttachments_TransitRouterAttachment
		{

			private string transitRouterAttachmentId;

			private string vpcRegionId;

			private long? vpcOwnerId;

			private string vpcId;

			private string transitRouterAttachmentName;

			private string resourceType;

			private string status;

			private string transitRouterAttachmentDescription;

			private string creationTime;

			private string transitRouterId;

			private List<ListTransitRouterVpcAttachments_ZoneMapping> zoneMappings;

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

			public string VpcRegionId
			{
				get
				{
					return vpcRegionId;
				}
				set	
				{
					vpcRegionId = value;
				}
			}

			public long? VpcOwnerId
			{
				get
				{
					return vpcOwnerId;
				}
				set	
				{
					vpcOwnerId = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
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

			public List<ListTransitRouterVpcAttachments_ZoneMapping> ZoneMappings
			{
				get
				{
					return zoneMappings;
				}
				set	
				{
					zoneMappings = value;
				}
			}

			public class ListTransitRouterVpcAttachments_ZoneMapping
			{

				private string zoneId;

				private string vSwitchId;

				public string ZoneId
				{
					get
					{
						return zoneId;
					}
					set	
					{
						zoneId = value;
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
			}
		}
	}
}
