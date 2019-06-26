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
	public class DescribeRdsAccountsResponse : AcsResponse
	{

		private int? code;

		private string requestId;

		private string errMsg;

		private DescribeRdsAccounts_Result result;

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

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
			}
		}

		public DescribeRdsAccounts_Result Result
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

		public class DescribeRdsAccounts_Result
		{

			private List<DescribeRdsAccounts_AccountsItem> accounts;

			public List<DescribeRdsAccounts_AccountsItem> Accounts
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

			public class DescribeRdsAccounts_AccountsItem
			{

				private string accountStatus;

				private string accountDescription;

				private string accountName;

				private string accountType;

				private string privExceeded;

				private string dBInstanceId;

				private List<DescribeRdsAccounts_DatabasePrivilegesItem> databasePrivileges;

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

				public string PrivExceeded
				{
					get
					{
						return privExceeded;
					}
					set	
					{
						privExceeded = value;
					}
				}

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

				public List<DescribeRdsAccounts_DatabasePrivilegesItem> DatabasePrivileges
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

				public class DescribeRdsAccounts_DatabasePrivilegesItem
				{

					private string dBName;

					private string accountPrivilege;

					private string accountPrivilegeDetail;

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
}
