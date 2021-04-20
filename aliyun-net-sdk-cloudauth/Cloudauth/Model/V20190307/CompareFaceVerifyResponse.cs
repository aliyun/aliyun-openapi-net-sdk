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
	public class CompareFaceVerifyResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string code;

		private CompareFaceVerify_ResultObject resultObject;

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

		public CompareFaceVerify_ResultObject ResultObject
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

		public class CompareFaceVerify_ResultObject
		{

			private string passed;

			private float? verifyScore;

			private string certifyId;

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

			public float? VerifyScore
			{
				get
				{
					return verifyScore;
				}
				set	
				{
					verifyScore = value;
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
		}
	}
}
