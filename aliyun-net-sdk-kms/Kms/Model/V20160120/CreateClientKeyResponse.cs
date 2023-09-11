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
	public class CreateClientKeyResponse : AcsResponse
	{

		private string requestId;

		private string clientKeyId;

		private string keyAlgorithm;

		private string privateKeyData;

		private string notBefore;

		private string notAfter;

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

		[JsonProperty(PropertyName = "PrivateKeyData")]
		public string PrivateKeyData
		{
			get
			{
				return privateKeyData;
			}
			set	
			{
				privateKeyData = value;
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
	}
}
