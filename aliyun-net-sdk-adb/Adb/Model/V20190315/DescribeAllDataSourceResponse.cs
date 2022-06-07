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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeAllDataSourceResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAllDataSource_Table> tables;

		private List<DescribeAllDataSource_Column> columns;

		private List<DescribeAllDataSource_Schema> schemas;

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

		public class DescribeAllDataSource_Table
		{

			private string tableName;

			private string dBClusterId;

			private string schemaName;

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

		public class DescribeAllDataSource_Column
		{

			private string type;

			private string columnName;

			private string tableName;

			private bool? autoIncrementColumn;

			private string dBClusterId;

			private bool? primaryKey;

			private string schemaName;

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
	}
}
