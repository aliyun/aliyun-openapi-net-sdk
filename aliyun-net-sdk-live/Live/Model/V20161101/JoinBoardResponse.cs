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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class JoinBoardResponse : AcsResponse
	{

		private string requestId;

		private string token;

		private string boardId;

		private string topicId;

		private string keepaliveTopic;

		private int? keepaliveInterval;

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

		public string Token
		{
			get
			{
				return token;
			}
			set	
			{
				token = value;
			}
		}

		public string BoardId
		{
			get
			{
				return boardId;
			}
			set	
			{
				boardId = value;
			}
		}

		public string TopicId
		{
			get
			{
				return topicId;
			}
			set	
			{
				topicId = value;
			}
		}

		public string KeepaliveTopic
		{
			get
			{
				return keepaliveTopic;
			}
			set	
			{
				keepaliveTopic = value;
			}
		}

		public int? KeepaliveInterval
		{
			get
			{
				return keepaliveInterval;
			}
			set	
			{
				keepaliveInterval = value;
			}
		}
	}
}