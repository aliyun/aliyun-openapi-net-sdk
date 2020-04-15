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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeSmartAccessGatewayAttributeResponse : AcsResponse
	{

		private string requestId;

		private string smartAGId;

		private string name;

		private string city;

		private string maxBandwidth;

		private string status;

		private string cidrBlock;

		private string associatedCcnId;

		private string associatedCcnName;

		private string description;

		private long? createTime;

		private long? endTime;

		private string instanceType;

		private string serialNumber;

		private int? securityLockThreshold;

		private long? dataPlan;

		private int? userCount;

		private string routingStrategy;

		private string ipsecStatus;

		private string vpnStatus;

		private string trafficMasterSn;

		private string boxControllerIp;

		private string backupBoxControllerIp;

		private int? upBandwidthWan;

		private int? upBandwidth4G;

		private bool? enableOptimization;

		private bool? optimizationType;

		private string resourceGroupId;

		private List<DescribeSmartAccessGatewayAttribute_Link> links;

		private List<DescribeSmartAccessGatewayAttribute_Device> devices;

		private List<string> aclIds;

		private List<string> qosIds;

		private List<string> flowLogIds;

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

		public string SmartAGId
		{
			get
			{
				return smartAGId;
			}
			set	
			{
				smartAGId = value;
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

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
			}
		}

		public string MaxBandwidth
		{
			get
			{
				return maxBandwidth;
			}
			set	
			{
				maxBandwidth = value;
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

		public string AssociatedCcnId
		{
			get
			{
				return associatedCcnId;
			}
			set	
			{
				associatedCcnId = value;
			}
		}

		public string AssociatedCcnName
		{
			get
			{
				return associatedCcnName;
			}
			set	
			{
				associatedCcnName = value;
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

		public long? CreateTime
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

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
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

		public int? SecurityLockThreshold
		{
			get
			{
				return securityLockThreshold;
			}
			set	
			{
				securityLockThreshold = value;
			}
		}

		public long? DataPlan
		{
			get
			{
				return dataPlan;
			}
			set	
			{
				dataPlan = value;
			}
		}

		public int? UserCount
		{
			get
			{
				return userCount;
			}
			set	
			{
				userCount = value;
			}
		}

		public string RoutingStrategy
		{
			get
			{
				return routingStrategy;
			}
			set	
			{
				routingStrategy = value;
			}
		}

		public string IpsecStatus
		{
			get
			{
				return ipsecStatus;
			}
			set	
			{
				ipsecStatus = value;
			}
		}

		public string VpnStatus
		{
			get
			{
				return vpnStatus;
			}
			set	
			{
				vpnStatus = value;
			}
		}

		public string TrafficMasterSn
		{
			get
			{
				return trafficMasterSn;
			}
			set	
			{
				trafficMasterSn = value;
			}
		}

		public string BoxControllerIp
		{
			get
			{
				return boxControllerIp;
			}
			set	
			{
				boxControllerIp = value;
			}
		}

		public string BackupBoxControllerIp
		{
			get
			{
				return backupBoxControllerIp;
			}
			set	
			{
				backupBoxControllerIp = value;
			}
		}

		public int? UpBandwidthWan
		{
			get
			{
				return upBandwidthWan;
			}
			set	
			{
				upBandwidthWan = value;
			}
		}

		public int? UpBandwidth4G
		{
			get
			{
				return upBandwidth4G;
			}
			set	
			{
				upBandwidth4G = value;
			}
		}

		public bool? EnableOptimization
		{
			get
			{
				return enableOptimization;
			}
			set	
			{
				enableOptimization = value;
			}
		}

		public bool? OptimizationType
		{
			get
			{
				return optimizationType;
			}
			set	
			{
				optimizationType = value;
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

		public List<DescribeSmartAccessGatewayAttribute_Link> Links
		{
			get
			{
				return links;
			}
			set	
			{
				links = value;
			}
		}

		public List<DescribeSmartAccessGatewayAttribute_Device> Devices
		{
			get
			{
				return devices;
			}
			set	
			{
				devices = value;
			}
		}

		public List<string> AclIds
		{
			get
			{
				return aclIds;
			}
			set	
			{
				aclIds = value;
			}
		}

		public List<string> QosIds
		{
			get
			{
				return qosIds;
			}
			set	
			{
				qosIds = value;
			}
		}

		public List<string> FlowLogIds
		{
			get
			{
				return flowLogIds;
			}
			set	
			{
				flowLogIds = value;
			}
		}

		public class DescribeSmartAccessGatewayAttribute_Link
		{

			private string instanceId;

			private string type;

			private string status;

			private long? endTime;

			private string bandwidth;

			private string relateInstanceId;

			private string relateInstanceRegionId;

			private string commodityType;

			private string healthCheckTargetIp;

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

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string Bandwidth
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

			public string RelateInstanceId
			{
				get
				{
					return relateInstanceId;
				}
				set	
				{
					relateInstanceId = value;
				}
			}

			public string RelateInstanceRegionId
			{
				get
				{
					return relateInstanceRegionId;
				}
				set	
				{
					relateInstanceRegionId = value;
				}
			}

			public string CommodityType
			{
				get
				{
					return commodityType;
				}
				set	
				{
					commodityType = value;
				}
			}

			public string HealthCheckTargetIp
			{
				get
				{
					return healthCheckTargetIp;
				}
				set	
				{
					healthCheckTargetIp = value;
				}
			}
		}

		public class DescribeSmartAccessGatewayAttribute_Device
		{

			private string serialNumber;

			private string hcState;

			private string haState;

			private long? softwareVersion;

			private string monitorVersion;

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

			public string HcState
			{
				get
				{
					return hcState;
				}
				set	
				{
					hcState = value;
				}
			}

			public string HaState
			{
				get
				{
					return haState;
				}
				set	
				{
					haState = value;
				}
			}

			public long? SoftwareVersion
			{
				get
				{
					return softwareVersion;
				}
				set	
				{
					softwareVersion = value;
				}
			}

			public string MonitorVersion
			{
				get
				{
					return monitorVersion;
				}
				set	
				{
					monitorVersion = value;
				}
			}
		}
	}
}
