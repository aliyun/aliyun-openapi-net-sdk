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

namespace Aliyun.Acs.adb.Model.V20211201
{
	public class GetTableResponse : AcsResponse
	{

		private string requestId;

		private long? code;

		private string message;

		private bool? success;

		private GetTable_Table table;

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

		public long? Code
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public GetTable_Table Table
		{
			get
			{
				return table;
			}
			set	
			{
				table = value;
			}
		}

		public class GetTable_Table
		{

			private long? tblId;

			private string dbName;

			private string tableName;

			private string tableType;

			private string parameters;

			private string createTime;

			private string viewOriginalText;

			private string viewExpandedText;

			private bool? temporary;

			private string comment;

			private string physicalTableName;

			private string physicalDatabaseName;

			private string distributeType;

			private string partitionType;

			private string partitionColumn;

			private long? partitionCount;

			private long? previousVersion;

			private long? currentVersion;

			private string updateTime;

			private string tableEngineName;

			private bool? isAllIndex;

			private long? blockSize;

			private string compression;

			private string rawTableName;

			private string subpartitionType;

			private string subpartitionColumn;

			private long? subpartitionCount;

			private string archiveType;

			private long? maxColumnId;

			private bool? enableDfs;

			private string storagePolicy;

			private long? hotPartitionCount;

			private bool? isFulltextDict;

			private bool? rtIndexAll;

			private string rtEngineType;

			private string rtModeType;

			private string routeType;

			private bool? dictEncode;

			private long? bucketCount;

			private long? bucket;

			private string viewSecurityMode;

			private List<GetTable_PartitionKeysItem> partitionKeys;

			private List<GetTable_ColsItem> cols;

			private List<GetTable_DistributeColumnsItem> distributeColumns;

			private List<GetTable_RouteColumnsItem> routeColumns;

			private List<GetTable_IndexesItem> indexes;

			private GetTable_Sd sd;

			private GetTable_RouteEffectiveColumn routeEffectiveColumn;

