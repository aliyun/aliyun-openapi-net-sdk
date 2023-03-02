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

namespace Aliyun.Acs.lto.Model.V20210707
{
	public class ListMemberAuthorizedBizChainResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private List<ListMemberAuthorizedBizChain_MemberAuthorizedBizChainInfo> data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public List<ListMemberAuthorizedBizChain_MemberAuthorizedBizChainInfo> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListMemberAuthorizedBizChain_MemberAuthorizedBizChainInfo
		{

			private string bizChainType;

			private string bizChainName;

			private string bizChainId;

			private bool? authorized;

			private List<ListMemberAuthorizedBizChain_PeerInfo> peerList;

			public string BizChainType
			{
				get
				{
					return bizChainType;
				}
				set	
				{
					bizChainType = value;
				}
			}

			public string BizChainName
			{
				get
				{
					return bizChainName;
				}
				set	
				{
					bizChainName = value;
				}
			}

			public string BizChainId
			{
				get
				{
					return bizChainId;
				}
				set	
				{
					bizChainId = value;
				}
			}

			public bool? Authorized
			{
				get
				{
					return authorized;
				}
				set	
				{
					authorized = value;
				}
			}

			public List<ListMemberAuthorizedBizChain_PeerInfo> PeerList
			{
				get
				{
					return peerList;
				}
				set	
				{
					peerList = value;
				}
			}

			public class ListMemberAuthorizedBizChain_PeerInfo
			{

				private string peerName;

				private bool? authorized;

				public string PeerName
				{
					get
					{
						return peerName;
					}
					set	
					{
						peerName = value;
					}
				}

				public bool? Authorized
				{
					get
					{
						return authorized;
					}
					set	
					{
						authorized = value;
					}
				}
			}
		}
	}
}
