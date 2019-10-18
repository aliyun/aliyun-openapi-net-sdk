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

namespace Aliyun.Acs.DnsKnocker.Model.V20190910
{
	public class GetDomainResponse : AcsResponse
	{

		private string requestId;

		private string resultCode;

		private string resultMessage;

		private string success;

		private string transactionId;

		private List<GetDomain_Data> domain;

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

		public string ResultCode
		{
			get
			{
				return resultCode;
			}
			set	
			{
				resultCode = value;
			}
		}

		public string ResultMessage
		{
			get
			{
				return resultMessage;
			}
			set	
			{
				resultMessage = value;
			}
		}

		public string Success
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

		public string TransactionId
		{
			get
			{
				return transactionId;
			}
			set	
			{
				transactionId = value;
			}
		}

		public List<GetDomain_Data> Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
			}
		}

		public class GetDomain_Data
		{

			private string domainName;

			private string exists;

			private string message;

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public string Exists
			{
				get
				{
					return exists;
				}
				set	
				{
					exists = value;
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
		}
	}
}
