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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeAccountsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAccounts_Account> accounts;

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

		public List<DescribeAccounts_Account> Accounts
		{
			get
			{
				return accounts;
			}
			set	
			{
				accounts = value;
			}
		}

		public class DescribeAccounts_Account
		{

			private string instanceId;

			private string accountName;

			private string accountStatus;

			private string accountType;

			private string accountDescription;

			private List<DescribeAccounts_DatabasePrivilege> databasePrivileges;

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

			public string AccountName
			{
				get
				{
					return accountName;
				}
				set	
				{
					accountName = value;
				}
			}

			public string AccountStatus
			{
				get
				{
					return accountStatus;
				}
				set	
				{
					accountStatus = value;
				}
			}

			public string AccountType
			{
				get
				{
					return accountType;
				}
				set	
				{
					accountType = value;
				}
			}

			public string AccountDescription
			{
				get
				{
					return accountDescription;
				}
				set	
				{
					accountDescription = value;
				}
			}

			public List<DescribeAccounts_DatabasePrivilege> DatabasePrivileges
			{
				get
				{
					return databasePrivileges;
				}
				set	
				{
					databasePrivileges = value;
				}
			}

			public class DescribeAccounts_DatabasePrivilege
			{

				private string accountPrivilege;

				private string accountPrivilegeDetail;

				public string AccountPrivilege
				{
					get
					{
						return accountPrivilege;
					}
					set	
					{
						accountPrivilege = value;
					}
				}

				public string AccountPrivilegeDetail
				{
					get
					{
						return accountPrivilegeDetail;
					}
					set	
					{
						accountPrivilegeDetail = value;
					}
				}
			}
		}
	}
}
