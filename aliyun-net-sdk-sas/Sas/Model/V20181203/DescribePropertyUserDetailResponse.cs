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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribePropertyUserDetailResponse : AcsResponse
	{

		private string requestId;

		private List<DescribePropertyUserDetail_PropertyUser> propertys;

		private DescribePropertyUserDetail_PageInfo pageInfo;

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

		public List<DescribePropertyUserDetail_PropertyUser> Propertys
		{
			get
			{
				return propertys;
			}
			set	
			{
				propertys = value;
			}
		}

		public DescribePropertyUserDetail_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribePropertyUserDetail_PropertyUser
		{

			private string status;

			private string lastLoginIp;

			private string internetIp;

			private string lastLoginTime;

			private string isRoot;

			private string ip;

			private string user;

			private string instanceId;

			private string intranetIp;

			private string passwordExpirationDate;

			private string uuid;

			private long? lastLoginTimestamp;

			private string instanceName;

			private string accountsExpirationDate;

			private long? createTimestamp;

			private long? lastLoginTimeDt;

			private int? isPasswdExpired;

			private int? isPasswdLocked;

			private int? isUserExpired;

			private int? isCouldLogin;

			private int? isSudoer;

			private List<string> groupNames;

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

			public string LastLoginIp
			{
				get
				{
					return lastLoginIp;
				}
				set	
				{
					lastLoginIp = value;
				}
			}

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string LastLoginTime
			{
				get
				{
					return lastLoginTime;
				}
				set	
				{
					lastLoginTime = value;
				}
			}

			public string IsRoot
			{
				get
				{
					return isRoot;
				}
				set	
				{
					isRoot = value;
				}
			}

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}

			public string User
			{
				get
				{
					return user;
				}
				set	
				{
					user = value;
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

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

			public string PasswordExpirationDate
			{
				get
				{
					return passwordExpirationDate;
				}
				set	
				{
					passwordExpirationDate = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public long? LastLoginTimestamp
			{
				get
				{
					return lastLoginTimestamp;
				}
				set	
				{
					lastLoginTimestamp = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string AccountsExpirationDate
			{
				get
				{
					return accountsExpirationDate;
				}
				set	
				{
					accountsExpirationDate = value;
				}
			}

			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
				}
			}

			public long? LastLoginTimeDt
			{
				get
				{
					return lastLoginTimeDt;
				}
				set	
				{
					lastLoginTimeDt = value;
				}
			}

			public int? IsPasswdExpired
			{
				get
				{
					return isPasswdExpired;
				}
				set	
				{
					isPasswdExpired = value;
				}
			}

			public int? IsPasswdLocked
			{
				get
				{
					return isPasswdLocked;
				}
				set	
				{
					isPasswdLocked = value;
				}
			}

			public int? IsUserExpired
			{
				get
				{
					return isUserExpired;
				}
				set	
				{
					isUserExpired = value;
				}
			}

			public int? IsCouldLogin
			{
				get
				{
					return isCouldLogin;
				}
				set	
				{
					isCouldLogin = value;
				}
			}

			public int? IsSudoer
			{
				get
				{
					return isSudoer;
				}
				set	
				{
					isSudoer = value;
				}
			}

			public List<string> GroupNames
			{
				get
				{
					return groupNames;
				}
				set	
				{
					groupNames = value;
				}
			}
		}

		public class DescribePropertyUserDetail_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalCount;

			private int? count;

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

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}
	}
}
