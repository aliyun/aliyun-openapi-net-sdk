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

namespace Aliyun.Acs.Ccs.Model.V20171001
{
	public class GetHotlineRecordResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private string callType;

		private string visitorId;

		private string visitorPhone;

		private string visitorProvince;

		private string sceneId;

		private string agentId;

		private string agentName;

		private string createTime;

		private string finishTime;

		private string status;

		private string memo;

		private string hangupType;

		private string satisfaction;

		private string outboundTaskId;

		private string categories;

		private string ccsInstanceId;

		private long? talkDuration;

		private string groupId;

		private string groupName;

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

		public string Id
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

		public string CallType
		{
			get
			{
				return callType;
			}
			set	
			{
				callType = value;
			}
		}

		public string VisitorId
		{
			get
			{
				return visitorId;
			}
			set	
			{
				visitorId = value;
			}
		}

		public string VisitorPhone
		{
			get
			{
				return visitorPhone;
			}
			set	
			{
				visitorPhone = value;
			}
		}

		public string VisitorProvince
		{
			get
			{
				return visitorProvince;
			}
			set	
			{
				visitorProvince = value;
			}
		}

		public string SceneId
		{
			get
			{
				return sceneId;
			}
			set	
			{
				sceneId = value;
			}
		}

		public string AgentId
		{
			get
			{
				return agentId;
			}
			set	
			{
				agentId = value;
			}
		}

		public string AgentName
		{
			get
			{
				return agentName;
			}
			set	
			{
				agentName = value;
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

		public string FinishTime
		{
			get
			{
				return finishTime;
			}
			set	
			{
				finishTime = value;
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

		public string HangupType
		{
			get
			{
				return hangupType;
			}
			set	
			{
				hangupType = value;
			}
		}

		public string Satisfaction
		{
			get
			{
				return satisfaction;
			}
			set	
			{
				satisfaction = value;
			}
		}

		public string OutboundTaskId
		{
			get
			{
				return outboundTaskId;
			}
			set	
			{
				outboundTaskId = value;
			}
		}

		public string Categories
		{
			get
			{
				return categories;
			}
			set	
			{
				categories = value;
			}
		}

		public string CcsInstanceId
		{
			get
			{
				return ccsInstanceId;
			}
			set	
			{
				ccsInstanceId = value;
			}
		}

		public long? TalkDuration
		{
			get
			{
				return talkDuration;
			}
			set	
			{
				talkDuration = value;
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
			}
		}

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
			}
		}
	}
}
