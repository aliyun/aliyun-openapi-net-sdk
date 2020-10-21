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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeMqttConfigResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private bool? isEnabled;

		private string brokerUrl;

		private string internalBrokerUrl;

		private string publishTopic;

		private string subscribeTopic;

		private string groupId;

		private string mqttInstanceId;

		private string authType;

		private string username;

		private string password;

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

		public bool? IsEnabled
		{
			get
			{
				return isEnabled;
			}
			set	
			{
				isEnabled = value;
			}
		}

		public string BrokerUrl
		{
			get
			{
				return brokerUrl;
			}
			set	
			{
				brokerUrl = value;
			}
		}

		public string InternalBrokerUrl
		{
			get
			{
				return internalBrokerUrl;
			}
			set	
			{
				internalBrokerUrl = value;
			}
		}

		public string PublishTopic
		{
			get
			{
				return publishTopic;
			}
			set	
			{
				publishTopic = value;
			}
		}

		public string SubscribeTopic
		{
			get
			{
				return subscribeTopic;
			}
			set	
			{
				subscribeTopic = value;
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

		public string MqttInstanceId
		{
			get
			{
				return mqttInstanceId;
			}
			set	
			{
				mqttInstanceId = value;
			}
		}

		public string AuthType
		{
			get
			{
				return authType;
			}
			set	
			{
				authType = value;
			}
		}

		public string Username
		{
			get
			{
				return username;
			}
			set	
			{
				username = value;
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
			}
		}
	}
}
