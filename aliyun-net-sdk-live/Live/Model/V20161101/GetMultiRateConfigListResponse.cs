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
	public class GetMultiRateConfigListResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<GetMultiRateConfigList_Info> groupInfo;

		[JsonProperty(PropertyName = "Code")]
		public int? Code
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

		[JsonProperty(PropertyName = "GroupInfo")]
		public List<GetMultiRateConfigList_Info> GroupInfo
		{
			get
			{
				return groupInfo;
			}
			set	
			{
				groupInfo = value;
			}
		}

		public class GetMultiRateConfigList_Info
		{

			private string groupId;

			private int? count;

			private string app;

			private string avFormat;

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

			[JsonProperty(PropertyName = "Count")]
			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			[JsonProperty(PropertyName = "App")]
			public string App
			{
				get
				{
					return app;
				}
				set	
				{
					app = value;
				}
			}

			[JsonProperty(PropertyName = "AvFormat")]
			public string AvFormat
			{
				get
				{
					return avFormat;
				}
				set	
				{
					avFormat = value;
				}
			}
		}
	}
}
