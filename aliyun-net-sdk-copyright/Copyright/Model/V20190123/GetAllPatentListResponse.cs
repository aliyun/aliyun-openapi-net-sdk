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
	public class GetAllPatentListResponse : AcsResponse
	{

		private int? pageNum;

		private int? pageSize;

		private string requestId;

		private bool? success;

		private int? totalItemNum;

		private int? totalPageNum;

		private List<GetAllPatentList_DataItem> data;

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

		public List<GetAllPatentList_DataItem> Data
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

		public class GetAllPatentList_DataItem
		{

			private string agency;

			private string applyNumber;

			private string bizId;

			private string name;

			private string owner;

			private int? payStatus;

			private int? soldStatus;

			private string type;

			private int? year;

			private string payEndDate;

			private float? discountPrice;

			private bool? patentDiscard;

			private string patentStatus;

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

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
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

			public int? PayStatus
			{
				get
				{
					return payStatus;
				}
				set	
				{
					payStatus = value;
				}
			}

			public int? SoldStatus
			{
				get
				{
					return soldStatus;
				}
				set	
				{
					soldStatus = value;
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

			public bool? PatentDiscard
			{
				get
				{
					return patentDiscard;
				}
				set	
				{
					patentDiscard = value;
				}
			}

			public string PatentStatus
			{
				get
				{
					return patentStatus;
				}
				set	
				{
					patentStatus = value;
				}
			}
		}
	}
}
