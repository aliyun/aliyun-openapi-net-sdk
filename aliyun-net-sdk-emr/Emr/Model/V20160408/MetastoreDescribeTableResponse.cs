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
	public class MetastoreDescribeTableResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private string databaseId;

		private string clusterBizId;

		private string clusterName;

		private int? createTime;

		private int? lastAccessTime;

		private string locationUri;

		private string inputFormat;

		private string outputFormat;

		private bool? compressed;

		private string serializationLib;

		private string tableName;

		private string dbName;

		private string owner;

		private string tableComment;

		private string tableType;

		private string creator;

		private string fieldDelimiter;

		private List<MetastoreDescribeTable_Column> columns;

		private List<MetastoreDescribeTable_PartitionColumn> partitionColumns;

		private List<MetastoreDescribeTable_SerdeParameter> serdeParameters;

		private List<MetastoreDescribeTable_StorageDescParameter> storageDescParameters;

		private List<MetastoreDescribeTable_TableParameter> tableParameters;

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

		public int? CreateTime
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

		public int? LastAccessTime
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

		public string LocationUri
		{
			get
			{
				return locationUri;
			}
			set	
			{
				locationUri = value;
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

		public bool? Compressed
		{
			get
			{
				return compressed;
			}
			set	
			{
				compressed = value;
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

		public string DbName
		{
			get
			{
				return dbName;
			}
			set	
			{
				dbName = value;
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

		public string Creator
		{
			get
			{
				return creator;
			}
			set	
			{
				creator = value;
			}
		}

		public string FieldDelimiter
		{
			get
			{
				return fieldDelimiter;
			}
			set	
			{
				fieldDelimiter = value;
			}
		}

		public List<MetastoreDescribeTable_Column> Columns
		{
			get
			{
				return columns;
			}
			set	
			{
				columns = value;
			}
		}

		public List<MetastoreDescribeTable_PartitionColumn> PartitionColumns
		{
			get
			{
				return partitionColumns;
			}
			set	
			{
				partitionColumns = value;
			}
		}

		public List<MetastoreDescribeTable_SerdeParameter> SerdeParameters
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

		public List<MetastoreDescribeTable_StorageDescParameter> StorageDescParameters
		{
			get
			{
				return storageDescParameters;
			}
			set	
			{
				storageDescParameters = value;
			}
		}

		public List<MetastoreDescribeTable_TableParameter> TableParameters
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

		public class MetastoreDescribeTable_Column
		{

			private string name;

			private string type;

			private string comment;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}
		}

		public class MetastoreDescribeTable_PartitionColumn
		{

			private string name;

			private string type;

			private string comment;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}
		}

		public class MetastoreDescribeTable_SerdeParameter
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class MetastoreDescribeTable_StorageDescParameter
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class MetastoreDescribeTable_TableParameter
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}
	}
}
