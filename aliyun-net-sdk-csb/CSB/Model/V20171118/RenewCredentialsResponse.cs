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

namespace Aliyun.Acs.CSB.Model.V20171118
{
	public class RenewCredentialsResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private RenewCredentials_Data data;

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

		public RenewCredentials_Data Data
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

		public class RenewCredentials_Data
		{

			private RenewCredentials_Credentials credentials;

			public RenewCredentials_Credentials Credentials
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

			public class RenewCredentials_Credentials
			{

				private long? gmtCreate;

				private long? id;

				private string name;

				private string userId;

				private RenewCredentials_CurrentCredential currentCredential;

				private RenewCredentials_NewCredential newCredential;

				public long? GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

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

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
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

				public RenewCredentials_CurrentCredential CurrentCredential
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

				public RenewCredentials_NewCredential NewCredential
				{
					get
					{
						return newCredential;
					}
					set	
					{
						newCredential = value;
					}
				}

				public class RenewCredentials_CurrentCredential
				{

					private string accessKey;

					private string secretKey;

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
				}

				public class RenewCredentials_NewCredential
				{

					private string accessKey;

					private string secretKey;

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
				}
			}
		}
	}
}