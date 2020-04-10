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
	public class ListBarcodesResponse : AcsResponse
	{

		private int? pageSize;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private int? totalCount;

		private List<ListBarcodes_BarcodeModel> barcodes;

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

		public List<ListBarcodes_BarcodeModel> Barcodes
		{
			get
			{
				return barcodes;
			}
			set	
			{
				barcodes = value;
			}
		}

		public class ListBarcodes_BarcodeModel
		{

			private int? disable;

			private string styleId;

			private string sizeName;

			private float? retailPrice;

			private string sizeCode;

			private string colorCode;

			private string name;

			private string colorId;

			private string code;

			private string updateDate;

			private string sizeId;

			private string colorName;

			private string createDate;

			private string styleCode;

			private string styleName;

			private string description;

			private float? currentPrice;

			private string barcodeId;

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

			public string SizeName
			{
				get
				{
					return sizeName;
				}
				set	
				{
					sizeName = value;
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

			public string SizeCode
			{
				get
				{
					return sizeCode;
				}
				set	
				{
					sizeCode = value;
				}
			}

			public string ColorCode
			{
				get
				{
					return colorCode;
				}
				set	
				{
					colorCode = value;
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

			public string ColorId
			{
				get
				{
					return colorId;
				}
				set	
				{
					colorId = value;
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

			public string SizeId
			{
				get
				{
					return sizeId;
				}
				set	
				{
					sizeId = value;
				}
			}

			public string ColorName
			{
				get
				{
					return colorName;
				}
				set	
				{
					colorName = value;
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

			public string StyleCode
			{
				get
				{
					return styleCode;
				}
				set	
				{
					styleCode = value;
				}
			}

			public string StyleName
			{
				get
				{
					return styleName;
				}
				set	
				{
					styleName = value;
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

			public string BarcodeId
			{
				get
				{
					return barcodeId;
				}
				set	
				{
					barcodeId = value;
				}
			}
		}
	}
}
