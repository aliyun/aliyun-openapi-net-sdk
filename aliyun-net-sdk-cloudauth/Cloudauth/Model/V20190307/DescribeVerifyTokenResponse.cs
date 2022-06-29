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

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
	public class DescribeVerifyTokenResponse : AcsResponse
	{

		private string verifyPageUrl;

		private string requestId;

		private string verifyToken;

		private DescribeVerifyToken_OssUploadToken ossUploadToken;

		public string VerifyPageUrl
		{
			get
			{
				return verifyPageUrl;
			}
			set	
			{
				verifyPageUrl = value;
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

		public string VerifyToken
		{
			get
			{
				return verifyToken;
			}
			set	
			{
				verifyToken = value;
			}
		}

		public DescribeVerifyToken_OssUploadToken OssUploadToken
		{
			get
			{
				return ossUploadToken;
			}
			set	
			{
				ossUploadToken = value;
			}
		}

		public class DescribeVerifyToken_OssUploadToken
		{

			private string key;

			private string token;

			private string secret;

			private long? expired;

			private string path;

			private string endPoint;

			private string bucket;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Token
			{
				get
				{
					return token;
				}
				set	
				{
					token = value;
				}
			}

			public string Secret
			{
				get
				{
					return secret;
				}
				set	
				{
					secret = value;
				}
			}

			public long? Expired
			{
				get
				{
					return expired;
				}
				set	
				{
					expired = value;
				}
			}

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}

			public string EndPoint
			{
				get
				{
					return endPoint;
				}
				set	
				{
					endPoint = value;
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
		}
	}
}
