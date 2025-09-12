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

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
	public class GetDomainInfoForPartnerResponse : AcsResponse
	{

		private string requestId;

		private GetDomainInfoForPartner_Data data;

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

		public GetDomainInfoForPartner_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetDomainInfoForPartner_Data
		{

			private string domainName;

			private string registrar;

			private string nameServers;

			private GetDomainInfoForPartner_Ownership ownership;

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

			public string Registrar
			{
				get
				{
					return registrar;
				}
				set	
				{
					registrar = value;
				}
			}

			public string NameServers
			{
				get
				{
					return nameServers;
				}
				set	
				{
					nameServers = value;
				}
			}

			public GetDomainInfoForPartner_Ownership Ownership
			{
				get
				{
					return ownership;
				}
				set	
				{
					ownership = value;
				}
			}

			public class GetDomainInfoForPartner_Ownership
			{

				private string account;

				private string provider;

				public string Account
				{
					get
					{
						return account;
					}
					set	
					{
						account = value;
					}
				}

				public string Provider
				{
					get
					{
						return provider;
					}
					set	
					{
						provider = value;
					}
				}
			}
		}
	}
}
