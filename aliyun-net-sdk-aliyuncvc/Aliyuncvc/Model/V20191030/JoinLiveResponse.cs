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

namespace Aliyun.Acs.aliyuncvc.Model.V20191030
{
	public class JoinLiveResponse : AcsResponse
	{

		private int? errorCode;

		private bool? success;

		private string requestId;

		private string message;

		private JoinLive_MeetingInfo meetingInfo;

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

		public JoinLive_MeetingInfo MeetingInfo
		{
			get
			{
				return meetingInfo;
			}
			set	
			{
				meetingInfo = value;
			}
		}

		public class JoinLive_MeetingInfo
		{

			private string meetingDomain;

			private string meetingToken;

			private string meetingCode;

			private string memberUUID;

			private string clientAppId;

			private string meetingUUID;

			private string meetingAppId;

			private JoinLive_SlsInfo slsInfo;

			public string MeetingDomain
			{
				get
				{
					return meetingDomain;
				}
				set	
				{
					meetingDomain = value;
				}
			}

			public string MeetingToken
			{
				get
				{
					return meetingToken;
				}
				set	
				{
					meetingToken = value;
				}
			}

			public string MeetingCode
			{
				get
				{
					return meetingCode;
				}
				set	
				{
					meetingCode = value;
				}
			}

			public string MemberUUID
			{
				get
				{
					return memberUUID;
				}
				set	
				{
					memberUUID = value;
				}
			}

			public string ClientAppId
			{
				get
				{
					return clientAppId;
				}
				set	
				{
					clientAppId = value;
				}
			}

			public string MeetingUUID
			{
				get
				{
					return meetingUUID;
				}
				set	
				{
					meetingUUID = value;
				}
			}

			public string MeetingAppId
			{
				get
				{
					return meetingAppId;
				}
				set	
				{
					meetingAppId = value;
				}
			}

			public JoinLive_SlsInfo SlsInfo
			{
				get
				{
					return slsInfo;
				}
				set	
				{
					slsInfo = value;
				}
			}

			public class JoinLive_SlsInfo
			{

				private string logServiceEndpoint;

				private string logstore;

				private string project;

				public string LogServiceEndpoint
				{
					get
					{
						return logServiceEndpoint;
					}
					set	
					{
						logServiceEndpoint = value;
					}
				}

				public string Logstore
				{
					get
					{
						return logstore;
					}
					set	
					{
						logstore = value;
					}
				}

				public string Project
				{
					get
					{
						return project;
					}
					set	
					{
						project = value;
					}
				}
			}
		}
	}
}
