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

namespace Aliyun.Acs.idrsservice.Model.V20200630
{
	public class JoinLiveResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private JoinLive_Data data;

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

		public JoinLive_Data Data
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

		public class JoinLive_Data
		{

			private int? code;

			private JoinLive_TokenData tokenData;

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

			public JoinLive_TokenData TokenData
			{
				get
				{
					return tokenData;
				}
				set	
				{
					tokenData = value;
				}
			}

			public class JoinLive_TokenData
			{

				private string appId;

				private string liveId;

				private string nonce;

				private long? timestamp;

				private string token;

				private string userId;

				private List<string> gslb;

				private JoinLive_Turn turn;

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

				public string LiveId
				{
					get
					{
						return liveId;
					}
					set	
					{
						liveId = value;
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

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public List<string> Gslb
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

				public JoinLive_Turn Turn
				{
					get
					{
						return turn;
					}
					set	
					{
						turn = value;
					}
				}

				public class JoinLive_Turn
				{

					private string password;

					private string username;

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

					public string Username
					{
						get
						{
							return username;
						}
						set	
						{
							username = value;
						}
					}
				}
			}
		}
	}
}
