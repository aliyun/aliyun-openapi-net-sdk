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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDomainWhoisInfoResponse : AcsResponse
	{

		private string registrantName;

		private string registrantEmail;

		private string registrar;

		private string registrationDate;

		private string expirationDate;

		private List<string> statusList;

		private List<string> dnsServers;

		public string RegistrantName
		{
			get
			{
				return registrantName;
			}
			set	
			{
				registrantName = value;
			}
		}

		public string RegistrantEmail
		{
			get
			{
				return registrantEmail;
			}
			set	
			{
				registrantEmail = value;
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

		public string RegistrationDate
		{
			get
			{
				return registrationDate;
			}
			set	
			{
				registrationDate = value;
			}
		}

		public string ExpirationDate
		{
			get
			{
				return expirationDate;
			}
			set	
			{
				expirationDate = value;
			}
		}

		public List<string> StatusList
		{
			get
			{
				return statusList;
			}
			set	
			{
				statusList = value;
			}
		}

		public List<string> DnsServers
		{
			get
			{
				return dnsServers;
			}
			set	
			{
				dnsServers = value;
			}
		}
	}
}