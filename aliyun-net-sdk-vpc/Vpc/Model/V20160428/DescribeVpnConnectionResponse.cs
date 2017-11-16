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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeVpnConnectionResponse : AcsResponse
	{

		private string requestId;

		private string vpnConnectionId;

		private string customerGatewayId;

		private string vpnGatewayId;

		private string name;

		private string localSubnet;

		private string remoteSubnet;

		private long? createTime;

		private bool? effectImmediately;

		private string status;

		private DescribeVpnConnection_IkeConfig ikeConfig;

		private DescribeVpnConnection_IpsecConfig ipsecConfig;

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

		public class DescribeVpnConnection_IkeConfig
		{

			private string psk;

			private string ikeVersion;

			private string ikeMode;

			private string ikeEncAlg;

			private string ikeAuthAlg;

			private string ikePfs;

			private long? ikeLifetime;

			private string localId;

			private string remoteId;

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
		}

		public class DescribeVpnConnection_IpsecConfig
		{

			private string ipsecEncAlg;

			private string ipsecAuthAlg;

			private string ipsecPfs;

			private long? ipsecLifetime;

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
		}
	}
}