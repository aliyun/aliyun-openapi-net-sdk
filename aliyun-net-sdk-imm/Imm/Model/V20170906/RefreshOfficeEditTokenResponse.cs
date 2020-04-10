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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class RefreshOfficeEditTokenResponse : AcsResponse
	{

		private string accessToken;

		private string accessTokenExpiredTime;

		private string refreshToken;

		private string refreshTokenExpiredTime;

		private string requestId;

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

		public string AccessTokenExpiredTime
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

		public string RefreshTokenExpiredTime
		{
			get
			{
				return refreshTokenExpiredTime;
			}
			set	
			{
				refreshTokenExpiredTime = value;
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
	}
}
