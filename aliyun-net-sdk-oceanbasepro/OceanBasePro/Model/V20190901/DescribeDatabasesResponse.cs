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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeDatabasesResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeDatabases_Data> databases;

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
		public List<DescribeDatabases_Data> Databases
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

		public class DescribeDatabases_Data
		{

			private string status;

			private string description;

			private string encoding;

			private string dbType;

			private string databaseName;

			private string createTime;

			private string tenantId;

			private double? requiredSize;

			private double? dataSize;

			private string collation;

			private string instanceId;

			private string tenantName;

			private List<DescribeDatabases_UsersItem> users;

			private List<DescribeDatabases_TablesItem> tables;

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "Encoding")]
			public string Encoding
			{
				get
				{
					return encoding;
				}
				set	
				{
					encoding = value;
				}
			}

			[JsonProperty(PropertyName = "DbType")]
			public string DbType
			{
				get
				{
					return dbType;
				}
				set	
				{
					dbType = value;
				}
			}

			[JsonProperty(PropertyName = "DatabaseName")]
			public string DatabaseName
			{
				get
				{
					return databaseName;
				}
				set	
				{
					databaseName = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTime")]
			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			[JsonProperty(PropertyName = "TenantId")]
			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			[JsonProperty(PropertyName = "RequiredSize")]
			public double? RequiredSize
			{
				get
				{
					return requiredSize;
				}
				set	
				{
					requiredSize = value;
				}
			}

			[JsonProperty(PropertyName = "DataSize")]
			public double? DataSize
			{
				get
				{
					return dataSize;
				}
				set	
				{
					dataSize = value;
				}
			}

			[JsonProperty(PropertyName = "Collation")]
			public string Collation
			{
				get
				{
					return collation;
				}
				set	
				{
					collation = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceId")]
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

			[JsonProperty(PropertyName = "TenantName")]
			public string TenantName
			{
				get
				{
					return tenantName;
				}
				set	
				{
					tenantName = value;
				}
			}

			[JsonProperty(PropertyName = "Users")]
			public List<DescribeDatabases_UsersItem> Users
			{
				get
				{
					return users;
				}
				set	
				{
					users = value;
				}
			}

			[JsonProperty(PropertyName = "Tables")]
			public List<DescribeDatabases_TablesItem> Tables
			{
				get
				{
					return tables;
				}
				set	
				{
					tables = value;
				}
			}

			public class DescribeDatabases_UsersItem
			{

				private string userType;

				private string role;

				private string userName;

				private string privileges;

				[JsonProperty(PropertyName = "UserType")]
				public string UserType
				{
					get
					{
						return userType;
					}
					set	
					{
						userType = value;
					}
				}

				[JsonProperty(PropertyName = "Role")]
				public string Role
				{
					get
					{
						return role;
					}
					set	
					{
						role = value;
					}
				}

				[JsonProperty(PropertyName = "UserName")]
				public string UserName
				{
					get
					{
						return userName;
					}
					set	
					{
						userName = value;
					}
				}

				[JsonProperty(PropertyName = "Privileges")]
				public string Privileges
				{
					get
					{
						return privileges;
					}
					set	
					{
						privileges = value;
					}
				}
			}

			public class DescribeDatabases_TablesItem
			{

				private string tableName;

				[JsonProperty(PropertyName = "TableName")]
				public string TableName
				{
					get
					{
						return tableName;
					}
					set	
					{
						tableName = value;
					}
				}
			}
		}
	}
}
