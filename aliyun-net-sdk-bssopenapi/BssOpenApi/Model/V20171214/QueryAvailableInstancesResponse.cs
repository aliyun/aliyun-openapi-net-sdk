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
	public class QueryAvailableInstancesResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryAvailableInstances_Data data;

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
		public QueryAvailableInstances_Data Data
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

		public class QueryAvailableInstances_Data
		{

			private int? pageNum;

			private int? pageSize;

			private int? totalCount;

			private List<QueryAvailableInstances_Instance> instanceList;

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

			[JsonProperty(PropertyName = "InstanceList")]
			public List<QueryAvailableInstances_Instance> InstanceList
			{
				get
				{
					return instanceList;
				}
				set	
				{
					instanceList = value;
				}
			}

			public class QueryAvailableInstances_Instance
			{

				private string subStatus;

				private string status;

				private string expectedReleaseTime;

				private string renewStatus;

				private string createTime;

				private long? sellerId;

				private string instanceID;

				private string seller;

				private string stopTime;

				private string renewalDurationUnit;

				private string subscriptionType;

				private long? ownerId;

				private string endTime;

				private string productType;

				private string region;

				private string releaseTime;

				private int? renewalDuration;

				private string productCode;

				[JsonProperty(PropertyName = "SubStatus")]
				public string SubStatus
				{
					get
					{
						return subStatus;
					}
					set	
					{
						subStatus = value;
					}
				}

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

				[JsonProperty(PropertyName = "ExpectedReleaseTime")]
				public string ExpectedReleaseTime
				{
					get
					{
						return expectedReleaseTime;
					}
					set	
					{
						expectedReleaseTime = value;
					}
				}

				[JsonProperty(PropertyName = "RenewStatus")]
				public string RenewStatus
				{
					get
					{
						return renewStatus;
					}
					set	
					{
						renewStatus = value;
					}
				}

				[JsonProperty(PropertyName = "CreateTime")]
				public string CreateTime
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

				[JsonProperty(PropertyName = "SellerId")]
				public long? SellerId
				{
					get
					{
						return sellerId;
					}
					set	
					{
						sellerId = value;
					}
				}

				[JsonProperty(PropertyName = "InstanceID")]
				public string InstanceID
				{
					get
					{
						return instanceID;
					}
					set	
					{
						instanceID = value;
					}
				}

				[JsonProperty(PropertyName = "Seller")]
				public string Seller
				{
					get
					{
						return seller;
					}
					set	
					{
						seller = value;
					}
				}

				[JsonProperty(PropertyName = "StopTime")]
				public string StopTime
				{
					get
					{
						return stopTime;
					}
					set	
					{
						stopTime = value;
					}
				}

				[JsonProperty(PropertyName = "RenewalDurationUnit")]
				public string RenewalDurationUnit
				{
					get
					{
						return renewalDurationUnit;
					}
					set	
					{
						renewalDurationUnit = value;
					}
				}

				[JsonProperty(PropertyName = "SubscriptionType")]
				public string SubscriptionType
				{
					get
					{
						return subscriptionType;
					}
					set	
					{
						subscriptionType = value;
					}
				}

				[JsonProperty(PropertyName = "OwnerId")]
				public long? OwnerId
				{
					get
					{
						return ownerId;
					}
					set	
					{
						ownerId = value;
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

				[JsonProperty(PropertyName = "ProductType")]
				public string ProductType
				{
					get
					{
						return productType;
					}
					set	
					{
						productType = value;
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

				[JsonProperty(PropertyName = "ReleaseTime")]
				public string ReleaseTime
				{
					get
					{
						return releaseTime;
					}
					set	
					{
						releaseTime = value;
					}
				}

				[JsonProperty(PropertyName = "RenewalDuration")]
				public int? RenewalDuration
				{
					get
					{
						return renewalDuration;
					}
					set	
					{
						renewalDuration = value;
					}
				}

				[JsonProperty(PropertyName = "ProductCode")]
				public string ProductCode
				{
					get
					{
						return productCode;
					}
					set	
					{
						productCode = value;
					}
				}
			}
		}
	}
}
