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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class CreateHybridClusterRequest : RpcAcsRequest<CreateHybridClusterResponse>
    {
        public CreateHybridClusterRequest()
            : base("EHPC", "2018-04-12", "CreateHybridCluster", "ehs", "openAPI")
        {
        }

		private string ehpcVersion;

		private string securityGroupId;

		private string description;

		private string keyPairName;

		private string securityGroupName;

		private string ecsOrderComputeInstanceType;

		private string onPremiseVolumeRemotePath;

		private string accessKeyId;

		private string volumeType;

		private string password;

		private string onPremiseVolumeMountPoint;

		private string action;

		private string onPremiseVolumeProtocol;

		private string volumeProtocol;

		private string onPremiseVolumeLocalPath;

		private string clientVersion;

		private string osTag;

		private string remoteDirectory;

		private string vSwitchId;

		private string nodes;

		private List<Application> applications;

		private string domain;

		private string vpcId;

		private string name;

		private string volumeId;

		private string volumeMountpoint;

		private string zoneId;

		private string location;

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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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

		public string Nodes
		{
			get
			{
				return nodes;
			}
			set	
			{
				nodes = value;
				DictionaryUtil.Add(QueryParameters, "Nodes", value);
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

        public override CreateHybridClusterResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateHybridClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}