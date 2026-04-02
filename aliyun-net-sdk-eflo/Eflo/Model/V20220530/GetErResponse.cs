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

namespace Aliyun.Acs.eflo.Model.V20220530
{
	public class GetErResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private string accessDeniedDetail;

		private GetEr_Content content;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public string AccessDeniedDetail
		{
			get
			{
				return accessDeniedDetail;
			}
			set	
			{
				accessDeniedDetail = value;
			}
		}

		public GetEr_Content Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public class GetEr_Content
		{

			private string createTime;

			private string gmtModified;

			private string message;

			private string erId;

			private string regionId;

			private string tenantId;

			private string status;

			private string erName;

			private string masterZoneId;

			private string description;

			private string resourceGroupId;

			private List<GetEr_ErAttachment> erAttachments;

			private List<GetEr_ErRouteMap> erRouteMaps;

			private List<GetEr_ErRouteEntry> erRouteEntrys;

			private List<GetEr_Tag> tags;

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			public string ErId
			{
				get
				{
					return erId;
				}
				set	
				{
					erId = value;
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

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
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

			public string ErName
			{
				get
				{
					return erName;
				}
				set	
				{
					erName = value;
				}
			}

			public string MasterZoneId
			{
				get
				{
					return masterZoneId;
				}
				set	
				{
					masterZoneId = value;
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

			public List<GetEr_ErAttachment> ErAttachments
			{
				get
				{
					return erAttachments;
				}
				set	
				{
					erAttachments = value;
				}
			}

			public List<GetEr_ErRouteMap> ErRouteMaps
			{
				get
				{
					return erRouteMaps;
				}
				set	
				{
					erRouteMaps = value;
				}
			}

			public List<GetEr_ErRouteEntry> ErRouteEntrys
			{
				get
				{
					return erRouteEntrys;
				}
				set	
				{
					erRouteEntrys = value;
				}
			}

			public List<GetEr_Tag> Tags
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

			public class GetEr_ErAttachment
			{

				private string status;

				private string message;

				private string resourceGroupId;

				private string instanceId;

				private string createTime;

				private string gmtModified;

				private string erId;

				private bool? across;

				private string instanceName;

				private string tenantId;

				private string resourceTenantId;

				private bool? autoReceiveAllRoute;

				private string erAttachmentName;

				private string erAttachmentId;

				private string regionId;

				private string instanceType;

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

				public string Message
				{
					get
					{
						return message;
					}
					set	
					{
						message = value;
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

				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public string ErId
				{
					get
					{
						return erId;
					}
					set	
					{
						erId = value;
					}
				}

				public bool? Across
				{
					get
					{
						return across;
					}
					set	
					{
						across = value;
					}
				}

				public string InstanceName
				{
					get
					{
						return instanceName;
					}
					set	
					{
						instanceName = value;
					}
				}

				public string TenantId
				{
					get
					{
						return tenantId;
					}
					set	
					{
						tenantId = value;
					}
				}

				public string ResourceTenantId
				{
					get
					{
						return resourceTenantId;
					}
					set	
					{
						resourceTenantId = value;
					}
				}

				public bool? AutoReceiveAllRoute
				{
					get
					{
						return autoReceiveAllRoute;
					}
					set	
					{
						autoReceiveAllRoute = value;
					}
				}

				public string ErAttachmentName
				{
					get
					{
						return erAttachmentName;
					}
					set	
					{
						erAttachmentName = value;
					}
				}

				public string ErAttachmentId
				{
					get
					{
						return erAttachmentId;
					}
					set	
					{
						erAttachmentId = value;
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

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}
			}

			public class GetEr_ErRouteMap
			{

				private string status;

				private string transmissionInstanceType;

				private string action;

				private string description;

				private string receptionInstanceType;

				private string message;

				private string erRouteMapName;

				private string receptionInstanceId;

				private string resourceGroupId;

				private string createTime;

				private string gmtModified;

				private string erId;

				private string transmissionInstanceName;

				private string destinationCidrBlock;

				private string receptionInstanceOwner;

				private string tenantId;

				private string receptionInstanceName;

				private string erRouteMapId;

				private string transmissionInstanceOwner;

				private string regionId;

				private string transmissionInstanceId;

				private int? routeMapNum;

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

				public string TransmissionInstanceType
				{
					get
					{
						return transmissionInstanceType;
					}
					set	
					{
						transmissionInstanceType = value;
					}
				}

				public string Action
				{
					get
					{
						return action;
					}
					set	
					{
						action = value;
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

				public string ReceptionInstanceType
				{
					get
					{
						return receptionInstanceType;
					}
					set	
					{
						receptionInstanceType = value;
					}
				}

				public string Message
				{
					get
					{
						return message;
					}
					set	
					{
						message = value;
					}
				}

				public string ErRouteMapName
				{
					get
					{
						return erRouteMapName;
					}
					set	
					{
						erRouteMapName = value;
					}
				}

				public string ReceptionInstanceId
				{
					get
					{
						return receptionInstanceId;
					}
					set	
					{
						receptionInstanceId = value;
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

				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public string ErId
				{
					get
					{
						return erId;
					}
					set	
					{
						erId = value;
					}
				}

				public string TransmissionInstanceName
				{
					get
					{
						return transmissionInstanceName;
					}
					set	
					{
						transmissionInstanceName = value;
					}
				}

				public string DestinationCidrBlock
				{
					get
					{
						return destinationCidrBlock;
					}
					set	
					{
						destinationCidrBlock = value;
					}
				}

				public string ReceptionInstanceOwner
				{
					get
					{
						return receptionInstanceOwner;
					}
					set	
					{
						receptionInstanceOwner = value;
					}
				}

				public string TenantId
				{
					get
					{
						return tenantId;
					}
					set	
					{
						tenantId = value;
					}
				}

				public string ReceptionInstanceName
				{
					get
					{
						return receptionInstanceName;
					}
					set	
					{
						receptionInstanceName = value;
					}
				}

				public string ErRouteMapId
				{
					get
					{
						return erRouteMapId;
					}
					set	
					{
						erRouteMapId = value;
					}
				}

				public string TransmissionInstanceOwner
				{
					get
					{
						return transmissionInstanceOwner;
					}
					set	
					{
						transmissionInstanceOwner = value;
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

				public string TransmissionInstanceId
				{
					get
					{
						return transmissionInstanceId;
					}
					set	
					{
						transmissionInstanceId = value;
					}
				}

				public int? RouteMapNum
				{
					get
					{
						return routeMapNum;
					}
					set	
					{
						routeMapNum = value;
					}
				}
			}

			public class GetEr_ErRouteEntry
			{

				private string status;

				private string nextHopType;

				private string tenantId;

				private string resourceTenantId;

				private string routeType;

				private string erRouteEntryId;

				private string resourceGroupId;

				private string nextHopId;

				private string gmtModified;

				private string erId;

				private string regionId;

				private string destinationCidrBlock;

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

				public string NextHopType
				{
					get
					{
						return nextHopType;
					}
					set	
					{
						nextHopType = value;
					}
				}

				public string TenantId
				{
					get
					{
						return tenantId;
					}
					set	
					{
						tenantId = value;
					}
				}

				public string ResourceTenantId
				{
					get
					{
						return resourceTenantId;
					}
					set	
					{
						resourceTenantId = value;
					}
				}

				public string RouteType
				{
					get
					{
						return routeType;
					}
					set	
					{
						routeType = value;
					}
				}

				public string ErRouteEntryId
				{
					get
					{
						return erRouteEntryId;
					}
					set	
					{
						erRouteEntryId = value;
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

				public string NextHopId
				{
					get
					{
						return nextHopId;
					}
					set	
					{
						nextHopId = value;
					}
				}

				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public string ErId
				{
					get
					{
						return erId;
					}
					set	
					{
						erId = value;
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

				public string DestinationCidrBlock
				{
					get
					{
						return destinationCidrBlock;
					}
					set	
					{
						destinationCidrBlock = value;
					}
				}
			}

			public class GetEr_Tag
			{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}
		}
	}
}
