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

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
	public class DescribeAppInfoResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeAppInfo_AppInfo> appInfoList;

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

		public List<DescribeAppInfo_AppInfo> AppInfoList
		{
			get
			{
				return appInfoList;
			}
			set	
			{
				appInfoList = value;
			}
		}

		public class DescribeAppInfo_AppInfo
		{

			private long? id;

			private string name;

			private string packageName;

			private string icon;

			private string startDate;

			private string endDate;

			private int? type;

			private DescribeAppInfo_PackageInfo packageInfo;

			private DescribeAppInfo_DebugPackageInfo debugPackageInfo;

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

			public string PackageName
			{
				get
				{
					return packageName;
				}
				set	
				{
					packageName = value;
				}
			}

			public string Icon
			{
				get
				{
					return icon;
				}
				set	
				{
					icon = value;
				}
			}

			public string StartDate
			{
				get
				{
					return startDate;
				}
				set	
				{
					startDate = value;
				}
			}

			public string EndDate
			{
				get
				{
					return endDate;
				}
				set	
				{
					endDate = value;
				}
			}

			public int? Type
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

			public DescribeAppInfo_PackageInfo PackageInfo
			{
				get
				{
					return packageInfo;
				}
				set	
				{
					packageInfo = value;
				}
			}

			public DescribeAppInfo_DebugPackageInfo DebugPackageInfo
			{
				get
				{
					return debugPackageInfo;
				}
				set	
				{
					debugPackageInfo = value;
				}
			}

			public class DescribeAppInfo_PackageInfo
			{

				private string version;

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}
			}

			public class DescribeAppInfo_DebugPackageInfo
			{

				private string version;

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}
			}
		}
	}
}
