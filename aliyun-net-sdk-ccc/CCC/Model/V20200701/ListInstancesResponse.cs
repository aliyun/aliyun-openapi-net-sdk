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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class ListInstancesResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private List<string> _params;

		private ListInstances_Data data;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public List<string> _Params
		{
			get
			{
				return _params;
			}
			set	
			{
				_params = value;
			}
		}

		public ListInstances_Data Data
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

		public class ListInstances_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListInstances_CallCenterInstance> list;

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

			public List<ListInstances_CallCenterInstance> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListInstances_CallCenterInstance
			{

				private string status;

				private string consoleUrl;

				private string description;

				private long? createTime;

				private string aliyunUid;

				private string name;

				private string domainName;

				private string id;

				private List<ListInstances_User> adminList;

				private List<ListInstances_PhoneNumber> numberList;

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

				public string ConsoleUrl
				{
					get
					{
						return consoleUrl;
					}
					set	
					{
						consoleUrl = value;
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

				public long? CreateTime
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

				public string AliyunUid
				{
					get
					{
						return aliyunUid;
					}
					set	
					{
						aliyunUid = value;
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

				public string DomainName
				{
					get
					{
						return domainName;
					}
					set	
					{
						domainName = value;
					}
				}

				public string Id
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

				public List<ListInstances_User> AdminList
				{
					get
					{
						return adminList;
					}
					set	
					{
						adminList = value;
					}
				}

				public List<ListInstances_PhoneNumber> NumberList
				{
					get
					{
						return numberList;
					}
					set	
					{
						numberList = value;
					}
				}

				public class ListInstances_User
				{

					private string displayName;

					private string extension;

					private string loginName;

					private string email;

					private string workMode;

					private string mobile;

					private string userId;

					private string roleName;

					private string instanceId;

					private string roleId;

					public string DisplayName
					{
						get
						{
							return displayName;
						}
						set	
						{
							displayName = value;
						}
					}

					public string Extension
					{
						get
						{
							return extension;
						}
						set	
						{
							extension = value;
						}
					}

					public string LoginName
					{
						get
						{
							return loginName;
						}
						set	
						{
							loginName = value;
						}
					}

					public string Email
					{
						get
						{
							return email;
						}
						set	
						{
							email = value;
						}
					}

					public string WorkMode
					{
						get
						{
							return workMode;
						}
						set	
						{
							workMode = value;
						}
					}

					public string Mobile
					{
						get
						{
							return mobile;
						}
						set	
						{
							mobile = value;
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

					public string RoleId
					{
						get
						{
							return roleId;
						}
						set	
						{
							roleId = value;
						}
					}
				}

				public class ListInstances_PhoneNumber
				{

					private string number;

					public string Number
					{
						get
						{
							return number;
						}
						set	
						{
							number = value;
						}
					}
				}
			}
		}
	}
}
