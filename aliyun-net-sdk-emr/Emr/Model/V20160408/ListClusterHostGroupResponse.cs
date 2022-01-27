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
	public class ListClusterHostGroupResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? total;

		private string clusterId;

		private List<ListClusterHostGroup_HostGroup> hostGroupList;

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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
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

		public List<ListClusterHostGroup_HostGroup> HostGroupList
		{
			get
			{
				return hostGroupList;
			}
			set	
			{
				hostGroupList = value;
			}
		}

		public class ListClusterHostGroup_HostGroup
		{

			private string hostGroupId;

			private string hostGroupName;

			private string hostGroupType;

			private string hostGroupSubType;

			private string instanceType;

			private string systemDiskType;

			private int? systemDiskSize;

			private int? systemDiskCount;

			private string dataDiskType;

			private int? dataDiskSize;

			private int? dataDiskCount;

			private int? cpu;

			private int? memory;

			private string status;

			private string lockType;

			private string lockReason;

			private string payType;

			private string chargeType;

			private int? nodeCount;

			private string vswitchId;

			private string comment;

			private string securityGroupId;

			private string gmtCreate;

			private string gmtModified;

			private string hostGroupChangeType;

			private string hostGroupChangeStatus;

			private string scalingGroupBizId;

			private string scalingGroupActiveStatus;

			private string scalingInMode;

			private int? scalingGroupMinNode;

			private int? scalingGroupMaxNode;

			private string scalingGroupConfigState;

			private float? costSavingPercent;

			public string HostGroupId
			{
				get
				{
					return hostGroupId;
				}
				set	
				{
					hostGroupId = value;
				}
			}

			public string HostGroupName
			{
				get
				{
					return hostGroupName;
				}
				set	
				{
					hostGroupName = value;
				}
			}

			public string HostGroupType
			{
				get
				{
					return hostGroupType;
				}
				set	
				{
					hostGroupType = value;
				}
			}

			public string HostGroupSubType
			{
				get
				{
					return hostGroupSubType;
				}
				set	
				{
					hostGroupSubType = value;
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

			public string SystemDiskType
			{
				get
				{
					return systemDiskType;
				}
				set	
				{
					systemDiskType = value;
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
				}
			}

			public int? SystemDiskCount
			{
				get
				{
					return systemDiskCount;
				}
				set	
				{
					systemDiskCount = value;
				}
			}

			public string DataDiskType
			{
				get
				{
					return dataDiskType;
				}
				set	
				{
					dataDiskType = value;
				}
			}

			public int? DataDiskSize
			{
				get
				{
					return dataDiskSize;
				}
				set	
				{
					dataDiskSize = value;
				}
			}

			public int? DataDiskCount
			{
				get
				{
					return dataDiskCount;
				}
				set	
				{
					dataDiskCount = value;
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

			public string LockType
			{
				get
				{
					return lockType;
				}
				set	
				{
					lockType = value;
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

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public int? NodeCount
			{
				get
				{
					return nodeCount;
				}
				set	
				{
					nodeCount = value;
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

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
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

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string HostGroupChangeType
			{
				get
				{
					return hostGroupChangeType;
				}
				set	
				{
					hostGroupChangeType = value;
				}
			}

			public string HostGroupChangeStatus
			{
				get
				{
					return hostGroupChangeStatus;
				}
				set	
				{
					hostGroupChangeStatus = value;
				}
			}

			public string ScalingGroupBizId
			{
				get
				{
					return scalingGroupBizId;
				}
				set	
				{
					scalingGroupBizId = value;
				}
			}

			public string ScalingGroupActiveStatus
			{
				get
				{
					return scalingGroupActiveStatus;
				}
				set	
				{
					scalingGroupActiveStatus = value;
				}
			}

			public string ScalingInMode
			{
				get
				{
					return scalingInMode;
				}
				set	
				{
					scalingInMode = value;
				}
			}

			public int? ScalingGroupMinNode
			{
				get
				{
					return scalingGroupMinNode;
				}
				set	
				{
					scalingGroupMinNode = value;
				}
			}

			public int? ScalingGroupMaxNode
			{
				get
				{
					return scalingGroupMaxNode;
				}
				set	
				{
					scalingGroupMaxNode = value;
				}
			}

			public string ScalingGroupConfigState
			{
				get
				{
					return scalingGroupConfigState;
				}
				set	
				{
					scalingGroupConfigState = value;
				}
			}

			public float? CostSavingPercent
			{
				get
				{
					return costSavingPercent;
				}
				set	
				{
					costSavingPercent = value;
				}
			}
		}
	}
}
