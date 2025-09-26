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

namespace Aliyun.Acs.Dypnsapi.Model.V20170525
{
	public class SendSmsVerifyCodeResponse : AcsResponse
	{

		private string accessDeniedDetail;

		private string message;

		private string requestId;

		private string code;

		private bool? success;

		private SendSmsVerifyCode_Model model;

		public string AccessDeniedDetail
		{
			get
			{
				return accessDeniedDetail;
			}
			set	
			{
				accessDeniedDetail = value;
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

		public SendSmsVerifyCode_Model Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
			}
		}

		public class SendSmsVerifyCode_Model
		{

			private string verifyCode;

			private string requestId;

			private string outId;

			private string bizId;

			public string VerifyCode
			{
				get
				{
					return verifyCode;
				}
				set	
				{
					verifyCode = value;
				}
			}

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

			public string OutId
			{
				get
				{
					return outId;
				}
				set	
				{
					outId = value;
				}
			}

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}
		}
	}
}
