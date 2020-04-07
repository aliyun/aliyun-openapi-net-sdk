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

namespace Aliyun.Acs.ARMS.Model.V20190808
{
	public class ListPromClustersResponse : AcsResponse
	{

		private string requestId;

		private List<ListPromClusters_PromCluster> promClusterList;

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

		public List<ListPromClusters_PromCluster> PromClusterList
		{
			get
			{
				return promClusterList;
			}
			set	
			{
				promClusterList = value;
			}
		}

		public class ListPromClusters_PromCluster
		{

			private long? id;

			private string clusterId;

			private string clusterName;

			private string agentStatus;

			private string clusterType;

			private string controllerId;

			private bool? isControllerInstalled;

			private string userId;

			private string regionId;

			private string pluginsJsonArray;

			private string stateJson;

			private int? nodeNum;

			private long? createTime;

			private long? updateTime;

			private long? lastHeartBeatTime;

			private long? installTime;

			private string extra;

			private string options;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string ClusterName
			{
				get
				{
					return clusterName;
				}
				set	
				{
					clusterName = value;
				}
			}

			public string AgentStatus
			{
				get
				{
					return agentStatus;
				}
				set	
				{
					agentStatus = value;
				}
			}

			public string ClusterType
			{
				get
				{
					return clusterType;
				}
				set	
				{
					clusterType = value;
				}
			}

			public string ControllerId
			{
				get
				{
					return controllerId;
				}
				set	
				{
					controllerId = value;
				}
			}

			public bool? IsControllerInstalled
			{
				get
				{
					return isControllerInstalled;
				}
				set	
				{
					isControllerInstalled = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
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

			public string PluginsJsonArray
			{
				get
				{
					return pluginsJsonArray;
				}
				set	
				{
					pluginsJsonArray = value;
				}
			}

			public string StateJson
			{
				get
				{
					return stateJson;
				}
				set	
				{
					stateJson = value;
				}
			}

			public int? NodeNum
			{
				get
				{
					return nodeNum;
				}
				set	
				{
					nodeNum = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public long? LastHeartBeatTime
			{
				get
				{
					return lastHeartBeatTime;
				}
				set	
				{
					lastHeartBeatTime = value;
				}
			}

			public long? InstallTime
			{
				get
				{
					return installTime;
				}
				set	
				{
					installTime = value;
				}
			}

			public string Extra
			{
				get
				{
					return extra;
				}
				set	
				{
					extra = value;
				}
			}

			public string Options
			{
				get
				{
					return options;
				}
				set	
				{
					options = value;
				}
			}
		}
	}
}
