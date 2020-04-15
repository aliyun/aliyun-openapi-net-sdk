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

namespace Aliyun.Acs.Netana.Model.V20181018
{
	public class DescribeNetworkQuotaRequestResultResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeNetworkQuotaRequestResult_QuotaRequest> quotaRequests;

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

		public List<DescribeNetworkQuotaRequestResult_QuotaRequest> QuotaRequests
		{
			get
			{
				return quotaRequests;
			}
			set	
			{
				quotaRequests = value;
			}
		}

		public class DescribeNetworkQuotaRequestResult_QuotaRequest
		{

			private string regionId;

			private string product;

			private string requestId;

			private string resourceType;

			private string quotaPublicityName;

			private string requestReason;

			private string mobilePhone;

			private string email;

			private string requestResult;

			private string requestQuantity;

			private string resultReason;

			private string createTime;

			private string resultQuantity;

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string Product
			{
				get
				{
					return product;
				}
				set	
				{
					product = value;
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

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public string QuotaPublicityName
			{
				get
				{
					return quotaPublicityName;
				}
				set	
				{
					quotaPublicityName = value;
				}
			}

			public string RequestReason
			{
				get
				{
					return requestReason;
				}
				set	
				{
					requestReason = value;
				}
			}

			public string MobilePhone
			{
				get
				{
					return mobilePhone;
				}
				set	
				{
					mobilePhone = value;
				}
			}

			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
				}
			}

			public string RequestResult
			{
				get
				{
					return requestResult;
				}
				set	
				{
					requestResult = value;
				}
			}

			public string RequestQuantity
			{
				get
				{
					return requestQuantity;
				}
				set	
				{
					requestQuantity = value;
				}
			}

			public string ResultReason
			{
				get
				{
					return resultReason;
				}
				set	
				{
					resultReason = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string ResultQuantity
			{
				get
				{
					return resultQuantity;
				}
				set	
				{
					resultQuantity = value;
				}
			}
		}
	}
}
