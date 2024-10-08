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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class SubmitEmailVerificationResponse : AcsResponse
	{

		private string requestId;

		private List<SubmitEmailVerification_SendResult> existList;

		private List<SubmitEmailVerification_SendResult> successList;

		private List<SubmitEmailVerification_SendResult> failList;

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

		[JsonProperty(PropertyName = "ExistList")]
		public List<SubmitEmailVerification_SendResult> ExistList
		{
			get
			{
				return existList;
			}
			set	
			{
				existList = value;
			}
		}

		[JsonProperty(PropertyName = "SuccessList")]
		public List<SubmitEmailVerification_SendResult> SuccessList
		{
			get
			{
				return successList;
			}
			set	
			{
				successList = value;
			}
		}

		[JsonProperty(PropertyName = "FailList")]
		public List<SubmitEmailVerification_SendResult> FailList
		{
			get
			{
				return failList;
			}
			set	
			{
				failList = value;
			}
		}

		public class SubmitEmailVerification_SendResult
		{

			private string email;

			private string code;

			private string message;

			[JsonProperty(PropertyName = "Email")]
			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
				}
			}

			[JsonProperty(PropertyName = "Code")]
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

			[JsonProperty(PropertyName = "Message")]
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
		}
	}
}
