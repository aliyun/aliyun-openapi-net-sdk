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
	public class BatchCheckPatentAddResponse : AcsResponse
	{

		private string cacheKey;

		private int? canAddCount;

		private int? existCount;

		private string requestId;

		private bool? success;

		private int? totalCount;

		private List<BatchCheckPatentAdd_ErrorDetailItem> errorDetail;

		private List<BatchCheckPatentAdd_TradeListItem> tradeList;

		public string CacheKey
		{
			get
			{
				return cacheKey;
			}
			set	
			{
				cacheKey = value;
			}
		}

		public int? CanAddCount
		{
			get
			{
				return canAddCount;
			}
			set	
			{
				canAddCount = value;
			}
		}

		public int? ExistCount
		{
			get
			{
				return existCount;
			}
			set	
			{
				existCount = value;
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

		public List<BatchCheckPatentAdd_ErrorDetailItem> ErrorDetail
		{
			get
			{
				return errorDetail;
			}
			set	
			{
				errorDetail = value;
			}
		}

		public List<BatchCheckPatentAdd_TradeListItem> TradeList
		{
			get
			{
				return tradeList;
			}
			set	
			{
				tradeList = value;
			}
		}

		public class BatchCheckPatentAdd_ErrorDetailItem
		{

			private string applyNumber;

			private string message;

			private bool? success;

			public string ApplyNumber
			{
				get
				{
					return applyNumber;
				}
				set	
				{
					applyNumber = value;
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
		}

		public class BatchCheckPatentAdd_TradeListItem
		{

			private string age;

			private string discount;

			private long? existCount;

			private int? needCount;

			private float? needFee;

			private long? totalCount;

			private string type;

			private string overduePenalty;

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

			public string Discount
			{
				get
				{
					return discount;
				}
				set	
				{
					discount = value;
				}
			}

			public long? ExistCount
			{
				get
				{
					return existCount;
				}
				set	
				{
					existCount = value;
				}
			}

			public int? NeedCount
			{
				get
				{
					return needCount;
				}
				set	
				{
					needCount = value;
				}
			}

			public float? NeedFee
			{
				get
				{
					return needFee;
				}
				set	
				{
					needFee = value;
				}
			}

			public long? TotalCount
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

			public string OverduePenalty
			{
				get
				{
					return overduePenalty;
				}
				set	
				{
					overduePenalty = value;
				}
			}
		}
	}
}
