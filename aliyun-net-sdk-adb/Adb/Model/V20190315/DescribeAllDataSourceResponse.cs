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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeAllDataSourceResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAllDataSource_Schema> schemas;

		private List<DescribeAllDataSource_Table> tables;

		private List<DescribeAllDataSource_Column> columns;

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

		public List<DescribeAllDataSource_Schema> Schemas
		{
			get
			{
				return schemas;
			}
			set	
			{
				schemas = value;
			}
		}

		public List<DescribeAllDataSource_Table> Tables
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

		public List<DescribeAllDataSource_Column> Columns
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

		public class DescribeAllDataSource_Schema
		{

			private string dBClusterId;

			private string schemaName;

			public string DBClusterId
			{
				get
				{
					return dBClusterId;
				}
				set	
				{
					dBClusterId = value;
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
		}

		public class DescribeAllDataSource_Table
		{

			private string dBClusterId;

			private string schemaName;

			private string tableName;

			public string DBClusterId
			{
				get
				{
					return dBClusterId;
				}
				set	
				{
					dBClusterId = value;
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
		}

		public class DescribeAllDataSource_Column
		{

			private string dBClusterId;

			private string schemaName;

			private string tableName;

			private string columnName;

			private string type;

			private bool? primaryKey;

			private bool? autoIncrementColumn;

			public string DBClusterId
			{
				get
				{
					return dBClusterId;
				}
				set	
				{
					dBClusterId = value;
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

			public bool? AutoIncrementColumn
			{
				get
				{
					return autoIncrementColumn;
				}
				set	
				{
					autoIncrementColumn = value;
				}
			}
		}
	}
}
