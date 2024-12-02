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

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
	public class GetFeatureViewResponse : AcsResponse
	{

		private string requestId;

		private string projectId;

		private string projectName;

		private string featureEntityName;

		private string name;

		private string owner;

		private string type;

		private string gmtCreateTime;

		private string gmtModifiedTime;

		private string featureEntityId;

		private string joinId;

		private string writeMethod;

		private string registerTable;

		private string registerDatasourceId;

		private string registerDatasourceName;

		private bool? writeToFeatureDB;

		private bool? syncOnlineTable;

		private int? tTL;

		private string config;

		private string gmtSyncTime;

		private string lastSyncConfig;

		private string publishTableScript;

		private List<GetFeatureView_FieldsItem> fields;

		private List<string> tags;

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

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
			}
		}

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
			}
		}

		public string FeatureEntityName
		{
			get
			{
				return featureEntityName;
			}
			set	
			{
				featureEntityName = value;
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

		public string GmtCreateTime
		{
			get
			{
				return gmtCreateTime;
			}
			set	
			{
				gmtCreateTime = value;
			}
		}

		public string GmtModifiedTime
		{
			get
			{
				return gmtModifiedTime;
			}
			set	
			{
				gmtModifiedTime = value;
			}
		}

		public string FeatureEntityId
		{
			get
			{
				return featureEntityId;
			}
			set	
			{
				featureEntityId = value;
			}
		}

		public string JoinId
		{
			get
			{
				return joinId;
			}
			set	
			{
				joinId = value;
			}
		}

		public string WriteMethod
		{
			get
			{
				return writeMethod;
			}
			set	
			{
				writeMethod = value;
			}
		}

		public string RegisterTable
		{
			get
			{
				return registerTable;
			}
			set	
			{
				registerTable = value;
			}
		}

		public string RegisterDatasourceId
		{
			get
			{
				return registerDatasourceId;
			}
			set	
			{
				registerDatasourceId = value;
			}
		}

		public string RegisterDatasourceName
		{
			get
			{
				return registerDatasourceName;
			}
			set	
			{
				registerDatasourceName = value;
			}
		}

		public bool? WriteToFeatureDB
		{
			get
			{
				return writeToFeatureDB;
			}
			set	
			{
				writeToFeatureDB = value;
			}
		}

		public bool? SyncOnlineTable
		{
			get
			{
				return syncOnlineTable;
			}
			set	
			{
				syncOnlineTable = value;
			}
		}

		public int? TTL
		{
			get
			{
				return tTL;
			}
			set	
			{
				tTL = value;
			}
		}

		public string Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
			}
		}

		public string GmtSyncTime
		{
			get
			{
				return gmtSyncTime;
			}
			set	
			{
				gmtSyncTime = value;
			}
		}

		public string LastSyncConfig
		{
			get
			{
				return lastSyncConfig;
			}
			set	
			{
				lastSyncConfig = value;
			}
		}

		public string PublishTableScript
		{
			get
			{
				return publishTableScript;
			}
			set	
			{
				publishTableScript = value;
			}
		}

		public List<GetFeatureView_FieldsItem> Fields
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

		public List<string> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public class GetFeatureView_FieldsItem
		{

			private string name;

			private string type;

			private List<string> attributes;

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

			public List<string> Attributes
			{
				get
				{
					return attributes;
				}
				set	
				{
					attributes = value;
				}
			}
		}
	}
}
