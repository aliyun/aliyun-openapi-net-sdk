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
	public class GetTableDBTopologyResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private GetTableDBTopology_DBTopology dBTopology;

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

		[JsonProperty(PropertyName = "DBTopology")]
		public GetTableDBTopology_DBTopology DBTopology
		{
			get
			{
				return dBTopology;
			}
			set	
			{
				dBTopology = value;
			}
		}

		public class GetTableDBTopology_DBTopology
		{

			private string tableName;

			private string tableGuid;

			private List<GetTableDBTopology_DataSource> dataSourceList;

			[JsonProperty(PropertyName = "TableName")]
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

			[JsonProperty(PropertyName = "TableGuid")]
			public string TableGuid
			{
				get
				{
					return tableGuid;
				}
				set	
				{
					tableGuid = value;
				}
			}

			[JsonProperty(PropertyName = "DataSourceList")]
			public List<GetTableDBTopology_DataSource> DataSourceList
			{
				get
				{
					return dataSourceList;
				}
				set	
				{
					dataSourceList = value;
				}
			}

			public class GetTableDBTopology_DataSource
			{

				private string sid;

				private string host;

				private string dbType;

				private int? port;

				private List<GetTableDBTopology_Database> databaseList;

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

				[JsonProperty(PropertyName = "DatabaseList")]
				public List<GetTableDBTopology_Database> DatabaseList
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

				public class GetTableDBTopology_Database
				{

					private string dbId;

					private string dbName;

					private string dbType;

					private string envType;

					private List<GetTableDBTopology_Table> tableList;

					[JsonProperty(PropertyName = "DbId")]
					public string DbId
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

					[JsonProperty(PropertyName = "DbName")]
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

					[JsonProperty(PropertyName = "TableList")]
					public List<GetTableDBTopology_Table> TableList
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

					public class GetTableDBTopology_Table
					{

						private string tableName;

						private string tableType;

						private string tableId;

						[JsonProperty(PropertyName = "TableName")]
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

						[JsonProperty(PropertyName = "TableType")]
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

						[JsonProperty(PropertyName = "TableId")]
						public string TableId
						{
							get
							{
								return tableId;
							}
							set	
							{
								tableId = value;
							}
						}
					}
				}
			}
		}
	}
}
