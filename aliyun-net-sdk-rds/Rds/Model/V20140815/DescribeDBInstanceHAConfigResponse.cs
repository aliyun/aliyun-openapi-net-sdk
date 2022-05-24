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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstanceHAConfigResponse : AcsResponse
	{

		private string dBInstanceId;

		private string requestId;

		private string hAMode;

		private string syncMode;

		private List<DescribeDBInstanceHAConfig_NodeInfo> hostInstanceInfos;

		[JsonProperty(PropertyName = "DBInstanceId")]
		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
			}
		}

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

		[JsonProperty(PropertyName = "HAMode")]
		public string HAMode
		{
			get
			{
				return hAMode;
			}
			set	
			{
				hAMode = value;
			}
		}

		[JsonProperty(PropertyName = "SyncMode")]
		public string SyncMode
		{
			get
			{
				return syncMode;
			}
			set	
			{
				syncMode = value;
			}
		}

		[JsonProperty(PropertyName = "HostInstanceInfos")]
		public List<DescribeDBInstanceHAConfig_NodeInfo> HostInstanceInfos
		{
			get
			{
				return hostInstanceInfos;
			}
			set	
			{
				hostInstanceInfos = value;
			}
		}

		public class DescribeDBInstanceHAConfig_NodeInfo
		{

			private string logSyncTime;

			private string nodeType;

			private string zoneId;

			private string syncStatus;

			private string dataSyncTime;

			private string nodeId;

			private string regionId;

			[JsonProperty(PropertyName = "LogSyncTime")]
			public string LogSyncTime
			{
				get
				{
					return logSyncTime;
				}
				set	
				{
					logSyncTime = value;
				}
			}

			[JsonProperty(PropertyName = "NodeType")]
			public string NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			[JsonProperty(PropertyName = "ZoneId")]
			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			[JsonProperty(PropertyName = "SyncStatus")]
			public string SyncStatus
			{
				get
				{
					return syncStatus;
				}
				set	
				{
					syncStatus = value;
				}
			}

			[JsonProperty(PropertyName = "DataSyncTime")]
			public string DataSyncTime
			{
				get
				{
					return dataSyncTime;
				}
				set	
				{
					dataSyncTime = value;
				}
			}

			[JsonProperty(PropertyName = "NodeId")]
			public string NodeId
			{
				get
				{
					return nodeId;
				}
				set	
				{
					nodeId = value;
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
		}
	}
}
