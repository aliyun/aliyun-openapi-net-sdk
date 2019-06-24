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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetMessageCallbackResponse : AcsResponse
	{

		private string requestId;

		private GetMessageCallback_MessageCallback messageCallback;

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

		public GetMessageCallback_MessageCallback MessageCallback
		{
			get
			{
				return messageCallback;
			}
			set	
			{
				messageCallback = value;
			}
		}

		public class GetMessageCallback_MessageCallback
		{

			private string callbackType;

			private string callbackURL;

			private string eventTypeList;

			private string authSwitch;

			private string authKey;

			private string mnsEndpoint;

			private string mnsQueueName;

			private string appId;

			public string CallbackType
			{
				get
				{
					return callbackType;
				}
				set	
				{
					callbackType = value;
				}
			}

			public string CallbackURL
			{
				get
				{
					return callbackURL;
				}
				set	
				{
					callbackURL = value;
				}
			}

			public string EventTypeList
			{
				get
				{
					return eventTypeList;
				}
				set	
				{
					eventTypeList = value;
				}
			}

			public string AuthSwitch
			{
				get
				{
					return authSwitch;
				}
				set	
				{
					authSwitch = value;
				}
			}

			public string AuthKey
			{
				get
				{
					return authKey;
				}
				set	
				{
					authKey = value;
				}
			}

			public string MnsEndpoint
			{
				get
				{
					return mnsEndpoint;
				}
				set	
				{
					mnsEndpoint = value;
				}
			}

			public string MnsQueueName
			{
				get
				{
					return mnsQueueName;
				}
				set	
				{
					mnsQueueName = value;
				}
			}

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}
		}
	}
}
