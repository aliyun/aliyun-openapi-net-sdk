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
	public class GetTableTopologyResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetTableTopology_TableTopology tableTopology;

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

		[JsonProperty(PropertyName = "TableTopology")]
		public GetTableTopology_TableTopology TableTopology
		{
			get
			{
				return tableTopology;
			}
			set	
			{
				tableTopology = value;
			}
		}

		public class GetTableTopology_TableTopology
		{

			private string tableGuid;

			private string tableName;

			private bool? logic;

			private List<GetTableTopology_TableTopologyInfo> tableTopologyInfoList;

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

			[JsonProperty(PropertyName = "Logic")]
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

			[JsonProperty(PropertyName = "TableTopologyInfoList")]
			public List<GetTableTopology_TableTopologyInfo> TableTopologyInfoList
			{
				get
				{
					return tableTopologyInfoList;
				}
				set	
				{
					tableTopologyInfoList = value;
				}
			}

			public class GetTableTopology_TableTopologyInfo
			{

				private string tableNameList;

				private string tableNameExpr;

				private long? tableCount;

				private long? dbId;

				private string dbSearchName;

				private long? instanceId;

				private string regionId;

				private string instanceResourceId;

				private string instanceSource;

				private string dbName;

				private string dbType;

				[JsonProperty(PropertyName = "TableNameList")]
				public string TableNameList
				{
					get
					{
						return tableNameList;
					}
					set	
					{
						tableNameList = value;
					}
				}

				[JsonProperty(PropertyName = "TableNameExpr")]
				public string TableNameExpr
				{
					get
					{
						return tableNameExpr;
					}
					set	
					{
						tableNameExpr = value;
					}
				}

				[JsonProperty(PropertyName = "TableCount")]
				public long? TableCount
				{
					get
					{
						return tableCount;
					}
					set	
					{
						tableCount = value;
					}
				}

				[JsonProperty(PropertyName = "DbId")]
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

				[JsonProperty(PropertyName = "DbSearchName")]
				public string DbSearchName
				{
					get
					{
						return dbSearchName;
					}
					set	
					{
						dbSearchName = value;
					}
				}

				[JsonProperty(PropertyName = "InstanceId")]
				public long? InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				[JsonProperty(PropertyName = "RegionId")]
				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				[JsonProperty(PropertyName = "InstanceResourceId")]
				public string InstanceResourceId
				{
					get
					{
						return instanceResourceId;
					}
					set	
					{
						instanceResourceId = value;
					}
				}

				[JsonProperty(PropertyName = "InstanceSource")]
				public string InstanceSource
				{
					get
					{
						return instanceSource;
					}
					set	
					{
						instanceSource = value;
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
			}
		}
	}
}
