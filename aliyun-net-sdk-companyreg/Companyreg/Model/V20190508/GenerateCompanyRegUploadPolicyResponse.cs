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

namespace Aliyun.Acs.companyreg.Model.V20190508
{
	public class GenerateCompanyRegUploadPolicyResponse : AcsResponse
	{

		private string requestId;

		private string accessId;

		private string signature;

		private string fileDir;

		private string host;

		private long? expireTime;

		private string encodedPolicy;

		private long? min;

		private long? max;

		private string encryption;

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

		public string FileDir
		{
			get
			{
				return fileDir;
			}
			set	
			{
				fileDir = value;
			}
		}

		public string Host
		{
			get
			{
				return host;
			}
			set	
			{
				host = value;
			}
		}

		public long? ExpireTime
		{
			get
			{
				return expireTime;
			}
			set	
			{
				expireTime = value;
			}
		}

		public string EncodedPolicy
		{
			get
			{
				return encodedPolicy;
			}
			set	
			{
				encodedPolicy = value;
			}
		}

		public long? Min
		{
			get
			{
				return min;
			}
			set	
			{
				min = value;
			}
		}

		public long? Max
		{
			get
			{
				return max;
			}
			set	
			{
				max = value;
			}
		}

		public string Encryption
		{
			get
			{
				return encryption;
			}
			set	
			{
				encryption = value;
			}
		}
	}
}
