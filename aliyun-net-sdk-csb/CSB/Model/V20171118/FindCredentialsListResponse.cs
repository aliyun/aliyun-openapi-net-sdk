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
	public class FindCredentialsListResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private FindCredentialsList_Data data;

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

		public FindCredentialsList_Data Data
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

		public class FindCredentialsList_Data
		{

			private int? currentPage;

			private int? pageNumber;

			private List<FindCredentialsList_Credential> credentialList;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public List<FindCredentialsList_Credential> CredentialList
			{
				get
				{
					return credentialList;
				}
				set	
				{
					credentialList = value;
				}
			}

			public class FindCredentialsList_Credential
			{

				private long? gmtCreate;

				private long? id;

				private string name;

				private string ownerAttr;

				private string userId;

				private FindCredentialsList_CurrentCredential currentCredential;

				private FindCredentialsList_NewCredential newCredential;

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

				public string OwnerAttr
				{
					get
					{
						return ownerAttr;
					}
					set	
					{
						ownerAttr = value;
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

				public FindCredentialsList_CurrentCredential CurrentCredential
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

				public FindCredentialsList_NewCredential NewCredential
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

				public class FindCredentialsList_CurrentCredential
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

				public class FindCredentialsList_NewCredential
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