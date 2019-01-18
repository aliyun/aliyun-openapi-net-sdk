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

namespace Aliyun.Acs.Sts.Model.V20150401
{
	public class GenerateSessionAccessKeyResponse : AcsResponse
	{

		private string requestId;

		private GenerateSessionAccessKey_SessionAccessKey sessionAccessKey;

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

		public GenerateSessionAccessKey_SessionAccessKey SessionAccessKey
		{
			get
			{
				return sessionAccessKey;
			}
			set	
			{
				sessionAccessKey = value;
			}
		}

		public class GenerateSessionAccessKey_SessionAccessKey
		{

			private string sessionAccessKeyId;

			private string sessionAccessKeySecret;

			private string expiration;

			public string SessionAccessKeyId
			{
				get
				{
					return sessionAccessKeyId;
				}
				set	
				{
					sessionAccessKeyId = value;
				}
			}

			public string SessionAccessKeySecret
			{
				get
				{
					return sessionAccessKeySecret;
				}
				set	
				{
					sessionAccessKeySecret = value;
				}
			}

			public string Expiration
			{
				get
				{
					return expiration;
				}
				set	
				{
					expiration = value;
				}
			}
		}
	}
}