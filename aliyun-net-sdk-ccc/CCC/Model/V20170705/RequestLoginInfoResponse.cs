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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class RequestLoginInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private RequestLoginInfo_LoginInfo loginInfo;

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

		public RequestLoginInfo_LoginInfo LoginInfo
		{
			get
			{
				return loginInfo;
			}
			set	
			{
				loginInfo = value;
			}
		}

		public class RequestLoginInfo_LoginInfo
		{

			private string userName;

			private string displayName;

			private string region;

			private string webRtcUrl;

			private string agentServerUrl;

			private string extension;

			private string tenantId;

			private string signature;

			private string signData;

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

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

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string WebRtcUrl
			{
				get
				{
					return webRtcUrl;
				}
				set	
				{
					webRtcUrl = value;
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

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
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

			public string SignData
			{
				get
				{
					return signData;
				}
				set	
				{
					signData = value;
				}
			}
		}
	}
}