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

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
	public class DescribeConversationResponse : AcsResponse
	{

		private int? effectiveAnswerCount;

		private string conversationId;

		private bool? transferredToAgent;

		private long? endTime;

		private string requestId;

		private long? beginTime;

		private string skillGroupId;

		private string callingNumber;

		private int? userUtteranceCount;

		public int? EffectiveAnswerCount
		{
			get
			{
				return effectiveAnswerCount;
			}
			set	
			{
				effectiveAnswerCount = value;
			}
		}

		public string ConversationId
		{
			get
			{
				return conversationId;
			}
			set	
			{
				conversationId = value;
			}
		}

		public bool? TransferredToAgent
		{
			get
			{
				return transferredToAgent;
			}
			set	
			{
				transferredToAgent = value;
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
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

		public long? BeginTime
		{
			get
			{
				return beginTime;
			}
			set	
			{
				beginTime = value;
			}
		}

		public string SkillGroupId
		{
			get
			{
				return skillGroupId;
			}
			set	
			{
				skillGroupId = value;
			}
		}

		public string CallingNumber
		{
			get
			{
				return callingNumber;
			}
			set	
			{
				callingNumber = value;
			}
		}

		public int? UserUtteranceCount
		{
			get
			{
				return userUtteranceCount;
			}
			set	
			{
				userUtteranceCount = value;
			}
		}
	}
}
