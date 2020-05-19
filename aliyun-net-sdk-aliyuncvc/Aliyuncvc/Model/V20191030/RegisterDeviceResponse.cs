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
	public class RegisterDeviceResponse : AcsResponse
	{

		private int? errorCode;

		private bool? success;

		private string requestId;

		private string message;

		private RegisterDevice_DeviceInfo deviceInfo;

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

		public RegisterDevice_DeviceInfo DeviceInfo
		{
			get
			{
				return deviceInfo;
			}
			set	
			{
				deviceInfo = value;
			}
		}

		public class RegisterDevice_DeviceInfo
		{

			private string channelType;

			private long? registerTime;

			private string deviceName;

			private string deviceSessionId;

			private string messageKey;

			private string screenCode;

			private RegisterDevice_MqttParam mqttParam;

			private RegisterDevice_AuthWsChannelConfig authWsChannelConfig;

			private RegisterDevice_SlsConfig slsConfig;

			public string ChannelType
			{
				get
				{
					return channelType;
				}
				set	
				{
					channelType = value;
				}
			}

			public long? RegisterTime
			{
				get
				{
					return registerTime;
				}
				set	
				{
					registerTime = value;
				}
			}

			public string DeviceName
			{
				get
				{
					return deviceName;
				}
				set	
				{
					deviceName = value;
				}
			}

			public string DeviceSessionId
			{
				get
				{
					return deviceSessionId;
				}
				set	
				{
					deviceSessionId = value;
				}
			}

			public string MessageKey
			{
				get
				{
					return messageKey;
				}
				set	
				{
					messageKey = value;
				}
			}

			public string ScreenCode
			{
				get
				{
					return screenCode;
				}
				set	
				{
					screenCode = value;
				}
			}

			public RegisterDevice_MqttParam MqttParam
			{
				get
				{
					return mqttParam;
				}
				set	
				{
					mqttParam = value;
				}
			}

			public RegisterDevice_AuthWsChannelConfig AuthWsChannelConfig
			{
				get
				{
					return authWsChannelConfig;
				}
				set	
				{
					authWsChannelConfig = value;
				}
			}

			public RegisterDevice_SlsConfig SlsConfig
			{
				get
				{
					return slsConfig;
				}
				set	
				{
					slsConfig = value;
				}
			}

			public class RegisterDevice_MqttParam
			{

				private string clientId;

				private string groupId;

				private string cleanSession;

				private string password;

				private string port;

				private string host;

				private string topic;

				private string sDKClientPort;

				private string tLSPort;

				private string useTLS;

				private string userName;

				private string reconnectTimeout;

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

				public string CleanSession
				{
					get
					{
						return cleanSession;
					}
					set	
					{
						cleanSession = value;
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

				public string Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
					}
				}

				public string Host
				{
					get
					{
						return host;
					}
					set	
					{
						host = value;
					}
				}

				public string Topic
				{
					get
					{
						return topic;
					}
					set	
					{
						topic = value;
					}
				}

				public string SDKClientPort
				{
					get
					{
						return sDKClientPort;
					}
					set	
					{
						sDKClientPort = value;
					}
				}

				public string TLSPort
				{
					get
					{
						return tLSPort;
					}
					set	
					{
						tLSPort = value;
					}
				}

				public string UseTLS
				{
					get
					{
						return useTLS;
					}
					set	
					{
						useTLS = value;
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

				public string ReconnectTimeout
				{
					get
					{
						return reconnectTimeout;
					}
					set	
					{
						reconnectTimeout = value;
					}
				}
			}

			public class RegisterDevice_AuthWsChannelConfig
			{

				private string authWsUrl;

				private int? wsOuterReconnTime;

				private string token;

				public string AuthWsUrl
				{
					get
					{
						return authWsUrl;
					}
					set	
					{
						authWsUrl = value;
					}
				}

				public int? WsOuterReconnTime
				{
					get
					{
						return wsOuterReconnTime;
					}
					set	
					{
						wsOuterReconnTime = value;
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
			}

			public class RegisterDevice_SlsConfig
			{

				private string project;

				private string logStore;

				private string logServiceEndpoint;

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

				public string LogStore
				{
					get
					{
						return logStore;
					}
					set	
					{
						logStore = value;
					}
				}

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
			}
		}
	}
}
