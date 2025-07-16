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

namespace Aliyun.Acs.LingMou.Model.V20250527
{
	public class CreateChatSessionResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private long? httpStatusCode;

		private string code;

		private bool? success;

		private CreateChatSession_Data data;

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

		public long? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public CreateChatSession_Data Data
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

		public class CreateChatSession_Data
		{

			private string sessionId;

			private CreateChatSession_RtcParams rtcParams;

			private CreateChatSession_AvatarAssets avatarAssets;

			public string SessionId
			{
				get
				{
					return sessionId;
				}
				set	
				{
					sessionId = value;
				}
			}

			public CreateChatSession_RtcParams RtcParams
			{
				get
				{
					return rtcParams;
				}
				set	
				{
					rtcParams = value;
				}
			}

			public CreateChatSession_AvatarAssets AvatarAssets
			{
				get
				{
					return avatarAssets;
				}
				set	
				{
					avatarAssets = value;
				}
			}

			public class CreateChatSession_RtcParams
			{

				private string appId;

				private string avatarUserId;

				private string channel;

				private string clientUserId;

				private string gslb;

				private string nonce;

				private string serverUserId;

				private long? timestamp;

				private string token;

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

				public string AvatarUserId
				{
					get
					{
						return avatarUserId;
					}
					set	
					{
						avatarUserId = value;
					}
				}

				public string Channel
				{
					get
					{
						return channel;
					}
					set	
					{
						channel = value;
					}
				}

				public string ClientUserId
				{
					get
					{
						return clientUserId;
					}
					set	
					{
						clientUserId = value;
					}
				}

				public string Gslb
				{
					get
					{
						return gslb;
					}
					set	
					{
						gslb = value;
					}
				}

				public string Nonce
				{
					get
					{
						return nonce;
					}
					set	
					{
						nonce = value;
					}
				}

				public string ServerUserId
				{
					get
					{
						return serverUserId;
					}
					set	
					{
						serverUserId = value;
					}
				}

				public long? Timestamp
				{
					get
					{
						return timestamp;
					}
					set	
					{
						timestamp = value;
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

			public class CreateChatSession_AvatarAssets
			{

				private string url;

				private string md5;

				private string secret;

				private string type;

				private string minRequiredVersion;

				public string Url
				{
					get
					{
						return url;
					}
					set	
					{
						url = value;
					}
				}

				public string Md5
				{
					get
					{
						return md5;
					}
					set	
					{
						md5 = value;
					}
				}

				public string Secret
				{
					get
					{
						return secret;
					}
					set	
					{
						secret = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string MinRequiredVersion
				{
					get
					{
						return minRequiredVersion;
					}
					set	
					{
						minRequiredVersion = value;
					}
				}
			}
		}
	}
}
