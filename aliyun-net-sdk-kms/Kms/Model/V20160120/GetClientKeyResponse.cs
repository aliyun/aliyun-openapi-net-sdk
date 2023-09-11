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

namespace Aliyun.Acs.Kms.Model.V20160120
{
	public class GetClientKeyResponse : AcsResponse
	{

		private string requestId;

		private string clientKeyId;

		private string createTime;

		private string keyAlgorithm;

		private string keyOrigin;

		private string publicKeyData;

		private string notAfter;

		private string notBefore;

		private string aapName;

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

		[JsonProperty(PropertyName = "ClientKeyId")]
		public string ClientKeyId
		{
			get
			{
				return clientKeyId;
			}
			set	
			{
				clientKeyId = value;
			}
		}

		[JsonProperty(PropertyName = "CreateTime")]
		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		[JsonProperty(PropertyName = "KeyAlgorithm")]
		public string KeyAlgorithm
		{
			get
			{
				return keyAlgorithm;
			}
			set	
			{
				keyAlgorithm = value;
			}
		}

		[JsonProperty(PropertyName = "KeyOrigin")]
		public string KeyOrigin
		{
			get
			{
				return keyOrigin;
			}
			set	
			{
				keyOrigin = value;
			}
		}

		[JsonProperty(PropertyName = "PublicKeyData")]
		public string PublicKeyData
		{
			get
			{
				return publicKeyData;
			}
			set	
			{
				publicKeyData = value;
			}
		}

		[JsonProperty(PropertyName = "NotAfter")]
		public string NotAfter
		{
			get
			{
				return notAfter;
			}
			set	
			{
				notAfter = value;
			}
		}

		[JsonProperty(PropertyName = "NotBefore")]
		public string NotBefore
		{
			get
			{
				return notBefore;
			}
			set	
			{
				notBefore = value;
			}
		}

		[JsonProperty(PropertyName = "AapName")]
		public string AapName
		{
			get
			{
				return aapName;
			}
			set	
			{
				aapName = value;
			}
		}
	}
}
