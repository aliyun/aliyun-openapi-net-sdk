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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDatabasesResponse : AcsResponse
	{

		private int? pageRecordCount;

		private string requestId;

		private int? pageNumber;

		private List<DescribeDatabases_Database> databases;

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
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

		public List<DescribeDatabases_Database> Databases
		{
			get
			{
				return databases;
			}
			set	
			{
				databases = value;
			}
		}

		public class DescribeDatabases_Database
		{

			private string dBDescription;

			private string dBStatus;

			private string dBName;

			private string engine;

			private string masterID;

			private string characterSetName;

			private List<DescribeDatabases_Account> accounts;

			public string DBDescription
			{
				get
				{
					return dBDescription;
				}
				set	
				{
					dBDescription = value;
				}
			}

			public string DBStatus
			{
				get
				{
					return dBStatus;
				}
				set	
				{
					dBStatus = value;
				}
			}

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

			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			public string MasterID
			{
				get
				{
					return masterID;
				}
				set	
				{
					masterID = value;
				}
			}

			public string CharacterSetName
			{
				get
				{
					return characterSetName;
				}
				set	
				{
					characterSetName = value;
				}
			}

			public List<DescribeDatabases_Account> Accounts
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

			public class DescribeDatabases_Account
			{

				private string privilegeStatus;

				private string accountStatus;

				private string accountPrivilege;

				private string accountName;

				public string PrivilegeStatus
				{
					get
					{
						return privilegeStatus;
					}
					set	
					{
						privilegeStatus = value;
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
			}
		}
	}
}
