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
	public class ModifyVpnConnectionAttributeResponse : AcsResponse
	{

		private bool? enableNatTraversal;

		private long? createTime;

		private bool? effectImmediately;

		private string vpnGatewayId;

		private string localSubnet;

		private string requestId;

		private string vpnConnectionId;

		private string description;

		private string remoteSubnet;

		private string customerGatewayId;

		private string name;

		private bool? enableDpd;

		private ModifyVpnConnectionAttribute_IkeConfig ikeConfig;

		private ModifyVpnConnectionAttribute_IpsecConfig ipsecConfig;

		private ModifyVpnConnectionAttribute_VcoHealthCheck vcoHealthCheck;

		private ModifyVpnConnectionAttribute_VpnBgpConfig vpnBgpConfig;

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

		public ModifyVpnConnectionAttribute_IkeConfig IkeConfig
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

		public ModifyVpnConnectionAttribute_IpsecConfig IpsecConfig
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

		public ModifyVpnConnectionAttribute_VcoHealthCheck VcoHealthCheck
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

		public ModifyVpnConnectionAttribute_VpnBgpConfig VpnBgpConfig
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

		public class ModifyVpnConnectionAttribute_IkeConfig
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

		public class ModifyVpnConnectionAttribute_IpsecConfig
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

		public class ModifyVpnConnectionAttribute_VcoHealthCheck
		{

			private string dip;

			private int? interval;

			private int? retry;

			private string sip;

			private string enable;

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
		}

		public class ModifyVpnConnectionAttribute_VpnBgpConfig
		{

			private string status;

			private string peerBgpIp;

			private string tunnelCidr;

			private string enableBgp;

			private string localBgpIp;

			private int? peerAsn;

			private int? localAsn;

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

			public int? PeerAsn
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

			public int? LocalAsn
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
		}
	}
}
