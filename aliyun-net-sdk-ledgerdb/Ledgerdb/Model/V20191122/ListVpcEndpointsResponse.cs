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

namespace Aliyun.Acs.ledgerdb.Model.V20191122
{
	public class ListVpcEndpointsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private List<ListVpcEndpoints_VpcEndpoint> vpcEndpoints;

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

		public List<ListVpcEndpoints_VpcEndpoint> VpcEndpoints
		{
			get
			{
				return vpcEndpoints;
			}
			set	
			{
				vpcEndpoints = value;
			}
		}

		public class ListVpcEndpoints_VpcEndpoint
		{

			private string vpcEndpointId;

			private string ledgerId;

			private string memberId;

			private string regionId;

			private string vpcId;

			private string vSwitchId;

			private string address;

			private long? createTime;

			private string status;

			public string VpcEndpointId
			{
				get
				{
					return vpcEndpointId;
				}
				set	
				{
					vpcEndpointId = value;
				}
			}

			public string LedgerId
			{
				get
				{
					return ledgerId;
				}
				set	
				{
					ledgerId = value;
				}
			}

			public string MemberId
			{
				get
				{
					return memberId;
				}
				set	
				{
					memberId = value;
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

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
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
		}
	}
}
