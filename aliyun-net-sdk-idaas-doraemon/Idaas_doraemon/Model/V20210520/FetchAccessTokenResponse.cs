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

namespace Aliyun.Acs.idaas_doraemon.Model.V20210520
{
	public class FetchAccessTokenResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string code;

		private bool? success;

		private FetchAccessToken_Data data;

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

		public FetchAccessToken_Data Data
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

		public class FetchAccessToken_Data
		{

			private string access_token;

			private string token_type;

			private string scope;

			private string expires_in;

			private string refresh_token;

			private string id_token;

			public string Access_token
			{
				get
				{
					return access_token;
				}
				set	
				{
					access_token = value;
				}
			}

			public string Token_type
			{
				get
				{
					return token_type;
				}
				set	
				{
					token_type = value;
				}
			}

			public string Scope
			{
				get
				{
					return scope;
				}
				set	
				{
					scope = value;
				}
			}

			public string Expires_in
			{
				get
				{
					return expires_in;
				}
				set	
				{
					expires_in = value;
				}
			}

			public string Refresh_token
			{
				get
				{
					return refresh_token;
				}
				set	
				{
					refresh_token = value;
				}
			}

			public string Id_token
			{
				get
				{
					return id_token;
				}
				set	
				{
					id_token = value;
				}
			}
		}
	}
}
