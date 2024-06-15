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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeRtcMPUEventSubResponse : AcsResponse
	{

		private string requestId;

		private DescribeRtcMPUEventSub_SubInfo subInfo;

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

		[JsonProperty(PropertyName = "SubInfo")]
		public DescribeRtcMPUEventSub_SubInfo SubInfo
		{
			get
			{
				return subInfo;
			}
			set	
			{
				subInfo = value;
			}
		}

		public class DescribeRtcMPUEventSub_SubInfo
		{

			private string subId;

			private string appId;

			private string channelIds;

			private string createTime;

			private string callbackUrl;

			[JsonProperty(PropertyName = "SubId")]
			public string SubId
			{
				get
				{
					return subId;
				}
				set	
				{
					subId = value;
				}
			}

			[JsonProperty(PropertyName = "AppId")]
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

			[JsonProperty(PropertyName = "ChannelIds")]
			public string ChannelIds
			{
				get
				{
					return channelIds;
				}
				set	
				{
					channelIds = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTime")]
			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			[JsonProperty(PropertyName = "CallbackUrl")]
			public string CallbackUrl
			{
				get
				{
					return callbackUrl;
				}
				set	
				{
					callbackUrl = value;
				}
			}
		}
	}
}
