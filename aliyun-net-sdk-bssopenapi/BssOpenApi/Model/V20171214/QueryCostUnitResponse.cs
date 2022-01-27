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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryCostUnitResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string code;

		private bool? success;

		private QueryCostUnit_Data data;

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

			private int? totalCount;

			private int? pageSize;

			private int? pageNum;

			private List<QueryCostUnit_CostUnitDtoListItem> costUnitDtoList;

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

				private long? unitId;

				private long? parentUnitId;

				private long? ownerUid;

				private string unitName;

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
			}
		}
	}
}
