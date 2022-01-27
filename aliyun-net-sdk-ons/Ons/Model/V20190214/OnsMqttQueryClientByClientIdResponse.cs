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

namespace Aliyun.Acs.Ons.Model.V20190214
{
	public class OnsMqttQueryClientByClientIdResponse : AcsResponse
	{

		private string requestId;

		private string helpUrl;

		private OnsMqttQueryClientByClientId_MqttClientInfoDo mqttClientInfoDo;

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

		public string HelpUrl
		{
			get
			{
				return helpUrl;
			}
			set	
			{
				helpUrl = value;
			}
		}

		public OnsMqttQueryClientByClientId_MqttClientInfoDo MqttClientInfoDo
		{
			get
			{
				return mqttClientInfoDo;
			}
			set	
			{
				mqttClientInfoDo = value;
			}
		}

		public class OnsMqttQueryClientByClientId_MqttClientInfoDo
		{

			private bool? online;

			private long? lastTouch;

			private string socketChannel;

			private string clientId;

			private List<OnsMqttQueryClientByClientId_SubscriptionDo> subScriptonData;

			public bool? Online
			{
				get
				{
					return online;
				}
				set	
				{
					online = value;
				}
			}

			public long? LastTouch
			{
				get
				{
					return lastTouch;
				}
				set	
				{
					lastTouch = value;
				}
			}

			public string SocketChannel
			{
				get
				{
					return socketChannel;
				}
				set	
				{
					socketChannel = value;
				}
			}

			public string ClientId
			{
				get
				{
					return clientId;
				}
				set	
				{
					clientId = value;
				}
			}

			public List<OnsMqttQueryClientByClientId_SubscriptionDo> SubScriptonData
			{
				get
				{
					return subScriptonData;
				}
				set	
				{
					subScriptonData = value;
				}
			}

			public class OnsMqttQueryClientByClientId_SubscriptionDo
			{

				private string subTopic;

				private string parentTopic;

				private int? qos;

				public string SubTopic
				{
					get
					{
						return subTopic;
					}
					set	
					{
						subTopic = value;
					}
				}

				public string ParentTopic
				{
					get
					{
						return parentTopic;
					}
					set	
					{
						parentTopic = value;
					}
				}

				public int? Qos
				{
					get
					{
						return qos;
					}
					set	
					{
						qos = value;
					}
				}
			}
		}
	}
}
