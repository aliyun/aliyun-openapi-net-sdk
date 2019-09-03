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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDTCSecurityIpHostsForSQLServerResponse : AcsResponse
	{

		private string requestId;

		private string dBInstanceId;

		private string ipHostPairNum;

		private List<DescribeDTCSecurityIpHostsForSQLServer_WhiteListGroups> items;

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

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
			}
		}

		public string IpHostPairNum
		{
			get
			{
				return ipHostPairNum;
			}
			set	
			{
				ipHostPairNum = value;
			}
		}

		public List<DescribeDTCSecurityIpHostsForSQLServer_WhiteListGroups> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeDTCSecurityIpHostsForSQLServer_WhiteListGroups
		{

			private string securityIpHosts;

			private string whitelistGroupName;

			public string SecurityIpHosts
			{
				get
				{
					return securityIpHosts;
				}
				set	
				{
					securityIpHosts = value;
				}
			}

			public string WhitelistGroupName
			{
				get
				{
					return whitelistGroupName;
				}
				set	
				{
					whitelistGroupName = value;
				}
			}
		}
	}
}
