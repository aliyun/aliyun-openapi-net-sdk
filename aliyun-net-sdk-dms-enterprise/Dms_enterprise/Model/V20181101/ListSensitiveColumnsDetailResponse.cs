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
	public class ListSensitiveColumnsDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private List<ListSensitiveColumnsDetail_SensitiveColumnsDetail> sensitiveColumnsDetailList;

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

		public List<ListSensitiveColumnsDetail_SensitiveColumnsDetail> SensitiveColumnsDetailList
		{
			get
			{
				return sensitiveColumnsDetailList;
			}
			set	
			{
				sensitiveColumnsDetailList = value;
			}
		}

		public class ListSensitiveColumnsDetail_SensitiveColumnsDetail
		{

			private string schemaName;

			private string tableName;

			private string columnName;

			private string searchName;

			private long? dbId;

			private string envType;

			private string dbType;

			private bool? logic;

			private string columnType;

			private string columnDescription;

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

			public long? DbId
			{
				get
				{
					return dbId;
				}
				set	
				{
					dbId = value;
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

			public string ColumnType
			{
				get
				{
					return columnType;
				}
				set	
				{
					columnType = value;
				}
			}

			public string ColumnDescription
			{
				get
				{
					return columnDescription;
				}
				set	
				{
					columnDescription = value;
				}
			}
		}
	}
}
