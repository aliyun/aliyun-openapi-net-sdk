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
	public class DescribeVpnConnectionResponse : AcsResponse
	{

		private string status;

		private string remoteCaCertificate;

		private bool? enableNatTraversal;

		private long? createTime;

		private bool? effectImmediately;

		private string vpnGatewayId;

		private string localSubnet;

		private string requestId;

		private string vpnConnectionId;

		private string remoteSubnet;

		private string customerGatewayId;

		private string name;

		private bool? enableDpd;

		private string attachType;

		private string networkType;

		private string attachInstanceId;

		private string spec;

		private string state;

		private string zoneNo;

		private string internetIp;

		private string transitRouterId;

		private string transitRouterName;

		private bool? crossAccountAuthorized;

		private List<DescribeVpnConnection_Tag> tags;

		private DescribeVpnConnection_IkeConfig ikeConfig;

		private DescribeVpnConnection_IpsecConfig ipsecConfig;

		private DescribeVpnConnection_VcoHealthCheck vcoHealthCheck;

		private DescribeVpnConnection_VpnBgpConfig vpnBgpConfig;

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

		public string RemoteCaCertificate
		{
			get
			{
				return remoteCaCertificate;
			}
			set	
			{
				remoteCaCertificate = value;
			}
		}

		public bool? EnableNatTraversal
		{
			get
			{
				return enableNatTraversal;
			}
			set	
			{
				enableNatTraversal = value;
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

		public bool? EffectImmediately
		{
			get
			{
				return effectImmediately;
			}
			set	
			{
				effectImmediately = value;
			}
		}

		public string VpnGatewayId
		{
			get
			{
				return vpnGatewayId;
			}
			set	
			{
				vpnGatewayId = value;
			}
		}

		public string LocalSubnet
		{
			get
			{
				return localSubnet;
			}
			set	
			{
				localSubnet = value;
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

		public string VpnConnectionId
		{
			get
			{
				return vpnConnectionId;
			}
			set	
			{
				vpnConnectionId = value;
			}
		}

		public string RemoteSubnet
		{
			get
			{
				return remoteSubnet;
			}
			set	
			{
				remoteSubnet = value;
			}
		}

		public string CustomerGatewayId
		{
			get
			{
				return customerGatewayId;
			}
			set	
			{
				customerGatewayId = value;
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

		public bool? EnableDpd
		{
			get
			{
				return enableDpd;
			}
			set	
			{
				enableDpd = value;
			}
		}

		public string AttachType
		{
			get
			{
				return attachType;
			}
			set	
			{
				attachType = value;
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

		public string AttachInstanceId
		{
			get
			{
				return attachInstanceId;
			}
			set	
			{
				attachInstanceId = value;
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

		public string State
		{
			get
			{
				return state;
			}
			set	
			{
				state = value;
			}
		}

		public string ZoneNo
		{
			get
			{
				return zoneNo;
			}
			set	
			{
				zoneNo = value;
			}
		}

		public string InternetIp
		{
			get
			{
				return internetIp;
			}
			set	
			{
				internetIp = value;
			}
		}

		public string TransitRouterId
		{
			get
			{
				return transitRouterId;
			}
			set	
			{
				transitRouterId = value;
			}
		}

		public string TransitRouterName
		{
			get
			{
				return transitRouterName;
			}
			set	
			{
				transitRouterName = value;
			}
		}

		public bool? CrossAccountAuthorized
		{
			get
			{
				return crossAccountAuthorized;
			}
			set	
			{
				crossAccountAuthorized = value;
			}
		}

		public List<DescribeVpnConnection_Tag> Tags
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

		public DescribeVpnConnection_IkeConfig IkeConfig
		{
			get
			{
				return ikeConfig;
			}
			set	
			{
				ikeConfig = value;
			}
		}

		public DescribeVpnConnection_IpsecConfig IpsecConfig
		{
			get
			{
				return ipsecConfig;
			}
			set	
			{
				ipsecConfig = value;
			}
		}

		public DescribeVpnConnection_VcoHealthCheck VcoHealthCheck
		{
			get
			{
				return vcoHealthCheck;
			}
			set	
			{
				vcoHealthCheck = value;
			}
		}

		public DescribeVpnConnection_VpnBgpConfig VpnBgpConfig
		{
			get
			{
				return vpnBgpConfig;
			}
			set	
			{
				vpnBgpConfig = value;
			}
		}

		public class DescribeVpnConnection_Tag
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeVpnConnection_IkeConfig
		{

			private string remoteId;

			private long? ikeLifetime;

			private string ikeEncAlg;

			private string localId;

			private string ikeMode;

			private string ikeVersion;

			private string ikePfs;

			private string psk;

			private string ikeAuthAlg;

			public string RemoteId
			{
				get
				{
					return remoteId;
				}
				set	
				{
					remoteId = value;
				}
			}

			public long? IkeLifetime
			{
				get
				{
					return ikeLifetime;
				}
				set	
				{
					ikeLifetime = value;
				}
			}

			public string IkeEncAlg
			{
				get
				{
					return ikeEncAlg;
				}
				set	
				{
					ikeEncAlg = value;
				}
			}

			public string LocalId
			{
				get
				{
					return localId;
				}
				set	
				{
					localId = value;
				}
			}

			public string IkeMode
			{
				get
				{
					return ikeMode;
				}
				set	
				{
					ikeMode = value;
				}
			}

			public string IkeVersion
			{
				get
				{
					return ikeVersion;
				}
				set	
				{
					ikeVersion = value;
				}
			}

			public string IkePfs
			{
				get
				{
					return ikePfs;
				}
				set	
				{
					ikePfs = value;
				}
			}

			public string Psk
			{
				get
				{
					return psk;
				}
				set	
				{
					psk = value;
				}
			}

			public string IkeAuthAlg
			{
				get
				{
					return ikeAuthAlg;
				}
				set	
				{
					ikeAuthAlg = value;
				}
			}
		}

		public class DescribeVpnConnection_IpsecConfig
		{

			private string ipsecAuthAlg;

			private long? ipsecLifetime;

			private string ipsecEncAlg;

			private string ipsecPfs;

			public string IpsecAuthAlg
			{
				get
				{
					return ipsecAuthAlg;
				}
				set	
				{
					ipsecAuthAlg = value;
				}
			}

			public long? IpsecLifetime
			{
				get
				{
					return ipsecLifetime;
				}
				set	
				{
					ipsecLifetime = value;
				}
			}

			public string IpsecEncAlg
			{
				get
				{
					return ipsecEncAlg;
				}
				set	
				{
					ipsecEncAlg = value;
				}
			}

			public string IpsecPfs
			{
				get
				{
					return ipsecPfs;
				}
				set	
				{
					ipsecPfs = value;
				}
			}
		}

		public class DescribeVpnConnection_VcoHealthCheck
		{

			private string status;

			private string dip;

			private int? interval;

			private int? retry;

			private string sip;

			private string enable;

			private string policy;

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

			public string Dip
			{
				get
				{
					return dip;
				}
				set	
				{
					dip = value;
				}
			}

			public int? Interval
			{
				get
				{
					return interval;
				}
				set	
				{
					interval = value;
				}
			}

			public int? Retry
			{
				get
				{
					return retry;
				}
				set	
				{
					retry = value;
				}
			}

			public string Sip
			{
				get
				{
					return sip;
				}
				set	
				{
					sip = value;
				}
			}

			public string Enable
			{
				get
				{
					return enable;
				}
				set	
				{
					enable = value;
				}
			}

			public string Policy
			{
				get
				{
					return policy;
				}
				set	
				{
					policy = value;
				}
			}
		}

		public class DescribeVpnConnection_VpnBgpConfig
		{

			private string status;

			private string peerBgpIp;

			private string tunnelCidr;

			private string enableBgp;

			private string localBgpIp;

			private long? peerAsn;

			private long? localAsn;

			private string authKey;

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

			public string PeerBgpIp
			{
				get
				{
					return peerBgpIp;
				}
				set	
				{
					peerBgpIp = value;
				}
			}

			public string TunnelCidr
			{
				get
				{
					return tunnelCidr;
				}
				set	
				{
					tunnelCidr = value;
				}
			}

			public string EnableBgp
			{
				get
				{
					return enableBgp;
				}
				set	
				{
					enableBgp = value;
				}
			}

			public string LocalBgpIp
			{
				get
				{
					return localBgpIp;
				}
				set	
				{
					localBgpIp = value;
				}
			}

			public long? PeerAsn
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

			public long? LocalAsn
			{
				get
				{
					return localAsn;
				}
				set	
				{
					localAsn = value;
				}
			}

			public string AuthKey
			{
				get
				{
					return authKey;
				}
				set	
				{
					authKey = value;
				}
			}
		}
	}
}
