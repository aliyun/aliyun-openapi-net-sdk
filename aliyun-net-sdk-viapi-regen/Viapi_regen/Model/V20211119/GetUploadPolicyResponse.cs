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

namespace Aliyun.Acs.viapi_regen.Model.V20211119
{
	public class GetUploadPolicyResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private GetUploadPolicy_Data data;

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Data")]
		public GetUploadPolicy_Data Data
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

		public class GetUploadPolicy_Data
		{

			private string accessId;

			private string policy;

			private string signature;

			private string objectKey;

			private string fileName;

			private string bucketName;

			private string endpoint;

			private string originalFilename;

			private string signedHttpUrl;

			[JsonProperty(PropertyName = "AccessId")]
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

			[JsonProperty(PropertyName = "Policy")]
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

			[JsonProperty(PropertyName = "Signature")]
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

			[JsonProperty(PropertyName = "ObjectKey")]
			public string ObjectKey
			{
				get
				{
					return objectKey;
				}
				set	
				{
					objectKey = value;
				}
			}

			[JsonProperty(PropertyName = "FileName")]
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

			[JsonProperty(PropertyName = "BucketName")]
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

			[JsonProperty(PropertyName = "Endpoint")]
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

			[JsonProperty(PropertyName = "OriginalFilename")]
			public string OriginalFilename
			{
				get
				{
					return originalFilename;
				}
				set	
				{
					originalFilename = value;
				}
			}

			[JsonProperty(PropertyName = "SignedHttpUrl")]
			public string SignedHttpUrl
			{
				get
				{
					return signedHttpUrl;
				}
				set	
				{
					signedHttpUrl = value;
				}
			}
		}
	}
}
