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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Model.V20180731
{
	public class DescribeConsortiumsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private List<DescribeConsortiums_ResultItem> result;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public List<DescribeConsortiums_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeConsortiums_ResultItem
		{

			private string requestId;

			private string consortiumId;

			private string name;

			private string codeName;

			private string ownerBid;

			private int? ownerUid;

			private string ownerName;

			private string channelPolicy;

			private int? organizationCount;

			private int? channelCount;

			private string createTime;

			private string state;

			private string regionId;

			private string domain;

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

			public string ConsortiumId
			{
				get
				{
					return consortiumId;
				}
				set	
				{
					consortiumId = value;
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

			public string CodeName
			{
				get
				{
					return codeName;
				}
				set	
				{
					codeName = value;
				}
			}

			public string OwnerBid
			{
				get
				{
					return ownerBid;
				}
				set	
				{
					ownerBid = value;
				}
			}

			public int? OwnerUid
			{
				get
				{
					return ownerUid;
				}
				set	
				{
					ownerUid = value;
				}
			}

			public string OwnerName
			{
				get
				{
					return ownerName;
				}
				set	
				{
					ownerName = value;
				}
			}

			public string ChannelPolicy
			{
				get
				{
					return channelPolicy;
				}
				set	
				{
					channelPolicy = value;
				}
			}

			public int? OrganizationCount
			{
				get
				{
					return organizationCount;
				}
				set	
				{
					organizationCount = value;
				}
			}

			public int? ChannelCount
			{
				get
				{
					return channelCount;
				}
				set	
				{
					channelCount = value;
				}
			}

			public string CreateTime
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

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
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

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}
		}
	}
}