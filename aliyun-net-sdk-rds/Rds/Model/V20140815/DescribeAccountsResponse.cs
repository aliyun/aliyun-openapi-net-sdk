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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeAccountsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAccounts_DBInstanceAccount> accounts;

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

		public List<DescribeAccounts_DBInstanceAccount> Accounts
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

		public class DescribeAccounts_DBInstanceAccount
		{

			private string dBInstanceId;

			private string accountName;

			private string accountStatus;

			private string accountType;

			private string accountDescription;

			private List<DescribeAccounts_DatabasePrivilege> databasePrivileges;

			public string DBInstanceId
			{
				get
				{
					return dBInstanceId;
				}
				set	
				{
					dBInstanceId = value;
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

				private string dBName;

				private string accountPrivilege;

				public string DBName
				{
					get
					{
						return dBName;
					}
					set	
					{
						dBName = value;
					}
				}

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
			}
		}
	}
}