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

namespace Aliyun.Acs.eflo.Model.V20220530
{
	public class GetVccResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetVcc_Content content;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public GetVcc_Content Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public class GetVcc_Content
		{

			private string tenantId;

			private string regionId;

			private string zoneId;

			private string vccId;

			private string vpdId;

			private string vpcId;

			private string vSwitchId;

			private string cenId;

			private string vccName;

			private string accessPointId;

			private string lineOperator;

			private string spec;

			private string portType;

			private string pricingCycle;

			private string payType;

			private string duration;

			private string status;

			private string currentNode;

			private string internetChargeType;

			private string bandwidthStr;

			private string message;

			private string createTime;

			private string gmtModified;

			private string commodityCode;

			private string bgpCidr;

			private string expirationDate;

			private bool? attachErStatus;

			private string resourceGroupId;

			private string connectionType;

			private string cenOwnerId;

			private List<GetVcc_ErInfo> erInfos;

			private List<GetVcc_AliyunRouterInfoItem> aliyunRouterInfo;

			private List<GetVcc_CisRouterInfoItem> cisRouterInfo;

			private List<GetVcc_Tag> tags;

			private List<GetVcc_VbrInfo> vbrInfos;

			private GetVcc_VpdBaseInfo vpdBaseInfo;

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
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

			public string VccId
			{
				get
				{
					return vccId;
				}
				set	
				{
					vccId = value;
				}
			}

