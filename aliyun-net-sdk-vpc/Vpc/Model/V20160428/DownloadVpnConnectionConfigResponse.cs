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
	public class DownloadVpnConnectionConfigResponse : AcsResponse
	{

		private string requestId;

		private DownloadVpnConnectionConfig_VpnConnectionConfig vpnConnectionConfig;

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

		public DownloadVpnConnectionConfig_VpnConnectionConfig VpnConnectionConfig
		{
			get
			{
				return vpnConnectionConfig;
			}
			set	
			{
				vpnConnectionConfig = value;
			}
		}

		public class DownloadVpnConnectionConfig_VpnConnectionConfig
		{

			private string remote;

			private string local;

			private string remoteSubnet;

			private string localSubnet;

			private DownloadVpnConnectionConfig_IkeConfig ikeConfig;

			private DownloadVpnConnectionConfig_IpsecConfig ipsecConfig;

			public string Remote
			{
				get
				{
					return remote;
				}
				set	
				{
					remote = value;
				}
			}

			public string Local
			{
				get
				{
					return local;
				}
				set	
				{
					local = value;
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

			public DownloadVpnConnectionConfig_IkeConfig IkeConfig
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

			public DownloadVpnConnectionConfig_IpsecConfig IpsecConfig
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

			public class DownloadVpnConnectionConfig_IkeConfig
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

			public class DownloadVpnConnectionConfig_IpsecConfig
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
		}
	}
}
