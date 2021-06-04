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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeInstancesResponse : AcsResponse
	{

		private string nextToken;

		private int? pageSize;

		private int? pageNumber;

		private string requestId;

		private int? totalCount;

		private List<DescribeInstances_Instance> instances;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribeInstances_Instance> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public class DescribeInstances_Instance
		{

			private string creationTime;

			private string serialNumber;

			private string status;

			private string deploymentSetId;

			private string keyPairName;

			private string saleCycle;

			private string spotStrategy;

			private bool? deviceAvailable;

			private long? localStorageCapacity;

			private string description;

			private int? spotDuration;

			private string instanceNetworkType;

			private string instanceName;

			private string oSNameEn;

			private string hpcClusterId;

			private float? spotPriceLimit;

			private int? memory;

			private string oSName;

			private int? deploymentSetGroupNo;

			private string imageId;

			private string vlanId;

			private string clusterId;

			private string gPUSpec;

			private string autoReleaseTime;

			private bool? deletionProtection;

			private string stoppedMode;

			private int? gPUAmount;

			private string hostName;

			private string instanceId;

			private int? internetMaxBandwidthOut;

			private int? internetMaxBandwidthIn;

			private string instanceType;

			private string instanceChargeType;

			private string regionId;

			private bool? ioOptimized;

			private string startTime;

			private int? cpu;

			private int? localStorageAmount;

			private string expiredTime;

			private string resourceGroupId;

			private string internetChargeType;

			private string zoneId;

			private bool? recyclable;

			private string iSP;

			private string creditSpecification;

			private string instanceTypeFamily;

			private string oSType;

			private List<DescribeInstances_NetworkInterface> networkInterfaces;

			private List<DescribeInstances_LockReason> operationLocks;

			private List<DescribeInstances_Tag> tags;

			private List<string> rdmaIpAddress;

			private List<string> securityGroupIds;

			private List<string> publicIpAddress;

			private List<string> innerIpAddress;

			private DescribeInstances_VpcAttributes vpcAttributes;

			private DescribeInstances_EipAddress eipAddress;

			private DescribeInstances_HibernationOptions hibernationOptions;

			private DescribeInstances_DedicatedHostAttribute dedicatedHostAttribute;

			private DescribeInstances_EcsCapacityReservationAttr ecsCapacityReservationAttr;

			private DescribeInstances_DedicatedInstanceAttribute dedicatedInstanceAttribute;

			private DescribeInstances_CpuOptions cpuOptions;

			private DescribeInstances_MetadataOptions metadataOptions;

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

			public string SerialNumber
			{
				get
				{
					return serialNumber;
				}
				set	
				{
					serialNumber = value;
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

			public string DeploymentSetId
			{
				get
				{
					return deploymentSetId;
				}
				set	
				{
					deploymentSetId = value;
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

			public string SaleCycle
			{
				get
				{
					return saleCycle;
				}
				set	
				{
					saleCycle = value;
				}
			}

			public string SpotStrategy
			{
				get
				{
					return spotStrategy;
				}
				set	
				{
					spotStrategy = value;
				}
			}

			public bool? DeviceAvailable
			{
				get
				{
					return deviceAvailable;
				}
				set	
				{
					deviceAvailable = value;
				}
			}

			public long? LocalStorageCapacity
			{
				get
				{
					return localStorageCapacity;
				}
				set	
				{
					localStorageCapacity = value;
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

			public int? SpotDuration
			{
				get
				{
					return spotDuration;
				}
				set	
				{
					spotDuration = value;
				}
			}

			public string InstanceNetworkType
			{
				get
				{
					return instanceNetworkType;
				}
				set	
				{
					instanceNetworkType = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string OSNameEn
			{
				get
				{
					return oSNameEn;
				}
				set	
				{
					oSNameEn = value;
				}
			}

			public string HpcClusterId
			{
				get
				{
					return hpcClusterId;
				}
				set	
				{
					hpcClusterId = value;
				}
			}

			public float? SpotPriceLimit
			{
				get
				{
					return spotPriceLimit;
				}
				set	
				{
					spotPriceLimit = value;
				}
			}

			public int? Memory
			{
				get
				{
					return memory;
				}
				set	
				{
					memory = value;
				}
			}

			public string OSName
			{
				get
				{
					return oSName;
				}
				set	
				{
					oSName = value;
				}
			}

			public int? DeploymentSetGroupNo
			{
				get
				{
					return deploymentSetGroupNo;
				}
				set	
				{
					deploymentSetGroupNo = value;
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

			public string VlanId
			{
				get
				{
					return vlanId;
				}
				set	
				{
					vlanId = value;
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

			public string GPUSpec
			{
				get
				{
					return gPUSpec;
				}
				set	
				{
					gPUSpec = value;
				}
			}

			public string AutoReleaseTime
			{
				get
				{
					return autoReleaseTime;
				}
				set	
				{
					autoReleaseTime = value;
				}
			}

			public bool? DeletionProtection
			{
				get
				{
					return deletionProtection;
				}
				set	
				{
					deletionProtection = value;
				}
			}

			public string StoppedMode
			{
				get
				{
					return stoppedMode;
				}
				set	
				{
					stoppedMode = value;
				}
			}

			public int? GPUAmount
			{
				get
				{
					return gPUAmount;
				}
				set	
				{
					gPUAmount = value;
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

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public int? InternetMaxBandwidthOut
			{
				get
				{
					return internetMaxBandwidthOut;
				}
				set	
				{
					internetMaxBandwidthOut = value;
				}
			}

			public int? InternetMaxBandwidthIn
			{
				get
				{
					return internetMaxBandwidthIn;
				}
				set	
				{
					internetMaxBandwidthIn = value;
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

			public string InstanceChargeType
			{
				get
				{
					return instanceChargeType;
				}
				set	
				{
					instanceChargeType = value;
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

			public string StartTime
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

			public int? Cpu
			{
				get
				{
					return cpu;
				}
				set	
				{
					cpu = value;
				}
			}

			public int? LocalStorageAmount
			{
				get
				{
					return localStorageAmount;
				}
				set	
				{
					localStorageAmount = value;
				}
			}

			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
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
				}
			}

			public string InternetChargeType
			{
				get
				{
					return internetChargeType;
				}
				set	
				{
					internetChargeType = value;
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

			public bool? Recyclable
			{
				get
				{
					return recyclable;
				}
				set	
				{
					recyclable = value;
				}
			}

			public string ISP
			{
				get
				{
					return iSP;
				}
				set	
				{
					iSP = value;
				}
			}

			public string CreditSpecification
			{
				get
				{
					return creditSpecification;
				}
				set	
				{
					creditSpecification = value;
				}
			}

			public string InstanceTypeFamily
			{
				get
				{
					return instanceTypeFamily;
				}
				set	
				{
					instanceTypeFamily = value;
				}
			}

			public string OSType
			{
				get
				{
					return oSType;
				}
				set	
				{
					oSType = value;
				}
			}

			public List<DescribeInstances_NetworkInterface> NetworkInterfaces
			{
				get
				{
					return networkInterfaces;
				}
				set	
				{
					networkInterfaces = value;
				}
			}

			public List<DescribeInstances_LockReason> OperationLocks
			{
				get
				{
					return operationLocks;
				}
				set	
				{
					operationLocks = value;
				}
			}

			public List<DescribeInstances_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<string> RdmaIpAddress
			{
				get
				{
					return rdmaIpAddress;
				}
				set	
				{
					rdmaIpAddress = value;
				}
			}

			public List<string> SecurityGroupIds
			{
				get
				{
					return securityGroupIds;
				}
				set	
				{
					securityGroupIds = value;
				}
			}

			public List<string> PublicIpAddress
			{
				get
				{
					return publicIpAddress;
				}
				set	
				{
					publicIpAddress = value;
				}
			}

			public List<string> InnerIpAddress
			{
				get
				{
					return innerIpAddress;
				}
				set	
				{
					innerIpAddress = value;
				}
			}

			public DescribeInstances_VpcAttributes VpcAttributes
			{
				get
				{
					return vpcAttributes;
				}
				set	
				{
					vpcAttributes = value;
				}
			}

			public DescribeInstances_EipAddress EipAddress
			{
				get
				{
					return eipAddress;
				}
				set	
				{
					eipAddress = value;
				}
			}

			public DescribeInstances_HibernationOptions HibernationOptions
			{
				get
				{
					return hibernationOptions;
				}
				set	
				{
					hibernationOptions = value;
				}
			}

			public DescribeInstances_DedicatedHostAttribute DedicatedHostAttribute
			{
				get
				{
					return dedicatedHostAttribute;
				}
				set	
				{
					dedicatedHostAttribute = value;
				}
			}

			public DescribeInstances_EcsCapacityReservationAttr EcsCapacityReservationAttr
			{
				get
				{
					return ecsCapacityReservationAttr;
				}
				set	
				{
					ecsCapacityReservationAttr = value;
				}
			}

			public DescribeInstances_DedicatedInstanceAttribute DedicatedInstanceAttribute
			{
				get
				{
					return dedicatedInstanceAttribute;
				}
				set	
				{
					dedicatedInstanceAttribute = value;
				}
			}

			public DescribeInstances_CpuOptions CpuOptions
			{
				get
				{
					return cpuOptions;
				}
				set	
				{
					cpuOptions = value;
				}
			}

			public DescribeInstances_MetadataOptions MetadataOptions
			{
				get
				{
					return metadataOptions;
				}
				set	
				{
					metadataOptions = value;
				}
			}

			public class DescribeInstances_NetworkInterface
			{

				private string type;

				private string macAddress;

				private string primaryIpAddress;

				private string networkInterfaceId;

				private List<DescribeInstances_PrivateIpSet> privateIpSets;

				private List<DescribeInstances_Ipv6Set> ipv6Sets;

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

				public string MacAddress
				{
					get
					{
						return macAddress;
					}
					set	
					{
						macAddress = value;
					}
				}

				public string PrimaryIpAddress
				{
					get
					{
						return primaryIpAddress;
					}
					set	
					{
						primaryIpAddress = value;
					}
				}

				public string NetworkInterfaceId
				{
					get
					{
						return networkInterfaceId;
					}
					set	
					{
						networkInterfaceId = value;
					}
				}

				public List<DescribeInstances_PrivateIpSet> PrivateIpSets
				{
					get
					{
						return privateIpSets;
					}
					set	
					{
						privateIpSets = value;
					}
				}

				public List<DescribeInstances_Ipv6Set> Ipv6Sets
				{
					get
					{
						return ipv6Sets;
					}
					set	
					{
						ipv6Sets = value;
					}
				}

				public class DescribeInstances_PrivateIpSet
				{

					private string privateIpAddress;

					private bool? primary;

					public string PrivateIpAddress
					{
						get
						{
							return privateIpAddress;
						}
						set	
						{
							privateIpAddress = value;
						}
					}

					public bool? Primary
					{
						get
						{
							return primary;
						}
						set	
						{
							primary = value;
						}
					}
				}

				public class DescribeInstances_Ipv6Set
				{

					private string ipv6Address;

					public string Ipv6Address
					{
						get
						{
							return ipv6Address;
						}
						set	
						{
							ipv6Address = value;
						}
					}
				}
			}

			public class DescribeInstances_LockReason
			{

				private string lockMsg;

				private string lockReason;

				public string LockMsg
				{
					get
					{
						return lockMsg;
					}
					set	
					{
						lockMsg = value;
					}
				}

				public string LockReason
				{
					get
					{
						return lockReason;
					}
					set	
					{
						lockReason = value;
					}
				}
			}

			public class DescribeInstances_Tag
			{

				private string tagValue;

				private string tagKey;

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}
			}

			public class DescribeInstances_VpcAttributes
			{

				private string vpcId;

				private string natIpAddress;

				private string vSwitchId;

				private List<string> privateIpAddress;

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

				public string NatIpAddress
				{
					get
					{
						return natIpAddress;
					}
					set	
					{
						natIpAddress = value;
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

				public List<string> PrivateIpAddress
				{
					get
					{
						return privateIpAddress;
					}
					set	
					{
						privateIpAddress = value;
					}
				}
			}

			public class DescribeInstances_EipAddress
			{

				private bool? isSupportUnassociate;

				private string internetChargeType;

				private string ipAddress;

				private int? bandwidth;

				private string allocationId;

				public bool? IsSupportUnassociate
				{
					get
					{
						return isSupportUnassociate;
					}
					set	
					{
						isSupportUnassociate = value;
					}
				}

				public string InternetChargeType
				{
					get
					{
						return internetChargeType;
					}
					set	
					{
						internetChargeType = value;
					}
				}

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

				public int? Bandwidth
				{
					get
					{
						return bandwidth;
					}
					set	
					{
						bandwidth = value;
					}
				}

				public string AllocationId
				{
					get
					{
						return allocationId;
					}
					set	
					{
						allocationId = value;
					}
				}
			}

			public class DescribeInstances_HibernationOptions
			{

				private bool? configured;

				public bool? Configured
				{
					get
					{
						return configured;
					}
					set	
					{
						configured = value;
					}
				}
			}

			public class DescribeInstances_DedicatedHostAttribute
			{

				private string dedicatedHostId;

				private string dedicatedHostName;

				private string dedicatedHostClusterId;

				public string DedicatedHostId
				{
					get
					{
						return dedicatedHostId;
					}
					set	
					{
						dedicatedHostId = value;
					}
				}

				public string DedicatedHostName
				{
					get
					{
						return dedicatedHostName;
					}
					set	
					{
						dedicatedHostName = value;
					}
				}

				public string DedicatedHostClusterId
				{
					get
					{
						return dedicatedHostClusterId;
					}
					set	
					{
						dedicatedHostClusterId = value;
					}
				}
			}

			public class DescribeInstances_EcsCapacityReservationAttr
			{

				private string capacityReservationPreference;

				private string capacityReservationId;

				public string CapacityReservationPreference
				{
					get
					{
						return capacityReservationPreference;
					}
					set	
					{
						capacityReservationPreference = value;
					}
				}

				public string CapacityReservationId
				{
					get
					{
						return capacityReservationId;
					}
					set	
					{
						capacityReservationId = value;
					}
				}
			}

			public class DescribeInstances_DedicatedInstanceAttribute
			{

				private string affinity;

				private string tenancy;

				public string Affinity
				{
					get
					{
						return affinity;
					}
					set	
					{
						affinity = value;
					}
				}

				public string Tenancy
				{
					get
					{
						return tenancy;
					}
					set	
					{
						tenancy = value;
					}
				}
			}

			public class DescribeInstances_CpuOptions
			{

				private string numa;

				private int? coreCount;

				private int? threadsPerCore;

				public string Numa
				{
					get
					{
						return numa;
					}
					set	
					{
						numa = value;
					}
				}

				public int? CoreCount
				{
					get
					{
						return coreCount;
					}
					set	
					{
						coreCount = value;
					}
				}

				public int? ThreadsPerCore
				{
					get
					{
						return threadsPerCore;
					}
					set	
					{
						threadsPerCore = value;
					}
				}
			}

			public class DescribeInstances_MetadataOptions
			{

				private string httpEndpoint;

				private int? httpPutResponseHopLimit;

				private string httpTokens;

				public string HttpEndpoint
				{
					get
					{
						return httpEndpoint;
					}
					set	
					{
						httpEndpoint = value;
					}
				}

				public int? HttpPutResponseHopLimit
				{
					get
					{
						return httpPutResponseHopLimit;
					}
					set	
					{
						httpPutResponseHopLimit = value;
					}
				}

				public string HttpTokens
				{
					get
					{
						return httpTokens;
					}
					set	
					{
						httpTokens = value;
					}
				}
			}
		}
	}
}
