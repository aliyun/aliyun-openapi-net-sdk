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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryCostUnitResourceResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryCostUnitResource_Data data;

		[JsonProperty(PropertyName = "Code")]
		public string Code
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public QueryCostUnitResource_Data Data
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

		public class QueryCostUnitResource_Data
		{

			private int? pageNum;

			private int? pageSize;

			private int? totalCount;

			private List<QueryCostUnitResource_ResourceInstanceList> resourceInstanceDtoList;

			private QueryCostUnitResource_CostUnit costUnit;

			private QueryCostUnitResource_CostUnitStatisInfo costUnitStatisInfo;

			[JsonProperty(PropertyName = "PageNum")]
			public int? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
				}
			}

			[JsonProperty(PropertyName = "PageSize")]
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

			[JsonProperty(PropertyName = "TotalCount")]
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

			[JsonProperty(PropertyName = "ResourceInstanceDtoList")]
			public List<QueryCostUnitResource_ResourceInstanceList> ResourceInstanceDtoList
			{
				get
				{
					return resourceInstanceDtoList;
				}
				set	
				{
					resourceInstanceDtoList = value;
				}
			}

			[JsonProperty(PropertyName = "CostUnit")]
			public QueryCostUnitResource_CostUnit CostUnit
			{
				get
				{
					return costUnit;
				}
				set	
				{
					costUnit = value;
				}
			}

			[JsonProperty(PropertyName = "CostUnitStatisInfo")]
			public QueryCostUnitResource_CostUnitStatisInfo CostUnitStatisInfo
			{
				get
				{
					return costUnitStatisInfo;
				}
				set	
				{
					costUnitStatisInfo = value;
				}
			}

			public class QueryCostUnitResource_ResourceInstanceList
			{

				private string commodityCode;

				private string resourceUserName;

				private string commodityName;

				private long? resourceUserId;

				private string apportionName;

				private string apportionCode;

				private string resourceType;

				private string resourceNick;

				private string resourceTag;

				private string resourceId;

				private string resourceGroup;

				private string relatedResources;

				private string resourceStatus;

				[JsonProperty(PropertyName = "CommodityCode")]
				public string CommodityCode
				{
					get
					{
						return commodityCode;
					}
					set	
					{
						commodityCode = value;
					}
				}

				[JsonProperty(PropertyName = "ResourceUserName")]
				public string ResourceUserName
				{
					get
					{
						return resourceUserName;
					}
					set	
					{
						resourceUserName = value;
					}
				}

				[JsonProperty(PropertyName = "CommodityName")]
				public string CommodityName
				{
					get
					{
						return commodityName;
					}
					set	
					{
						commodityName = value;
					}
				}

				[JsonProperty(PropertyName = "ResourceUserId")]
				public long? ResourceUserId
				{
					get
					{
						return resourceUserId;
					}
					set	
					{
						resourceUserId = value;
					}
				}

				[JsonProperty(PropertyName = "ApportionName")]
				public string ApportionName
				{
					get
					{
						return apportionName;
					}
					set	
					{
						apportionName = value;
					}
				}

				[JsonProperty(PropertyName = "ApportionCode")]
				public string ApportionCode
				{
					get
					{
						return apportionCode;
					}
					set	
					{
						apportionCode = value;
					}
				}

				[JsonProperty(PropertyName = "ResourceType")]
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

				[JsonProperty(PropertyName = "ResourceNick")]
				public string ResourceNick
				{
					get
					{
						return resourceNick;
					}
					set	
					{
						resourceNick = value;
					}
				}

				[JsonProperty(PropertyName = "ResourceTag")]
				public string ResourceTag
				{
					get
					{
						return resourceTag;
					}
					set	
					{
						resourceTag = value;
					}
				}

				[JsonProperty(PropertyName = "ResourceId")]
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

				[JsonProperty(PropertyName = "ResourceGroup")]
				public string ResourceGroup
				{
					get
					{
						return resourceGroup;
					}
					set	
					{
						resourceGroup = value;
					}
				}

				[JsonProperty(PropertyName = "RelatedResources")]
				public string RelatedResources
				{
					get
					{
						return relatedResources;
					}
					set	
					{
						relatedResources = value;
					}
				}

				[JsonProperty(PropertyName = "ResourceStatus")]
				public string ResourceStatus
				{
					get
					{
						return resourceStatus;
					}
					set	
					{
						resourceStatus = value;
					}
				}
			}

			public class QueryCostUnitResource_CostUnit
			{

				private long? parentUnitId;

				private string unitName;

				private long? unitId;

				private long? ownerUid;

				[JsonProperty(PropertyName = "ParentUnitId")]
				public long? ParentUnitId
				{
					get
					{
						return parentUnitId;
					}
					set	
					{
						parentUnitId = value;
					}
				}

				[JsonProperty(PropertyName = "UnitName")]
				public string UnitName
				{
					get
					{
						return unitName;
					}
					set	
					{
						unitName = value;
					}
				}

				[JsonProperty(PropertyName = "UnitId")]
				public long? UnitId
				{
					get
					{
						return unitId;
					}
					set	
					{
						unitId = value;
					}
				}

				[JsonProperty(PropertyName = "OwnerUid")]
				public long? OwnerUid
				{
					get
					{
						return ownerUid;
					}
					set	
					{
						ownerUid = value;
					}
				}
			}

			public class QueryCostUnitResource_CostUnitStatisInfo
			{

				private long? totalResourceCount;

				private long? resourceCount;

				private long? totalUserCount;

				private long? subUnitCount;

				private long? resourceGroupCount;

				private long? totalResourceGroupCount;

				private long? userCount;

				[JsonProperty(PropertyName = "TotalResourceCount")]
				public long? TotalResourceCount
				{
					get
					{
						return totalResourceCount;
					}
					set	
					{
						totalResourceCount = value;
					}
				}

				[JsonProperty(PropertyName = "ResourceCount")]
				public long? ResourceCount
				{
					get
					{
						return resourceCount;
					}
					set	
					{
						resourceCount = value;
					}
				}

				[JsonProperty(PropertyName = "TotalUserCount")]
				public long? TotalUserCount
				{
					get
					{
						return totalUserCount;
					}
					set	
					{
						totalUserCount = value;
					}
				}

				[JsonProperty(PropertyName = "SubUnitCount")]
				public long? SubUnitCount
				{
					get
					{
						return subUnitCount;
					}
					set	
					{
						subUnitCount = value;
					}
				}

				[JsonProperty(PropertyName = "ResourceGroupCount")]
				public long? ResourceGroupCount
				{
					get
					{
						return resourceGroupCount;
					}
					set	
					{
						resourceGroupCount = value;
					}
				}

				[JsonProperty(PropertyName = "TotalResourceGroupCount")]
				public long? TotalResourceGroupCount
				{
					get
					{
						return totalResourceGroupCount;
					}
					set	
					{
						totalResourceGroupCount = value;
					}
				}

				[JsonProperty(PropertyName = "UserCount")]
				public long? UserCount
				{
					get
					{
						return userCount;
					}
					set	
					{
						userCount = value;
					}
				}
			}
		}
	}
}
