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
    public class ModifyExecutionPlanClusterInfoRequest : RpcAcsRequest<ModifyExecutionPlanClusterInfoResponse>
    {
        public ModifyExecutionPlanClusterInfoRequest()
            : base("Emr", "2016-04-08", "ModifyExecutionPlanClusterInfo", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string logPath;

		private string clusterName;

		private string configurations;

		private bool? ioOptimized;

		private string securityGroupId;

		private bool? easEnable;

		private bool? createClusterOnDemand;

		private string accessKeyId;

		private List<BootstrapAction> bootstrapActions;

		private string regionId;

		private bool? useLocalMetaDb;

		private string emrVer;

		private string id;

		private bool? isOpenPublicIp;

		private string clusterId;

		private string instanceGeneration;

		private string clusterType;

		private string vSwitchId;

		private List<string> optionSoftWareLists;

		private string vpcId;

		private string netType;

		private List<EcsOrder> ecsOrders;

		private string zoneId;

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

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
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
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".Arg", bootstrapActions[i].Arg);
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".Name", bootstrapActions[i].Name);
				}
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
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
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

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
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

			private string arg;

			private string name;

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

        public override ModifyExecutionPlanClusterInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyExecutionPlanClusterInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
