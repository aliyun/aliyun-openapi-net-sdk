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
	public class ListOrderConsumeStatisticRecordsResponse : AcsResponse
	{

		private string requestId;

		private long? totalPages;

		private long? totalElements;

		private long? pageSize;

		private List<ListOrderConsumeStatisticRecords_Item> items;

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

		public List<ListOrderConsumeStatisticRecords_Item> Items
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

		public class ListOrderConsumeStatisticRecords_Item
		{

			private string aliOrderCode;

			private long? statisticTime;

			private string applicationExternalId;

			private string serviceCode;

			private long? unitPrice;

			private long? chargedCount;

			private long? totalPrice;

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

			public long? StatisticTime
			{
				get
				{
					return statisticTime;
				}
				set	
				{
					statisticTime = value;
				}
			}

			public string ApplicationExternalId
			{
				get
				{
					return applicationExternalId;
				}
				set	
				{
					applicationExternalId = value;
				}
			}

			public string ServiceCode
			{
				get
				{
					return serviceCode;
				}
				set	
				{
					serviceCode = value;
				}
			}

			public long? UnitPrice
			{
				get
				{
					return unitPrice;
				}
				set	
				{
					unitPrice = value;
				}
			}

			public long? ChargedCount
			{
				get
				{
					return chargedCount;
				}
				set	
				{
					chargedCount = value;
				}
			}

			public long? TotalPrice
			{
				get
				{
					return totalPrice;
				}
				set	
				{
					totalPrice = value;
				}
			}
		}
	}
}
