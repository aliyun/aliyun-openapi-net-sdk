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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class GetNatGatewayAttributeResponse : AcsResponse
	{

		private string vpcId;

		private string creationTime;

		private string status;

		private string natType;

		private string networkType;

		private string regionId;

		private bool? ecsMetricEnabled;

		private string requestId;

		private string description;

		private string expiredTime;

		private string resourceGroupId;

		private string natGatewayId;

		private string businessStatus;

		private string name;

		private bool? privateLinkEnabled;

		private string privateLinkMode;

		private List<GetNatGatewayAttribute_IpListItem> ipList;

		private GetNatGatewayAttribute_ForwardTable forwardTable;

		private GetNatGatewayAttribute_SnatTable snatTable;

		private GetNatGatewayAttribute_FullNatTable fullNatTable;

		private GetNatGatewayAttribute_BillingConfig billingConfig;

		private GetNatGatewayAttribute_PrivateInfo privateInfo;

		private GetNatGatewayAttribute_DeletionProtectionInfo deletionProtectionInfo;

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

		public string NetworkType
		{
			get
			{
				return networkType;
			}
			set	
			{
				networkType = value;
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

		public bool? PrivateLinkEnabled
		{
			get
			{
				return privateLinkEnabled;
			}
			set	
			{
				privateLinkEnabled = value;
			}
		}

		public string PrivateLinkMode
		{
			get
			{
				return privateLinkMode;
			}
			set	
			{
				privateLinkMode = value;
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

		public GetNatGatewayAttribute_FullNatTable FullNatTable
		{
			get
			{
				return fullNatTable;
			}
			set	
			{
				fullNatTable = value;
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

			private string usingStatus;

			private string ipAddress;

			private string allocationId;

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

			private int? snatEntryCount;

			private string snatTableId;

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
		}

		public class GetNatGatewayAttribute_FullNatTable
		{

			private long? fullNatEntryCount;

			private string fullNatTableId;

			public long? FullNatEntryCount
			{
				get
				{
					return fullNatEntryCount;
				}
				set	
				{
					fullNatEntryCount = value;
				}
			}

			public string FullNatTableId
			{
				get
				{
					return fullNatTableId;
				}
				set	
				{
					fullNatTableId = value;
				}
			}
		}

		public class GetNatGatewayAttribute_BillingConfig
		{

			private string internetChargeType;

			private string autoPay;

			private string spec;

			private string instanceChargeType;

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
		}

		public class GetNatGatewayAttribute_PrivateInfo
		{

			private int? maxBandwidth;

			private string vswitchId;

			private string privateIpAddress;

			private string izNo;

			private string eniInstanceId;

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
