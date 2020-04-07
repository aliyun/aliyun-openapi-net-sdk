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
	public class ModifySslVpnServerResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private string sslVpnServerId;

		private string vpnGatewayId;

		private string name;

		private string localSubnet;

		private string clientIpPool;

		private long? createTime;

		private string cipher;

		private string proto;

		private int? port;

		private bool? compress;

		private int? connections;

		private int? maxConnections;

		private string internetIp;

		private bool? enableMultiFactorAuth;

		private string iDaaSInstanceId;

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

		public string SslVpnServerId
		{
			get
			{
				return sslVpnServerId;
			}
			set	
			{
				sslVpnServerId = value;
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

		public string Cipher
		{
			get
			{
				return cipher;
			}
			set	
			{
				cipher = value;
			}
		}

		public string Proto
		{
			get
			{
				return proto;
			}
			set	
			{
				proto = value;
			}
		}

		public int? Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
			}
		}

		public bool? Compress
		{
			get
			{
				return compress;
			}
			set	
			{
				compress = value;
			}
		}

		public int? Connections
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

		public bool? EnableMultiFactorAuth
		{
			get
			{
				return enableMultiFactorAuth;
			}
			set	
			{
				enableMultiFactorAuth = value;
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
	}
}
