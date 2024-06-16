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

namespace Aliyun.Acs.idaas_doraemon.Model.V20210520
{
	public class ListCostUnitOrdersResponse : AcsResponse
	{

		private string requestId;

		private long? totalPages;

		private long? totalElements;

		private long? pageSize;

		private List<ListCostUnitOrders_Item> items;

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

		public long? TotalPages
		{
			get
			{
				return totalPages;
			}
			set	
			{
				totalPages = value;
			}
		}

		public long? TotalElements
		{
			get
			{
				return totalElements;
			}
			set	
			{
				totalElements = value;
			}
		}

		public long? PageSize
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

		public List<ListCostUnitOrders_Item> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class ListCostUnitOrders_Item
		{

			private string aliOrderCode;

			private string aliOrderInstanceId;

			private long? totalCostUnit;

			private long? usedCostUnit;

			private string orderStatus;

			private long? createTime;

			private long? expiredTime;

			private long? refundTime;

			private bool? exhausted;

			public string AliOrderCode
			{
				get
				{
					return aliOrderCode;
				}
				set	
				{
					aliOrderCode = value;
				}
			}

			public string AliOrderInstanceId
			{
				get
				{
					return aliOrderInstanceId;
				}
				set	
				{
					aliOrderInstanceId = value;
				}
			}

			public long? TotalCostUnit
			{
				get
				{
					return totalCostUnit;
				}
				set	
				{
					totalCostUnit = value;
				}
			}

			public long? UsedCostUnit
			{
				get
				{
					return usedCostUnit;
				}
				set	
				{
					usedCostUnit = value;
				}
			}

			public string OrderStatus
			{
				get
				{
					return orderStatus;
				}
				set	
				{
					orderStatus = value;
				}
			}

			public long? CreateTime
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

			public long? ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			public long? RefundTime
			{
				get
				{
					return refundTime;
				}
				set	
				{
					refundTime = value;
				}
			}

			public bool? Exhausted
			{
				get
				{
					return exhausted;
				}
				set	
				{
					exhausted = value;
				}
			}
		}
	}
}
