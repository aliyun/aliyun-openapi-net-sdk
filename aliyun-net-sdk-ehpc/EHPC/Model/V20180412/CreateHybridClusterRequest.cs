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
    public class CreateHybridClusterRequest : RpcAcsRequest<CreateHybridClusterResponse>
    {
        public CreateHybridClusterRequest()
            : base("EHPC", "2018-04-12", "CreateHybridCluster")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointRegionalType, null);
            }
        }

		private string keyPairName;

		private bool? multiOs;

		private string securityGroupName;

		private string onPremiseVolumeRemotePath;

		private string imageOwnerAlias;

		private string resourceGroupId;

		private string password;

		private float? computeSpotPriceLimit;

		private string onPremiseVolumeLocalPath;

		private string remoteDirectory;

		private string computeSpotStrategy;

		private List<PostInstallScript> postInstallScripts = new List<PostInstallScript>(){ };

		private string vSwitchId;

		private string domain;

		private string name;

		private string volumeId;

		private string zoneId;

		private string imageId;

		private string clientToken;

		private string ehpcVersion;

		private string securityGroupId;

		private string description;

		private string ecsOrderComputeInstanceType;

		private string jobQueue;

		private string volumeType;

		private string onPremiseVolumeMountPoint;

		private string onPremiseVolumeProtocol;

		private string volumeProtocol;

		private string clientVersion;

		private string osTag;

		private List<Nodes> nodess = new List<Nodes>(){ };

		private List<Application> applications = new List<Application>(){ };

		private string vpcId;

		private string volumeMountpoint;

		private bool? schedulerPreInstall;

		private string location;

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

		public bool? MultiOs
		{
			get
			{
				return multiOs;
			}
			set	
			{
				multiOs = value;
				DictionaryUtil.Add(QueryParameters, "MultiOs", value.ToString());
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

		public string OnPremiseVolumeRemotePath
		{
			get
			{
				return onPremiseVolumeRemotePath;
			}
			set	
			{
				onPremiseVolumeRemotePath = value;
				DictionaryUtil.Add(QueryParameters, "OnPremiseVolumeRemotePath", value);
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

		public float? ComputeSpotPriceLimit
		{
			get
			{
				return computeSpotPriceLimit;
			}
			set	
			{
				computeSpotPriceLimit = value;
				DictionaryUtil.Add(QueryParameters, "ComputeSpotPriceLimit", value.ToString());
			}
		}

		public string OnPremiseVolumeLocalPath
		{
			get
			{
				return onPremiseVolumeLocalPath;
			}
			set	
			{
				onPremiseVolumeLocalPath = value;
				DictionaryUtil.Add(QueryParameters, "OnPremiseVolumeLocalPath", value);
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

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
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

		public string OnPremiseVolumeMountPoint
		{
			get
			{
				return onPremiseVolumeMountPoint;
			}
			set	
			{
				onPremiseVolumeMountPoint = value;
				DictionaryUtil.Add(QueryParameters, "OnPremiseVolumeMountPoint", value);
			}
		}

		public string OnPremiseVolumeProtocol
		{
			get
			{
				return onPremiseVolumeProtocol;
			}
			set	
			{
				onPremiseVolumeProtocol = value;
				DictionaryUtil.Add(QueryParameters, "OnPremiseVolumeProtocol", value);
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

		public List<Nodes> Nodess
		{
			get
			{
				return nodess;
			}

			set
			{
				nodess = value;
				for (int i = 0; i < nodess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Nodes." + (i + 1) + ".IpAddress", nodess[i].IpAddress);
					DictionaryUtil.Add(QueryParameters,"Nodes." + (i + 1) + ".HostName", nodess[i].HostName);
					DictionaryUtil.Add(QueryParameters,"Nodes." + (i + 1) + ".Role", nodess[i].Role);
					DictionaryUtil.Add(QueryParameters,"Nodes." + (i + 1) + ".AccountType", nodess[i].AccountType);
					DictionaryUtil.Add(QueryParameters,"Nodes." + (i + 1) + ".SchedulerType", nodess[i].SchedulerType);
				}
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

		public bool? SchedulerPreInstall
		{
			get
			{
				return schedulerPreInstall;
			}
			set	
			{
				schedulerPreInstall = value;
				DictionaryUtil.Add(QueryParameters, "SchedulerPreInstall", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Location", value);
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

		public class Nodes
		{

			private string ipAddress;

			private string hostName;

			private string role;

			private string accountType;

			private string schedulerType;

			public string IpAddress
			{
				get
				{
					return ipAddress;
				}
				set	
				{
					ipAddress = value;
				}
			}

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

			public string Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
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

        public override CreateHybridClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateHybridClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