			public string VpdId
			{
				get
				{
					return vpdId;
				}
				set	
				{
					vpdId = value;
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

			public string CenId
			{
				get
				{
					return cenId;
				}
				set	
				{
					cenId = value;
				}
			}

			public string VccName
			{
				get
				{
					return vccName;
				}
				set	
				{
					vccName = value;
				}
			}

			public string AccessPointId
			{
				get
				{
					return accessPointId;
				}
				set	
				{
					accessPointId = value;
				}
			}

			public string LineOperator
			{
				get
				{
					return lineOperator;
				}
				set	
				{
					lineOperator = value;
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

			public string PortType
			{
				get
				{
					return portType;
				}
				set	
				{
					portType = value;
				}
			}

			public string PricingCycle
			{
				get
				{
					return pricingCycle;
				}
				set	
				{
					pricingCycle = value;
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

			public string Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
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

			public string CurrentNode
			{
				get
				{
					return currentNode;
				}
				set	
				{
					currentNode = value;
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

			public string BandwidthStr
			{
				get
				{
					return bandwidthStr;
				}
				set	
				{
					bandwidthStr = value;
				}
			}

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
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

			public string CommodityCode
			{
				get
				{
					return commodityCode;
				}
				set	
				{
					commodityCode = value;
				}
			}

			public string BgpCidr
			{
				get
				{
					return bgpCidr;
				}
				set	
				{
					bgpCidr = value;
				}
			}

			public string ExpirationDate
			{
				get
				{
					return expirationDate;
				}
				set	
				{
					expirationDate = value;
				}
			}

			public bool? AttachErStatus
			{
				get
				{
					return attachErStatus;
				}
				set	
				{
					attachErStatus = value;
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

			public string ConnectionType
			{
				get
				{
					return connectionType;
				}
				set	
				{
					connectionType = value;
				}
			}

			public string CenOwnerId
			{
				get
				{
					return cenOwnerId;
				}
				set	
				{
					cenOwnerId = value;
				}
			}

			public List<GetVcc_ErInfo> ErInfos
			{
				get
				{
					return erInfos;
				}
				set	
				{
					erInfos = value;
				}
			}

			public List<GetVcc_AliyunRouterInfoItem> AliyunRouterInfo
			{
				get
				{
					return aliyunRouterInfo;
				}
				set	
				{
					aliyunRouterInfo = value;
				}
			}

			public List<GetVcc_CisRouterInfoItem> CisRouterInfo
			{
				get
				{
					return cisRouterInfo;
				}
				set	
				{
					cisRouterInfo = value;
				}
			}

			public List<GetVcc_Tag> Tags
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

			public List<GetVcc_VbrInfo> VbrInfos
			{
				get
				{
					return vbrInfos;
				}
				set	
				{
					vbrInfos = value;
				}
			}

			public GetVcc_VpdBaseInfo VpdBaseInfo
			{
				get
				{
					return vpdBaseInfo;
				}
				set	
				{
					vpdBaseInfo = value;
				}
			}

			public class GetVcc_ErInfo
			{

				private string createTime;

				private string gmtModified;

				private string message;

				private string erId;

				private string regionId;

				private string tenantId;

				private string status;

				private string erName;

				private string masterZoneId;

				private string description;

				private long? connections;

				private long? routeMaps;

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

				public string Message
				{
					get
					{
						return message;
					}
					set	
					{
						message = value;
					}
				}

				public string ErId
				{
					get
					{
						return erId;
					}
					set	
					{
						erId = value;
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

				public string TenantId
				{
					get
					{
						return tenantId;
					}
					set	
					{
						tenantId = value;
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

				public string ErName
				{
					get
					{
						return erName;
					}
					set	
					{
						erName = value;
					}
				}

				public string MasterZoneId
				{
					get
					{
						return masterZoneId;
					}
					set	
					{
						masterZoneId = value;
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

				public long? Connections
				{
					get
					{
						return connections;
					}
					set	
					{
						connections = value;
					}
				}

				public long? RouteMaps
				{
					get
					{
						return routeMaps;
					}
					set	
					{
						routeMaps = value;
					}
				}
			}

			public class GetVcc_AliyunRouterInfoItem
			{

				private string pcId;

				private string vbrId;

				private string localGatewayIp;

				private string peerGatewayIp;

				private string mask;

				private string vlanId;

				public string PcId
				{
					get
					{
						return pcId;
					}
					set	
					{
						pcId = value;
					}
				}

				public string VbrId
				{
					get
					{
						return vbrId;
					}
					set	
					{
						vbrId = value;
					}
				}

				public string LocalGatewayIp
				{
					get
					{
						return localGatewayIp;
					}
					set	
					{
						localGatewayIp = value;
					}
				}

				public string PeerGatewayIp
				{
					get
					{
						return peerGatewayIp;
					}
					set	
					{
						peerGatewayIp = value;
					}
				}

				public string Mask
				{
					get
					{
						return mask;
					}
					set	
					{
						mask = value;
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
			}

			public class GetVcc_CisRouterInfoItem
			{

				private string ccrId;

				private List<GetVcc_CcInfo> ccInfos;

				public string CcrId
				{
					get
					{
						return ccrId;
					}
					set	
					{
						ccrId = value;
					}
				}

				public List<GetVcc_CcInfo> CcInfos
				{
					get
					{
						return ccInfos;
					}
					set	
					{
						ccInfos = value;
					}
				}

				public class GetVcc_CcInfo
				{

					private string ccId;

					private string vlanId;

					private string localGatewayIp;

					private string remoteGatewayIp;

					private string subnetMask;

					private string status;

					public string CcId
					{
						get
						{
							return ccId;
						}
						set	
						{
							ccId = value;
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

					public string LocalGatewayIp
					{
						get
						{
							return localGatewayIp;
						}
						set	
						{
							localGatewayIp = value;
						}
					}

					public string RemoteGatewayIp
					{
						get
						{
							return remoteGatewayIp;
						}
						set	
						{
							remoteGatewayIp = value;
						}
					}

					public string SubnetMask
					{
						get
						{
							return subnetMask;
						}
						set	
						{
							subnetMask = value;
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
				}
			}

			public class GetVcc_Tag
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

			public class GetVcc_VbrInfo
			{

				private string vbrId;

				private string cenId;

				private string status;

				private string gmtCreate;

				private string gmtModified;

				private List<GetVcc_VbrBgpPeer> vbrBgpPeers;

				public string VbrId
				{
					get
					{
						return vbrId;
					}
					set	
					{
						vbrId = value;
					}
				}

				public string CenId
				{
					get
					{
						return cenId;
					}
					set	
					{
						cenId = value;
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

				public List<GetVcc_VbrBgpPeer> VbrBgpPeers
				{
					get
					{
						return vbrBgpPeers;
					}
					set	
					{
						vbrBgpPeers = value;
					}
				}

				public class GetVcc_VbrBgpPeer
				{

					private string bgpGroupId;

					private string bgpPeerId;

					private string peerIpAddress;

					private string peerAsn;

					private string status;

					public string BgpGroupId
					{
						get
						{
							return bgpGroupId;
						}
						set	
						{
							bgpGroupId = value;
						}
					}

					public string BgpPeerId
					{
						get
						{
							return bgpPeerId;
						}
						set	
						{
							bgpPeerId = value;
						}
					}

					public string PeerIpAddress
					{
						get
						{
							return peerIpAddress;
						}
						set	
						{
							peerIpAddress = value;
						}
					}

					public string PeerAsn
					{
						get
						{
							return peerAsn;
						}
						set	
						{
							peerAsn = value;
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
				}
			}

			public class GetVcc_VpdBaseInfo
			{

				private string vpdId;

				private string vpdName;

				private string cidr;

				private string createTime;

				public string VpdId
				{
					get
					{
						return vpdId;
					}
					set	
					{
						vpdId = value;
					}
				}

				public string VpdName
				{
					get
					{
						return vpdName;
					}
					set	
					{
						vpdName = value;
					}
				}

				public string Cidr
				{
					get
					{
						return cidr;
					}
					set	
					{
						cidr = value;
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
			}
		}
	}
}
