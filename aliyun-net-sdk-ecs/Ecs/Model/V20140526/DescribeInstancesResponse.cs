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

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<Instance> instances;

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

		public List<Instance> Instances
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

		public class Instance{

			private string instanceId;

			private string instanceName;

			private string description;

			private string imageId;

			private string regionId;

			private string zoneId;

			private string clusterId;

			private string instanceType;

			private string hostName;

			private Status_ status;

			private string serialNumber;

			private string internetChargeType;

			private int? internetMaxBandwidthIn;

			private int? internetMaxBandwidthOut;

			private string vlanId;

			private string creationTime;

			private string instanceNetworkType;

			private string instanceChargeType;

			private string expiredTime;

			private bool? ioOptimized;

			private bool? deviceAvailable;

			private List<LockReason> operationLocks;

			private List<Tag> tags;

			private List<string> securityGroupIds;

			private List<string> publicIpAddress;

			private List<string> innerIpAddress;

			private VpcAttributes_ vpcAttributes;

			private EipAddress_ eipAddress;

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

			public Status_ Status
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

			public List<LockReason> OperationLocks
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

			public List<Tag> Tags
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

			public VpcAttributes_ VpcAttributes
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

			public EipAddress_ EipAddress
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

			public enum Status_ {
			
					Deleted,
					Stopped,
					Transferring,
					Running,
					Resetting,
					Starting,
					Stopping,
			}

			public class LockReason{

				private string lockReason_;

				public string LockReason_
				{
					get
					{
						return lockReason_;
					}
					set	
					{
						lockReason_ = value;
					}
				}
			}

			public class Tag{

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

			public class VpcAttributes_{

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

			public class EipAddress_{

				private string allocationId;

				private string ipAddress;

				private int? bandwidth;

				private string internetChargeType;

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
			}
		}
	}
}