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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class CreateFileDetectUploadUrlResponse : AcsResponse
	{

		private string requestId;

		private List<CreateFileDetectUploadUrl_UploadUrList> uploadUrlList;

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

		public List<CreateFileDetectUploadUrl_UploadUrList> UploadUrlList
		{
			get
			{
				return uploadUrlList;
			}
			set	
			{
				uploadUrlList = value;
			}
		}

		public class CreateFileDetectUploadUrl_UploadUrList
		{

			private string publicUrl;

			private string internalUrl;

			private string expire;

			private bool? fileExist;

			private string hashKey;

			private CreateFileDetectUploadUrl_Context context;

			public string PublicUrl
			{
				get
				{
					return publicUrl;
				}
				set	
				{
					publicUrl = value;
				}
			}

			public string InternalUrl
			{
				get
				{
					return internalUrl;
				}
				set	
				{
					internalUrl = value;
				}
			}

			public string Expire
			{
				get
				{
					return expire;
				}
				set	
				{
					expire = value;
				}
			}

			public bool? FileExist
			{
				get
				{
					return fileExist;
				}
				set	
				{
					fileExist = value;
				}
			}

			public string HashKey
			{
				get
				{
					return hashKey;
				}
				set	
				{
					hashKey = value;
				}
			}

			public CreateFileDetectUploadUrl_Context Context
			{
				get
				{
					return context;
				}
				set	
				{
					context = value;
				}
			}

			public class CreateFileDetectUploadUrl_Context
			{

				private string accessId;

				private string policy;

				private string signature;

				private string ossKey;

				public string AccessId
				{
					get
					{
						return accessId;
					}
					set	
					{
						accessId = value;
					}
				}

				public string Policy
				{
					get
					{
						return policy;
					}
					set	
					{
						policy = value;
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

				public string OssKey
				{
					get
					{
						return ossKey;
					}
					set	
					{
						ossKey = value;
					}
				}
			}
		}
	}
}
