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
	public class DescribeConsortiumChannelsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private List<DescribeConsortiumChannels_ResultItem> result;

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

		public List<DescribeConsortiumChannels_ResultItem> Result
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

		public class DescribeConsortiumChannels_ResultItem
		{

			private int? id;

			private string channelId;

			private string name;

			private string consortiumId;

			private string state;

			private string ownerBid;

			private int? ownerUid;

			private string ownerName;

			private int? memberCount;

			private int? chaincodeCount;

			private int? blockCount;

			private string requestId;

			private string createTime;

			private string updateTime;

			private bool? deleted;

			private string deleteTime;

			private string consortiumName;

			private string memberJoinedCount;

			private bool? needJoined;

			public int? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string ChannelId
			{
				get
				{
					return channelId;
				}
				set	
				{
					channelId = value;
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

			public int? MemberCount
			{
				get
				{
					return memberCount;
				}
				set	
				{
					memberCount = value;
				}
			}

			public int? ChaincodeCount
			{
				get
				{
					return chaincodeCount;
				}
				set	
				{
					chaincodeCount = value;
				}
			}

			public int? BlockCount
			{
				get
				{
					return blockCount;
				}
				set	
				{
					blockCount = value;
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

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public bool? Deleted
			{
				get
				{
					return deleted;
				}
				set	
				{
					deleted = value;
				}
			}

			public string DeleteTime
			{
				get
				{
					return deleteTime;
				}
				set	
				{
					deleteTime = value;
				}
			}

			public string ConsortiumName
			{
				get
				{
					return consortiumName;
				}
				set	
				{
					consortiumName = value;
				}
			}

			public string MemberJoinedCount
			{
				get
				{
					return memberJoinedCount;
				}
				set	
				{
					memberJoinedCount = value;
				}
			}

			public bool? NeedJoined
			{
				get
				{
					return needJoined;
				}
				set	
				{
					needJoined = value;
				}
			}
		}
	}
}