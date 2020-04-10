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

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
	public class ListGoodsStylesResponse : AcsResponse
	{

		private int? pageSize;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private int? totalCount;

		private List<ListGoodsStyles_GoodsStyleModel> goodsStyles;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
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

		public List<ListGoodsStyles_GoodsStyleModel> GoodsStyles
		{
			get
			{
				return goodsStyles;
			}
			set	
			{
				goodsStyles = value;
			}
		}

		public class ListGoodsStyles_GoodsStyleModel
		{

			private string sizeGroupName;

			private int? disable;

			private string name;

			private string sizeGroupCode;

			private float? retailPrice;

			private string sizeGroupId;

			private string code;

			private string updateDate;

			private int? useSkuColor;

			private string description;

			private float? currentPrice;

			private int? useSkuSize;

			private string createDate;

			private string styleId;

			public string SizeGroupName
			{
				get
				{
					return sizeGroupName;
				}
				set	
				{
					sizeGroupName = value;
				}
			}

			public int? Disable
			{
				get
				{
					return disable;
				}
				set	
				{
					disable = value;
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

			public string SizeGroupCode
			{
				get
				{
					return sizeGroupCode;
				}
				set	
				{
					sizeGroupCode = value;
				}
			}

			public float? RetailPrice
			{
				get
				{
					return retailPrice;
				}
				set	
				{
					retailPrice = value;
				}
			}

			public string SizeGroupId
			{
				get
				{
					return sizeGroupId;
				}
				set	
				{
					sizeGroupId = value;
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

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

			public int? UseSkuColor
			{
				get
				{
					return useSkuColor;
				}
				set	
				{
					useSkuColor = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public float? CurrentPrice
			{
				get
				{
					return currentPrice;
				}
				set	
				{
					currentPrice = value;
				}
			}

			public int? UseSkuSize
			{
				get
				{
					return useSkuSize;
				}
				set	
				{
					useSkuSize = value;
				}
			}

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}

			public string StyleId
			{
				get
				{
					return styleId;
				}
				set	
				{
					styleId = value;
				}
			}
		}
	}
}
