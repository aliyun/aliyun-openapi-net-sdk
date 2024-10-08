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
	public class AdvanceEncryptResponse : AcsResponse
	{

		private string requestId;

		private string ciphertextBlob;

		private string algorithm;

		private string keyId;

		private string keyVersionId;

		private string iv;

		private string paddingMode;

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

		public string CiphertextBlob
		{
			get
			{
				return ciphertextBlob;
			}
			set	
			{
				ciphertextBlob = value;
			}
		}

		public string Algorithm
		{
			get
			{
				return algorithm;
			}
			set	
			{
				algorithm = value;
			}
		}

		public string KeyId
		{
			get
			{
				return keyId;
			}
			set	
			{
				keyId = value;
			}
		}

		public string KeyVersionId
		{
			get
			{
				return keyVersionId;
			}
			set	
			{
				keyVersionId = value;
			}
		}

		public string Iv
		{
			get
			{
				return iv;
			}
			set	
			{
				iv = value;
			}
		}

		public string PaddingMode
		{
			get
			{
				return paddingMode;
			}
			set	
			{
				paddingMode = value;
			}
		}
	}
}
