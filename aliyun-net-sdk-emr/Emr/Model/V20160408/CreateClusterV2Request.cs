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
    public class CreateClusterV2Request : RpcAcsRequest<CreateClusterV2Response>
    {
        public CreateClusterV2Request()
            : base("Emr", "2016-04-08", "CreateClusterV2", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? autoPayOrder;

		private long? resourceOwnerId;

		private string logPath;

		private string masterPwd;

		private string configurations;

		private bool? sshEnable;

		private string keyPairName;

		private string metaStoreType;

		private string securityGroupName;

		private string machineType;

		private string resourceGroupId;

		private List<HostComponentInfo> hostComponentInfos = new List<HostComponentInfo>(){ };

		private string clickHouseConf;

		private List<BootstrapAction> bootstrapActions = new List<BootstrapAction>(){ };

		private string metaStoreConf;

		private string emrVer;

		private List<Tag> tags = new List<Tag>(){ };

		private string authorizeContent;

		private bool? isOpenPublicIp;

		private int? period;

		private string instanceGeneration;

		private string vSwitchId;

		private string clusterType;

		private string extraAttributes;

		private bool? autoRenew;

		private List<string> optionSoftWareLists = new List<string>(){ };

		private string netType;

		private string name;

		private string zoneId;

		private bool? useCustomHiveMetaDB;

		private bool? initCustomHiveMetaDB;

		private bool? ioOptimized;

		private string securityGroupId;

		private bool? easEnable;

		private string depositType;

		private bool? useLocalMetaDb;

		private List<UserInfo> userInfos = new List<UserInfo>(){ };

		private string userDefinedEmrEcsRole;

		private string whiteListType;

		private string relatedClusterId;

		private string vpcId;

		private List<PromotionInfo> promotionInfos = new List<PromotionInfo>(){ };

		private List<HostGroup> hostGroups = new List<HostGroup>(){ };

		private string chargeType;

		private List<ServiceInfo> serviceInfos = new List<ServiceInfo>(){ };

		private List<Config> configs = new List<Config>(){ };

		private bool? highAvailabilityEnable;

		public bool? AutoPayOrder
		{
			get
			{
				return autoPayOrder;
			}
			set	
			{
				autoPayOrder = value;
				DictionaryUtil.Add(QueryParameters, "AutoPayOrder", value.ToString());
			}
		}

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

		public string MasterPwd
		{
			get
			{
				return masterPwd;
			}
			set	
			{
				masterPwd = value;
				DictionaryUtil.Add(QueryParameters, "MasterPwd", value);
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

		public bool? SshEnable
		{
			get
			{
				return sshEnable;
			}
			set	
			{
				sshEnable = value;
				DictionaryUtil.Add(QueryParameters, "SshEnable", value.ToString());
			}
		}

		public string KeyPairName
		{
			get
			{
				return keyPairName;
			}
			set	
			{
				keyPairName = value;
				DictionaryUtil.Add(QueryParameters, "KeyPairName", value);
			}
		}

		public string MetaStoreType
		{
			get
			{
				return metaStoreType;
			}
			set	
			{
				metaStoreType = value;
				DictionaryUtil.Add(QueryParameters, "MetaStoreType", value);
			}
		}

		public string SecurityGroupName
		{
			get
			{
				return securityGroupName;
			}
			set	
			{
				securityGroupName = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupName", value);
			}
		}

		public string MachineType
		{
			get
			{
				return machineType;
			}
			set	
			{
				machineType = value;
				DictionaryUtil.Add(QueryParameters, "MachineType", value);
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public List<HostComponentInfo> HostComponentInfos
		{
			get
			{
				return hostComponentInfos;
			}

			set
			{
				hostComponentInfos = value;
				for (int i = 0; i < hostComponentInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"HostComponentInfo." + (i + 1) + ".HostName", hostComponentInfos[i].HostName);
					for (int j = 0; j < hostComponentInfos[i].ComponentNameLists.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"HostComponentInfo." + (i + 1) + ".ComponentNameList." +(j + 1), hostComponentInfos[i].ComponentNameLists[j]);
					}
					DictionaryUtil.Add(QueryParameters,"HostComponentInfo." + (i + 1) + ".ServiceName", hostComponentInfos[i].ServiceName);
				}
			}
		}

		public string ClickHouseConf
		{
			get
			{
				return clickHouseConf;
			}
			set	
			{
				clickHouseConf = value;
				DictionaryUtil.Add(QueryParameters, "ClickHouseConf", value);
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

		public string MetaStoreConf
		{
			get
			{
				return metaStoreConf;
			}
			set	
			{
				metaStoreConf = value;
				DictionaryUtil.Add(QueryParameters, "MetaStoreConf", value);
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

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
				}
			}
		}

		public string AuthorizeContent
		{
			get
			{
				return authorizeContent;
			}
			set	
			{
				authorizeContent = value;
				DictionaryUtil.Add(QueryParameters, "AuthorizeContent", value);
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

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
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

		public string ExtraAttributes
		{
			get
			{
				return extraAttributes;
			}
			set	
			{
				extraAttributes = value;
				DictionaryUtil.Add(QueryParameters, "ExtraAttributes", value);
			}
		}

		public bool? AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value.ToString());
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

		public string DepositType
		{
			get
			{
				return depositType;
			}
			set	
			{
				depositType = value;
				DictionaryUtil.Add(QueryParameters, "DepositType", value);
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

		public List<UserInfo> UserInfos
		{
			get
			{
				return userInfos;
			}

			set
			{
				userInfos = value;
				for (int i = 0; i < userInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UserInfo." + (i + 1) + ".Password", userInfos[i].Password);
					DictionaryUtil.Add(QueryParameters,"UserInfo." + (i + 1) + ".UserId", userInfos[i].UserId);
					DictionaryUtil.Add(QueryParameters,"UserInfo." + (i + 1) + ".UserName", userInfos[i].UserName);
				}
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

		public string WhiteListType
		{
			get
			{
				return whiteListType;
			}
			set	
			{
				whiteListType = value;
				DictionaryUtil.Add(QueryParameters, "WhiteListType", value);
			}
		}

		public string RelatedClusterId
		{
			get
			{
				return relatedClusterId;
			}
			set	
			{
				relatedClusterId = value;
				DictionaryUtil.Add(QueryParameters, "RelatedClusterId", value);
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

		public List<PromotionInfo> PromotionInfos
		{
			get
			{
				return promotionInfos;
			}

			set
			{
				promotionInfos = value;
				for (int i = 0; i < promotionInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PromotionInfo." + (i + 1) + ".PromotionOptionCode", promotionInfos[i].PromotionOptionCode);
					DictionaryUtil.Add(QueryParameters,"PromotionInfo." + (i + 1) + ".ProductCode", promotionInfos[i].ProductCode);
					DictionaryUtil.Add(QueryParameters,"PromotionInfo." + (i + 1) + ".PromotionOptionNo", promotionInfos[i].PromotionOptionNo);
				}
			}
		}

		public List<HostGroup> HostGroups
		{
			get
			{
				return hostGroups;
			}

			set
			{
				hostGroups = value;
				for (int i = 0; i < hostGroups.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".Period", hostGroups[i].Period);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".SysDiskCapacity", hostGroups[i].SysDiskCapacity);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".DiskCapacity", hostGroups[i].DiskCapacity);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".SysDiskType", hostGroups[i].SysDiskType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".ClusterId", hostGroups[i].ClusterId);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".DiskType", hostGroups[i].DiskType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".HostGroupName", hostGroups[i].HostGroupName);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".VSwitchId", hostGroups[i].VSwitchId);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".DiskCount", hostGroups[i].DiskCount);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".AutoRenew", hostGroups[i].AutoRenew);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".GpuDriver", hostGroups[i].GpuDriver);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".HostGroupId", hostGroups[i].HostGroupId);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".NodeCount", hostGroups[i].NodeCount);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".InstanceType", hostGroups[i].InstanceType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".Comment", hostGroups[i].Comment);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".ChargeType", hostGroups[i].ChargeType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".CreateType", hostGroups[i].CreateType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".HostGroupType", hostGroups[i].HostGroupType);
				}
			}
		}

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
				DictionaryUtil.Add(QueryParameters, "ChargeType", value);
			}
		}

		public List<ServiceInfo> ServiceInfos
		{
			get
			{
				return serviceInfos;
			}

			set
			{
				serviceInfos = value;
				for (int i = 0; i < serviceInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ServiceInfo." + (i + 1) + ".ServiceVersion", serviceInfos[i].ServiceVersion);
					DictionaryUtil.Add(QueryParameters,"ServiceInfo." + (i + 1) + ".ServiceName", serviceInfos[i].ServiceName);
				}
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

		public class HostComponentInfo
		{

			private string hostName;

			private List<string> componentNameLists = new List<string>(){ };

			private string serviceName;

			public string HostName
			{
				get
				{
					return hostName;
				}
				set	
				{
					hostName = value;
				}
			}

			public List<string> ComponentNameLists
			{
				get
				{
					return componentNameLists;
				}
				set	
				{
					componentNameLists = value;
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

		public class Tag
		{

			private string value_;

			private string key;

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

		public class UserInfo
		{

			private string password;

			private string userId;

			private string userName;

			public string Password
			{
				get
				{
					return password;
				}
				set	
				{
					password = value;
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
		}

		public class PromotionInfo
		{

			private string promotionOptionCode;

			private string productCode;

			private string promotionOptionNo;

			public string PromotionOptionCode
			{
				get
				{
					return promotionOptionCode;
				}
				set	
				{
					promotionOptionCode = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public string PromotionOptionNo
			{
				get
				{
					return promotionOptionNo;
				}
				set	
				{
					promotionOptionNo = value;
				}
			}
		}

		public class HostGroup
		{

			private int? period;

			private int? sysDiskCapacity;

			private int? diskCapacity;

			private string sysDiskType;

			private string clusterId;

			private string diskType;

			private string hostGroupName;

			private string vSwitchId;

			private int? diskCount;

			private bool? autoRenew;

			private string gpuDriver;

			private string hostGroupId;

			private int? nodeCount;

			private string instanceType;

			private string comment;

			private string chargeType;

			private string createType;

			private string hostGroupType;

			public int? Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public int? SysDiskCapacity
			{
				get
				{
					return sysDiskCapacity;
				}
				set	
				{
					sysDiskCapacity = value;
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

			public string SysDiskType
			{
				get
				{
					return sysDiskType;
				}
				set	
				{
					sysDiskType = value;
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

			public string HostGroupName
			{
				get
				{
					return hostGroupName;
				}
				set	
				{
					hostGroupName = value;
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

			public bool? AutoRenew
			{
				get
				{
					return autoRenew;
				}
				set	
				{
					autoRenew = value;
				}
			}

			public string GpuDriver
			{
				get
				{
					return gpuDriver;
				}
				set	
				{
					gpuDriver = value;
				}
			}

			public string HostGroupId
			{
				get
				{
					return hostGroupId;
				}
				set	
				{
					hostGroupId = value;
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

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public string CreateType
			{
				get
				{
					return createType;
				}
				set	
				{
					createType = value;
				}
			}

			public string HostGroupType
			{
				get
				{
					return hostGroupType;
				}
				set	
				{
					hostGroupType = value;
				}
			}
		}

		public class ServiceInfo
		{

			private string serviceVersion;

			private string serviceName;

			public string ServiceVersion
			{
				get
				{
					return serviceVersion;
				}
				set	
				{
					serviceVersion = value;
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

        public override CreateClusterV2Response GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateClusterV2ResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
