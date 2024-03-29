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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryMessageInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string code;

		private QueryMessageInfo_Message message;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public QueryMessageInfo_Message Message
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

		public class QueryMessageInfo_Message
		{

			private string uniMsgId;

			private string topicFullName;

			private string messageContent;

			private long? generateTime;

			private string transformedMessageContent;

			private string transformedTopicFullName;

			private List<QueryMessageInfo_UserProperty> userProperties;

			private List<QueryMessageInfo_MqttProperty> mqttProperties;

			public string UniMsgId
			{
				get
				{
					return uniMsgId;
				}
				set	
				{
					uniMsgId = value;
				}
			}

			public string TopicFullName
			{
				get
				{
					return topicFullName;
				}
				set	
				{
					topicFullName = value;
				}
			}

			public string MessageContent
			{
				get
				{
					return messageContent;
				}
				set	
				{
					messageContent = value;
				}
			}

			public long? GenerateTime
			{
				get
				{
					return generateTime;
				}
				set	
				{
					generateTime = value;
				}
			}

			public string TransformedMessageContent
			{
				get
				{
					return transformedMessageContent;
				}
				set	
				{
					transformedMessageContent = value;
				}
			}

			public string TransformedTopicFullName
			{
				get
				{
					return transformedTopicFullName;
				}
				set	
				{
					transformedTopicFullName = value;
				}
			}

			public List<QueryMessageInfo_UserProperty> UserProperties
			{
				get
				{
					return userProperties;
				}
				set	
				{
					userProperties = value;
				}
			}

			public List<QueryMessageInfo_MqttProperty> MqttProperties
			{
				get
				{
					return mqttProperties;
				}
				set	
				{
					mqttProperties = value;
				}
			}

			public class QueryMessageInfo_UserProperty
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class QueryMessageInfo_MqttProperty
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
