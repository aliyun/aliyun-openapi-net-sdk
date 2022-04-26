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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class GetLoginDetailsResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private List<string> _params;

		private GetLoginDetails_Data data;

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

		public int? HttpStatusCode
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

		public List<string> _Params
		{
			get
			{
				return _params;
			}
			set	
			{
				_params = value;
			}
		}

		public GetLoginDetails_Data Data
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

		public class GetLoginDetails_Data
		{

			private string displayName;

			private string extension;

			private string signature;

			private string sipServerUrl;

			private string deviceId;

			private string agentServerUrl;

			private string userId;

			private string userKey;

			private string workMode;

			private string userKey2;

			private string signature2;

			private string deviceExt;

			private string deviceState;

			public string DisplayName
			{
				get
				{
					return displayName;
				}
				set	
				{
					displayName = value;
				}
			}

			public string Extension
			{
				get
				{
					return extension;
				}
				set	
				{
					extension = value;
				}
			}

			public string Signature
			{
				get
				{
					return signature;
				}
				set	
				{
					signature = value;
				}
			}

			public string SipServerUrl
			{
				get
				{
					return sipServerUrl;
				}
				set	
				{
					sipServerUrl = value;
				}
			}

			public string DeviceId
			{
				get
				{
					return deviceId;
				}
				set	
				{
					deviceId = value;
				}
			}

			public string AgentServerUrl
			{
				get
				{
					return agentServerUrl;
				}
				set	
				{
					agentServerUrl = value;
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

			public string UserKey
			{
				get
				{
					return userKey;
				}
				set	
				{
					userKey = value;
				}
			}

			public string WorkMode
			{
				get
				{
					return workMode;
				}
				set	
				{
					workMode = value;
				}
			}

			public string UserKey2
			{
				get
				{
					return userKey2;
				}
				set	
				{
					userKey2 = value;
				}
			}

			public string Signature2
			{
				get
				{
					return signature2;
				}
				set	
				{
					signature2 = value;
				}
			}

			public string DeviceExt
			{
				get
				{
					return deviceExt;
				}
				set	
				{
					deviceExt = value;
				}
			}

			public string DeviceState
			{
				get
				{
					return deviceState;
				}
				set	
				{
					deviceState = value;
				}
			}
		}
	}
}
