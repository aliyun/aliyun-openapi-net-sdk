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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeUpdatePackageResultResponse : AcsResponse
	{

		private string requestId;

		private DescribeUpdatePackageResult_AppInfo appInfo;

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

		public DescribeUpdatePackageResult_AppInfo AppInfo
		{
			get
			{
				return appInfo;
			}
			set	
			{
				appInfo = value;
			}
		}

		public class DescribeUpdatePackageResult_AppInfo
		{

			private int? type;

			private string endDate;

			private string packageName;

			private string icon;

			private string startDate;

			private string name;

			private long? id;

			private DescribeUpdatePackageResult_PackageInfo packageInfo;

			private DescribeUpdatePackageResult_DebugPackageInfo debugPackageInfo;

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

			public DescribeUpdatePackageResult_PackageInfo PackageInfo
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

			public DescribeUpdatePackageResult_DebugPackageInfo DebugPackageInfo
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

			public class DescribeUpdatePackageResult_PackageInfo
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

			public class DescribeUpdatePackageResult_DebugPackageInfo
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
