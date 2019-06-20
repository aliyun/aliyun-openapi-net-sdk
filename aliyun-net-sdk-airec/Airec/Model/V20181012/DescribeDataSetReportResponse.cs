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

namespace Aliyun.Acs.Airec.Model.V20181012
{
	public class DescribeDataSetReportResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private DescribeDataSetReport_Result result;

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

		public DescribeDataSetReport_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeDataSetReport_Result
		{

			private List<DescribeDataSetReport_DetailItem> detail;

			private DescribeDataSetReport_Overall overall;

			public List<DescribeDataSetReport_DetailItem> Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public DescribeDataSetReport_Overall Overall
			{
				get
				{
					return overall;
				}
				set	
				{
					overall = value;
				}
			}

			public class DescribeDataSetReport_DetailItem
			{

				private long? bizDate;

				private long? pv;

				private long? uv;

				private long? click;

				private float? ctr;

				private float? uvCtr;

				private float? perUvBhv;

				private float? perUvClick;

				private long? clickUser;

				private long? activeItem;

				public long? BizDate
				{
					get
					{
						return bizDate;
					}
					set	
					{
						bizDate = value;
					}
				}

				public long? Pv
				{
					get
					{
						return pv;
					}
					set	
					{
						pv = value;
					}
				}

				public long? Uv
				{
					get
					{
						return uv;
					}
					set	
					{
						uv = value;
					}
				}

				public long? Click
				{
					get
					{
						return click;
					}
					set	
					{
						click = value;
					}
				}

				public float? Ctr
				{
					get
					{
						return ctr;
					}
					set	
					{
						ctr = value;
					}
				}

				public float? UvCtr
				{
					get
					{
						return uvCtr;
					}
					set	
					{
						uvCtr = value;
					}
				}

				public float? PerUvBhv
				{
					get
					{
						return perUvBhv;
					}
					set	
					{
						perUvBhv = value;
					}
				}

				public float? PerUvClick
				{
					get
					{
						return perUvClick;
					}
					set	
					{
						perUvClick = value;
					}
				}

				public long? ClickUser
				{
					get
					{
						return clickUser;
					}
					set	
					{
						clickUser = value;
					}
				}

				public long? ActiveItem
				{
					get
					{
						return activeItem;
					}
					set	
					{
						activeItem = value;
					}
				}
			}

			public class DescribeDataSetReport_Overall
			{

				private int? bhvCount;

				private int? itemItemCount;

				private int? userUserCount;

				private float? itemRepetitiveRate;

				private float? userRepetitiveRate;

				private float? userLegalRate;

				private float? itemLegalRate;

				private float? bhvLegalRate;

				private float? userCompleteRate;

				private float? itemCompleteRate;

				private float? userLoginRate;

				private float? itemLoginRate;

				public int? BhvCount
				{
					get
					{
						return bhvCount;
					}
					set	
					{
						bhvCount = value;
					}
				}

				public int? ItemItemCount
				{
					get
					{
						return itemItemCount;
					}
					set	
					{
						itemItemCount = value;
					}
				}

				public int? UserUserCount
				{
					get
					{
						return userUserCount;
					}
					set	
					{
						userUserCount = value;
					}
				}

				public float? ItemRepetitiveRate
				{
					get
					{
						return itemRepetitiveRate;
					}
					set	
					{
						itemRepetitiveRate = value;
					}
				}

				public float? UserRepetitiveRate
				{
					get
					{
						return userRepetitiveRate;
					}
					set	
					{
						userRepetitiveRate = value;
					}
				}

				public float? UserLegalRate
				{
					get
					{
						return userLegalRate;
					}
					set	
					{
						userLegalRate = value;
					}
				}

				public float? ItemLegalRate
				{
					get
					{
						return itemLegalRate;
					}
					set	
					{
						itemLegalRate = value;
					}
				}

				public float? BhvLegalRate
				{
					get
					{
						return bhvLegalRate;
					}
					set	
					{
						bhvLegalRate = value;
					}
				}

				public float? UserCompleteRate
				{
					get
					{
						return userCompleteRate;
					}
					set	
					{
						userCompleteRate = value;
					}
				}

				public float? ItemCompleteRate
				{
					get
					{
						return itemCompleteRate;
					}
					set	
					{
						itemCompleteRate = value;
					}
				}

				public float? UserLoginRate
				{
					get
					{
						return userLoginRate;
					}
					set	
					{
						userLoginRate = value;
					}
				}

				public float? ItemLoginRate
				{
					get
					{
						return itemLoginRate;
					}
					set	
					{
						itemLoginRate = value;
					}
				}
			}
		}
	}
}
