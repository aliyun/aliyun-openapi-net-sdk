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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class ListSipCallRecordsResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private List<ListSipCallRecords_SipCallRecords> data;

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

		public List<ListSipCallRecords_SipCallRecords> Data
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

		public class ListSipCallRecords_SipCallRecords
		{

			private string instanceId;

			private string callId;

			private string contactId;

			private string caller;

			private string callee;

			private string callerClusterId;

			private string calleeClusterId;

			private int? lastResponseCode;

			private string lastResponseText;

			private long? inviteTime;

			private long? ringTime;

			private long? establishedTime;

			private long? releasedTime;

			private int? releaseReasonCode;

			private string earlyMediaUrl;

			private string earlyMediaText;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string CallId
			{
				get
				{
					return callId;
				}
				set	
				{
					callId = value;
				}
			}

			public string ContactId
			{
				get
				{
					return contactId;
				}
				set	
				{
					contactId = value;
				}
			}

			public string Caller
			{
				get
				{
					return caller;
				}
				set	
				{
					caller = value;
				}
			}

			public string Callee
			{
				get
				{
					return callee;
				}
				set	
				{
					callee = value;
				}
			}

			public string CallerClusterId
			{
				get
				{
					return callerClusterId;
				}
				set	
				{
					callerClusterId = value;
				}
			}

			public string CalleeClusterId
			{
				get
				{
					return calleeClusterId;
				}
				set	
				{
					calleeClusterId = value;
				}
			}

			public int? LastResponseCode
			{
				get
				{
					return lastResponseCode;
				}
				set	
				{
					lastResponseCode = value;
				}
			}

			public string LastResponseText
			{
				get
				{
					return lastResponseText;
				}
				set	
				{
					lastResponseText = value;
				}
			}

			public long? InviteTime
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

			public long? RingTime
			{
				get
				{
					return ringTime;
				}
				set	
				{
					ringTime = value;
				}
			}

			public long? EstablishedTime
			{
				get
				{
					return establishedTime;
				}
				set	
				{
					establishedTime = value;
				}
			}

			public long? ReleasedTime
			{
				get
				{
					return releasedTime;
				}
				set	
				{
					releasedTime = value;
				}
			}

			public int? ReleaseReasonCode
			{
				get
				{
					return releaseReasonCode;
				}
				set	
				{
					releaseReasonCode = value;
				}
			}

			public string EarlyMediaUrl
			{
				get
				{
					return earlyMediaUrl;
				}
				set	
				{
					earlyMediaUrl = value;
				}
			}

			public string EarlyMediaText
			{
				get
				{
					return earlyMediaText;
				}
				set	
				{
					earlyMediaText = value;
				}
			}
		}
	}
}
