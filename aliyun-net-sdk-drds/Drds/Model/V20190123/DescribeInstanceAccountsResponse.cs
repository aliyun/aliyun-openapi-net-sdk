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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeInstanceAccountsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeInstanceAccounts_InstanceAccount> instanceAccounts;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<DescribeInstanceAccounts_InstanceAccount> InstanceAccounts
		{
			get
			{
				return instanceAccounts;
			}
			set	
			{
				instanceAccounts = value;
			}
		}

		public class DescribeInstanceAccounts_InstanceAccount
		{

			private string accountName;

			private string host;

			private int? accountType;

			private string description;

			private List<DescribeInstanceAccounts_DbPrivilege> dbPrivileges;

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

			public string Host
			{
				get
				{
					return host;
				}
				set	
				{
					host = value;
				}
			}

			public int? AccountType
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

			public List<DescribeInstanceAccounts_DbPrivilege> DbPrivileges
			{
				get
				{
					return dbPrivileges;
				}
				set	
				{
					dbPrivileges = value;
				}
			}

			public class DescribeInstanceAccounts_DbPrivilege
			{

				private string dbName;

				private string privilege;

				public string DbName
				{
					get
					{
						return dbName;
					}
					set	
					{
						dbName = value;
					}
				}

				public string Privilege
				{
					get
					{
						return privilege;
					}
					set	
					{
						privilege = value;
					}
				}
			}
		}
	}
}
