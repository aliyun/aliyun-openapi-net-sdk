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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class MetastoreListTablesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<MetastoreListTables_Table> tableList;

		private List<string> tableNames;

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

		public List<MetastoreListTables_Table> TableList
		{
			get
			{
				return tableList;
			}
			set	
			{
				tableList = value;
			}
		}

		public List<string> TableNames
		{
			get
			{
				return tableNames;
			}
			set	
			{
				tableNames = value;
			}
		}

		public class MetastoreListTables_Table
		{

			private string id;

			private string databaseId;

			private string databaseName;

			private string clusterBizId;

			private string clusterName;

			private string tableName;

			private string tableComment;

			private string tableType;

			private string tableParameters;

			private string owner;

			private string ownerType;

			private bool? isTemporary;

			private string partitionKeys;

			private string serializationLib;

			private string serdeParameters;

			private string inputFormat;

			private string outputFormat;

			private string location;

			private bool? isCompressed;

			private long? lastAccessTime;

			private long? createTime;

			private long? gmtCreate;

			private long? gmtModified;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

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

			public string ClusterBizId
			{
				get
				{
					return clusterBizId;
				}
				set	
				{
					clusterBizId = value;
				}
			}

			public string ClusterName
			{
				get
				{
					return clusterName;
				}
				set	
				{
					clusterName = value;
				}
			}

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

			public string TableComment
			{
				get
				{
					return tableComment;
				}
				set	
				{
					tableComment = value;
				}
			}

			public string TableType
			{
				get
				{
					return tableType;
				}
				set	
				{
					tableType = value;
				}
			}

			public string TableParameters
			{
				get
				{
					return tableParameters;
				}
				set	
				{
					tableParameters = value;
				}
			}

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public string OwnerType
			{
				get
				{
					return ownerType;
				}
				set	
				{
					ownerType = value;
				}
			}

			public bool? IsTemporary
			{
				get
				{
					return isTemporary;
				}
				set	
				{
					isTemporary = value;
				}
			}

			public string PartitionKeys
			{
				get
				{
					return partitionKeys;
				}
				set	
				{
					partitionKeys = value;
				}
			}

			public string SerializationLib
			{
				get
				{
					return serializationLib;
				}
				set	
				{
					serializationLib = value;
				}
			}

			public string SerdeParameters
			{
				get
				{
					return serdeParameters;
				}
				set	
				{
					serdeParameters = value;
				}
			}

			public string InputFormat
			{
				get
				{
					return inputFormat;
				}
				set	
				{
					inputFormat = value;
				}
			}

			public string OutputFormat
			{
				get
				{
					return outputFormat;
				}
				set	
				{
					outputFormat = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public bool? IsCompressed
			{
				get
				{
					return isCompressed;
				}
				set	
				{
					isCompressed = value;
				}
			}

			public long? LastAccessTime
			{
				get
				{
					return lastAccessTime;
				}
				set	
				{
					lastAccessTime = value;
				}
			}

			public long? CreateTime
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

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}
		}
	}
}
