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

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
	public class InitDeviceResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private InitDevice_ResultObject resultObject;

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

		public InitDevice_ResultObject ResultObject
		{
			get
			{
				return resultObject;
			}
			set	
			{
				resultObject = value;
			}
		}

		public class InitDevice_ResultObject
		{

			private string ossEndPoint;

			private string retCodeSub;

			private string protocol;

			private string certifyId;

			private string extParams;

			private string message;

			private string fileName;

			private string accessKeyId;

			private string presignedUrl;

			private string securityToken;

			private string fileNamePrefix;

			private string bucketName;

			private string accessKeySecret;

			private string retMessageSub;

			private string retCode;

			public string OssEndPoint
			{
				get
				{
					return ossEndPoint;
				}
				set	
				{
					ossEndPoint = value;
				}
			}

			public string RetCodeSub
			{
				get
				{
					return retCodeSub;
				}
				set	
				{
					retCodeSub = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public string CertifyId
			{
				get
				{
					return certifyId;
				}
				set	
				{
					certifyId = value;
				}
			}

			public string ExtParams
			{
				get
				{
					return extParams;
				}
				set	
				{
					extParams = value;
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

			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
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

			public string PresignedUrl
			{
				get
				{
					return presignedUrl;
				}
				set	
				{
					presignedUrl = value;
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

			public string FileNamePrefix
			{
				get
				{
					return fileNamePrefix;
				}
				set	
				{
					fileNamePrefix = value;
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

			public string RetMessageSub
			{
				get
				{
					return retMessageSub;
				}
				set	
				{
					retMessageSub = value;
				}
			}

			public string RetCode
			{
				get
				{
					return retCode;
				}
				set	
				{
					retCode = value;
				}
			}
		}
	}
}
