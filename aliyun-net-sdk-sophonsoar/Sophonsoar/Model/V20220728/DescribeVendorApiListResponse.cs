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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class DescribeVendorApiListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeVendorApiList_Data> apiList;

		private DescribeVendorApiList_Page page;

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

		public List<DescribeVendorApiList_Data> ApiList
		{
			get
			{
				return apiList;
			}
			set	
			{
				apiList = value;
			}
		}

		public DescribeVendorApiList_Page Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
			}
		}

		public class DescribeVendorApiList_Data
		{

			private string vendorCode;

			private string productCode;

			private string productName;

			private string parameter;

			private string productDomain;

			private string protocol;

			private string method;

			private string apiName;

			private bool? needPageInfo;

			private string pageInfo;

			private string apiVersion;

			private bool? needAdvanceConfig;

			private string advanceConfig;

			public string VendorCode
			{
				get
				{
					return vendorCode;
				}
				set	
				{
					vendorCode = value;
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

			public string Parameter
			{
				get
				{
					return parameter;
				}
				set	
				{
					parameter = value;
				}
			}

			public string ProductDomain
			{
				get
				{
					return productDomain;
				}
				set	
				{
					productDomain = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public string Method
			{
				get
				{
					return method;
				}
				set	
				{
					method = value;
				}
			}

			public string ApiName
			{
				get
				{
					return apiName;
				}
				set	
				{
					apiName = value;
				}
			}

			public bool? NeedPageInfo
			{
				get
				{
					return needPageInfo;
				}
				set	
				{
					needPageInfo = value;
				}
			}

			public string PageInfo
			{
				get
				{
					return pageInfo;
				}
				set	
				{
					pageInfo = value;
				}
			}

			public string ApiVersion
			{
				get
				{
					return apiVersion;
				}
				set	
				{
					apiVersion = value;
				}
			}

			public bool? NeedAdvanceConfig
			{
				get
				{
					return needAdvanceConfig;
				}
				set	
				{
					needAdvanceConfig = value;
				}
			}

			public string AdvanceConfig
			{
				get
				{
					return advanceConfig;
				}
				set	
				{
					advanceConfig = value;
				}
			}
		}

		public class DescribeVendorApiList_Page
		{

			private long? totalCount;

			private long? pageNumber;

			private int? pageSize;

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

			public long? PageNumber
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
		}
	}
}
