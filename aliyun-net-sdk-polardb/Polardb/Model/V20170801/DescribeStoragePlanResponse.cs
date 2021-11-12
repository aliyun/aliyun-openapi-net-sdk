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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeStoragePlanResponse : AcsResponse
	{

		private string requestId;

		private long? totalRecordCount;

		private long? pageSize;

		private long? pageNumber;

		private List<DescribeStoragePlan_DescribeStoragePlanResponses> items;

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

		public long? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
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

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<DescribeStoragePlan_DescribeStoragePlanResponses> Items
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

		public class DescribeStoragePlan_DescribeStoragePlanResponses
		{

			private string prodCode;

			private string aliUid;

			private string commodityCode;

			private string templateName;

			private string storageType;

			private string status;

			private string startTimes;

			private string endTimes;

			private string purchaseTimes;

			private string instanceId;

			private string initCapacityViewValue;

			private string initCapaCityViewUnit;

			private string periodCapacityViewValue;

			private string periodCapaCityViewUnit;

			private string periodTime;

			public string ProdCode
			{
				get
				{
					return prodCode;
				}
				set	
				{
					prodCode = value;
				}
			}

			public string AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

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

			public string TemplateName
			{
				get
				{
					return templateName;
				}
				set	
				{
					templateName = value;
				}
			}

			public string StorageType
			{
				get
				{
					return storageType;
				}
				set	
				{
					storageType = value;
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

			public string StartTimes
			{
				get
				{
					return startTimes;
				}
				set	
				{
					startTimes = value;
				}
			}

			public string EndTimes
			{
				get
				{
					return endTimes;
				}
				set	
				{
					endTimes = value;
				}
			}

			public string PurchaseTimes
			{
				get
				{
					return purchaseTimes;
				}
				set	
				{
					purchaseTimes = value;
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

			public string InitCapacityViewValue
			{
				get
				{
					return initCapacityViewValue;
				}
				set	
				{
					initCapacityViewValue = value;
				}
			}

			public string InitCapaCityViewUnit
			{
				get
				{
					return initCapaCityViewUnit;
				}
				set	
				{
					initCapaCityViewUnit = value;
				}
			}

			public string PeriodCapacityViewValue
			{
				get
				{
					return periodCapacityViewValue;
				}
				set	
				{
					periodCapacityViewValue = value;
				}
			}

			public string PeriodCapaCityViewUnit
			{
				get
				{
					return periodCapaCityViewUnit;
				}
				set	
				{
					periodCapaCityViewUnit = value;
				}
			}

			public string PeriodTime
			{
				get
				{
					return periodTime;
				}
				set	
				{
					periodTime = value;
				}
			}
		}
	}
}
