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
	public class ListNatIpsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private string totalCount;

		private string maxResults;

		private List<ListNatIps_NatIp> natIps;

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

		public string TotalCount
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

		public string MaxResults
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

		public List<ListNatIps_NatIp> NatIps
		{
			get
			{
				return natIps;
			}
			set	
			{
				natIps = value;
			}
		}

		public class ListNatIps_NatIp
		{

			private bool? isDefault;

			private string natIp;

			private string natIpCidr;

			private string natIpId;

			private string natIpDescription;

			private string natGatewayId;

			private string natIpName;

			private string natIpStatus;

			private string regionId;

			public bool? IsDefault
			{
				get
				{
					return isDefault;
				}
				set	
				{
					isDefault = value;
				}
			}

			public string NatIp
			{
				get
				{
					return natIp;
				}
				set	
				{
					natIp = value;
				}
			}

			public string NatIpCidr
			{
				get
				{
					return natIpCidr;
				}
				set	
				{
					natIpCidr = value;
				}
			}

			public string NatIpId
			{
				get
				{
					return natIpId;
				}
				set	
				{
					natIpId = value;
				}
			}

			public string NatIpDescription
			{
				get
				{
					return natIpDescription;
				}
				set	
				{
					natIpDescription = value;
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

			public string NatIpName
			{
				get
				{
					return natIpName;
				}
				set	
				{
					natIpName = value;
				}
			}

			public string NatIpStatus
			{
				get
				{
					return natIpStatus;
				}
				set	
				{
					natIpStatus = value;
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
		}
	}
}
