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

namespace Aliyun.Acs.Cloudauth.Model.V20180916
{
	public class GetVerifyTokenResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetVerifyToken_Data data;

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

		public GetVerifyToken_Data Data
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

		public class GetVerifyToken_Data
		{

			private string cloudauthPageUrl;

			private GetVerifyToken_VerifyToken verifyToken;

			private GetVerifyToken_StsToken stsToken;

			public string CloudauthPageUrl
			{
				get
				{
					return cloudauthPageUrl;
				}
				set	
				{
					cloudauthPageUrl = value;
				}
			}

			public GetVerifyToken_VerifyToken VerifyToken
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

			public GetVerifyToken_StsToken StsToken
			{
				get
				{
					return stsToken;
				}
				set	
				{
					stsToken = value;
				}
			}

			public class GetVerifyToken_VerifyToken
			{

				private int? durationSeconds;

				private string token;

				public int? DurationSeconds
				{
					get
					{
						return durationSeconds;
					}
					set	
					{
						durationSeconds = value;
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
			}

			public class GetVerifyToken_StsToken
			{

				private string token;

				private string bucketName;

				private string accessKeySecret;

				private string expiration;

				private string path;

				private string accessKeyId;

				private string endPoint;

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

				public string BucketName
				{
					get
					{
						return bucketName;
					}
					set	
					{
						bucketName = value;
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
			}
		}
	}
}
