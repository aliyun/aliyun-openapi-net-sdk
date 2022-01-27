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

namespace Aliyun.Acs.codeup.Model.V20200414
{
	public class GetCodeCompletionResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private bool? success;

		private string errorMessage;

		private GetCodeCompletion_Result result;

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

		public string ErrorCode
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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public GetCodeCompletion_Result Result
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

		public class GetCodeCompletion_Result
		{

			private string body;

			private string clientTimestamp;

			private string receiveTimestamp;

			private string invokeTimestamp;

			private string fetchTimestamp;

			private string rspTimestamp;

			public string Body
			{
				get
				{
					return body;
				}
				set	
				{
					body = value;
				}
			}

			public string ClientTimestamp
			{
				get
				{
					return clientTimestamp;
				}
				set	
				{
					clientTimestamp = value;
				}
			}

			public string ReceiveTimestamp
			{
				get
				{
					return receiveTimestamp;
				}
				set	
				{
					receiveTimestamp = value;
				}
			}

			public string InvokeTimestamp
			{
				get
				{
					return invokeTimestamp;
				}
				set	
				{
					invokeTimestamp = value;
				}
			}

			public string FetchTimestamp
			{
				get
				{
					return fetchTimestamp;
				}
				set	
				{
					fetchTimestamp = value;
				}
			}

			public string RspTimestamp
			{
				get
				{
					return rspTimestamp;
				}
				set	
				{
					rspTimestamp = value;
				}
			}
		}
	}
}
