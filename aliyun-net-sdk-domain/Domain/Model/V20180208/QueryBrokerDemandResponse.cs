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

namespace Aliyun.Acs.Domain.Model.V20180208
{
	public class QueryBrokerDemandResponse : AcsResponse
	{

		private int? currentPageNum;

		private int? totalPageNum;

		private int? pageSize;

		private string requestId;

		private int? totalItemNum;

		private List<QueryBrokerDemand_Demand> data;

		public int? CurrentPageNum
		{
			get
			{
				return currentPageNum;
			}
			set	
			{
				currentPageNum = value;
			}
		}

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
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

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public List<QueryBrokerDemand_Demand> Data
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

		public class QueryBrokerDemand_Demand
		{

			private string status;

			private float? demandPrice;

			private string bizId;

			private string bargainSellerMobile;

			private long? publishTime;

			private int? produceType;

			private string demandDomain;

			private string description;

			private string mobile;

			private float? servicePayPrice;

			private float? payPrice;

			private long? payTime;

			private float? bargainSellerPrice;

			private int? orderType;

			private string payDomain;

			private int? auditStatus;

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

			public float? DemandPrice
			{
				get
				{
					return demandPrice;
				}
				set	
				{
					demandPrice = value;
				}
			}

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public string BargainSellerMobile
			{
				get
				{
					return bargainSellerMobile;
				}
				set	
				{
					bargainSellerMobile = value;
				}
			}

			public long? PublishTime
			{
				get
				{
					return publishTime;
				}
				set	
				{
					publishTime = value;
				}
			}

			public int? ProduceType
			{
				get
				{
					return produceType;
				}
				set	
				{
					produceType = value;
				}
			}

			public string DemandDomain
			{
				get
				{
					return demandDomain;
				}
				set	
				{
					demandDomain = value;
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

			public string Mobile
			{
				get
				{
					return mobile;
				}
				set	
				{
					mobile = value;
				}
			}

			public float? ServicePayPrice
			{
				get
				{
					return servicePayPrice;
				}
				set	
				{
					servicePayPrice = value;
				}
			}

			public float? PayPrice
			{
				get
				{
					return payPrice;
				}
				set	
				{
					payPrice = value;
				}
			}

			public long? PayTime
			{
				get
				{
					return payTime;
				}
				set	
				{
					payTime = value;
				}
			}

			public float? BargainSellerPrice
			{
				get
				{
					return bargainSellerPrice;
				}
				set	
				{
					bargainSellerPrice = value;
				}
			}

			public int? OrderType
			{
				get
				{
					return orderType;
				}
				set	
				{
					orderType = value;
				}
			}

			public string PayDomain
			{
				get
				{
					return payDomain;
				}
				set	
				{
					payDomain = value;
				}
			}

			public int? AuditStatus
			{
				get
				{
					return auditStatus;
				}
				set	
				{
					auditStatus = value;
				}
			}
		}
	}
}
