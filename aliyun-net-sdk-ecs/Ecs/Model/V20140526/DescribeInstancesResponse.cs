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
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeInstances_Instance> instances;

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

			private string instanceId;

			private string instanceName;

			private string description;

			private string imageId;

			private string oSName;

			private string oSType;

			private string regionId;

			private string zoneId;

			private string clusterId;

			private string instanceType;

			private int? cpu;

			private int? memory;

			private string hostName;

			private string status;

			private string serialNumber;

			private string internetChargeType;

			private int? internetMaxBandwidthIn;

			private int? internetMaxBandwidthOut;

			private string vlanId;

			private string creationTime;

			private string instanceNetworkType;

			private string instanceChargeType;

			private string saleCycle;

			private string expiredTime;

			private string autoReleaseTime;

			private bool? ioOptimized;

			private bool? deviceAvailable;

			private string instanceTypeFamily;

			private long? localStorageCapacity;

			private int? localStorageAmount;

			private int? gPUAmount;

			private string gPUSpec;

			private string spotStrategy;

			private float? spotPriceLimit;

			private string resourceGroupId;

			private string keyPairName;

			private bool? recyclable;

			private string hpcClusterId;

			private List<DescribeInstances_NetworkInterface> networkInterfaces;

			private List<DescribeInstances_LockReason> operationLocks;

			private List<DescribeInstances_Tag> tags;

			private List<string> securityGroupIds;

			private List<string> publicIpAddress;

			private List<string> innerIpAddress;

			private List<string> rdmaIpAddress;

			private DescribeInstances_VpcAttributes vpcAttributes;

			private DescribeInstances_EipAddress eipAddress;

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

			public class DescribeInstances_NetworkInterface
			{

				private string networkInterfaceId;

				private string macAddress;

				private string primaryIpAddress;

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
			}

			public class DescribeInstances_LockReason
			{

				private string lockReason;

				private string lockMsg;

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
			}

			public class DescribeInstances_Tag
			{

				private string tagKey;

				private string tagValue;

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
			}

			public class DescribeInstances_VpcAttributes
			{

				private string vpcId;

				private string vSwitchId;

				private string natIpAddress;

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

				private string allocationId;

				private string ipAddress;

				private int? bandwidth;

				private string internetChargeType;

				private bool? isSupportUnassociate;

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
			}
		}
	}
}