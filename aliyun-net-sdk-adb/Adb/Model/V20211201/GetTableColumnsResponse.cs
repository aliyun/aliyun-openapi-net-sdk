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
	public class GetTableColumnsResponse : AcsResponse
	{

		private string requestId;

		private long? pageNumber;

		private long? pageSize;

		private long? totalCount;

		private GetTableColumns_Data data;

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

		public long? PageNumber
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

		public long? PageSize
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

		public GetTableColumns_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetTableColumns_Data
		{

			private long? pageNumber;

			private long? pageSize;

			private long? totalCount;

			private GetTableColumns_Table table;

			public long? PageNumber
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

			public long? PageSize
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

			public GetTableColumns_Table Table
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

			public class GetTableColumns_Table
			{

				private string schemaName;

				private string tableName;

				private string tableType;

				private string createTime;

				private string updateTime;

				private string description;

				private string owner;

				private string catalog;

				private List<GetTableColumns_ColumnsItem> columns;

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

				public string Catalog
				{
					get
					{
						return catalog;
					}
					set	
					{
						catalog = value;
					}
				}

				public List<GetTableColumns_ColumnsItem> Columns
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

				public class GetTableColumns_ColumnsItem
				{

					private string columnName;

					private string type;

					private string description;

					private string schemaName;

					private string tableName;

					private string createTime;

					private string updateTime;

					private bool? partitionKey;

					private bool? nullable;

					private bool? primaryKey;

					private bool? distributeKey;

					public string ColumnName
					{
						get
						{
							return columnName;
						}
						set	
						{
							columnName = value;
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

					public bool? PartitionKey
					{
						get
						{
							return partitionKey;
						}
						set	
						{
							partitionKey = value;
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

					public bool? PrimaryKey
					{
						get
						{
							return primaryKey;
						}
						set	
						{
							primaryKey = value;
						}
					}

					public bool? DistributeKey
					{
						get
						{
							return distributeKey;
						}
						set	
						{
							distributeKey = value;
						}
					}
				}
			}
		}
	}
}
