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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class ListDatabasesResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private List<ListDatabases_Database> databaseList;

		[JsonProperty(PropertyName = "TotalCount")]
		public long? TotalCount
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

		[JsonProperty(PropertyName = "ErrorCode")]
		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		[JsonProperty(PropertyName = "ErrorMessage")]
		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "DatabaseList")]
		public List<ListDatabases_Database> DatabaseList
		{
			get
			{
				return databaseList;
			}
			set	
			{
				databaseList = value;
			}
		}

		public class ListDatabases_Database
		{

			private string databaseId;

			private string host;

			private string catalogName;

			private string dbaName;

			private string state;

			private string dbaId;

			private string schemaName;

			private string instanceId;

			private int? port;

			private string envType;

			private string sid;

			private string encoding;

			private string dbType;

			private string searchName;

			private List<string> ownerIdList;

			private List<string> ownerNameList;

			[JsonProperty(PropertyName = "DatabaseId")]
			public string DatabaseId
			{
				get
				{
					return databaseId;
				}
				set	
				{
					databaseId = value;
				}
			}

			[JsonProperty(PropertyName = "Host")]
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

			[JsonProperty(PropertyName = "CatalogName")]
			public string CatalogName
			{
				get
				{
					return catalogName;
				}
				set	
				{
					catalogName = value;
				}
			}

			[JsonProperty(PropertyName = "DbaName")]
			public string DbaName
			{
				get
				{
					return dbaName;
				}
				set	
				{
					dbaName = value;
				}
			}

			[JsonProperty(PropertyName = "State")]
			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			[JsonProperty(PropertyName = "DbaId")]
			public string DbaId
			{
				get
				{
					return dbaId;
				}
				set	
				{
					dbaId = value;
				}
			}

			[JsonProperty(PropertyName = "SchemaName")]
			public string SchemaName
			{
				get
				{
					return schemaName;
				}
				set	
				{
					schemaName = value;
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

			[JsonProperty(PropertyName = "Port")]
			public int? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			[JsonProperty(PropertyName = "EnvType")]
			public string EnvType
			{
				get
				{
					return envType;
				}
				set	
				{
					envType = value;
				}
			}

			[JsonProperty(PropertyName = "Sid")]
			public string Sid
			{
				get
				{
					return sid;
				}
				set	
				{
					sid = value;
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

			[JsonProperty(PropertyName = "SearchName")]
			public string SearchName
			{
				get
				{
					return searchName;
				}
				set	
				{
					searchName = value;
				}
			}

			[JsonProperty(PropertyName = "OwnerIdList")]
			public List<string> OwnerIdList
			{
				get
				{
					return ownerIdList;
				}
				set	
				{
					ownerIdList = value;
				}
			}

			[JsonProperty(PropertyName = "OwnerNameList")]
			public List<string> OwnerNameList
			{
				get
				{
					return ownerNameList;
				}
				set	
				{
					ownerNameList = value;
				}
			}
		}
	}
}
