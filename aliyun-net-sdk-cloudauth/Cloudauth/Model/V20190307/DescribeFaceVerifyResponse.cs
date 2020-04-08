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
	public class DescribeFaceVerifyResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string code;

		private DescribeFaceVerify_ResultObject resultObject;

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

		public DescribeFaceVerify_ResultObject ResultObject
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

		public class DescribeFaceVerify_ResultObject
		{

			private string passed;

			private string identityInfo;

			private string materialInfo;

			private string deviceToken;

			private string subCode;

			public string Passed
			{
				get
				{
					return passed;
				}
				set	
				{
					passed = value;
				}
			}

			public string IdentityInfo
			{
				get
				{
					return identityInfo;
				}
				set	
				{
					identityInfo = value;
				}
			}

			public string MaterialInfo
			{
				get
				{
					return materialInfo;
				}
				set	
				{
					materialInfo = value;
				}
			}

			public string DeviceToken
			{
				get
				{
					return deviceToken;
				}
				set	
				{
					deviceToken = value;
				}
			}

			public string SubCode
			{
				get
				{
					return subCode;
				}
				set	
				{
					subCode = value;
				}
			}
		}
	}
}
