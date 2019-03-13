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

namespace Aliyun.Acs.jarvis.Model.V20180206
{
	public class DescribeCdnSubscriptionResponse : AcsResponse
	{

		private string requestId;

		private string module;

		private List<DescribeCdnSubscription_Data> dataList;

		private DescribeCdnSubscription_PageInfo pageInfo;

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

		public string Module
		{
			get
			{
				return module;
			}
			set	
			{
				module = value;
			}
		}

		public List<DescribeCdnSubscription_Data> DataList
		{
			get
			{
				return dataList;
			}
			set	
			{
				dataList = value;
			}
		}

		public DescribeCdnSubscription_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeCdnSubscription_Data
		{

			private int? vendorAliuid;

			private string vendorName;

			private string safetyFactor;

			private int? subscriptionState;

			private string gmtCreate;

			private string updateTime;

			public int? VendorAliuid
			{
				get
				{
					return vendorAliuid;
				}
				set	
				{
					vendorAliuid = value;
				}
			}

			public string VendorName
			{
				get
				{
					return vendorName;
				}
				set	
				{
					vendorName = value;
				}
			}

			public string SafetyFactor
			{
				get
				{
					return safetyFactor;
				}
				set	
				{
					safetyFactor = value;
				}
			}

			public int? SubscriptionState
			{
				get
				{
					return subscriptionState;
				}
				set	
				{
					subscriptionState = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}
		}

		public class DescribeCdnSubscription_PageInfo
		{

			private int? total;

			private int? pageSize;

			private int? currentPage;

			public int? Total
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

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}
		}
	}
}
