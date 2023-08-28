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

			private List<GetEr_ErAttachment> erAttachments;

			private List<GetEr_ErRouteMap> erRouteMaps;

			private List<GetEr_ErRouteEntry> erRouteEntrys;

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

			public class GetEr_ErAttachment
			{

				private string createTime;

				private string gmtModified;

				private string message;

				private string status;

				private string regionId;

				private string tenantId;

				private string erAttachmentName;

				private string erAttachmentId;

				private string erId;

				private string instanceType;

				private string instanceId;

				private string instanceName;

				private bool? autoReceiveAllRoute;

				private bool? across;

				private string resourceTenantId;

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
			}

			public class GetEr_ErRouteMap
			{

				private string regionId;

				private string tenantId;

				private string createTime;

				private string gmtModified;

				private string message;

				private string status;

				private string erRouteMapName;

				private string erRouteMapId;

				private string erId;

				private int? routeMapNum;

				private string description;

				private string destinationCidrBlock;

				private string transmissionInstanceName;

				private string transmissionInstanceId;

				private string transmissionInstanceType;

				private string receptionInstanceName;

				private string receptionInstanceId;

				private string receptionInstanceType;

				private string action;

				private string transmissionInstanceOwner;

				private string receptionInstanceOwner;

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
			}

			public class GetEr_ErRouteEntry
			{

				private string erId;

				private string tenantId;

				private string resourceTenantId;

				private string regionId;

				private string erRouteEntryId;

				private string destinationCidrBlock;

				private string nextHopType;

				private string nextHopId;

				private string routeType;

				private string status;

				private string gmtModified;

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
			}
		}
	}
}
