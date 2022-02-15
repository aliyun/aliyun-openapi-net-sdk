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
	public class GetPatentStatisticsDetailListResponse : AcsResponse
	{

		private int? pageNum;

		private int? pageSize;

		private string requestId;

		private bool? success;

		private int? totalItemNum;

		private int? totalPageNum;

		private List<GetPatentStatisticsDetailList_DataItem> data;

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

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
			}
		}

		public List<GetPatentStatisticsDetailList_DataItem> Data
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

		public class GetPatentStatisticsDetailList_DataItem
		{

			private string age;

			private string agency;

			private string applyNumber;

			private string discount;

			private float? discountPrice;

			private string name;

			private string owner;

			private string payEndDate;

			private float? salePrice;

			private string type;

			private int? year;

			private string status;

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

			public string Agency
			{
				get
				{
					return agency;
				}
				set	
				{
					agency = value;
				}
			}

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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public string PayEndDate
			{
				get
				{
					return payEndDate;
				}
				set	
				{
					payEndDate = value;
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

			public int? Year
			{
				get
				{
					return year;
				}
				set	
				{
					year = value;
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
		}
	}
}
