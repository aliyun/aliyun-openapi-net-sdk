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
	public class DescribeExecutionPlanResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private string name;

		private string status;

		private string strategy;

		private int? timeInterval;

		private long? startTime;

		private string timeUnit;

		private string dayOfWeek;

		private string dayOfMonth;

		private bool? createClusterOnDemand;

		private string clusterId;

		private string clusterName;

		private string workflowApp;

		private long? executionPlanVersion;

		private List<DescribeExecutionPlan_JobInfo> jobInfoList;

		private DescribeExecutionPlan_ClusterInfo clusterInfo;

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

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string Strategy
		{
			get
			{
				return strategy;
			}
			set	
			{
				strategy = value;
			}
		}

		public int? TimeInterval
		{
			get
			{
				return timeInterval;
			}
			set	
			{
				timeInterval = value;
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

		public string TimeUnit
		{
			get
			{
				return timeUnit;
			}
			set	
			{
				timeUnit = value;
			}
		}

		public string DayOfWeek
		{
			get
			{
				return dayOfWeek;
			}
			set	
			{
				dayOfWeek = value;
			}
		}

		public string DayOfMonth
		{
			get
			{
				return dayOfMonth;
			}
			set	
			{
				dayOfMonth = value;
			}
		}

		public bool? CreateClusterOnDemand
		{
			get
			{
				return createClusterOnDemand;
			}
			set	
			{
				createClusterOnDemand = value;
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

		public string WorkflowApp
		{
			get
			{
				return workflowApp;
			}
			set	
			{
				workflowApp = value;
			}
		}

		public long? ExecutionPlanVersion
		{
			get
			{
				return executionPlanVersion;
			}
			set	
			{
				executionPlanVersion = value;
			}
		}

		public List<DescribeExecutionPlan_JobInfo> JobInfoList
		{
			get
			{
				return jobInfoList;
			}
			set	
			{
				jobInfoList = value;
			}
		}

		public DescribeExecutionPlan_ClusterInfo ClusterInfo
		{
			get
			{
				return clusterInfo;
			}
			set	
			{
				clusterInfo = value;
			}
		}

		public class DescribeExecutionPlan_JobInfo
		{

			private string id;

			private string name;

			private string type;

			private string runParameter;

			private string failAct;

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

			public string RunParameter
			{
				get
				{
					return runParameter;
				}
				set	
				{
					runParameter = value;
				}
			}

			public string FailAct
			{
				get
				{
					return failAct;
				}
				set	
				{
					failAct = value;
				}
			}
		}

		public class DescribeExecutionPlan_ClusterInfo
		{

			private string name;

			private string zoneId;

			private bool? logEnable;

			private string logPath;

			private string securityGroupId;

			private string emrVer;

			private string clusterType;

			private bool? highAvailabilityEnable;

			private string vpcId;

			private string vSwitchId;

			private string netType;

			private bool? ioOptimized;

			private string instanceGeneration;

			private string configurations;

			private bool? easEnable;

			private bool? useCustomHiveMetaDB;

			private bool? initCustomHiveMetaDB;

			private string userDefinedEmrEcsRole;

			private bool? useLocalMetaDb;

			private List<DescribeExecutionPlan_EcsOrderInfo> ecsOrders;

			private List<DescribeExecutionPlan_BootstrapAction> bootstrapActionList;

			private List<DescribeExecutionPlan_Config> configList;

			private DescribeExecutionPlan_SoftwareInfo softwareInfo;

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

			public bool? LogEnable
			{
				get
				{
					return logEnable;
				}
				set	
				{
					logEnable = value;
				}
			}

			public string LogPath
			{
				get
				{
					return logPath;
				}
				set	
				{
					logPath = value;
				}
			}

			public string SecurityGroupId
			{
				get
				{
					return securityGroupId;
				}
				set	
				{
					securityGroupId = value;
				}
			}

			public string EmrVer
			{
				get
				{
					return emrVer;
				}
				set	
				{
					emrVer = value;
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

			public bool? HighAvailabilityEnable
			{
				get
				{
					return highAvailabilityEnable;
				}
				set	
				{
					highAvailabilityEnable = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public string NetType
			{
				get
				{
					return netType;
				}
				set	
				{
					netType = value;
				}
			}

			public bool? IoOptimized
			{
				get
				{
					return ioOptimized;
				}
				set	
				{
					ioOptimized = value;
				}
			}

			public string InstanceGeneration
			{
				get
				{
					return instanceGeneration;
				}
				set	
				{
					instanceGeneration = value;
				}
			}

			public string Configurations
			{
				get
				{
					return configurations;
				}
				set	
				{
					configurations = value;
				}
			}

			public bool? EasEnable
			{
				get
				{
					return easEnable;
				}
				set	
				{
					easEnable = value;
				}
			}

			public bool? UseCustomHiveMetaDB
			{
				get
				{
					return useCustomHiveMetaDB;
				}
				set	
				{
					useCustomHiveMetaDB = value;
				}
			}

			public bool? InitCustomHiveMetaDB
			{
				get
				{
					return initCustomHiveMetaDB;
				}
				set	
				{
					initCustomHiveMetaDB = value;
				}
			}

			public string UserDefinedEmrEcsRole
			{
				get
				{
					return userDefinedEmrEcsRole;
				}
				set	
				{
					userDefinedEmrEcsRole = value;
				}
			}

			public bool? UseLocalMetaDb
			{
				get
				{
					return useLocalMetaDb;
				}
				set	
				{
					useLocalMetaDb = value;
				}
			}

			public List<DescribeExecutionPlan_EcsOrderInfo> EcsOrders
			{
				get
				{
					return ecsOrders;
				}
				set	
				{
					ecsOrders = value;
				}
			}

			public List<DescribeExecutionPlan_BootstrapAction> BootstrapActionList
			{
				get
				{
					return bootstrapActionList;
				}
				set	
				{
					bootstrapActionList = value;
				}
			}

			public List<DescribeExecutionPlan_Config> ConfigList
			{
				get
				{
					return configList;
				}
				set	
				{
					configList = value;
				}
			}

			public DescribeExecutionPlan_SoftwareInfo SoftwareInfo
			{
				get
				{
					return softwareInfo;
				}
				set	
				{
					softwareInfo = value;
				}
			}

			public class DescribeExecutionPlan_EcsOrderInfo
			{

				private int? index;

				private int? nodeCount;

				private string instanceType;

				private string diskType;

				private int? diskCapacity;

				private string nodeType;

				private int? diskCount;

				public int? Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public int? NodeCount
				{
					get
					{
						return nodeCount;
					}
					set	
					{
						nodeCount = value;
					}
				}

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

				public int? DiskCapacity
				{
					get
					{
						return diskCapacity;
					}
					set	
					{
						diskCapacity = value;
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

				public int? DiskCount
				{
					get
					{
						return diskCount;
					}
					set	
					{
						diskCount = value;
					}
				}
			}

			public class DescribeExecutionPlan_BootstrapAction
			{

				private string name;

				private string path;

				private string arg;

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

				public string Path
				{
					get
					{
						return path;
					}
					set	
					{
						path = value;
					}
				}

				public string Arg
				{
					get
					{
						return arg;
					}
					set	
					{
						arg = value;
					}
				}
			}

			public class DescribeExecutionPlan_Config
			{

				private string serviceName;

				private string fileName;

				private string configKey;

				private string configValue;

				private string encrypt;

				public string ServiceName
				{
					get
					{
						return serviceName;
					}
					set	
					{
						serviceName = value;
					}
				}

				public string FileName
				{
					get
					{
						return fileName;
					}
					set	
					{
						fileName = value;
					}
				}

				public string ConfigKey
				{
					get
					{
						return configKey;
					}
					set	
					{
						configKey = value;
					}
				}

				public string ConfigValue
				{
					get
					{
						return configValue;
					}
					set	
					{
						configValue = value;
					}
				}

				public string Encrypt
				{
					get
					{
						return encrypt;
					}
					set	
					{
						encrypt = value;
					}
				}
			}

			public class DescribeExecutionPlan_SoftwareInfo
			{

				private string emrVer;

				private string clusterType;

				private List<DescribeExecutionPlan_Software> softwares;

				public string EmrVer
				{
					get
					{
						return emrVer;
					}
					set	
					{
						emrVer = value;
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

				public List<DescribeExecutionPlan_Software> Softwares
				{
					get
					{
						return softwares;
					}
					set	
					{
						softwares = value;
					}
				}

				public class DescribeExecutionPlan_Software
				{

					private string displayName;

					private string name;

					private bool? onlyDisplay;

					private int? startTpe;

					private string version;

					private bool? optional;

					public string DisplayName
					{
						get
						{
							return displayName;
						}
						set	
						{
							displayName = value;
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

					public bool? OnlyDisplay
					{
						get
						{
							return onlyDisplay;
						}
						set	
						{
							onlyDisplay = value;
						}
					}

					public int? StartTpe
					{
						get
						{
							return startTpe;
						}
						set	
						{
							startTpe = value;
						}
					}

					public string Version
					{
						get
						{
							return version;
						}
						set	
						{
							version = value;
						}
					}

					public bool? Optional
					{
						get
						{
							return optional;
						}
						set	
						{
							optional = value;
						}
					}
				}
			}
		}
	}
}
