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

namespace Aliyun.Acs.ComputeNest.Model.V20210601
{
	public class ListServiceInstanceResourcesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? maxResults;

		private List<ListServiceInstanceResources_ResourcesItem> resources;

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

		public List<ListServiceInstanceResources_ResourcesItem> Resources
		{
			get
			{
				return resources;
			}
			set	
			{
				resources = value;
			}
		}

		public class ListServiceInstanceResources_ResourcesItem
		{

			private string resourceARN;

			private string payType;

			private string renewStatus;

			private string createTime;

			private string expireTime;

			private int? renewalPeriod;

			private string renewalPeriodUnit;

			private string productType;

			private string productCode;

			private string status;

			public string ResourceARN
			{
				get
				{
					return resourceARN;
				}
				set	
				{
					resourceARN = value;
				}
			}

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public string RenewStatus
			{
				get
				{
					return renewStatus;
				}
				set	
				{
					renewStatus = value;
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

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public int? RenewalPeriod
			{
				get
				{
					return renewalPeriod;
				}
				set	
				{
					renewalPeriod = value;
				}
			}

			public string RenewalPeriodUnit
			{
				get
				{
					return renewalPeriodUnit;
				}
				set	
				{
					renewalPeriodUnit = value;
				}
			}

			public string ProductType
			{
				get
				{
					return productType;
				}
				set	
				{
					productType = value;
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
