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
	public class OnsMessageGetByMsgIdResponse : AcsResponse
	{

		private string requestId;

		private string helpUrl;

		private OnsMessageGetByMsgId_Data data;

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

		public OnsMessageGetByMsgId_Data Data
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

		public class OnsMessageGetByMsgId_Data
		{

			private string offsetId;

			private int? storeSize;

			private int? reconsumeTimes;

			private long? storeTimestamp;

			private string body;

			private string instanceId;

			private string msgId;

			private int? flag;

			private string storeHost;

			private string topic;

			private long? bornTimestamp;

			private int? bodyCRC;

			private string bornHost;

			private List<OnsMessageGetByMsgId_MessageProperty> propertyList;

			public string OffsetId
			{
				get
				{
					return offsetId;
				}
				set	
				{
					offsetId = value;
				}
			}

			public int? StoreSize
			{
				get
				{
					return storeSize;
				}
				set	
				{
					storeSize = value;
				}
			}

			public int? ReconsumeTimes
			{
				get
				{
					return reconsumeTimes;
				}
				set	
				{
					reconsumeTimes = value;
				}
			}

			public long? StoreTimestamp
			{
				get
				{
					return storeTimestamp;
				}
				set	
				{
					storeTimestamp = value;
				}
			}

			public string Body
			{
				get
				{
					return body;
				}
				set	
				{
					body = value;
				}
			}

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

			public string MsgId
			{
				get
				{
					return msgId;
				}
				set	
				{
					msgId = value;
				}
			}

			public int? Flag
			{
				get
				{
					return flag;
				}
				set	
				{
					flag = value;
				}
			}

			public string StoreHost
			{
				get
				{
					return storeHost;
				}
				set	
				{
					storeHost = value;
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

			public long? BornTimestamp
			{
				get
				{
					return bornTimestamp;
				}
				set	
				{
					bornTimestamp = value;
				}
			}

			public int? BodyCRC
			{
				get
				{
					return bodyCRC;
				}
				set	
				{
					bodyCRC = value;
				}
			}

			public string BornHost
			{
				get
				{
					return bornHost;
				}
				set	
				{
					bornHost = value;
				}
			}

			public List<OnsMessageGetByMsgId_MessageProperty> PropertyList
			{
				get
				{
					return propertyList;
				}
				set	
				{
					propertyList = value;
				}
			}

			public class OnsMessageGetByMsgId_MessageProperty
			{

				private string _value;

				private string name;

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

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}
			}
		}
	}
}
