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
	public class ListDataSourceSchemaTableResponse : AcsResponse
	{

		private string requestId;

		private string dataSourceId;

		private List<ListDataSourceSchemaTable_Schema> schemaList;

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

		public string DataSourceId
		{
			get
			{
				return dataSourceId;
			}
			set	
			{
				dataSourceId = value;
			}
		}

		public List<ListDataSourceSchemaTable_Schema> SchemaList
		{
			get
			{
				return schemaList;
			}
			set	
			{
				schemaList = value;
			}
		}

		public class ListDataSourceSchemaTable_Schema
		{

			private string dbType;

			private string dbVersion;

			private string dbName;

			private string tableName;

			private List<ListDataSourceSchemaTable_Field> fields;

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

			public string DbVersion
			{
				get
				{
					return dbVersion;
				}
				set	
				{
					dbVersion = value;
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

			public List<ListDataSourceSchemaTable_Field> Fields
			{
				get
				{
					return fields;
				}
				set	
				{
					fields = value;
				}
			}

			public class ListDataSourceSchemaTable_Field
			{

				private string type;

				private string name;

				private int? index;

				private string rawType;

				private string assignType;

				private string assignValue;

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

				public int? Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public string RawType
				{
					get
					{
						return rawType;
					}
					set	
					{
						rawType = value;
					}
				}

				public string AssignType
				{
					get
					{
						return assignType;
					}
					set	
					{
						assignType = value;
					}
				}

				public string AssignValue
				{
					get
					{
						return assignValue;
					}
					set	
					{
						assignValue = value;
					}
				}
			}
		}
	}
}
