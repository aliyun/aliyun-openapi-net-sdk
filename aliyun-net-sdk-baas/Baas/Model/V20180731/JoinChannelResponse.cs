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
	public class JoinChannelResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private List<JoinChannel_ResultItem> result;

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

		public List<JoinChannel_ResultItem> Result
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

		public class JoinChannel_ResultItem
		{

			private string channelId;

			private string organizationId;

			private bool? withPeer;

			private string state;

			private string inviteTime;

			private string acceptTime;

			private string approveTime;

			private string confirmTime;

			private string destroyTime;

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

			public string OrganizationId
			{
				get
				{
					return organizationId;
				}
				set	
				{
					organizationId = value;
				}
			}

			public bool? WithPeer
			{
				get
				{
					return withPeer;
				}
				set	
				{
					withPeer = value;
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

			public string InviteTime
			{
				get
				{
					return inviteTime;
				}
				set	
				{
					inviteTime = value;
				}
			}

			public string AcceptTime
			{
				get
				{
					return acceptTime;
				}
				set	
				{
					acceptTime = value;
				}
			}

			public string ApproveTime
			{
				get
				{
					return approveTime;
				}
				set	
				{
					approveTime = value;
				}
			}

			public string ConfirmTime
			{
				get
				{
					return confirmTime;
				}
				set	
				{
					confirmTime = value;
				}
			}

			public string DestroyTime
			{
				get
				{
					return destroyTime;
				}
				set	
				{
					destroyTime = value;
				}
			}
		}
	}
}