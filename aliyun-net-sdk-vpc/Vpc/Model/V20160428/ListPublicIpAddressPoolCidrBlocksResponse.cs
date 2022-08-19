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
	public class ListPublicIpAddressPoolCidrBlocksResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private int? totalCount;

		private List<ListPublicIpAddressPoolCidrBlocks_PublicIpPoolCidrBlock> publicIpPoolCidrBlockList;

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

		public List<ListPublicIpAddressPoolCidrBlocks_PublicIpPoolCidrBlock> PublicIpPoolCidrBlockList
		{
			get
			{
				return publicIpPoolCidrBlockList;
			}
			set	
			{
				publicIpPoolCidrBlockList = value;
			}
		}

		public class ListPublicIpAddressPoolCidrBlocks_PublicIpPoolCidrBlock
		{

			private string publicIpAddressPoolId;

			private string cidrBlock;

			private string creationTime;

			private string status;

			private int? usedIpNum;

			private int? totalIpNum;

			public string PublicIpAddressPoolId
			{
				get
				{
					return publicIpAddressPoolId;
				}
				set	
				{
					publicIpAddressPoolId = value;
				}
			}

			public string CidrBlock
			{
				get
				{
					return cidrBlock;
				}
				set	
				{
					cidrBlock = value;
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

			public int? UsedIpNum
			{
				get
				{
					return usedIpNum;
				}
				set	
				{
					usedIpNum = value;
				}
			}

			public int? TotalIpNum
			{
				get
				{
					return totalIpNum;
				}
				set	
				{
					totalIpNum = value;
				}
			}
		}
	}
}
