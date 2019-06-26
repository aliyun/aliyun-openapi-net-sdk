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
	public class DescribeDatabasesResponse : AcsResponse
	{

		private int? code;

		private string requestId;

		private string errMsg;

		private DescribeDatabases_Result result;

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

		public DescribeDatabases_Result Result
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

		public class DescribeDatabases_Result
		{

			private List<DescribeDatabases_DatabasesItem> databases;

			public List<DescribeDatabases_DatabasesItem> Databases
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

			public class DescribeDatabases_DatabasesItem
			{

				private string dBName;

				private string dBStatus;

				private string dBDescription;

				private string engine;

				private string characterSetName;

				private string dBInstanceId;

				private List<DescribeDatabases_AccountsItem> accounts;

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

				public List<DescribeDatabases_AccountsItem> Accounts
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

				public class DescribeDatabases_AccountsItem
				{

					private string accountPrivilegeDetail;

					private string accountPrivilege;

					private string account;

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
				}
			}
		}
	}
}
