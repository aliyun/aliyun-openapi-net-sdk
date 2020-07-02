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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListDataServiceAuthorizedApisResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private string requestId;

		private bool? success;

		private ListDataServiceAuthorizedApis_Data data;

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public ListDataServiceAuthorizedApis_Data Data
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

		public class ListDataServiceAuthorizedApis_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListDataServiceAuthorizedApis_ApiAuthorized> apiAuthorizedList;

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

			public List<ListDataServiceAuthorizedApis_ApiAuthorized> ApiAuthorizedList
			{
				get
				{
					return apiAuthorizedList;
				}
				set	
				{
					apiAuthorizedList = value;
				}
			}

			public class ListDataServiceAuthorizedApis_ApiAuthorized
			{

				private long? apiId;

				private string apiName;

				private string apiPath;

				private int? apiStatus;

				private string createdTime;

				private string creatorId;

				private string grantCreatedTime;

				private string grantEndTime;

				private string grantOperatorId;

				private string groupId;

				private string modifiedTime;

				private long? projectId;

				private long? tenantId;

				public long? ApiId
				{
					get
					{
						return apiId;
					}
					set	
					{
						apiId = value;
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

				public string ApiPath
				{
					get
					{
						return apiPath;
					}
					set	
					{
						apiPath = value;
					}
				}

				public int? ApiStatus
				{
					get
					{
						return apiStatus;
					}
					set	
					{
						apiStatus = value;
					}
				}

				public string CreatedTime
				{
					get
					{
						return createdTime;
					}
					set	
					{
						createdTime = value;
					}
				}

				public string CreatorId
				{
					get
					{
						return creatorId;
					}
					set	
					{
						creatorId = value;
					}
				}

				public string GrantCreatedTime
				{
					get
					{
						return grantCreatedTime;
					}
					set	
					{
						grantCreatedTime = value;
					}
				}

				public string GrantEndTime
				{
					get
					{
						return grantEndTime;
					}
					set	
					{
						grantEndTime = value;
					}
				}

				public string GrantOperatorId
				{
					get
					{
						return grantOperatorId;
					}
					set	
					{
						grantOperatorId = value;
					}
				}

				public string GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
					}
				}

				public string ModifiedTime
				{
					get
					{
						return modifiedTime;
					}
					set	
					{
						modifiedTime = value;
					}
				}

				public long? ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
					}
				}

				public long? TenantId
				{
					get
					{
						return tenantId;
					}
					set	
					{
						tenantId = value;
					}
				}
			}
		}
	}
}
