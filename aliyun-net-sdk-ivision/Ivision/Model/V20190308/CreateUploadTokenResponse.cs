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

namespace Aliyun.Acs.ivision.Model.V20190308
{
	public class CreateUploadTokenResponse : AcsResponse
	{

		private string requestId;

		private CreateUploadToken_UploadToken uploadToken;

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

		public CreateUploadToken_UploadToken UploadToken
		{
			get
			{
				return uploadToken;
			}
			set	
			{
				uploadToken = value;
			}
		}

		public class CreateUploadToken_UploadToken
		{

			private string accessKeyId;

			private string accessKeySecret;

			private string securityToken;

			private string expiration;

			private string bucket;

			private string _object;

			private string endpoint;

			private string url;

			public string AccessKeyId
			{
				get
				{
					return accessKeyId;
				}
				set	
				{
					accessKeyId = value;
				}
			}

			public string AccessKeySecret
			{
				get
				{
					return accessKeySecret;
				}
				set	
				{
					accessKeySecret = value;
				}
			}

			public string SecurityToken
			{
				get
				{
					return securityToken;
				}
				set	
				{
					securityToken = value;
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

			public string Bucket
			{
				get
				{
					return bucket;
				}
				set	
				{
					bucket = value;
				}
			}

			public string _Object
			{
				get
				{
					return _object;
				}
				set	
				{
					_object = value;
				}
			}

			public string Endpoint
			{
				get
				{
					return endpoint;
				}
				set	
				{
					endpoint = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}
		}
	}
}
