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
	public class ListMembersResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private List<ListMembers_Member> members;

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

		public List<ListMembers_Member> Members
		{
			get
			{
				return members;
			}
			set	
			{
				members = value;
			}
		}

		public class ListMembers_Member
		{

			private string ledgerId;

			private string memberId;

			private string aliUid;

			private string keyType;

			private string publicKey;

			private string role;

			private string state;

			private long? createTime;

			private long? updateTime;

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

			public string AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string KeyType
			{
				get
				{
					return keyType;
				}
				set	
				{
					keyType = value;
				}
			}

			public string PublicKey
			{
				get
				{
					return publicKey;
				}
				set	
				{
					publicKey = value;
				}
			}

			public string Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
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

			public long? UpdateTime
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
		}
	}
}
