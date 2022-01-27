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

namespace Aliyun.Acs.quotas.Model.V20200510
{
	public class ListProductsResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private List<ListProducts_ProductInfos> productInfo;

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

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public List<ListProducts_ProductInfos> ProductInfo
		{
			get
			{
				return productInfo;
			}
			set	
			{
				productInfo = value;
			}
		}

		public class ListProducts_ProductInfos
		{

			private string secondCategoryNameEn;

			private bool? _dynamic;

			private string commonQuotaSupport;

			private string productName;

			private string productCode;

			private string secondCategoryName;

			private string flowControlSupport;

			private long? secondCategoryId;

			private string productNameEn;

			public string SecondCategoryNameEn
			{
				get
				{
					return secondCategoryNameEn;
				}
				set	
				{
					secondCategoryNameEn = value;
				}
			}

			public bool? _Dynamic
			{
				get
				{
					return _dynamic;
				}
				set	
				{
					_dynamic = value;
				}
			}

			public string CommonQuotaSupport
			{
				get
				{
					return commonQuotaSupport;
				}
				set	
				{
					commonQuotaSupport = value;
				}
			}

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}

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

			public string SecondCategoryName
			{
				get
				{
					return secondCategoryName;
				}
				set	
				{
					secondCategoryName = value;
				}
			}

			public string FlowControlSupport
			{
				get
				{
					return flowControlSupport;
				}
				set	
				{
					flowControlSupport = value;
				}
			}

			public long? SecondCategoryId
			{
				get
				{
					return secondCategoryId;
				}
				set	
				{
					secondCategoryId = value;
				}
			}

			public string ProductNameEn
			{
				get
				{
					return productNameEn;
				}
				set	
				{
					productNameEn = value;
				}
			}
		}
	}
}
