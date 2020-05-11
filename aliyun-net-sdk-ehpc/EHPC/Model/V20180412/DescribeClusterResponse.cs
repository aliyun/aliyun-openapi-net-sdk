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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class DescribeClusterResponse : AcsResponse
	{

		private string requestId;

		private DescribeCluster_ClusterInfo clusterInfo;

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

		public DescribeCluster_ClusterInfo ClusterInfo
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

		public class DescribeCluster_ClusterInfo
		{

			private string id;

			private string regionId;

			private string name;

			private string description;

			private string status;

			private string osTag;

			private string accountType;

			private string schedulerType;

			private string createTime;

			private string securityGroupId;

			private string vpcId;

			private string vSwitchId;

			private string volumeType;

			private string volumeId;

			private string volumeProtocol;

			private string volumeMountpoint;

			private string remoteDirectory;

			private string deployMode;

			private bool? haEnable;

			private string ecsChargeType;

			private string keyPairName;

			private string sccClusterId;

			private string clientVersion;

			private string imageOwnerAlias;

			private string imageId;

			private string location;

			private string baseOsTag;

			private string imageName;

			private List<DescribeCluster_ApplicationInfo> applications;

			private List<DescribeCluster_PostInstallScriptInfo> postInstallScripts;

			private DescribeCluster_EcsInfo ecsInfo;

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

			public string OsTag
			{
				get
				{
					return osTag;
				}
				set	
				{
					osTag = value;
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

			public string CreateTime
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

			public string DeployMode
			{
				get
				{
					return deployMode;
				}
				set	
				{
					deployMode = value;
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

			public string BaseOsTag
			{
				get
				{
					return baseOsTag;
				}
				set	
				{
					baseOsTag = value;
				}
			}

			public string ImageName
			{
				get
				{
					return imageName;
				}
				set	
				{
					imageName = value;
				}
			}

			public List<DescribeCluster_ApplicationInfo> Applications
			{
				get
				{
					return applications;
				}
				set	
				{
					applications = value;
				}
			}

			public List<DescribeCluster_PostInstallScriptInfo> PostInstallScripts
			{
				get
				{
					return postInstallScripts;
				}
				set	
				{
					postInstallScripts = value;
				}
			}

			public DescribeCluster_EcsInfo EcsInfo
			{
				get
				{
					return ecsInfo;
				}
				set	
				{
					ecsInfo = value;
				}
			}

			public class DescribeCluster_ApplicationInfo
			{

				private string tag;

				private string name;

				private string version;

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
			}

			public class DescribeCluster_PostInstallScriptInfo
			{

				private string url;

				private string args;

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
			}

			public class DescribeCluster_EcsInfo
			{

				private DescribeCluster_Manager manager;

				private DescribeCluster_Compute compute;

				private DescribeCluster_Login login;

				public DescribeCluster_Manager Manager
				{
					get
					{
						return manager;
					}
					set	
					{
						manager = value;
					}
				}

				public DescribeCluster_Compute Compute
				{
					get
					{
						return compute;
					}
					set	
					{
						compute = value;
					}
				}

				public DescribeCluster_Login Login
				{
					get
					{
						return login;
					}
					set	
					{
						login = value;
					}
				}

				public class DescribeCluster_Manager
				{

					private int? count;

					private string instanceType;

					public int? Count
					{
						get
						{
							return count;
						}
						set	
						{
							count = value;
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
				}

				public class DescribeCluster_Compute
				{

					private int? count;

					private string instanceType;

					public int? Count
					{
						get
						{
							return count;
						}
						set	
						{
							count = value;
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
				}

				public class DescribeCluster_Login
				{

					private int? count;

					private string instanceType;

					public int? Count
					{
						get
						{
							return count;
						}
						set	
						{
							count = value;
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
				}
			}
		}
	}
}
