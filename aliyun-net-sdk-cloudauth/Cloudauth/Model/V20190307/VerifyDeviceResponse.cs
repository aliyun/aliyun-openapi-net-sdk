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

		private string code;

		private string message;

		private string requestId;

		private VerifyDevice_ResultObject resultObject;

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

			private string retCodeSub;

			private string productRetCode;

			private string hasNext;

			private string retMessageSub;

			private string extParams;

			private string validationRetCode;

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
		}
	}
}
