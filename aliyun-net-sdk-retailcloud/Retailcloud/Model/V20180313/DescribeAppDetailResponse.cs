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
	public class DescribeAppDetailResponse : AcsResponse
	{

		private long? code;

		private string requestId;

		private string errMessage;

		private DescribeAppDetail_Result result;

		public long? Code
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

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public DescribeAppDetail_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeAppDetail_Result
		{

			private string serviceType;

			private string bizTitle;

			private string bizName;

			private long? appId;

			private string language;

			private string title;

			private string operatingSystem;

			private string deployType;

			private string description;

			private string appStateType;

			private List<DescribeAppDetail_UserRole> userRoles;

			private List<DescribeAppDetail_MiddleWareInfo> middleWareInfoList;

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

			public List<DescribeAppDetail_UserRole> UserRoles
			{
				get
				{
					return userRoles;
				}
				set	
				{
					userRoles = value;
				}
			}

			public List<DescribeAppDetail_MiddleWareInfo> MiddleWareInfoList
			{
				get
				{
					return middleWareInfoList;
				}
				set	
				{
					middleWareInfoList = value;
				}
			}

			public class DescribeAppDetail_UserRole
			{

				private string userId;

				private string userType;

				private string realName;

				private string roleName;

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

				public string RealName
				{
					get
					{
						return realName;
					}
					set	
					{
						realName = value;
					}
				}

				public string RoleName
				{
					get
					{
						return roleName;
					}
					set	
					{
						roleName = value;
					}
				}
			}

			public class DescribeAppDetail_MiddleWareInfo
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
