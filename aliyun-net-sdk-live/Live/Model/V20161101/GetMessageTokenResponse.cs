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
	public class GetMessageTokenResponse : AcsResponse
	{

		private string requestId;

		private GetMessageToken_Result result;

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

		[JsonProperty(PropertyName = "Result")]
		public GetMessageToken_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class GetMessageToken_Result
		{

			private string accessToken;

			private string refreshToken;

			private long? accessTokenExpiredTime;

			[JsonProperty(PropertyName = "AccessToken")]
			public string AccessToken
			{
				get
				{
					return accessToken;
				}
				set	
				{
					accessToken = value;
				}
			}

			[JsonProperty(PropertyName = "RefreshToken")]
			public string RefreshToken
			{
				get
				{
					return refreshToken;
				}
				set	
				{
					refreshToken = value;
				}
			}

			[JsonProperty(PropertyName = "AccessTokenExpiredTime")]
			public long? AccessTokenExpiredTime
			{
				get
				{
					return accessTokenExpiredTime;
				}
				set	
				{
					accessTokenExpiredTime = value;
				}
			}
		}
	}
}
