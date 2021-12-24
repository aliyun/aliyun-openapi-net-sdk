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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeMqttConfigResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private bool? isEnabled;

		private string internalBrokerUrl;

		private string code;

		private bool? success;

		private string brokerUrl;

		private string groupId;

		private string mqttInstanceId;

		private string username;

		private string subscribeTopic;

		private string publishTopic;

		private string authType;

		private string password;

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "IsEnabled")]
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

		[JsonProperty(PropertyName = "InternalBrokerUrl")]
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

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "BrokerUrl")]
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

		[JsonProperty(PropertyName = "GroupId")]
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

		[JsonProperty(PropertyName = "MqttInstanceId")]
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

		[JsonProperty(PropertyName = "Username")]
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

		[JsonProperty(PropertyName = "SubscribeTopic")]
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

		[JsonProperty(PropertyName = "PublishTopic")]
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

		[JsonProperty(PropertyName = "AuthType")]
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

		[JsonProperty(PropertyName = "Password")]
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