			public long? TblId
			{
				get
				{
					return tblId;
				}
				set	
				{
					tblId = value;
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

			public string Parameters
			{
				get
				{
					return parameters;
				}
				set	
				{
					parameters = value;
				}
			}

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

			public string ViewOriginalText
			{
				get
				{
					return viewOriginalText;
				}
				set	
				{
					viewOriginalText = value;
				}
			}

			public string ViewExpandedText
			{
				get
				{
					return viewExpandedText;
				}
				set	
				{
					viewExpandedText = value;
				}
			}

			public bool? Temporary
			{
				get
				{
					return temporary;
				}
				set	
				{
					temporary = value;
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

			public string PhysicalTableName
			{
				get
				{
					return physicalTableName;
				}
				set	
				{
					physicalTableName = value;
				}
			}

			public string PhysicalDatabaseName
			{
				get
				{
					return physicalDatabaseName;
				}
				set	
				{
					physicalDatabaseName = value;
				}
			}

			public string DistributeType
			{
				get
				{
					return distributeType;
				}
				set	
				{
					distributeType = value;
				}
			}

			public string PartitionType
			{
				get
				{
					return partitionType;
				}
				set	
				{
					partitionType = value;
				}
			}

			public string PartitionColumn
			{
				get
				{
					return partitionColumn;
				}
				set	
				{
					partitionColumn = value;
				}
			}

			public long? PartitionCount
			{
				get
				{
					return partitionCount;
				}
				set	
				{
					partitionCount = value;
				}
			}

			public long? PreviousVersion
			{
				get
				{
					return previousVersion;
				}
				set	
				{
					previousVersion = value;
				}
			}

			public long? CurrentVersion
			{
				get
				{
					return currentVersion;
				}
				set	
				{
					currentVersion = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string TableEngineName
			{
				get
				{
					return tableEngineName;
				}
				set	
				{
					tableEngineName = value;
				}
			}

			public bool? IsAllIndex
			{
				get
				{
					return isAllIndex;
				}
				set	
				{
					isAllIndex = value;
				}
			}

			public long? BlockSize
			{
				get
				{
					return blockSize;
				}
				set	
				{
					blockSize = value;
				}
			}

			public string Compression
			{
				get
				{
					return compression;
				}
				set	
				{
					compression = value;
				}
			}

			public string RawTableName
			{
				get
				{
					return rawTableName;
				}
				set	
				{
					rawTableName = value;
				}
			}

			public string SubpartitionType
			{
				get
				{
					return subpartitionType;
				}
				set	
				{
					subpartitionType = value;
				}
			}

			public string SubpartitionColumn
			{
				get
				{
					return subpartitionColumn;
				}
				set	
				{
					subpartitionColumn = value;
				}
			}

			public long? SubpartitionCount
			{
				get
				{
					return subpartitionCount;
				}
				set	
				{
					subpartitionCount = value;
				}
			}

			public string ArchiveType
			{
				get
				{
					return archiveType;
				}
				set	
				{
					archiveType = value;
				}
			}

			public long? MaxColumnId
			{
				get
				{
					return maxColumnId;
				}
				set	
				{
					maxColumnId = value;
				}
			}

			public bool? EnableDfs
			{
				get
				{
					return enableDfs;
				}
				set	
				{
					enableDfs = value;
				}
			}

			public string StoragePolicy
			{
				get
				{
					return storagePolicy;
				}
				set	
				{
					storagePolicy = value;
				}
			}

			public long? HotPartitionCount
			{
				get
				{
					return hotPartitionCount;
				}
				set	
				{
					hotPartitionCount = value;
				}
			}

			public bool? IsFulltextDict
			{
				get
				{
					return isFulltextDict;
				}
				set	
				{
					isFulltextDict = value;
				}
			}

			public bool? RtIndexAll
			{
				get
				{
					return rtIndexAll;
				}
				set	
				{
					rtIndexAll = value;
				}
			}

			public string RtEngineType
			{
				get
				{
					return rtEngineType;
				}
				set	
				{
					rtEngineType = value;
				}
			}

			public string RtModeType
			{
				get
				{
					return rtModeType;
				}
				set	
				{
					rtModeType = value;
				}
			}

			public string RouteType
			{
				get
				{
					return routeType;
				}
				set	
				{
					routeType = value;
				}
			}

			public bool? DictEncode
			{
				get
				{
					return dictEncode;
				}
				set	
				{
					dictEncode = value;
				}
			}

			public long? BucketCount
			{
				get
				{
					return bucketCount;
				}
				set	
				{
					bucketCount = value;
				}
			}

			public long? Bucket
			{
				get
				{
					return bucket;
				}
				set	
				{
					bucket = value;
				}
			}

			public string ViewSecurityMode
			{
				get
				{
					return viewSecurityMode;
				}
				set	
				{
					viewSecurityMode = value;
				}
			}

			public List<GetTable_PartitionKeysItem> PartitionKeys
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

			public List<GetTable_ColsItem> Cols
			{
				get
				{
					return cols;
				}
				set	
				{
					cols = value;
				}
			}

			public List<GetTable_DistributeColumnsItem> DistributeColumns
			{
				get
				{
					return distributeColumns;
				}
				set	
				{
					distributeColumns = value;
				}
			}

			public List<GetTable_RouteColumnsItem> RouteColumns
			{
				get
				{
					return routeColumns;
				}
				set	
				{
					routeColumns = value;
				}
			}

			public List<GetTable_IndexesItem> Indexes
			{
				get
				{
					return indexes;
				}
				set	
				{
					indexes = value;
				}
			}

			public GetTable_Sd Sd
			{
				get
				{
					return sd;
				}
				set	
				{
					sd = value;
				}
			}

			public GetTable_RouteEffectiveColumn RouteEffectiveColumn
			{
				get
				{
					return routeEffectiveColumn;
				}
				set	
				{
					routeEffectiveColumn = value;
				}
			}

			public class GetTable_PartitionKeysItem
			{

				private string name;

				private string type;

				private string comment;

				private string databaseName;

				private string tableName;

				private string mappedName;

				private string dataType;

				private string createTime;

				private string updateTime;

				private long? pkPosition;

				private bool? isPartitionKey;

				private long? ordinalPosition;

				private string columnRawName;

				private string physicalColumnName;

				private bool? nullable;

				private bool? autoIncrement;

				private long? precision;

				private long? scale;

				private bool? primarykey;

				private string defaultValue;

				private string tokenizer;

				private string encode;

				private string compression;

				private string delimiter;

				private string valueType;

				private bool? compressFloatUseShort;

				private string onUpdate;

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

				public string MappedName
				{
					get
					{
						return mappedName;
					}
					set	
					{
						mappedName = value;
					}
				}

				public string DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}

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

				public string UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				public long? PkPosition
				{
					get
					{
						return pkPosition;
					}
					set	
					{
						pkPosition = value;
					}
				}

				public bool? IsPartitionKey
				{
					get
					{
						return isPartitionKey;
					}
					set	
					{
						isPartitionKey = value;
					}
				}

				public long? OrdinalPosition
				{
					get
					{
						return ordinalPosition;
					}
					set	
					{
						ordinalPosition = value;
					}
				}

				public string ColumnRawName
				{
					get
					{
						return columnRawName;
					}
					set	
					{
						columnRawName = value;
					}
				}

				public string PhysicalColumnName
				{
					get
					{
						return physicalColumnName;
					}
					set	
					{
						physicalColumnName = value;
					}
				}

				public bool? Nullable
				{
					get
					{
						return nullable;
					}
					set	
					{
						nullable = value;
					}
				}

				public bool? AutoIncrement
				{
					get
					{
						return autoIncrement;
					}
					set	
					{
						autoIncrement = value;
					}
				}

				public long? Precision
				{
					get
					{
						return precision;
					}
					set	
					{
						precision = value;
					}
				}

				public long? Scale
				{
					get
					{
						return scale;
					}
					set	
					{
						scale = value;
					}
				}

				public bool? Primarykey
				{
					get
					{
						return primarykey;
					}
					set	
					{
						primarykey = value;
					}
				}

				public string DefaultValue
				{
					get
					{
						return defaultValue;
					}
					set	
					{
						defaultValue = value;
					}
				}

				public string Tokenizer
				{
					get
					{
						return tokenizer;
					}
					set	
					{
						tokenizer = value;
					}
				}

				public string Encode
				{
					get
					{
						return encode;
					}
					set	
					{
						encode = value;
					}
				}

				public string Compression
				{
					get
					{
						return compression;
					}
					set	
					{
						compression = value;
					}
				}

				public string Delimiter
				{
					get
					{
						return delimiter;
					}
					set	
					{
						delimiter = value;
					}
				}

				public string ValueType
				{
					get
					{
						return valueType;
					}
					set	
					{
						valueType = value;
					}
				}

				public bool? CompressFloatUseShort
				{
					get
					{
						return compressFloatUseShort;
					}
					set	
					{
						compressFloatUseShort = value;
					}
				}

				public string OnUpdate
				{
					get
					{
						return onUpdate;
					}
					set	
					{
						onUpdate = value;
					}
				}
			}

			public class GetTable_ColsItem
			{

				private string name;

				private string type;

				private string comment;

				private string databaseName;

				private string tableName;

				private string mappedName;

				private string dataType;

				private string createTime;

				private string updateTime;

				private long? pkPosition;

				private bool? isPartitionKey;

				private long? ordinalPosition;

				private string columnRawName;

				private string physicalColumnName;

				private bool? nullable;

				private bool? autoIncrement;

				private long? precision;

				private long? scale;

				private bool? primarykey;

				private string defaultValue;

				private string tokenizer;

				private string encode;

				private string compression;

				private string delimiter;

				private string valueType;

				private bool? compressFloatUseShort;

				private string onUpdate;

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

				public string MappedName
				{
					get
					{
						return mappedName;
					}
					set	
					{
						mappedName = value;
					}
				}

				public string DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}

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

				public string UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				public long? PkPosition
				{
					get
					{
						return pkPosition;
					}
					set	
					{
						pkPosition = value;
					}
				}

				public bool? IsPartitionKey
				{
					get
					{
						return isPartitionKey;
					}
					set	
					{
						isPartitionKey = value;
					}
				}

				public long? OrdinalPosition
				{
					get
					{
						return ordinalPosition;
					}
					set	
					{
						ordinalPosition = value;
					}
				}

				public string ColumnRawName
				{
					get
					{
						return columnRawName;
					}
					set	
					{
						columnRawName = value;
					}
				}

				public string PhysicalColumnName
				{
					get
					{
						return physicalColumnName;
					}
					set	
					{
						physicalColumnName = value;
					}
				}

				public bool? Nullable
				{
					get
					{
						return nullable;
					}
					set	
					{
						nullable = value;
					}
				}

				public bool? AutoIncrement
				{
					get
					{
						return autoIncrement;
					}
					set	
					{
						autoIncrement = value;
					}
				}

				public long? Precision
				{
					get
					{
						return precision;
					}
					set	
					{
						precision = value;
					}
				}

				public long? Scale
				{
					get
					{
						return scale;
					}
					set	
					{
						scale = value;
					}
				}

				public bool? Primarykey
				{
					get
					{
						return primarykey;
					}
					set	
					{
						primarykey = value;
					}
				}

				public string DefaultValue
				{
					get
					{
						return defaultValue;
					}
					set	
					{
						defaultValue = value;
					}
				}

				public string Tokenizer
				{
					get
					{
						return tokenizer;
					}
					set	
					{
						tokenizer = value;
					}
				}

				public string Encode
				{
					get
					{
						return encode;
					}
					set	
					{
						encode = value;
					}
				}

				public string Compression
				{
					get
					{
						return compression;
					}
					set	
					{
						compression = value;
					}
				}

				public string Delimiter
				{
					get
					{
						return delimiter;
					}
					set	
					{
						delimiter = value;
					}
				}

				public string ValueType
				{
					get
					{
						return valueType;
					}
					set	
					{
						valueType = value;
					}
				}

				public bool? CompressFloatUseShort
				{
					get
					{
						return compressFloatUseShort;
					}
					set	
					{
						compressFloatUseShort = value;
					}
				}

				public string OnUpdate
				{
					get
					{
						return onUpdate;
					}
					set	
					{
						onUpdate = value;
					}
				}
			}

			public class GetTable_DistributeColumnsItem
			{

				private string name;

				private string type;

				private string comment;

				private string databaseName;

				private string tableName;

				private string mappedName;

				private string dataType;

				private string createTime;

				private string updateTime;

				private long? pkPosition;

				private bool? isPartitionKey;

				private long? ordinalPosition;

				private string columnRawName;

				private string physicalColumnName;

				private bool? nullable;

				private bool? autoIncrement;

				private long? precision;

				private long? scale;

				private bool? primarykey;

				private string defaultValue;

				private string tokenizer;

				private string encode;

				private string compression;

				private string delimiter;

				private string valueType;

				private bool? compressFloatUseShort;

				private string onUpdate;

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

				public string MappedName
				{
					get
					{
						return mappedName;
					}
					set	
					{
						mappedName = value;
					}
				}

				public string DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}

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

				public string UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				public long? PkPosition
				{
					get
					{
						return pkPosition;
					}
					set	
					{
						pkPosition = value;
					}
				}

				public bool? IsPartitionKey
				{
					get
					{
						return isPartitionKey;
					}
					set	
					{
						isPartitionKey = value;
					}
				}

				public long? OrdinalPosition
				{
					get
					{
						return ordinalPosition;
					}
					set	
					{
						ordinalPosition = value;
					}
				}

				public string ColumnRawName
				{
					get
					{
						return columnRawName;
					}
					set	
					{
						columnRawName = value;
					}
				}

				public string PhysicalColumnName
				{
					get
					{
						return physicalColumnName;
					}
					set	
					{
						physicalColumnName = value;
					}
				}

				public bool? Nullable
				{
					get
					{
						return nullable;
					}
					set	
					{
						nullable = value;
					}
				}

				public bool? AutoIncrement
				{
					get
					{
						return autoIncrement;
					}
					set	
					{
						autoIncrement = value;
					}
				}

				public long? Precision
				{
					get
					{
						return precision;
					}
					set	
					{
						precision = value;
					}
				}

				public long? Scale
				{
					get
					{
						return scale;
					}
					set	
					{
						scale = value;
					}
				}

				public bool? Primarykey
				{
					get
					{
						return primarykey;
					}
					set	
					{
						primarykey = value;
					}
				}

				public string DefaultValue
				{
					get
					{
						return defaultValue;
					}
					set	
					{
						defaultValue = value;
					}
				}

				public string Tokenizer
				{
					get
					{
						return tokenizer;
					}
					set	
					{
						tokenizer = value;
					}
				}

				public string Encode
				{
					get
					{
						return encode;
					}
					set	
					{
						encode = value;
					}
				}

				public string Compression
				{
					get
					{
						return compression;
					}
					set	
					{
						compression = value;
					}
				}

				public string Delimiter
				{
					get
					{
						return delimiter;
					}
					set	
					{
						delimiter = value;
					}
				}

				public string ValueType
				{
					get
					{
						return valueType;
					}
					set	
					{
						valueType = value;
					}
				}

				public bool? CompressFloatUseShort
				{
					get
					{
						return compressFloatUseShort;
					}
					set	
					{
						compressFloatUseShort = value;
					}
				}

				public string OnUpdate
				{
					get
					{
						return onUpdate;
					}
					set	
					{
						onUpdate = value;
					}
				}
			}

			public class GetTable_RouteColumnsItem
			{

				private string name;

				private string type;

				private string comment;

				private string databaseName;

				private string tableName;

				private string mappedName;

				private string dataType;

				private string createTime;

				private string updateTime;

				private long? pkPosition;

				private bool? isPartitionKey;

				private long? ordinalPosition;

				private string columnRawName;

				private string physicalColumnName;

				private bool? nullable;

				private bool? autoIncrement;

				private long? precision;

				private long? scale;

				private bool? primarykey;

				private string defaultValue;

				private string tokenizer;

				private string encode;

				private string compression;

				private string delimiter;

				private string valueType;

				private bool? compressFloatUseShort;

				private string onUpdate;

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

				public string MappedName
				{
					get
					{
						return mappedName;
					}
					set	
					{
						mappedName = value;
					}
				}

				public string DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}

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

				public string UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				public long? PkPosition
				{
					get
					{
						return pkPosition;
					}
					set	
					{
						pkPosition = value;
					}
				}

				public bool? IsPartitionKey
				{
					get
					{
						return isPartitionKey;
					}
					set	
					{
						isPartitionKey = value;
					}
				}

				public long? OrdinalPosition
				{
					get
					{
						return ordinalPosition;
					}
					set	
					{
						ordinalPosition = value;
					}
				}

				public string ColumnRawName
				{
					get
					{
						return columnRawName;
					}
					set	
					{
						columnRawName = value;
					}
				}

				public string PhysicalColumnName
				{
					get
					{
						return physicalColumnName;
					}
					set	
					{
						physicalColumnName = value;
					}
				}

				public bool? Nullable
				{
					get
					{
						return nullable;
					}
					set	
					{
						nullable = value;
					}
				}

				public bool? AutoIncrement
				{
					get
					{
						return autoIncrement;
					}
					set	
					{
						autoIncrement = value;
					}
				}

				public long? Precision
				{
					get
					{
						return precision;
					}
					set	
					{
						precision = value;
					}
				}

				public long? Scale
				{
					get
					{
						return scale;
					}
					set	
					{
						scale = value;
					}
				}

				public bool? Primarykey
				{
					get
					{
						return primarykey;
					}
					set	
					{
						primarykey = value;
					}
				}

				public string DefaultValue
				{
					get
					{
						return defaultValue;
					}
					set	
					{
						defaultValue = value;
					}
				}

				public string Tokenizer
				{
					get
					{
						return tokenizer;
					}
					set	
					{
						tokenizer = value;
					}
				}

				public string Encode
				{
					get
					{
						return encode;
					}
					set	
					{
						encode = value;
					}
				}

				public string Compression
				{
					get
					{
						return compression;
					}
					set	
					{
						compression = value;
					}
				}

				public string Delimiter
				{
					get
					{
						return delimiter;
					}
					set	
					{
						delimiter = value;
					}
				}

				public string ValueType
				{
					get
					{
						return valueType;
					}
					set	
					{
						valueType = value;
					}
				}

				public bool? CompressFloatUseShort
				{
					get
					{
						return compressFloatUseShort;
					}
					set	
					{
						compressFloatUseShort = value;
					}
				}

				public string OnUpdate
				{
					get
					{
						return onUpdate;
					}
					set	
					{
						onUpdate = value;
					}
				}
			}

			public class GetTable_IndexesItem
			{

				private string databaseName;

				private string physicalTableName;

				private string indexName;

				private string indexType;

				private string options;

				private string createTime;

				private string updateTime;

				private List<GetTable_IndexColumnsItem> indexColumns;

				private List<string> columnOrds;

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

				public string PhysicalTableName
				{
					get
					{
						return physicalTableName;
					}
					set	
					{
						physicalTableName = value;
					}
				}

				public string IndexName
				{
					get
					{
						return indexName;
					}
					set	
					{
						indexName = value;
					}
				}

				public string IndexType
				{
					get
					{
						return indexType;
					}
					set	
					{
						indexType = value;
					}
				}

				public string Options
				{
					get
					{
						return options;
					}
					set	
					{
						options = value;
					}
				}

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

				public string UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				public List<GetTable_IndexColumnsItem> IndexColumns
				{
					get
					{
						return indexColumns;
					}
					set	
					{
						indexColumns = value;
					}
				}

				public List<string> ColumnOrds
				{
					get
					{
						return columnOrds;
					}
					set	
					{
						columnOrds = value;
					}
				}

				public class GetTable_IndexColumnsItem
				{

					private string name;

					private string type;

					private string comment;

					private string databaseName;

					private string tableName;

					private string mappedName;

					private string dataType;

					private string createTime;

					private string updateTime;

					private long? pkPosition;

					private bool? isPartitionKey;

					private long? ordinalPosition;

					private string columnRawName;

					private string physicalColumnName;

					private bool? nullable;

					private bool? autoIncrement;

					private long? precision;

					private long? scale;

					private bool? primarykey;

					private string defaultValue;

					private string tokenizer;

					private string encode;

					private string compression;

					private string delimiter;

					private string valueType;

					private bool? compressFloatUseShort;

					private string onUpdate;

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

					public string MappedName
					{
						get
						{
							return mappedName;
						}
						set	
						{
							mappedName = value;
						}
					}

					public string DataType
					{
						get
						{
							return dataType;
						}
						set	
						{
							dataType = value;
						}
					}

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

					public string UpdateTime
					{
						get
						{
							return updateTime;
						}
						set	
						{
							updateTime = value;
						}
					}

					public long? PkPosition
					{
						get
						{
							return pkPosition;
						}
						set	
						{
							pkPosition = value;
						}
					}

					public bool? IsPartitionKey
					{
						get
						{
							return isPartitionKey;
						}
						set	
						{
							isPartitionKey = value;
						}
					}

					public long? OrdinalPosition
					{
						get
						{
							return ordinalPosition;
						}
						set	
						{
							ordinalPosition = value;
						}
					}

					public string ColumnRawName
					{
						get
						{
							return columnRawName;
						}
						set	
						{
							columnRawName = value;
						}
					}

					public string PhysicalColumnName
					{
						get
						{
							return physicalColumnName;
						}
						set	
						{
							physicalColumnName = value;
						}
					}

					public bool? Nullable
					{
						get
						{
							return nullable;
						}
						set	
						{
							nullable = value;
						}
					}

					public bool? AutoIncrement
					{
						get
						{
							return autoIncrement;
						}
						set	
						{
							autoIncrement = value;
						}
					}

					public long? Precision
					{
						get
						{
							return precision;
						}
						set	
						{
							precision = value;
						}
					}

					public long? Scale
					{
						get
						{
							return scale;
						}
						set	
						{
							scale = value;
						}
					}

					public bool? Primarykey
					{
						get
						{
							return primarykey;
						}
						set	
						{
							primarykey = value;
						}
					}

					public string DefaultValue
					{
						get
						{
							return defaultValue;
						}
						set	
						{
							defaultValue = value;
						}
					}

					public string Tokenizer
					{
						get
						{
							return tokenizer;
						}
						set	
						{
							tokenizer = value;
						}
					}

					public string Encode
					{
						get
						{
							return encode;
						}
						set	
						{
							encode = value;
						}
					}

					public string Compression
					{
						get
						{
							return compression;
						}
						set	
						{
							compression = value;
						}
					}

					public string Delimiter
					{
						get
						{
							return delimiter;
						}
						set	
						{
							delimiter = value;
						}
					}

					public string ValueType
					{
						get
						{
							return valueType;
						}
						set	
						{
							valueType = value;
						}
					}

					public bool? CompressFloatUseShort
					{
						get
						{
							return compressFloatUseShort;
						}
						set	
						{
							compressFloatUseShort = value;
						}
					}

					public string OnUpdate
					{
						get
						{
							return onUpdate;
						}
						set	
						{
							onUpdate = value;
						}
					}
				}
			}

			public class GetTable_Sd
			{

				private long? sdId;

				private string location;

				private string inputFormat;

				private string outputFormat;

				private bool? compressed;

				private long? numBuckets;

				private string parameters;

				private bool? storedAsSubDirectories;

				private GetTable_SerDeInfo serDeInfo;

				public long? SdId
				{
					get
					{
						return sdId;
					}
					set	
					{
						sdId = value;
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

				public long? NumBuckets
				{
					get
					{
						return numBuckets;
					}
					set	
					{
						numBuckets = value;
					}
				}

				public string Parameters
				{
					get
					{
						return parameters;
					}
					set	
					{
						parameters = value;
					}
				}

				public bool? StoredAsSubDirectories
				{
					get
					{
						return storedAsSubDirectories;
					}
					set	
					{
						storedAsSubDirectories = value;
					}
				}

				public GetTable_SerDeInfo SerDeInfo
				{
					get
					{
						return serDeInfo;
					}
					set	
					{
						serDeInfo = value;
					}
				}

				public class GetTable_SerDeInfo
				{

					private long? serDeId;

					private string name;

					private string parameters;

					private string serializationLib;

					public long? SerDeId
					{
						get
						{
							return serDeId;
						}
						set	
						{
							serDeId = value;
						}
					}

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

					public string Parameters
					{
						get
						{
							return parameters;
						}
						set	
						{
							parameters = value;
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
				}
			}

			public class GetTable_RouteEffectiveColumn
			{

				private string name;

				private string type;

				private string comment;

				private string databaseName;

				private string tableName;

				private string mappedName;

				private string dataType;

				private string createTime;

				private string updateTime;

				private long? pkPosition;

				private bool? isPartitionKey;

				private long? ordinalPosition;

				private string columnRawName;

				private string physicalColumnName;

				private bool? nullable;

				private bool? autoIncrement;

				private long? precision;

				private long? scale;

				private bool? primarykey;

				private string defaultValue;

				private string tokenizer;

				private string encode;

				private string compression;

				private string delimiter;

				private string valueType;

				private bool? compressFloatUseShort;

				private string onUpdate;

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

				public string MappedName
				{
					get
					{
						return mappedName;
					}
					set	
					{
						mappedName = value;
					}
				}

				public string DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}

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

				public string UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				public long? PkPosition
				{
					get
					{
						return pkPosition;
					}
					set	
					{
						pkPosition = value;
					}
				}

				public bool? IsPartitionKey
				{
					get
					{
						return isPartitionKey;
					}
					set	
					{
						isPartitionKey = value;
					}
				}

				public long? OrdinalPosition
				{
					get
					{
						return ordinalPosition;
					}
					set	
					{
						ordinalPosition = value;
					}
				}

				public string ColumnRawName
				{
					get
					{
						return columnRawName;
					}
					set	
					{
						columnRawName = value;
					}
				}

				public string PhysicalColumnName
				{
					get
					{
						return physicalColumnName;
					}
					set	
					{
						physicalColumnName = value;
					}
				}

				public bool? Nullable
				{
					get
					{
						return nullable;
					}
					set	
					{
						nullable = value;
					}
				}

				public bool? AutoIncrement
				{
					get
					{
						return autoIncrement;
					}
					set	
					{
						autoIncrement = value;
					}
				}

				public long? Precision
				{
					get
					{
						return precision;
					}
					set	
					{
						precision = value;
					}
				}

				public long? Scale
				{
					get
					{
						return scale;
					}
					set	
					{
						scale = value;
					}
				}

				public bool? Primarykey
				{
					get
					{
						return primarykey;
					}
					set	
					{
						primarykey = value;
					}
				}

				public string DefaultValue
				{
					get
					{
						return defaultValue;
					}
					set	
					{
						defaultValue = value;
					}
				}

				public string Tokenizer
				{
					get
					{
						return tokenizer;
					}
					set	
					{
						tokenizer = value;
					}
				}

				public string Encode
				{
					get
					{
						return encode;
					}
					set	
					{
						encode = value;
					}
				}

				public string Compression
				{
					get
					{
						return compression;
					}
					set	
					{
						compression = value;
					}
				}

				public string Delimiter
				{
					get
					{
						return delimiter;
					}
					set	
					{
						delimiter = value;
					}
				}

				public string ValueType
				{
					get
					{
						return valueType;
					}
					set	
					{
						valueType = value;
					}
				}

				public bool? CompressFloatUseShort
				{
					get
					{
						return compressFloatUseShort;
					}
					set	
					{
						compressFloatUseShort = value;
					}
				}

				public string OnUpdate
				{
					get
					{
						return onUpdate;
					}
					set	
					{
						onUpdate = value;
					}
				}
			}
		}
	}
}
