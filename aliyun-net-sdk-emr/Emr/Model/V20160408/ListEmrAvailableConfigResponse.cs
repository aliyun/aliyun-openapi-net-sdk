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
	public class ListEmrAvailableConfigResponse : AcsResponse
	{

		private string requestId;

		private List<ListEmrAvailableConfig_EmrMainVersion> emrMainVersionList;

		private List<ListEmrAvailableConfig_SecurityGroup> securityGroupList;

		private List<ListEmrAvailableConfig_VpcInfo> vpcInfoList;

		private List<string> keyPairNameList;

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

		public List<ListEmrAvailableConfig_EmrMainVersion> EmrMainVersionList
		{
			get
			{
				return emrMainVersionList;
			}
			set	
			{
				emrMainVersionList = value;
			}
		}

		public List<ListEmrAvailableConfig_SecurityGroup> SecurityGroupList
		{
			get
			{
				return securityGroupList;
			}
			set	
			{
				securityGroupList = value;
			}
		}

		public List<ListEmrAvailableConfig_VpcInfo> VpcInfoList
		{
			get
			{
				return vpcInfoList;
			}
			set	
			{
				vpcInfoList = value;
			}
		}

		public List<string> KeyPairNameList
		{
			get
			{
				return keyPairNameList;
			}
			set	
			{
				keyPairNameList = value;
			}
		}

		public class ListEmrAvailableConfig_EmrMainVersion
		{

			private string regionId;

			private string mainVersionName;

			private bool? ecmVersion;

			private string stackName;

			private string stackVersion;

			private string extraInfo;

			private bool? onCloudNative;

			private string publishType;

			private List<ListEmrAvailableConfig_ClusterTypeInfo> clusterTypeInfoList;

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

			public string MainVersionName
			{
				get
				{
					return mainVersionName;
				}
				set	
				{
					mainVersionName = value;
				}
			}

			public bool? EcmVersion
			{
				get
				{
					return ecmVersion;
				}
				set	
				{
					ecmVersion = value;
				}
			}

			public string StackName
			{
				get
				{
					return stackName;
				}
				set	
				{
					stackName = value;
				}
			}

			public string StackVersion
			{
				get
				{
					return stackVersion;
				}
				set	
				{
					stackVersion = value;
				}
			}

			public string ExtraInfo
			{
				get
				{
					return extraInfo;
				}
				set	
				{
					extraInfo = value;
				}
			}

			public bool? OnCloudNative
			{
				get
				{
					return onCloudNative;
				}
				set	
				{
					onCloudNative = value;
				}
			}

			public string PublishType
			{
				get
				{
					return publishType;
				}
				set	
				{
					publishType = value;
				}
			}

			public List<ListEmrAvailableConfig_ClusterTypeInfo> ClusterTypeInfoList
			{
				get
				{
					return clusterTypeInfoList;
				}
				set	
				{
					clusterTypeInfoList = value;
				}
			}

			public class ListEmrAvailableConfig_ClusterTypeInfo
			{

				private string clusterType;

				private List<ListEmrAvailableConfig_ClusterServiceInfo> clusterServiceInfoList;

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

				public List<ListEmrAvailableConfig_ClusterServiceInfo> ClusterServiceInfoList
				{
					get
					{
						return clusterServiceInfoList;
					}
					set	
					{
						clusterServiceInfoList = value;
					}
				}

				public class ListEmrAvailableConfig_ClusterServiceInfo
				{

					private string serviceName;

					private string serviceDisplayName;

					private string serviceVersion;

					private bool? mandatory;

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

					public string ServiceDisplayName
					{
						get
						{
							return serviceDisplayName;
						}
						set	
						{
							serviceDisplayName = value;
						}
					}

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

					public bool? Mandatory
					{
						get
						{
							return mandatory;
						}
						set	
						{
							mandatory = value;
						}
					}
				}
			}
		}

		public class ListEmrAvailableConfig_SecurityGroup
		{

			private string securityGroupId;

			private string description;

			private string securityGroupName;

			private string vpcId;

			private string creationTime;

			private string securityGroupType;

			private int? availableInstanceAmount;

			private int? ecsCount;

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

			public string SecurityGroupName
			{
				get
				{
					return securityGroupName;
				}
				set	
				{
					securityGroupName = value;
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

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string SecurityGroupType
			{
				get
				{
					return securityGroupType;
				}
				set	
				{
					securityGroupType = value;
				}
			}

			public int? AvailableInstanceAmount
			{
				get
				{
					return availableInstanceAmount;
				}
				set	
				{
					availableInstanceAmount = value;
				}
			}

			public int? EcsCount
			{
				get
				{
					return ecsCount;
				}
				set	
				{
					ecsCount = value;
				}
			}
		}

		public class ListEmrAvailableConfig_VpcInfo
		{

			private string vpcId;

			private string vpcName;

			private string cidrBlock;

			private string creationTime;

			private string vRouterId;

			private string description;

			private List<ListEmrAvailableConfig_VswitchInfo> vswitchInfoList;

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

			public string VpcName
			{
				get
				{
					return vpcName;
				}
				set	
				{
					vpcName = value;
				}
			}

			public string CidrBlock
			{
				get
				{
					return cidrBlock;
				}
				set	
				{
					cidrBlock = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string VRouterId
			{
				get
				{
					return vRouterId;
				}
				set	
				{
					vRouterId = value;
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

			public List<ListEmrAvailableConfig_VswitchInfo> VswitchInfoList
			{
				get
				{
					return vswitchInfoList;
				}
				set	
				{
					vswitchInfoList = value;
				}
			}

			public class ListEmrAvailableConfig_VswitchInfo
			{

				private string vpcId;

				private string vswitchId;

				private string vswitchName;

				private string zoneId;

				private string cidrBlock;

				private long? availableIpAddressCount;

				private string description;

				private string creationTime;

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

				public string VswitchId
				{
					get
					{
						return vswitchId;
					}
					set	
					{
						vswitchId = value;
					}
				}

				public string VswitchName
				{
					get
					{
						return vswitchName;
					}
					set	
					{
						vswitchName = value;
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

				public string CidrBlock
				{
					get
					{
						return cidrBlock;
					}
					set	
					{
						cidrBlock = value;
					}
				}

				public long? AvailableIpAddressCount
				{
					get
					{
						return availableIpAddressCount;
					}
					set	
					{
						availableIpAddressCount = value;
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

				public string CreationTime
				{
					get
					{
						return creationTime;
					}
					set	
					{
						creationTime = value;
					}
				}
			}
		}
	}
}
