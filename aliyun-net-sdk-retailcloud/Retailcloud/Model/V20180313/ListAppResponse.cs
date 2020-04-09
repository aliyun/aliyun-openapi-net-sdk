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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class ListAppResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string errorMsg;

		private int? totalCount;

		private List<ListApp_AppDetail> data;

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

		public int? Code
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

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
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

		public List<ListApp_AppDetail> Data
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

		public class ListApp_AppDetail
		{

			private long? appId;

			private string title;

			private string description;

			private string language;

			private string operatingSystem;

			private string bizName;

			private string serviceType;

			private string deployType;

			private string bizTitle;

			private string appStateType;

			private List<ListApp_MiddleWareInfo> middleWareList;

			public long? AppId
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

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string Language
			{
				get
				{
					return language;
				}
				set	
				{
					language = value;
				}
			}

			public string OperatingSystem
			{
				get
				{
					return operatingSystem;
				}
				set	
				{
					operatingSystem = value;
				}
			}

			public string BizName
			{
				get
				{
					return bizName;
				}
				set	
				{
					bizName = value;
				}
			}

			public string ServiceType
			{
				get
				{
					return serviceType;
				}
				set	
				{
					serviceType = value;
				}
			}

			public string DeployType
			{
				get
				{
					return deployType;
				}
				set	
				{
					deployType = value;
				}
			}

			public string BizTitle
			{
				get
				{
					return bizTitle;
				}
				set	
				{
					bizTitle = value;
				}
			}

			public string AppStateType
			{
				get
				{
					return appStateType;
				}
				set	
				{
					appStateType = value;
				}
			}

			public List<ListApp_MiddleWareInfo> MiddleWareList
			{
				get
				{
					return middleWareList;
				}
				set	
				{
					middleWareList = value;
				}
			}

			public class ListApp_MiddleWareInfo
			{

				private long? appId;

				private int? code;

				private string name;

				public long? AppId
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

				public int? Code
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
			}
		}
	}
}
