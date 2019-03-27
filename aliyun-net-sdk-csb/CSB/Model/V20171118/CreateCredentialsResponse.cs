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

namespace Aliyun.Acs.CSB.Model.V20171118
{
	public class CreateCredentialsResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private CreateCredentials_Data data;

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

		public CreateCredentials_Data Data
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

		public class CreateCredentials_Data
		{

			private CreateCredentials_Credentials credentials;

			public CreateCredentials_Credentials Credentials
			{
				get
				{
					return credentials;
				}
				set	
				{
					credentials = value;
				}
			}

			public class CreateCredentials_Credentials
			{

				private long? id;

				private CreateCredentials_CurrentCredential currentCredential;

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public CreateCredentials_CurrentCredential CurrentCredential
				{
					get
					{
						return currentCredential;
					}
					set	
					{
						currentCredential = value;
					}
				}

				public class CreateCredentials_CurrentCredential
				{

					private string secretKey;

					private string accessKey;

					public string SecretKey
					{
						get
						{
							return secretKey;
						}
						set	
						{
							secretKey = value;
						}
					}

					public string AccessKey
					{
						get
						{
							return accessKey;
						}
						set	
						{
							accessKey = value;
						}
					}
				}
			}
		}
	}
}
