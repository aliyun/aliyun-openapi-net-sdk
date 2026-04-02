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
	public class ListErsResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private string accessDeniedDetail;

		private ListErs_Content content;

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

		public ListErs_Content Content
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

		public class ListErs_Content
		{

			private long? total;

			private List<ListErs_DataItem> data;

			public long? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public List<ListErs_DataItem> Data
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

			public class ListErs_DataItem
			{

				private string status;

				private long? connections;

				private string description;

				private string message;

				private string resourceGroupId;

				private string createTime;

				private string gmtModified;

				private string erId;

				private long? routeMaps;

				private string erName;

				private string tenantId;

				private string regionId;

				private string masterZoneId;

				private List<ListErs_Tag> tags;

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

				public List<ListErs_Tag> Tags
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

				public class ListErs_Tag
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
}
