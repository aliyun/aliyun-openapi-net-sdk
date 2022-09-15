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
	public class DescribeLiveDomainOnlineUserNumResponse : AcsResponse
	{

		private string requestId;

		private int? userCount;

		private int? streamCount;

		private List<DescribeLiveDomainOnlineUserNum_LiveStreamOnlineUserNumInfo> onlineUserInfo;

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

		[JsonProperty(PropertyName = "UserCount")]
		public int? UserCount
		{
			get
			{
				return userCount;
			}
			set	
			{
				userCount = value;
			}
		}

		[JsonProperty(PropertyName = "StreamCount")]
		public int? StreamCount
		{
			get
			{
				return streamCount;
			}
			set	
			{
				streamCount = value;
			}
		}

		[JsonProperty(PropertyName = "OnlineUserInfo")]
		public List<DescribeLiveDomainOnlineUserNum_LiveStreamOnlineUserNumInfo> OnlineUserInfo
		{
			get
			{
				return onlineUserInfo;
			}
			set	
			{
				onlineUserInfo = value;
			}
		}

		public class DescribeLiveDomainOnlineUserNum_LiveStreamOnlineUserNumInfo
		{

			private string streamName;

			private List<DescribeLiveDomainOnlineUserNum_Info> infos;

			[JsonProperty(PropertyName = "StreamName")]
			public string StreamName
			{
				get
				{
					return streamName;
				}
				set	
				{
					streamName = value;
				}
			}

			[JsonProperty(PropertyName = "Infos")]
			public List<DescribeLiveDomainOnlineUserNum_Info> Infos
			{
				get
				{
					return infos;
				}
				set	
				{
					infos = value;
				}
			}

			public class DescribeLiveDomainOnlineUserNum_Info
			{

				private long? userNumber;

				private string transcodeTemplate;

				[JsonProperty(PropertyName = "UserNumber")]
				public long? UserNumber
				{
					get
					{
						return userNumber;
					}
					set	
					{
						userNumber = value;
					}
				}

				[JsonProperty(PropertyName = "TranscodeTemplate")]
				public string TranscodeTemplate
				{
					get
					{
						return transcodeTemplate;
					}
					set	
					{
						transcodeTemplate = value;
					}
				}
			}
		}
	}
}
