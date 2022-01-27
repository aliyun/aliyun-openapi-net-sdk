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
	public class ListIpsecServersResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private int? totalCount;

		private List<ListIpsecServers_IpsecServer> ipsecServers;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

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

		public List<ListIpsecServers_IpsecServer> IpsecServers
		{
			get
			{
				return ipsecServers;
			}
			set	
			{
				ipsecServers = value;
			}
		}

		public class ListIpsecServers_IpsecServer
		{

			private string regionId;

			private string ipsecServerId;

			private string ipsecServerName;

			private string vpnGatewayId;

			private string localSubnet;

			private string clientIpPool;

			private bool? effectImmediately;

			private bool? pskEnabled;

			private bool? multiFactorAuthEnabled;

			private string psk;

			private string iDaaSInstanceId;

			private int? onlineClientCount;

			private int? maxConnections;

			private string creationTime;

			private string internetIp;

			private ListIpsecServers_IkeConfig ikeConfig;

			private ListIpsecServers_IpsecConfig ipsecConfig;

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

			public string IpsecServerId
			{
				get
				{
					return ipsecServerId;
				}
				set	
				{
					ipsecServerId = value;
				}
			}

			public string IpsecServerName
			{
				get
				{
					return ipsecServerName;
				}
				set	
				{
					ipsecServerName = value;
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

			public string ClientIpPool
			{
				get
				{
					return clientIpPool;
				}
				set	
				{
					clientIpPool = value;
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

			public bool? PskEnabled
			{
				get
				{
					return pskEnabled;
				}
				set	
				{
					pskEnabled = value;
				}
			}

			public bool? MultiFactorAuthEnabled
			{
				get
				{
					return multiFactorAuthEnabled;
				}
				set	
				{
					multiFactorAuthEnabled = value;
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

			public string IDaaSInstanceId
			{
				get
				{
					return iDaaSInstanceId;
				}
				set	
				{
					iDaaSInstanceId = value;
				}
			}

			public int? OnlineClientCount
			{
				get
				{
					return onlineClientCount;
				}
				set	
				{
					onlineClientCount = value;
				}
			}

			public int? MaxConnections
			{
				get
				{
					return maxConnections;
				}
				set	
				{
					maxConnections = value;
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

			public ListIpsecServers_IkeConfig IkeConfig
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

			public ListIpsecServers_IpsecConfig IpsecConfig
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

			public class ListIpsecServers_IkeConfig
			{

				private string ikeVersion;

				private string ikeMode;

				private string ikeEncAlg;

				private string ikeAuthAlg;

				private string ikePfs;

				private long? ikeLifetime;

				private string localId;

				private string remoteId;

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

			public class ListIpsecServers_IpsecConfig
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
}
