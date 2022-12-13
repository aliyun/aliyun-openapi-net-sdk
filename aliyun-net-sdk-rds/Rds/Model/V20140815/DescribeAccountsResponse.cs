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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeAccountsResponse : AcsResponse
	{

		private string systemAdminAccountStatus;

		private string systemAdminAccountFirstActivationTime;

		private int? pageNumber;

		private string requestId;

		private int? totalRecordCount;

		private List<DescribeAccounts_DBInstanceAccount> accounts;

		[JsonProperty(PropertyName = "SystemAdminAccountStatus")]
		public string SystemAdminAccountStatus
		{
			get
			{
				return systemAdminAccountStatus;
			}
			set	
			{
				systemAdminAccountStatus = value;
			}
		}

		[JsonProperty(PropertyName = "SystemAdminAccountFirstActivationTime")]
		public string SystemAdminAccountFirstActivationTime
		{
			get
			{
				return systemAdminAccountFirstActivationTime;
			}
			set	
			{
				systemAdminAccountFirstActivationTime = value;
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "TotalRecordCount")]
		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		[JsonProperty(PropertyName = "Accounts")]
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

			private string accountStatus;

			private string accountDescription;

			private string dBInstanceId;

			private string privExceeded;

			private string accountType;

			private string accountName;

			private string validUntil;

			private string createDB;

			private string replication;

			private string createRole;

			private string bypassRLS;

			private List<DescribeAccounts_DatabasePrivilege> databasePrivileges;

			[JsonProperty(PropertyName = "AccountStatus")]
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

			[JsonProperty(PropertyName = "AccountDescription")]
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

			[JsonProperty(PropertyName = "DBInstanceId")]
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

			[JsonProperty(PropertyName = "PrivExceeded")]
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

			[JsonProperty(PropertyName = "AccountType")]
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

			[JsonProperty(PropertyName = "AccountName")]
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

			[JsonProperty(PropertyName = "ValidUntil")]
			public string ValidUntil
			{
				get
				{
					return validUntil;
				}
				set	
				{
					validUntil = value;
				}
			}

			[JsonProperty(PropertyName = "CreateDB")]
			public string CreateDB
			{
				get
				{
					return createDB;
				}
				set	
				{
					createDB = value;
				}
			}

			[JsonProperty(PropertyName = "Replication")]
			public string Replication
			{
				get
				{
					return replication;
				}
				set	
				{
					replication = value;
				}
			}

			[JsonProperty(PropertyName = "CreateRole")]
			public string CreateRole
			{
				get
				{
					return createRole;
				}
				set	
				{
					createRole = value;
				}
			}

			[JsonProperty(PropertyName = "BypassRLS")]
			public string BypassRLS
			{
				get
				{
					return bypassRLS;
				}
				set	
				{
					bypassRLS = value;
				}
			}

			[JsonProperty(PropertyName = "DatabasePrivileges")]
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

				private string accountPrivilegeDetail;

				[JsonProperty(PropertyName = "DBName")]
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

				[JsonProperty(PropertyName = "AccountPrivilege")]
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

				[JsonProperty(PropertyName = "AccountPrivilegeDetail")]
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
