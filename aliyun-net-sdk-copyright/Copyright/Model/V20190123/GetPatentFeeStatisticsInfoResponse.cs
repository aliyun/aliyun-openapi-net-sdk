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

namespace Aliyun.Acs.Copyright.Model.V20190123
{
	public class GetPatentFeeStatisticsInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private GetPatentFeeStatisticsInfo_Data data;

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

		public GetPatentFeeStatisticsInfo_Data Data
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

		public class GetPatentFeeStatisticsInfo_Data
		{

			private float? discountPrice;

			private int? famingCount;

			private int? freeCount;

			private int? shiyongCount;

			private int? total;

			private float? totalPrice;

			private int? usedCount;

			private string userType;

			private int? waiguanCount;

			private List<GetPatentFeeStatisticsInfo_AgeInfoItem> ageInfo;

			public float? DiscountPrice
			{
				get
				{
					return discountPrice;
				}
				set	
				{
					discountPrice = value;
				}
			}

			public int? FamingCount
			{
				get
				{
					return famingCount;
				}
				set	
				{
					famingCount = value;
				}
			}

			public int? FreeCount
			{
				get
				{
					return freeCount;
				}
				set	
				{
					freeCount = value;
				}
			}

			public int? ShiyongCount
			{
				get
				{
					return shiyongCount;
				}
				set	
				{
					shiyongCount = value;
				}
			}

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

			public float? TotalPrice
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

			public int? UsedCount
			{
				get
				{
					return usedCount;
				}
				set	
				{
					usedCount = value;
				}
			}

			public string UserType
			{
				get
				{
					return userType;
				}
				set	
				{
					userType = value;
				}
			}

			public int? WaiguanCount
			{
				get
				{
					return waiguanCount;
				}
				set	
				{
					waiguanCount = value;
				}
			}

			public List<GetPatentFeeStatisticsInfo_AgeInfoItem> AgeInfo
			{
				get
				{
					return ageInfo;
				}
				set	
				{
					ageInfo = value;
				}
			}

			public class GetPatentFeeStatisticsInfo_AgeInfoItem
			{

				private string age;

				private int? count;

				private float? discountPrice;

				private float? salePrice;

				private string type;

				public string Age
				{
					get
					{
						return age;
					}
					set	
					{
						age = value;
					}
				}

				public int? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public float? DiscountPrice
				{
					get
					{
						return discountPrice;
					}
					set	
					{
						discountPrice = value;
					}
				}

				public float? SalePrice
				{
					get
					{
						return salePrice;
					}
					set	
					{
						salePrice = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}
			}
		}
	}
}
