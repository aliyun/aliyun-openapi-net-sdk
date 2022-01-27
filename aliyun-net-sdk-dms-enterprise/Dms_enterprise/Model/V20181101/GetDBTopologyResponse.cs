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
	public class GetDBTopologyResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetDBTopology_DBTopology dBTopology;

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

		[JsonProperty(PropertyName = "DBTopology")]
		public GetDBTopology_DBTopology DBTopology
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

		public class GetDBTopology_DBTopology
		{

			private long? logicDbId;

			private string logicDbName;

			private string searchName;

			private string alias;

			private string dbType;

			private string envType;

			private List<GetDBTopology_DBTopologyInfo> dBTopologyInfoList;

			[JsonProperty(PropertyName = "LogicDbId")]
			public long? LogicDbId
			{
				get
				{
					return logicDbId;
				}
				set	
				{
					logicDbId = value;
				}
			}

			[JsonProperty(PropertyName = "LogicDbName")]
			public string LogicDbName
			{
				get
				{
					return logicDbName;
				}
				set	
				{
					logicDbName = value;
				}
			}

			[JsonProperty(PropertyName = "SearchName")]
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

			[JsonProperty(PropertyName = "Alias")]
			public string Alias
			{
				get
				{
					return alias;
				}
				set	
				{
					alias = value;
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

			[JsonProperty(PropertyName = "DBTopologyInfoList")]
			public List<GetDBTopology_DBTopologyInfo> DBTopologyInfoList
			{
				get
				{
					return dBTopologyInfoList;
				}
				set	
				{
					dBTopologyInfoList = value;
				}
			}

			public class GetDBTopology_DBTopologyInfo
			{

				private long? dbId;

				private string schemaName;

				private string catalogName;

				private string searchName;

				private string dbType;

				private string envType;

				private long? instanceId;

				private string regionId;

				private string instanceResourceId;

				private string instanceSource;

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

				[JsonProperty(PropertyName = "SchemaName")]
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

				[JsonProperty(PropertyName = "CatalogName")]
				public string CatalogName
				{
					get
					{
						return catalogName;
					}
					set	
					{
						catalogName = value;
					}
				}

				[JsonProperty(PropertyName = "SearchName")]
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
			}
		}
	}
}
