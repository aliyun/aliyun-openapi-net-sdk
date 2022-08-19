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
	public class ListFullNatEntriesResponse : AcsResponse
	{

		private string requestId;

		private string natGatewayId;

		private string fullNatTableId;

		private long? totalCount;

		private string nextToken;

		private long? maxResults;

		private List<ListFullNatEntries_FullNatEntry> fullNatEntries;

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

		public string FullNatTableId
		{
			get
			{
				return fullNatTableId;
			}
			set	
			{
				fullNatTableId = value;
			}
		}

		public long? TotalCount
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

		public long? MaxResults
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

		public List<ListFullNatEntries_FullNatEntry> FullNatEntries
		{
			get
			{
				return fullNatEntries;
			}
			set	
			{
				fullNatEntries = value;
			}
		}

		public class ListFullNatEntries_FullNatEntry
		{

			private string natIp;

			private string natIpPort;

			private string accessIp;

			private string accessPort;

			private string ipProtocol;

			private string networkInterfaceId;

			private string networkInterfaceType;

			private string fullNatEntryName;

			private string fullNatEntryDescription;

			private string creationTime;

			private string fullNatEntryId;

			private string fullNatEntryStatus;

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

			public string NatIpPort
			{
				get
				{
					return natIpPort;
				}
				set	
				{
					natIpPort = value;
				}
			}

			public string AccessIp
			{
				get
				{
					return accessIp;
				}
				set	
				{
					accessIp = value;
				}
			}

			public string AccessPort
			{
				get
				{
					return accessPort;
				}
				set	
				{
					accessPort = value;
				}
			}

			public string IpProtocol
			{
				get
				{
					return ipProtocol;
				}
				set	
				{
					ipProtocol = value;
				}
			}

			public string NetworkInterfaceId
			{
				get
				{
					return networkInterfaceId;
				}
				set	
				{
					networkInterfaceId = value;
				}
			}

			public string NetworkInterfaceType
			{
				get
				{
					return networkInterfaceType;
				}
				set	
				{
					networkInterfaceType = value;
				}
			}

			public string FullNatEntryName
			{
				get
				{
					return fullNatEntryName;
				}
				set	
				{
					fullNatEntryName = value;
				}
			}

			public string FullNatEntryDescription
			{
				get
				{
					return fullNatEntryDescription;
				}
				set	
				{
					fullNatEntryDescription = value;
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

			public string FullNatEntryId
			{
				get
				{
					return fullNatEntryId;
				}
				set	
				{
					fullNatEntryId = value;
				}
			}

			public string FullNatEntryStatus
			{
				get
				{
					return fullNatEntryStatus;
				}
				set	
				{
					fullNatEntryStatus = value;
				}
			}
		}
	}
}
