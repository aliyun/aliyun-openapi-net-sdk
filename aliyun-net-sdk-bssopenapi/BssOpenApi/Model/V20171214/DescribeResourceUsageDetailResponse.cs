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

			[JsonProperty(PropertyName = "NextToken")]
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

			[JsonProperty(PropertyName = "MaxResults")]
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

			[JsonProperty(PropertyName = "Items")]
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

				[JsonProperty(PropertyName = "Status")]
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

				[JsonProperty(PropertyName = "UsagePercentage")]
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

				[JsonProperty(PropertyName = "ResourceInstanceId")]
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

				[JsonProperty(PropertyName = "TotalQuantity")]
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

				[JsonProperty(PropertyName = "ReservationCost")]
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

				[JsonProperty(PropertyName = "RegionNo")]
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

				[JsonProperty(PropertyName = "UserId")]
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

				[JsonProperty(PropertyName = "StatusName")]
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

				[JsonProperty(PropertyName = "CapacityUnit")]
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

				[JsonProperty(PropertyName = "PotentialSavedCost")]
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

				[JsonProperty(PropertyName = "Currency")]
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

				[JsonProperty(PropertyName = "ZoneName")]
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

				[JsonProperty(PropertyName = "InstanceSpec")]
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

				[JsonProperty(PropertyName = "EndTime")]
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

				[JsonProperty(PropertyName = "PostpaidCost")]
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

				[JsonProperty(PropertyName = "ImageType")]
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

				[JsonProperty(PropertyName = "StartTime")]
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

				[JsonProperty(PropertyName = "Region")]
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

				[JsonProperty(PropertyName = "DeductQuantity")]
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

				[JsonProperty(PropertyName = "SavedCost")]
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

				[JsonProperty(PropertyName = "Zone")]
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

				[JsonProperty(PropertyName = "UserName")]
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

				[JsonProperty(PropertyName = "Quantity")]
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
