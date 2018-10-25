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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class GetQualificationUploadPolicyResponse : AcsResponse
	{

		private string requestId;

		private string accessid;

		private string policy;

		private string signature;

		private string dir;

		private string prefix;

		private string host;

		private string expire;

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

		public string Accessid
		{
			get
			{
				return accessid;
			}
			set	
			{
				accessid = value;
			}
		}

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

		public string Dir
		{
			get
			{
				return dir;
			}
			set	
			{
				dir = value;
			}
		}

		public string Prefix
		{
			get
			{
				return prefix;
			}
			set	
			{
				prefix = value;
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

		public string Expire
		{
			get
			{
				return expire;
			}
			set	
			{
				expire = value;
			}
		}
	}
}