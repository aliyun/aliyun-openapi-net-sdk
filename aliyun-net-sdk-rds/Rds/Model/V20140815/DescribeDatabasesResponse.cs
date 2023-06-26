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
	public class DescribeDatabasesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDatabases_Database> databases;

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

		[JsonProperty(PropertyName = "Databases")]
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

			private string dBInstanceId;

			private string engine;

			private string characterSetName;

			private string collate;

			private string ctype;

			private string connLimit;

			private string tablespace;

			private string resourceGroupId;

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<DescribeDatabases_AccountPrivilegeInfo> accounts;

			private List<Dictionary<string, string>> basicInfo;

			private List<Dictionary<string, string>> runtimeInfo;

			private List<Dictionary<string, string>> advancedInfo;

			[JsonProperty(PropertyName = "DBDescription")]
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

			[JsonProperty(PropertyName = "DBStatus")]
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

			[JsonProperty(PropertyName = "Engine")]
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

			[JsonProperty(PropertyName = "CharacterSetName")]
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

			[JsonProperty(PropertyName = "Collate")]
			public string Collate
			{
				get
				{
					return collate;
				}
				set	
				{
					collate = value;
				}
			}

			[JsonProperty(PropertyName = "Ctype")]
			public string Ctype
			{
				get
				{
					return ctype;
				}
				set	
				{
					ctype = value;
				}
			}

			[JsonProperty(PropertyName = "ConnLimit")]
			public string ConnLimit
			{
				get
				{
					return connLimit;
				}
				set	
				{
					connLimit = value;
				}
			}

			[JsonProperty(PropertyName = "Tablespace")]
			public string Tablespace
			{
				get
				{
					return tablespace;
				}
				set	
				{
					tablespace = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceGroupId")]
			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
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

			[JsonProperty(PropertyName = "PageSize")]
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

			[JsonProperty(PropertyName = "TotalCount")]
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

			[JsonProperty(PropertyName = "Accounts")]
			public List<DescribeDatabases_AccountPrivilegeInfo> Accounts
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

			[JsonProperty(PropertyName = "BasicInfo")]
			public List<Dictionary<string, string>> BasicInfo
			{
				get
				{
					return basicInfo;
				}
				set	
				{
					basicInfo = value;
				}
			}

			[JsonProperty(PropertyName = "RuntimeInfo")]
			public List<Dictionary<string, string>> RuntimeInfo
			{
				get
				{
					return runtimeInfo;
				}
				set	
				{
					runtimeInfo = value;
				}
			}

			[JsonProperty(PropertyName = "AdvancedInfo")]
			public List<Dictionary<string, string>> AdvancedInfo
			{
				get
				{
					return advancedInfo;
				}
				set	
				{
					advancedInfo = value;
				}
			}

			public class DescribeDatabases_AccountPrivilegeInfo
			{

				private string account;

				private string accountPrivilege;

				private string accountPrivilegeDetail;

				[JsonProperty(PropertyName = "Account")]
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
