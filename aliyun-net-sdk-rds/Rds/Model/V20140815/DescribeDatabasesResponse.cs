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
	public class DescribeDatabasesResponse : AcsResponse
	{

		private List<Database> databases;

		public List<Database> Databases
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

		public class Database{

			private string dBName;

			private string dBInstanceId;

			private string engine;

			private DBStatusEnum? dBStatus;

			private string characterSetName;

			private string dBDescription;

			private List<AccountPrivilegeInfo> accounts;

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

			public DBStatusEnum? DBStatus
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

			public List<AccountPrivilegeInfo> Accounts
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

public enum DBStatusEnum {

					Deleting,
					Running,
					Creating,
}

			public class AccountPrivilegeInfo{

				private string account;

				private string accountPrivilege;

				public string Account
				{
					get
					{
						return account;
					}
					set	
					{
						account = value;
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