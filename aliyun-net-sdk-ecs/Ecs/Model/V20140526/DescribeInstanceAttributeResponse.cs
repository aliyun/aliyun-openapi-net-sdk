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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeInstanceAttributeResponse : AcsResponse
	{

		private string status;

		private string serialNumber;

		private string creationTime;

		private string requestId;

		private string description;

		private string instanceName;

		private string instanceNetworkType;

		private int? memory;

		private string imageId;

		private string clusterId;

		private string vlanId;

		private string stoppedMode;

		private string hostName;

		private string instanceId;

		private string instanceType;

		private int? internetMaxBandwidthIn;

		private int? internetMaxBandwidthOut;

		private string regionId;

		private string instanceChargeType;

		private string ioOptimized;

		private int? cpu;

		private string expiredTime;

		private string zoneId;

		private string internetChargeType;

		private string creditSpecification;

		private List<DescribeInstanceAttribute_LockReason> operationLocks;

		private List<string> securityGroupIds;

		private List<string> publicIpAddress;

		private List<string> innerIpAddress;

		private DescribeInstanceAttribute_VpcAttributes vpcAttributes;

		private DescribeInstanceAttribute_EipAddress eipAddress;

		private DescribeInstanceAttribute_DedicatedHostAttribute dedicatedHostAttribute;

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

		public string IoOptimized
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

		public List<DescribeInstanceAttribute_LockReason> OperationLocks
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

		public DescribeInstanceAttribute_VpcAttributes VpcAttributes
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

		public DescribeInstanceAttribute_EipAddress EipAddress
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

		public DescribeInstanceAttribute_DedicatedHostAttribute DedicatedHostAttribute
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

		public class DescribeInstanceAttribute_LockReason
		{

			private string lockReason;

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

		public class DescribeInstanceAttribute_VpcAttributes
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

		public class DescribeInstanceAttribute_EipAddress
		{

			private string internetChargeType;

			private string ipAddress;

			private int? bandwidth;

			private string allocationId;

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

		public class DescribeInstanceAttribute_DedicatedHostAttribute
		{

			private string dedicatedHostName;

			private string dedicatedHostId;

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
		}
	}
}
