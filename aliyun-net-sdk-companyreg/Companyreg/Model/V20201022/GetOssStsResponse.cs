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

namespace Aliyun.Acs.companyreg.Model.V20201022
{
	public class GetOssStsResponse : AcsResponse
	{

		private string requestId;

		private string accessId;

		private string encodedPolicy;

		private string signature;

		private string filePath;

		private long? expireTime;

		private string host;

		private string ossHost;

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

		public string FilePath
		{
			get
			{
				return filePath;
			}
			set	
			{
				filePath = value;
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

		public string OssHost
		{
			get
			{
				return ossHost;
			}
			set	
			{
				ossHost = value;
			}
		}
	}
}
