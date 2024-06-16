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
	public class GetVpdResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetVpd_Content content;

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

		public GetVpd_Content Content
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

		public class GetVpd_Content
		{

			private string regionId;

			private string vpdId;

			private string vpdName;

			private string cidr;

			private string serviceCidr;

			private string status;

			private string message;

			private int? ncCount;

			private int? networkInterfaceCount;

			private long? subnetCount;

			private string createTime;

			private string gmtModified;

			private string tenantId;

			private bool? attachErStatus;

			private string resourceGroupId;

			private int? quota;

			private long? privateIpCount;

			private List<GetVpd_ErInfo> erInfos;

			private List<GetVpd_Tag> tags;

			private List<string> secondaryCidrBlocks;

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

			public string VpdId
			{
				get
				{
					return vpdId;
				}
				set	
				{
					vpdId = value;
				}
			}

			public string VpdName
			{
				get
				{
					return vpdName;
				}
				set	
				{
					vpdName = value;
				}
			}

			public string Cidr
			{
				get
				{
					return cidr;
				}
				set	
				{
					cidr = value;
				}
			}

			public string ServiceCidr
			{
				get
				{
					return serviceCidr;
				}
				set	
				{
					serviceCidr = value;
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

			public int? NcCount
			{
				get
				{
					return ncCount;
				}
				set	
				{
					ncCount = value;
				}
			}

			public int? NetworkInterfaceCount
			{
				get
				{
					return networkInterfaceCount;
				}
				set	
				{
					networkInterfaceCount = value;
				}
			}

			public long? SubnetCount
			{
				get
				{
					return subnetCount;
				}
				set	
				{
					subnetCount = value;
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

			public bool? AttachErStatus
			{
				get
				{
					return attachErStatus;
				}
				set	
				{
					attachErStatus = value;
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

			public int? Quota
			{
				get
				{
					return quota;
				}
				set	
				{
					quota = value;
				}
			}

			public long? PrivateIpCount
			{
				get
				{
					return privateIpCount;
				}
				set	
				{
					privateIpCount = value;
				}
			}

			public List<GetVpd_ErInfo> ErInfos
			{
				get
				{
					return erInfos;
				}
				set	
				{
					erInfos = value;
				}
			}

			public List<GetVpd_Tag> Tags
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

			public List<string> SecondaryCidrBlocks
			{
				get
				{
					return secondaryCidrBlocks;
				}
				set	
				{
					secondaryCidrBlocks = value;
				}
			}

			public class GetVpd_ErInfo
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

				private long? connections;

				private long? routeMaps;

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

				public long? Connections
				{
					get
					{
						return connections;
					}
					set	
					{
						connections = value;
					}
				}

				public long? RouteMaps
				{
					get
					{
						return routeMaps;
					}
					set	
					{
						routeMaps = value;
					}
				}
			}

			public class GetVpd_Tag
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
