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

namespace Aliyun.Acs.viapi_oxs_cross.Model.V20200701
{
	public class QuerySDKInstancesResponse : AcsResponse
	{

		private bool? ok;

		private string code;

		private int? httpCode;

		private string errorMessage;

		private string requestId;

		private QuerySDKInstances_Data data;

		public bool? Ok
		{
			get
			{
				return ok;
			}
			set	
			{
				ok = value;
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

		public int? HttpCode
		{
			get
			{
				return httpCode;
			}
			set	
			{
				httpCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public QuerySDKInstances_Data Data
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

		public class QuerySDKInstances_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<QuerySDKInstances_SDKInstance> content;

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

			public List<QuerySDKInstances_SDKInstance> Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public class QuerySDKInstances_SDKInstance
			{

				private string status;

				private string latestBuild;

				private string validFromDate;

				private string validToDate;

				private string userId;

				private string platform;

				private string createdAt;

				private string recipe;

				private string updatedAt;

				private string instanceId;

				private string bundleId;

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

				public string LatestBuild
				{
					get
					{
						return latestBuild;
					}
					set	
					{
						latestBuild = value;
					}
				}

				public string ValidFromDate
				{
					get
					{
						return validFromDate;
					}
					set	
					{
						validFromDate = value;
					}
				}

				public string ValidToDate
				{
					get
					{
						return validToDate;
					}
					set	
					{
						validToDate = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public string Platform
				{
					get
					{
						return platform;
					}
					set	
					{
						platform = value;
					}
				}

				public string CreatedAt
				{
					get
					{
						return createdAt;
					}
					set	
					{
						createdAt = value;
					}
				}

				public string Recipe
				{
					get
					{
						return recipe;
					}
					set	
					{
						recipe = value;
					}
				}

				public string UpdatedAt
				{
					get
					{
						return updatedAt;
					}
					set	
					{
						updatedAt = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public string BundleId
				{
					get
					{
						return bundleId;
					}
					set	
					{
						bundleId = value;
					}
				}
			}
		}
	}
}
