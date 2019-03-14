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
	public class DescribeETLJobResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private string name;

		private string description;

		private string categoryId;

		private string graph;

		private List<DescribeETLJob_TriggerRule> triggerRuleList;

		private List<DescribeETLJob_Stage> stageList;

		private List<DescribeETLJob_StageConnection> stageConnectionList;

		private DescribeETLJob_ClusterConfig clusterConfig;

		private DescribeETLJob_AlertConfig alertConfig;

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

		public string Id
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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public string CategoryId
		{
			get
			{
				return categoryId;
			}
			set	
			{
				categoryId = value;
			}
		}

		public string Graph
		{
			get
			{
				return graph;
			}
			set	
			{
				graph = value;
			}
		}

		public List<DescribeETLJob_TriggerRule> TriggerRuleList
		{
			get
			{
				return triggerRuleList;
			}
			set	
			{
				triggerRuleList = value;
			}
		}

		public List<DescribeETLJob_Stage> StageList
		{
			get
			{
				return stageList;
			}
			set	
			{
				stageList = value;
			}
		}

		public List<DescribeETLJob_StageConnection> StageConnectionList
		{
			get
			{
				return stageConnectionList;
			}
			set	
			{
				stageConnectionList = value;
			}
		}

		public DescribeETLJob_ClusterConfig ClusterConfig
		{
			get
			{
				return clusterConfig;
			}
			set	
			{
				clusterConfig = value;
			}
		}

		public DescribeETLJob_AlertConfig AlertConfig
		{
			get
			{
				return alertConfig;
			}
			set	
			{
				alertConfig = value;
			}
		}

		public class DescribeETLJob_TriggerRule
		{

			private bool? enabled;

			private long? startTime;

			private long? endTime;

			private string cronExpr;

			public bool? Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}

			public long? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string CronExpr
			{
				get
				{
					return cronExpr;
				}
				set	
				{
					cronExpr = value;
				}
			}
		}

		public class DescribeETLJob_Stage
		{

			private string stageName;

			private string stageType;

			private string stagePlugin;

			private string stageConf;

			public string StageName
			{
				get
				{
					return stageName;
				}
				set	
				{
					stageName = value;
				}
			}

			public string StageType
			{
				get
				{
					return stageType;
				}
				set	
				{
					stageType = value;
				}
			}

			public string StagePlugin
			{
				get
				{
					return stagePlugin;
				}
				set	
				{
					stagePlugin = value;
				}
			}

			public string StageConf
			{
				get
				{
					return stageConf;
				}
				set	
				{
					stageConf = value;
				}
			}
		}

		public class DescribeETLJob_StageConnection
		{

			private string from;

			private string to;

			private string port;

			public string From
			{
				get
				{
					return from;
				}
				set	
				{
					from = value;
				}
			}

			public string To
			{
				get
				{
					return to;
				}
				set	
				{
					to = value;
				}
			}

			public string Port
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
		}

		public class DescribeETLJob_ClusterConfig
		{

			private bool? isOnDemand;

			private string clusterId;

			private string queue;

			private string userName;

			private long? recordRate;

			private long? sizeRate;

			private DescribeETLJob_DriverResource driverResource;

			private DescribeETLJob_ExecutorResource executorResource;

			public bool? IsOnDemand
			{
				get
				{
					return isOnDemand;
				}
				set	
				{
					isOnDemand = value;
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

			public string Queue
			{
				get
				{
					return queue;
				}
				set	
				{
					queue = value;
				}
			}

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			public long? RecordRate
			{
				get
				{
					return recordRate;
				}
				set	
				{
					recordRate = value;
				}
			}

			public long? SizeRate
			{
				get
				{
					return sizeRate;
				}
				set	
				{
					sizeRate = value;
				}
			}

			public DescribeETLJob_DriverResource DriverResource
			{
				get
				{
					return driverResource;
				}
				set	
				{
					driverResource = value;
				}
			}

			public DescribeETLJob_ExecutorResource ExecutorResource
			{
				get
				{
					return executorResource;
				}
				set	
				{
					executorResource = value;
				}
			}

			public class DescribeETLJob_DriverResource
			{

				private int? vcores;

				private int? memSize;

				public int? Vcores
				{
					get
					{
						return vcores;
					}
					set	
					{
						vcores = value;
					}
				}

				public int? MemSize
				{
					get
					{
						return memSize;
					}
					set	
					{
						memSize = value;
					}
				}
			}

			public class DescribeETLJob_ExecutorResource
			{

				private int? vcores;

				private int? memSize;

				public int? Vcores
				{
					get
					{
						return vcores;
					}
					set	
					{
						vcores = value;
					}
				}

				public int? MemSize
				{
					get
					{
						return memSize;
					}
					set	
					{
						memSize = value;
					}
				}
			}
		}

		public class DescribeETLJob_AlertConfig
		{

			private List<DescribeETLJob_Item> items;

			public List<DescribeETLJob_Item> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class DescribeETLJob_Item
			{

				private bool? enable;

				private string eventId;

				private List<string> alertUserGroupIdList;

				private List<string> alertDingDingGroupIdList;

				public bool? Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string EventId
				{
					get
					{
						return eventId;
					}
					set	
					{
						eventId = value;
					}
				}

				public List<string> AlertUserGroupIdList
				{
					get
					{
						return alertUserGroupIdList;
					}
					set	
					{
						alertUserGroupIdList = value;
					}
				}

				public List<string> AlertDingDingGroupIdList
				{
					get
					{
						return alertDingDingGroupIdList;
					}
					set	
					{
						alertDingDingGroupIdList = value;
					}
				}
			}
		}
	}
}
