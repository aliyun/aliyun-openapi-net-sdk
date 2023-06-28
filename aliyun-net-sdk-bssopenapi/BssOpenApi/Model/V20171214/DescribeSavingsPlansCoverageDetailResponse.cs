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
	public class DescribeSavingsPlansCoverageDetailResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private DescribeSavingsPlansCoverageDetail_Data data;

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
		public DescribeSavingsPlansCoverageDetail_Data Data
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

		public class DescribeSavingsPlansCoverageDetail_Data
		{

			private int? totalCount;

			private string nextToken;

			private List<DescribeSavingsPlansCoverageDetail_Item> items;

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

			[JsonProperty(PropertyName = "Items")]
			public List<DescribeSavingsPlansCoverageDetail_Item> Items
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

			public class DescribeSavingsPlansCoverageDetail_Item
			{

				private long? userId;

				private string instanceId;

				private string currency;

				private string instanceSpec;

				private float? postpaidCost;

				private float? coveragePercentage;

				private string region;

				private float? deductAmount;

				private string startPeriod;

				private float? totalAmount;

				private string userName;

				private string endPeriod;

				[JsonProperty(PropertyName = "UserId")]
				public long? UserId
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

				[JsonProperty(PropertyName = "InstanceId")]
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

				[JsonProperty(PropertyName = "PostpaidCost")]
				public float? PostpaidCost
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

				[JsonProperty(PropertyName = "CoveragePercentage")]
				public float? CoveragePercentage
				{
					get
					{
						return coveragePercentage;
					}
					set	
					{
						coveragePercentage = value;
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

				[JsonProperty(PropertyName = "DeductAmount")]
				public float? DeductAmount
				{
					get
					{
						return deductAmount;
					}
					set	
					{
						deductAmount = value;
					}
				}

				[JsonProperty(PropertyName = "StartPeriod")]
				public string StartPeriod
				{
					get
					{
						return startPeriod;
					}
					set	
					{
						startPeriod = value;
					}
				}

				[JsonProperty(PropertyName = "TotalAmount")]
				public float? TotalAmount
				{
					get
					{
						return totalAmount;
					}
					set	
					{
						totalAmount = value;
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

				[JsonProperty(PropertyName = "EndPeriod")]
				public string EndPeriod
				{
					get
					{
						return endPeriod;
					}
					set	
					{
						endPeriod = value;
					}
				}
			}
		}
	}
}
