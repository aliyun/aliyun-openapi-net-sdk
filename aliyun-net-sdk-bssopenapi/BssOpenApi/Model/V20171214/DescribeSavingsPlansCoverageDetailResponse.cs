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
