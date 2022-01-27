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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeAccesskeyLeakListResponse : AcsResponse
	{

		private string requestId;

		private long? gmtLast;

		private int? akLeakCount;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeAccesskeyLeakList_AccessKeyLeak> accessKeyLeakList;

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

		public long? GmtLast
		{
			get
			{
				return gmtLast;
			}
			set	
			{
				gmtLast = value;
			}
		}

		public int? AkLeakCount
		{
			get
			{
				return akLeakCount;
			}
			set	
			{
				akLeakCount = value;
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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
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

		public List<DescribeAccesskeyLeakList_AccessKeyLeak> AccessKeyLeakList
		{
			get
			{
				return accessKeyLeakList;
			}
			set	
			{
				accessKeyLeakList = value;
			}
		}

		public class DescribeAccesskeyLeakList_AccessKeyLeak
		{

			private long? id;

			private long? gmtModified;

			private string asset;

			private string type;

			private string accesskeyId;

			private string status;

			private string aliUserName;

			private string dealType;

			private string dealTime;

			private string userType;

			private string url;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string Asset
			{
				get
				{
					return asset;
				}
				set	
				{
					asset = value;
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

			public string AccesskeyId
			{
				get
				{
					return accesskeyId;
				}
				set	
				{
					accesskeyId = value;
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

			public string AliUserName
			{
				get
				{
					return aliUserName;
				}
				set	
				{
					aliUserName = value;
				}
			}

			public string DealType
			{
				get
				{
					return dealType;
				}
				set	
				{
					dealType = value;
				}
			}

			public string DealTime
			{
				get
				{
					return dealTime;
				}
				set	
				{
					dealTime = value;
				}
			}

			public string UserType
			{
				get
				{
					return userType;
				}
				set	
				{
					userType = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}
		}
	}
}
