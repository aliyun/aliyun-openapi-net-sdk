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
	public class DescribeResourceUsageDetailResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private DescribeResourceUsageDetail_Data data;

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

		public DescribeResourceUsageDetail_Data Data
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

		public class DescribeResourceUsageDetail_Data
		{

			private string nextToken;

			private int? totalCount;

			private int? maxResults;

			private List<DescribeResourceUsageDetail_Item> items;

			public string NextToken
			{
				get
				{
					return nextToken;
				}
				set	
				{
					nextToken = value;
				}
			}

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

			public int? MaxResults
			{
				get
				{
					return maxResults;
				}
				set	
				{
					maxResults = value;
				}
			}

			public List<DescribeResourceUsageDetail_Item> Items
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

			public class DescribeResourceUsageDetail_Item
			{

				private string status;

				private float? usagePercentage;

				private string resourceInstanceId;

				private float? totalQuantity;

				private string reservationCost;

				private string regionNo;

				private string userId;

				private string statusName;

				private string capacityUnit;

				private string potentialSavedCost;

				private string currency;

				private string zoneName;

				private string instanceSpec;

				private string endTime;

				private string postpaidCost;

				private string imageType;

				private string startTime;

				private string region;

				private float? deductQuantity;

				private string savedCost;

				private string zone;

				private string userName;

				private long? quantity;

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

				public float? UsagePercentage
				{
					get
					{
						return usagePercentage;
					}
					set	
					{
						usagePercentage = value;
					}
				}

				public string ResourceInstanceId
				{
					get
					{
						return resourceInstanceId;
					}
					set	
					{
						resourceInstanceId = value;
					}
				}

				public float? TotalQuantity
				{
					get
					{
						return totalQuantity;
					}
					set	
					{
						totalQuantity = value;
					}
				}

				public string ReservationCost
				{
					get
					{
						return reservationCost;
					}
					set	
					{
						reservationCost = value;
					}
				}

				public string RegionNo
				{
					get
					{
						return regionNo;
					}
					set	
					{
						regionNo = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public string StatusName
				{
					get
					{
						return statusName;
					}
					set	
					{
						statusName = value;
					}
				}

				public string CapacityUnit
				{
					get
					{
						return capacityUnit;
					}
					set	
					{
						capacityUnit = value;
					}
				}

				public string PotentialSavedCost
				{
					get
					{
						return potentialSavedCost;
					}
					set	
					{
						potentialSavedCost = value;
					}
				}

				public string Currency
				{
					get
					{
						return currency;
					}
					set	
					{
						currency = value;
					}
				}

				public string ZoneName
				{
					get
					{
						return zoneName;
					}
					set	
					{
						zoneName = value;
					}
				}

				public string InstanceSpec
				{
					get
					{
						return instanceSpec;
					}
					set	
					{
						instanceSpec = value;
					}
				}

				public string EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				public string PostpaidCost
				{
					get
					{
						return postpaidCost;
					}
					set	
					{
						postpaidCost = value;
					}
				}

				public string ImageType
				{
					get
					{
						return imageType;
					}
					set	
					{
						imageType = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public float? DeductQuantity
				{
					get
					{
						return deductQuantity;
					}
					set	
					{
						deductQuantity = value;
					}
				}

				public string SavedCost
				{
					get
					{
						return savedCost;
					}
					set	
					{
						savedCost = value;
					}
				}

				public string Zone
				{
					get
					{
						return zone;
					}
					set	
					{
						zone = value;
					}
				}

				public string UserName
				{
					get
					{
						return userName;
					}
					set	
					{
						userName = value;
					}
				}

				public long? Quantity
				{
					get
					{
						return quantity;
					}
					set	
					{
						quantity = value;
					}
				}
			}
		}
	}
}
