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
	public class ListTransitRouterVpcAttachmentsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? totalCount;

		private int? maxResults;

		private List<ListTransitRouterVpcAttachments_TransitRouterAttachment> transitRouterAttachments;

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

			private string creationTime;

			private string status;

			private string vpcId;

			private string transitRouterAttachmentId;

			private string transitRouterId;

			private string resourceType;

			private string transitRouterAttachmentDescription;

			private long? vpcOwnerId;

			private string vpcRegionId;

			private string transitRouterAttachmentName;

			private string serviceMode;

			private bool? autoPublishRouteEnabled;

			private string chargeType;

			private List<ListTransitRouterVpcAttachments_ZoneMapping> zoneMappings;

			private List<ListTransitRouterVpcAttachments_Tag> tags;

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

			public string ServiceMode
			{
				get
				{
					return serviceMode;
				}
				set	
				{
					serviceMode = value;
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

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
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

			public List<ListTransitRouterVpcAttachments_Tag> Tags
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

			public class ListTransitRouterVpcAttachments_ZoneMapping
			{

				private string zoneId;

				private string vSwitchId;

				private string networkInterfaceId;

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
			}

			public class ListTransitRouterVpcAttachments_Tag
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
