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

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
	public class ListAppDomainRedirectRecordsResponse : AcsResponse
	{

		private string requestId;

		private string dynamicCode;

		private string dynamicMessage;

		private bool? synchro;

		private string accessDeniedDetail;

		private string rootErrorMsg;

		private string rootErrorCode;

		private bool? allowRetry;

		private string appName;

		private int? maxResults;

		private string nextToken;

		private List<string> errorArgs;

		private ListAppDomainRedirectRecords_Module module;

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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public bool? Synchro
		{
			get
			{
				return synchro;
			}
			set	
			{
				synchro = value;
			}
		}

		public string AccessDeniedDetail
		{
			get
			{
				return accessDeniedDetail;
			}
			set	
			{
				accessDeniedDetail = value;
			}
		}

		public string RootErrorMsg
		{
			get
			{
				return rootErrorMsg;
			}
			set	
			{
				rootErrorMsg = value;
			}
		}

		public string RootErrorCode
		{
			get
			{
				return rootErrorCode;
			}
			set	
			{
				rootErrorCode = value;
			}
		}

		public bool? AllowRetry
		{
			get
			{
				return allowRetry;
			}
			set	
			{
				allowRetry = value;
			}
		}

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
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

		public List<string> ErrorArgs
		{
			get
			{
				return errorArgs;
			}
			set	
			{
				errorArgs = value;
			}
		}

		public ListAppDomainRedirectRecords_Module Module
		{
			get
			{
				return module;
			}
			set	
			{
				module = value;
			}
		}

		public class ListAppDomainRedirectRecords_Module
		{

			private int? totalItemNum;

			private int? currentPageNum;

			private int? pageSize;

			private int? totalPageNum;

			private bool? prePage;

			private bool? nextPage;

			private bool? resultLimit;

			private List<ListAppDomainRedirectRecords_DataItem> data;

			private ListAppDomainRedirectRecords_Next next;

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

			public int? CurrentPageNum
			{
				get
				{
					return currentPageNum;
				}
				set	
				{
					currentPageNum = value;
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

			public bool? PrePage
			{
				get
				{
					return prePage;
				}
				set	
				{
					prePage = value;
				}
			}

			public bool? NextPage
			{
				get
				{
					return nextPage;
				}
				set	
				{
					nextPage = value;
				}
			}

			public bool? ResultLimit
			{
				get
				{
					return resultLimit;
				}
				set	
				{
					resultLimit = value;
				}
			}

			public List<ListAppDomainRedirectRecords_DataItem> Data
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

			public ListAppDomainRedirectRecords_Next Next
			{
				get
				{
					return next;
				}
				set	
				{
					next = value;
				}
			}

			public class ListAppDomainRedirectRecords_DataItem
			{

				private string recordId;

				private string sourceDomain;

				private string targetDomain;

				public string RecordId
				{
					get
					{
						return recordId;
					}
					set	
					{
						recordId = value;
					}
				}

				public string SourceDomain
				{
					get
					{
						return sourceDomain;
					}
					set	
					{
						sourceDomain = value;
					}
				}

				public string TargetDomain
				{
					get
					{
						return targetDomain;
					}
					set	
					{
						targetDomain = value;
					}
				}
			}

			public class ListAppDomainRedirectRecords_Next
			{

				private string recordId;

				private string sourceDomain;

				private string targetDomain;

				public string RecordId
				{
					get
					{
						return recordId;
					}
					set	
					{
						recordId = value;
					}
				}

				public string SourceDomain
				{
					get
					{
						return sourceDomain;
					}
					set	
					{
						sourceDomain = value;
					}
				}

				public string TargetDomain
				{
					get
					{
						return targetDomain;
					}
					set	
					{
						targetDomain = value;
					}
				}
			}
		}
	}
}
