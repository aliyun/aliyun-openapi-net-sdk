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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.rtc.Model.V20180111
{
	public class DescribeAppsResponse : AcsResponse
	{

		private string requestId;

		private int? totalNum;

		private int? totalPage;

		private List<DescribeApps_App> appList;

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

		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public int? TotalPage
		{
			get
			{
				return totalPage;
			}
			set	
			{
				totalPage = value;
			}
		}

		public List<DescribeApps_App> AppList
		{
			get
			{
				return appList;
			}
			set	
			{
				appList = value;
			}
		}

		public class DescribeApps_App
		{

			private int? status;

			private string appId;

			private string appName;

			private string createTime;

			private string appType;

			private string billType;

			private List<string> serviceAreas;

			public int? Status
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

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
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

			public string AppType
			{
				get
				{
					return appType;
				}
				set	
				{
					appType = value;
				}
			}

			public string BillType
			{
				get
				{
					return billType;
				}
				set	
				{
					billType = value;
				}
			}

			public List<string> ServiceAreas
			{
				get
				{
					return serviceAreas;
				}
				set	
				{
					serviceAreas = value;
				}
			}
		}
	}
}