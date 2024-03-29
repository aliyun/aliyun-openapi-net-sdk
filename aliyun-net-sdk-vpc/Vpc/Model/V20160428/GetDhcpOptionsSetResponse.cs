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
	public class GetDhcpOptionsSetResponse : AcsResponse
	{

		private string dhcpOptionsSetDescription;

		private string status;

		private string requestId;

		private string dhcpOptionsSetId;

		private string dhcpOptionsSetName;

		private long? ownerId;

		private List<GetDhcpOptionsSet_AssociateVpc> associateVpcs;

		private GetDhcpOptionsSet_DhcpOptions dhcpOptions;

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

		public List<GetDhcpOptionsSet_AssociateVpc> AssociateVpcs
		{
			get
			{
				return associateVpcs;
			}
			set	
			{
				associateVpcs = value;
			}
		}

		public GetDhcpOptionsSet_DhcpOptions DhcpOptions
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

		public class GetDhcpOptionsSet_AssociateVpc
		{

			private string associateStatus;

			private string vpcId;

			public string AssociateStatus
			{
				get
				{
					return associateStatus;
				}
				set	
				{
					associateStatus = value;
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
		}

		public class GetDhcpOptionsSet_DhcpOptions
		{

			private string tFTPServerName;

			private string domainNameServers;

			private string domainName;

			private string bootFileName;

			private string leaseTime;

			private string ipv6LeaseTime;

			public string TFTPServerName
			{
				get
				{
					return tFTPServerName;
				}
				set	
				{
					tFTPServerName = value;
				}
			}

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

			public string BootFileName
			{
				get
				{
					return bootFileName;
				}
				set	
				{
					bootFileName = value;
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
