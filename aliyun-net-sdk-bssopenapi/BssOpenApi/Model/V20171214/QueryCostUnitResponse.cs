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
	public class QueryCostUnitResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryCostUnit_Data data;

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
		public QueryCostUnit_Data Data
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

		public class QueryCostUnit_Data
		{

			private int? pageNum;

			private int? pageSize;

			private int? totalCount;

			private List<QueryCostUnit_CostUnitDtoListItem> costUnitDtoList;

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

			[JsonProperty(PropertyName = "CostUnitDtoList")]
			public List<QueryCostUnit_CostUnitDtoListItem> CostUnitDtoList
			{
				get
				{
					return costUnitDtoList;
				}
				set	
				{
					costUnitDtoList = value;
				}
			}

			public class QueryCostUnit_CostUnitDtoListItem
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
		}
	}
}
