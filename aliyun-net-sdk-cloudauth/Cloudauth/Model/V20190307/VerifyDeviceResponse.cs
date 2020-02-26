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
	public class VerifyDeviceResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private VerifyDevice_ResultObject resultObject;

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

		public VerifyDevice_ResultObject ResultObject
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

		public class VerifyDevice_ResultObject
		{

			private string validationRetCode;

			private string productRetCode;

			private string retCodeSub;

			private string retMessageSub;

			private string hasNext;

			private string extParams;

			public string ValidationRetCode
			{
				get
				{
					return validationRetCode;
				}
				set	
				{
					validationRetCode = value;
				}
			}

			public string ProductRetCode
			{
				get
				{
					return productRetCode;
				}
				set	
				{
					productRetCode = value;
				}
			}

			public string RetCodeSub
			{
				get
				{
					return retCodeSub;
				}
				set	
				{
					retCodeSub = value;
				}
			}

			public string RetMessageSub
			{
				get
				{
					return retMessageSub;
				}
				set	
				{
					retMessageSub = value;
				}
			}

			public string HasNext
			{
				get
				{
					return hasNext;
				}
				set	
				{
					hasNext = value;
				}
			}

			public string ExtParams
			{
				get
				{
					return extParams;
				}
				set	
				{
					extParams = value;
				}
			}
		}
	}
}
