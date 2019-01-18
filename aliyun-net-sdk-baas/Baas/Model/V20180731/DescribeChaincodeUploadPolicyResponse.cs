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

namespace Aliyun.Acs.Baas.Model.V20180731
{
	public class DescribeChaincodeUploadPolicyResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private DescribeChaincodeUploadPolicy_Result result;

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

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public DescribeChaincodeUploadPolicy_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeChaincodeUploadPolicy_Result
		{

			private string accessId;

			private string policy;

			private string signature;

			private string dir;

			private string host;

			private int? expire;

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

			public int? Expire
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
}