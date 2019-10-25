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

namespace Aliyun.Acs.aliyuncvc.Model.V20190919
{
	public class QueryMemberRecordResponse : AcsResponse
	{

		private int? errorCode;

		private string message;

		private bool? success;

		private string requestId;

		private QueryMemberRecord_MeetingInfo meetingInfo;

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

		public QueryMemberRecord_MeetingInfo MeetingInfo
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

		public class QueryMemberRecord_MeetingInfo
		{

			private string meetingName;

			private string meetingCode;

			private string memo;

			private string userName;

			private long? createDate;

			private string userId;

			private string meetingUUID;

			private List<QueryMemberRecord_MemberRecord> memberRecordsList;

			public string MeetingName
			{
				get
				{
					return meetingName;
				}
				set	
				{
					meetingName = value;
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

			public string Memo
			{
				get
				{
					return memo;
				}
				set	
				{
					memo = value;
				}
			}

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			public long? CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
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

			public List<QueryMemberRecord_MemberRecord> MemberRecordsList
			{
				get
				{
					return memberRecordsList;
				}
				set	
				{
					memberRecordsList = value;
				}
			}

			public class QueryMemberRecord_MemberRecord
			{

				private string memberUUID;

				private string userId;

				private string status;

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

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
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
}
