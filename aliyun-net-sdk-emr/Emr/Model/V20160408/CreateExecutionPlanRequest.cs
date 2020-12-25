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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class CreateExecutionPlanRequest : RpcAcsRequest<CreateExecutionPlanResponse>
    {
        public CreateExecutionPlanRequest()
            : base("Emr", "2016-04-08", "CreateExecutionPlan", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? timeInterval;

		private string logPath;

		private string clusterName;

		private string configurations;

		private bool? createClusterOnDemand;

		private long? startTime;

		private List<BootstrapAction> bootstrapActions = new List<BootstrapAction>(){ };

		private string emrVer;

		private bool? isOpenPublicIp;

		private string instanceGeneration;

		private string clusterType;

		private string vSwitchId;

		private List<string> optionSoftWareLists = new List<string>(){ };

		private string netType;

		private List<EcsOrder> ecsOrders = new List<EcsOrder>(){ };

		private string name;

		private string zoneId;

		private bool? useCustomHiveMetaDB;

		private bool? initCustomHiveMetaDB;

		private bool? ioOptimized;

		private string securityGroupId;

		private bool? easEnable;

		private List<string> jobIdLists = new List<string>(){ };

		private string dayOfMonth;

		private bool? useLocalMetaDb;

		private string userDefinedEmrEcsRole;

		private string clusterId;

		private string timeUnit;

		private string vpcId;

		private string workflowDefinition;

		private string dayOfWeek;

		private string strategy;

		private List<Config> configs = new List<Config>(){ };

		private bool? highAvailabilityEnable;

		private bool? logEnable;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "TimeInterval", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "LogPath", value);
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
				DictionaryUtil.Add(QueryParameters, "ClusterName", value);
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
				DictionaryUtil.Add(QueryParameters, "Configurations", value);
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
				DictionaryUtil.Add(QueryParameters, "CreateClusterOnDemand", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "StartTime", value.ToString());
			}
		}

		public List<BootstrapAction> BootstrapActions
		{
			get
			{
				return bootstrapActions;
			}

			set
			{
				bootstrapActions = value;
				for (int i = 0; i < bootstrapActions.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".Path", bootstrapActions[i].Path);
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".ExecutionTarget", bootstrapActions[i].ExecutionTarget);
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".ExecutionMoment", bootstrapActions[i].ExecutionMoment);
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".Arg", bootstrapActions[i].Arg);
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".Name", bootstrapActions[i].Name);
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".ExecutionFailStrategy", bootstrapActions[i].ExecutionFailStrategy);
				}
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
				DictionaryUtil.Add(QueryParameters, "EmrVer", value);
			}
		}

		public bool? IsOpenPublicIp
		{
			get
			{
				return isOpenPublicIp;
			}
			set	
			{
				isOpenPublicIp = value;
				DictionaryUtil.Add(QueryParameters, "IsOpenPublicIp", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "InstanceGeneration", value);
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
				DictionaryUtil.Add(QueryParameters, "ClusterType", value);
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
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public List<string> OptionSoftWareLists
		{
			get
			{
				return optionSoftWareLists;
			}

			set
			{
				optionSoftWareLists = value;
				for (int i = 0; i < optionSoftWareLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OptionSoftWareList." + (i + 1) , optionSoftWareLists[i]);
				}
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
				DictionaryUtil.Add(QueryParameters, "NetType", value);
			}
		}

		public List<EcsOrder> EcsOrders
		{
			get
			{
				return ecsOrders;
			}

			set
			{
				ecsOrders = value;
				for (int i = 0; i < ecsOrders.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"EcsOrder." + (i + 1) + ".NodeType", ecsOrders[i].NodeType);
					DictionaryUtil.Add(QueryParameters,"EcsOrder." + (i + 1) + ".DiskCount", ecsOrders[i].DiskCount);
					DictionaryUtil.Add(QueryParameters,"EcsOrder." + (i + 1) + ".NodeCount", ecsOrders[i].NodeCount);
					DictionaryUtil.Add(QueryParameters,"EcsOrder." + (i + 1) + ".DiskCapacity", ecsOrders[i].DiskCapacity);
					DictionaryUtil.Add(QueryParameters,"EcsOrder." + (i + 1) + ".Index", ecsOrders[i].Index);
					DictionaryUtil.Add(QueryParameters,"EcsOrder." + (i + 1) + ".InstanceType", ecsOrders[i].InstanceType);
					DictionaryUtil.Add(QueryParameters,"EcsOrder." + (i + 1) + ".DiskType", ecsOrders[i].DiskType);
				}
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
				DictionaryUtil.Add(QueryParameters, "Name", value);
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
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
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
				DictionaryUtil.Add(QueryParameters, "UseCustomHiveMetaDB", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "InitCustomHiveMetaDB", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
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
				DictionaryUtil.Add(QueryParameters, "EasEnable", value.ToString());
			}
		}

		public List<string> JobIdLists
		{
			get
			{
				return jobIdLists;
			}

			set
			{
				jobIdLists = value;
				for (int i = 0; i < jobIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"JobIdList." + (i + 1) , jobIdLists[i]);
				}
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
				DictionaryUtil.Add(QueryParameters, "DayOfMonth", value);
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
				DictionaryUtil.Add(QueryParameters, "UseLocalMetaDb", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "UserDefinedEmrEcsRole", value);
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
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
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
				DictionaryUtil.Add(QueryParameters, "TimeUnit", value);
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
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public string WorkflowDefinition
		{
			get
			{
				return workflowDefinition;
			}
			set	
			{
				workflowDefinition = value;
				DictionaryUtil.Add(QueryParameters, "WorkflowDefinition", value);
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
				DictionaryUtil.Add(QueryParameters, "DayOfWeek", value);
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
				DictionaryUtil.Add(QueryParameters, "Strategy", value);
			}
		}

		public List<Config> Configs
		{
			get
			{
				return configs;
			}

			set
			{
				configs = value;
				for (int i = 0; i < configs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".ConfigKey", configs[i].ConfigKey);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".FileName", configs[i].FileName);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".Encrypt", configs[i].Encrypt);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".Replace", configs[i].Replace);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".ConfigValue", configs[i].ConfigValue);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".ServiceName", configs[i].ServiceName);
				}
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
				DictionaryUtil.Add(QueryParameters, "HighAvailabilityEnable", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "LogEnable", value.ToString());
			}
		}

		public class BootstrapAction
		{

			private string path;

			private string executionTarget;

			private string executionMoment;

			private string arg;

			private string name;

			private string executionFailStrategy;

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

			public string ExecutionTarget
			{
				get
				{
					return executionTarget;
				}
				set	
				{
					executionTarget = value;
				}
			}

			public string ExecutionMoment
			{
				get
				{
					return executionMoment;
				}
				set	
				{
					executionMoment = value;
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

			public string ExecutionFailStrategy
			{
				get
				{
					return executionFailStrategy;
				}
				set	
				{
					executionFailStrategy = value;
				}
			}
		}

		public class EcsOrder
		{

			private string nodeType;

			private int? diskCount;

			private int? nodeCount;

			private int? diskCapacity;

			private int? index;

			private string instanceType;

			private string diskType;

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
		}

		public class Config
		{

			private string configKey;

			private string fileName;

			private string encrypt;

			private string replace;

			private string configValue;

			private string serviceName;

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

			public string Replace
			{
				get
				{
					return replace;
				}
				set	
				{
					replace = value;
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
		}

        public override CreateExecutionPlanResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateExecutionPlanResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
