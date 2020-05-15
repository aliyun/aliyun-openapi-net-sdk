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
	public class BatchGetEdgeInstanceChannelResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private List<BatchGetEdgeInstanceChannel_Channel> data;

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

		public List<BatchGetEdgeInstanceChannel_Channel> Data
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

		public class BatchGetEdgeInstanceChannel_Channel
		{

			private string channelId;

			private string channelName;

			private List<BatchGetEdgeInstanceChannel_Config> configList;

			public string ChannelId
			{
				get
				{
					return channelId;
				}
				set	
				{
					channelId = value;
				}
			}

			public string ChannelName
			{
				get
				{
					return channelName;
				}
				set	
				{
					channelName = value;
				}
			}

			public List<BatchGetEdgeInstanceChannel_Config> ConfigList
			{
				get
				{
					return configList;
				}
				set	
				{
					configList = value;
				}
			}

			public class BatchGetEdgeInstanceChannel_Config
			{

				private string configId;

				private string format;

				private string content;

				private string key;

				public string ConfigId
				{
					get
					{
						return configId;
					}
					set	
					{
						configId = value;
					}
				}

				public string Format
				{
					get
					{
						return format;
					}
					set	
					{
						format = value;
					}
				}

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

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
			}
		}
	}
}
