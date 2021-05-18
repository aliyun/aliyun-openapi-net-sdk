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
using Aliyun.Acs.EHPC;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class CreateClusterRequest : RpcAcsRequest<CreateClusterResponse>
    {
        public CreateClusterRequest()
            : base("EHPC", "2018-04-12", "CreateCluster")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointRegionalType, null);
            }
        }

		private List<AdditionalVolumes> additionalVolumess = new List<AdditionalVolumes>(){ };

		private string ecsOrderManagerInstanceType;

		private string keyPairName;

		private string securityGroupName;

		private string imageOwnerAlias;

		private string deployMode;

		private int? ecsOrderManagerCount;

		private string resourceGroupId;

		private string password;

		private int? ecsOrderLoginCount;

		private bool? withoutElasticIp;

		private string remoteVisEnable;

		private int? systemDiskSize;

		private string computeSpotPriceLimit;

		private int? autoRenewPeriod;

		private int? period;

		private string remoteDirectory;

		private int? ecsOrderComputeCount;

		private string computeSpotStrategy;

		private List<PostInstallScript> postInstallScripts = new List<PostInstallScript>(){ };

		private string vSwitchId;

		private string periodUnit;

		private bool? computeEnableHt;

		private string autoRenew;

		private string name;

		private string volumeId;

		private string zoneId;

		private string sccClusterId;

		private string imageId;

		private string systemDiskLevel;

		private string clientToken;

		private string ehpcVersion;

		private string accountType;

		private string securityGroupId;

		private string description;

		private string ecsOrderComputeInstanceType;

		private string jobQueue;

		private string volumeType;

		private string systemDiskType;

		private string volumeProtocol;

		private string clientVersion;

		private string osTag;

		private bool? isComputeEss;

		private List<Application> applications = new List<Application>(){ };

		private string ecsChargeType;

		private string inputFileUrl;

		private string vpcId;

		private bool? haEnable;

		private string schedulerType;

		private string volumeMountpoint;

		private string ecsOrderLoginInstanceType;

		public List<AdditionalVolumes> AdditionalVolumess
		{
			get
			{
				return additionalVolumess;
			}

			set
			{
				additionalVolumess = value;
				for (int i = 0; i < additionalVolumess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".VolumeType", additionalVolumess[i].VolumeType);
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".VolumeProtocol", additionalVolumess[i].VolumeProtocol);
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".LocalDirectory", additionalVolumess[i].LocalDirectory);
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".RemoteDirectory", additionalVolumess[i].RemoteDirectory);
					for (int j = 0; j < additionalVolumess[i].Roless.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".Roles." +(j + 1), additionalVolumess[i].Roless[j]);
					}
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".VolumeId", additionalVolumess[i].VolumeId);
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".VolumeMountpoint", additionalVolumess[i].VolumeMountpoint);
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".Location", additionalVolumess[i].Location);
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".JobQueue", additionalVolumess[i].JobQueue);
				}
			}
		}

		public string EcsOrderManagerInstanceType
		{
			get
			{
				return ecsOrderManagerInstanceType;
			}
			set	
			{
				ecsOrderManagerInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "EcsOrder.Manager.InstanceType", value);
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

		public string ImageOwnerAlias
		{
			get
			{
				return imageOwnerAlias;
			}
			set	
			{
				imageOwnerAlias = value;
				DictionaryUtil.Add(QueryParameters, "ImageOwnerAlias", value);
			}
		}

		public string DeployMode
		{
			get
			{
				return deployMode;
			}
			set	
			{
				deployMode = value;
				DictionaryUtil.Add(QueryParameters, "DeployMode", value);
			}
		}

		public int? EcsOrderManagerCount
		{
			get
			{
				return ecsOrderManagerCount;
			}
			set	
			{
				ecsOrderManagerCount = value;
				DictionaryUtil.Add(QueryParameters, "EcsOrder.Manager.Count", value.ToString());
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

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public int? EcsOrderLoginCount
		{
			get
			{
				return ecsOrderLoginCount;
			}
			set	
			{
				ecsOrderLoginCount = value;
				DictionaryUtil.Add(QueryParameters, "EcsOrder.Login.Count", value.ToString());
			}
		}

		public bool? WithoutElasticIp
		{
			get
			{
				return withoutElasticIp;
			}
			set	
			{
				withoutElasticIp = value;
				DictionaryUtil.Add(QueryParameters, "WithoutElasticIp", value.ToString());
			}
		}

		public string RemoteVisEnable
		{
			get
			{
				return remoteVisEnable;
			}
			set	
			{
				remoteVisEnable = value;
				DictionaryUtil.Add(QueryParameters, "RemoteVisEnable", value);
			}
		}

		public int? SystemDiskSize
		{
			get
			{
				return systemDiskSize;
			}
			set	
			{
				systemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskSize", value.ToString());
			}
		}

		public string ComputeSpotPriceLimit
		{
			get
			{
				return computeSpotPriceLimit;
			}
			set	
			{
				computeSpotPriceLimit = value;
				DictionaryUtil.Add(QueryParameters, "ComputeSpotPriceLimit", value);
			}
		}

		public int? AutoRenewPeriod
		{
			get
			{
				return autoRenewPeriod;
			}
			set	
			{
				autoRenewPeriod = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenewPeriod", value.ToString());
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

		public string RemoteDirectory
		{
			get
			{
				return remoteDirectory;
			}
			set	
			{
				remoteDirectory = value;
				DictionaryUtil.Add(QueryParameters, "RemoteDirectory", value);
			}
		}

		public int? EcsOrderComputeCount
		{
			get
			{
				return ecsOrderComputeCount;
			}
			set	
			{
				ecsOrderComputeCount = value;
				DictionaryUtil.Add(QueryParameters, "EcsOrder.Compute.Count", value.ToString());
			}
		}

		public string ComputeSpotStrategy
		{
			get
			{
				return computeSpotStrategy;
			}
			set	
			{
				computeSpotStrategy = value;
				DictionaryUtil.Add(QueryParameters, "ComputeSpotStrategy", value);
			}
		}

		public List<PostInstallScript> PostInstallScripts
		{
			get
			{
				return postInstallScripts;
			}

			set
			{
				postInstallScripts = value;
				for (int i = 0; i < postInstallScripts.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PostInstallScript." + (i + 1) + ".Args", postInstallScripts[i].Args);
					DictionaryUtil.Add(QueryParameters,"PostInstallScript." + (i + 1) + ".Url", postInstallScripts[i].Url);
				}
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

		public string PeriodUnit
		{
			get
			{
				return periodUnit;
			}
			set	
			{
				periodUnit = value;
				DictionaryUtil.Add(QueryParameters, "PeriodUnit", value);
			}
		}

		public bool? ComputeEnableHt
		{
			get
			{
				return computeEnableHt;
			}
			set	
			{
				computeEnableHt = value;
				DictionaryUtil.Add(QueryParameters, "ComputeEnableHt", value.ToString());
			}
		}

		public string AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value);
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

		public string VolumeId
		{
			get
			{
				return volumeId;
			}
			set	
			{
				volumeId = value;
				DictionaryUtil.Add(QueryParameters, "VolumeId", value);
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

		public string SccClusterId
		{
			get
			{
				return sccClusterId;
			}
			set	
			{
				sccClusterId = value;
				DictionaryUtil.Add(QueryParameters, "SccClusterId", value);
			}
		}

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		public string SystemDiskLevel
		{
			get
			{
				return systemDiskLevel;
			}
			set	
			{
				systemDiskLevel = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskLevel", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string EhpcVersion
		{
			get
			{
				return ehpcVersion;
			}
			set	
			{
				ehpcVersion = value;
				DictionaryUtil.Add(QueryParameters, "EhpcVersion", value);
			}
		}

		public string AccountType
		{
			get
			{
				return accountType;
			}
			set	
			{
				accountType = value;
				DictionaryUtil.Add(QueryParameters, "AccountType", value);
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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string EcsOrderComputeInstanceType
		{
			get
			{
				return ecsOrderComputeInstanceType;
			}
			set	
			{
				ecsOrderComputeInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "EcsOrder.Compute.InstanceType", value);
			}
		}

		public string JobQueue
		{
			get
			{
				return jobQueue;
			}
			set	
			{
				jobQueue = value;
				DictionaryUtil.Add(QueryParameters, "JobQueue", value);
			}
		}

		public string VolumeType
		{
			get
			{
				return volumeType;
			}
			set	
			{
				volumeType = value;
				DictionaryUtil.Add(QueryParameters, "VolumeType", value);
			}
		}

		public string SystemDiskType
		{
			get
			{
				return systemDiskType;
			}
			set	
			{
				systemDiskType = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskType", value);
			}
		}

		public string VolumeProtocol
		{
			get
			{
				return volumeProtocol;
			}
			set	
			{
				volumeProtocol = value;
				DictionaryUtil.Add(QueryParameters, "VolumeProtocol", value);
			}
		}

		public string ClientVersion
		{
			get
			{
				return clientVersion;
			}
			set	
			{
				clientVersion = value;
				DictionaryUtil.Add(QueryParameters, "ClientVersion", value);
			}
		}

		public string OsTag
		{
			get
			{
				return osTag;
			}
			set	
			{
				osTag = value;
				DictionaryUtil.Add(QueryParameters, "OsTag", value);
			}
		}

		public bool? IsComputeEss
		{
			get
			{
				return isComputeEss;
			}
			set	
			{
				isComputeEss = value;
				DictionaryUtil.Add(QueryParameters, "IsComputeEss", value.ToString());
			}
		}

		public List<Application> Applications
		{
			get
			{
				return applications;
			}

			set
			{
				applications = value;
				for (int i = 0; i < applications.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Application." + (i + 1) + ".Tag", applications[i].Tag);
				}
			}
		}

		public string EcsChargeType
		{
			get
			{
				return ecsChargeType;
			}
			set	
			{
				ecsChargeType = value;
				DictionaryUtil.Add(QueryParameters, "EcsChargeType", value);
			}
		}

		public string InputFileUrl
		{
			get
			{
				return inputFileUrl;
			}
			set	
			{
				inputFileUrl = value;
				DictionaryUtil.Add(QueryParameters, "InputFileUrl", value);
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

		public bool? HaEnable
		{
			get
			{
				return haEnable;
			}
			set	
			{
				haEnable = value;
				DictionaryUtil.Add(QueryParameters, "HaEnable", value.ToString());
			}
		}

		public string SchedulerType
		{
			get
			{
				return schedulerType;
			}
			set	
			{
				schedulerType = value;
				DictionaryUtil.Add(QueryParameters, "SchedulerType", value);
			}
		}

		public string VolumeMountpoint
		{
			get
			{
				return volumeMountpoint;
			}
			set	
			{
				volumeMountpoint = value;
				DictionaryUtil.Add(QueryParameters, "VolumeMountpoint", value);
			}
		}

		public string EcsOrderLoginInstanceType
		{
			get
			{
				return ecsOrderLoginInstanceType;
			}
			set	
			{
				ecsOrderLoginInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "EcsOrder.Login.InstanceType", value);
			}
		}

		public class AdditionalVolumes
		{

			private string volumeType;

			private string volumeProtocol;

			private string localDirectory;

			private string remoteDirectory;

			private List<Roles> roless = new List<Roles>(){ };

			private string volumeId;

			private string volumeMountpoint;

			private string location;

			private string jobQueue;

			public string VolumeType
			{
				get
				{
					return volumeType;
				}
				set	
				{
					volumeType = value;
				}
			}

			public string VolumeProtocol
			{
				get
				{
					return volumeProtocol;
				}
				set	
				{
					volumeProtocol = value;
				}
			}

			public string LocalDirectory
			{
				get
				{
					return localDirectory;
				}
				set	
				{
					localDirectory = value;
				}
			}

			public string RemoteDirectory
			{
				get
				{
					return remoteDirectory;
				}
				set	
				{
					remoteDirectory = value;
				}
			}

			public List<Roles> Roless
			{
				get
				{
					return roless;
				}
				set	
				{
					roless = value;
				}
			}

			public string VolumeId
			{
				get
				{
					return volumeId;
				}
				set	
				{
					volumeId = value;
				}
			}

			public string VolumeMountpoint
			{
				get
				{
					return volumeMountpoint;
				}
				set	
				{
					volumeMountpoint = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string JobQueue
			{
				get
				{
					return jobQueue;
				}
				set	
				{
					jobQueue = value;
				}
			}

			public class Roles
			{

				private string name;

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
		}

		public class PostInstallScript
		{

			private string args;

			private string url;

			public string Args
			{
				get
				{
					return args;
				}
				set	
				{
					args = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}
		}

		public class Application
		{

			private string tag;

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}
		}

        public override CreateClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
