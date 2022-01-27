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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class GetNatGatewayAttributeResponse : AcsResponse
	{

		private string requestId;

		private string description;

		private string natType;

		private bool? ecsMetricEnabled;

		private string vpcId;

		private string natGatewayId;

		private string creationTime;

		private string expiredTime;

		private string name;

		private string status;

		private string businessStatus;

		private string regionId;

		private string resourceGroupId;

		private List<GetNatGatewayAttribute_IpListItem> ipList;

		private GetNatGatewayAttribute_ForwardTable forwardTable;

		private GetNatGatewayAttribute_SnatTable snatTable;

		private GetNatGatewayAttribute_BillingConfig billingConfig;

		private GetNatGatewayAttribute_PrivateInfo privateInfo;

		private GetNatGatewayAttribute_DeletionProtectionInfo deletionProtectionInfo;

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

		public string NatType
		{
			get
			{
				return natType;
			}
			set	
			{
				natType = value;
			}
		}

		public bool? EcsMetricEnabled
		{
			get
			{
				return ecsMetricEnabled;
			}
			set	
			{
				ecsMetricEnabled = value;
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

		public string NatGatewayId
		{
			get
			{
				return natGatewayId;
			}
			set	
			{
				natGatewayId = value;
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

		public string BusinessStatus
		{
			get
			{
				return businessStatus;
			}
			set	
			{
				businessStatus = value;
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

		public List<GetNatGatewayAttribute_IpListItem> IpList
		{
			get
			{
				return ipList;
			}
			set	
			{
				ipList = value;
			}
		}

		public GetNatGatewayAttribute_ForwardTable ForwardTable
		{
			get
			{
				return forwardTable;
			}
			set	
			{
				forwardTable = value;
			}
		}

		public GetNatGatewayAttribute_SnatTable SnatTable
		{
			get
			{
				return snatTable;
			}
			set	
			{
				snatTable = value;
			}
		}

		public GetNatGatewayAttribute_BillingConfig BillingConfig
		{
			get
			{
				return billingConfig;
			}
			set	
			{
				billingConfig = value;
			}
		}

		public GetNatGatewayAttribute_PrivateInfo PrivateInfo
		{
			get
			{
				return privateInfo;
			}
			set	
			{
				privateInfo = value;
			}
		}

		public GetNatGatewayAttribute_DeletionProtectionInfo DeletionProtectionInfo
		{
			get
			{
				return deletionProtectionInfo;
			}
			set	
			{
				deletionProtectionInfo = value;
			}
		}

		public class GetNatGatewayAttribute_IpListItem
		{

			private string ipAddress;

			private string allocationId;

			private string usingStatus;

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

			public string UsingStatus
			{
				get
				{
					return usingStatus;
				}
				set	
				{
					usingStatus = value;
				}
			}
		}

		public class GetNatGatewayAttribute_ForwardTable
		{

			private string forwardTableId;

			private int? forwardEntryCount;

			public string ForwardTableId
			{
				get
				{
					return forwardTableId;
				}
				set	
				{
					forwardTableId = value;
				}
			}

			public int? ForwardEntryCount
			{
				get
				{
					return forwardEntryCount;
				}
				set	
				{
					forwardEntryCount = value;
				}
			}
		}

		public class GetNatGatewayAttribute_SnatTable
		{

			private string snatTableId;

			private int? snatEntryCount;

			public string SnatTableId
			{
				get
				{
					return snatTableId;
				}
				set	
				{
					snatTableId = value;
				}
			}

			public int? SnatEntryCount
			{
				get
				{
					return snatEntryCount;
				}
				set	
				{
					snatEntryCount = value;
				}
			}
		}

		public class GetNatGatewayAttribute_BillingConfig
		{

			private string spec;

			private string internetChargeType;

			private string instanceChargeType;

			private string autoPay;

			public string Spec
			{
				get
				{
					return spec;
				}
				set	
				{
					spec = value;
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

			public string AutoPay
			{
				get
				{
					return autoPay;
				}
				set	
				{
					autoPay = value;
				}
			}
		}

		public class GetNatGatewayAttribute_PrivateInfo
		{

			private string eniInstanceId;

			private string izNo;

			private int? maxBandwidth;

			private string privateIpAddress;

			private string vswitchId;

			public string EniInstanceId
			{
				get
				{
					return eniInstanceId;
				}
				set	
				{
					eniInstanceId = value;
				}
			}

			public string IzNo
			{
				get
				{
					return izNo;
				}
				set	
				{
					izNo = value;
				}
			}

			public int? MaxBandwidth
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
		}

		public class GetNatGatewayAttribute_DeletionProtectionInfo
		{

			private bool? enabled;

			public bool? Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}
		}
	}
}
