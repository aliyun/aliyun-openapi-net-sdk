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
	public class GetTableDBTopologyResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetTableDBTopology_DBTopology dBTopology;

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

				private string host;

				private int? port;

				private string dbType;

				private string sid;

				private List<GetTableDBTopology_Database> databaseList;

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

					private string dbName;

					private string dbId;

					private string envType;

					private string dbType;

					private List<GetTableDBTopology_Table> tableList;

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

						private string tableId;

						private string tableType;

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
					}
				}
			}
		}
	}
}
