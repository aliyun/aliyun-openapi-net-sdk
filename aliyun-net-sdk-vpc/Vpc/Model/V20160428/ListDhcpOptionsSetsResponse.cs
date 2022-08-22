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
	public class ListDhcpOptionsSetsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private List<ListDhcpOptionsSets_DhcpOptionsSet> dhcpOptionsSets;

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

		public List<ListDhcpOptionsSets_DhcpOptionsSet> DhcpOptionsSets
		{
			get
			{
				return dhcpOptionsSets;
			}
			set	
			{
				dhcpOptionsSets = value;
			}
		}

		public class ListDhcpOptionsSets_DhcpOptionsSet
		{

			private string dhcpOptionsSetDescription;

			private string status;

			private string dhcpOptionsSetId;

			private string dhcpOptionsSetName;

			private int? associateVpcCount;

			private long? ownerId;

			private ListDhcpOptionsSets_DhcpOptions dhcpOptions;

			public string DhcpOptionsSetDescription
			{
				get
				{
					return dhcpOptionsSetDescription;
				}
				set	
				{
					dhcpOptionsSetDescription = value;
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

			public string DhcpOptionsSetId
			{
				get
				{
					return dhcpOptionsSetId;
				}
				set	
				{
					dhcpOptionsSetId = value;
				}
			}

			public string DhcpOptionsSetName
			{
				get
				{
					return dhcpOptionsSetName;
				}
				set	
				{
					dhcpOptionsSetName = value;
				}
			}

			public int? AssociateVpcCount
			{
				get
				{
					return associateVpcCount;
				}
				set	
				{
					associateVpcCount = value;
				}
			}

			public long? OwnerId
			{
				get
				{
					return ownerId;
				}
				set	
				{
					ownerId = value;
				}
			}

			public ListDhcpOptionsSets_DhcpOptions DhcpOptions
			{
				get
				{
					return dhcpOptions;
				}
				set	
				{
					dhcpOptions = value;
				}
			}

			public class ListDhcpOptionsSets_DhcpOptions
			{

				private string domainNameServers;

				private string domainName;

				private string leaseTime;

				private string ipv6LeaseTime;

				public string DomainNameServers
				{
					get
					{
						return domainNameServers;
					}
					set	
					{
						domainNameServers = value;
					}
				}

				public string DomainName
				{
					get
					{
						return domainName;
					}
					set	
					{
						domainName = value;
					}
				}

				public string LeaseTime
				{
					get
					{
						return leaseTime;
					}
					set	
					{
						leaseTime = value;
					}
				}

				public string Ipv6LeaseTime
				{
					get
					{
						return ipv6LeaseTime;
					}
					set	
					{
						ipv6LeaseTime = value;
					}
				}
			}
		}
	}
}
