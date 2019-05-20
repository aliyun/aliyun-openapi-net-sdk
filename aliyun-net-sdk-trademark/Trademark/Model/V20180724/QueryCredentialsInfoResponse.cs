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

namespace Aliyun.Acs.Trademark.Model.V20180724
{
	public class QueryCredentialsInfoResponse : AcsResponse
	{

		private string requestId;

		private QueryCredentialsInfo_CredentialsInfo credentialsInfo;

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

		public QueryCredentialsInfo_CredentialsInfo CredentialsInfo
		{
			get
			{
				return credentialsInfo;
			}
			set	
			{
				credentialsInfo = value;
			}
		}

		public class QueryCredentialsInfo_CredentialsInfo
		{

			private string cardNumber;

			private string address;

			private string companyName;

			private string personName;

			private string province;

			public string CardNumber
			{
				get
				{
					return cardNumber;
				}
				set	
				{
					cardNumber = value;
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string CompanyName
			{
				get
				{
					return companyName;
				}
				set	
				{
					companyName = value;
				}
			}

			public string PersonName
			{
				get
				{
					return personName;
				}
				set	
				{
					personName = value;
				}
			}

			public string Province
			{
				get
				{
					return province;
				}
				set	
				{
					province = value;
				}
			}
		}
	}
}
