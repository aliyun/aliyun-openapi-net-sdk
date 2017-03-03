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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstanceHAConfigResponse : AcsResponse
	{

		private string dBInstanceId;

		private string syncMode;

		private string hAMode;

		private List<NodeInfo> hostInstanceInfos;

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

		public List<NodeInfo> HostInstanceInfos
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

		public class NodeInfo{

			private string nodeId;

			private string regionId;

			private string logSyncTime;

			private string dataSyncTime;

			private string nodeType;

			private string zoneId;

			private string syncStatus;

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
		}
	}
}