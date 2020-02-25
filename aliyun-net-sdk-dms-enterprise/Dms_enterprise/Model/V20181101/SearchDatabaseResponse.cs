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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class SearchDatabaseResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private long? totalCount;

		private List<SearchDatabase_SearchDatabase> searchDatabaseList;

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

		public List<SearchDatabase_SearchDatabase> SearchDatabaseList
		{
			get
			{
				return searchDatabaseList;
			}
			set	
			{
				searchDatabaseList = value;
			}
		}

		public class SearchDatabase_SearchDatabase
		{

			private string databaseId;

			private bool? logic;

			private string envType;

			private string schemaName;

			private string searchName;

			private string dbType;

			private string host;

			private int? port;

			private string sid;

			private string dbaId;

			private string encoding;

			private string alias;

			private string datalinkName;

			private List<string> ownerIdList;

			private List<string> ownerNameList;

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

			public bool? Logic
			{
				get
				{
					return logic;
				}
				set	
				{
					logic = value;
				}
			}

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

			public string Alias
			{
				get
				{
					return alias;
				}
				set	
				{
					alias = value;
				}
			}

			public string DatalinkName
			{
				get
				{
					return datalinkName;
				}
				set	
				{
					datalinkName = value;
				}
			}

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
