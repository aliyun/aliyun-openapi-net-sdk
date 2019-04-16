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

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
	public class QueryDomainByInstanceIdResponse : AcsResponse
	{

		private string userId;

		private string domainName;

		private string instanceId;

		private string registrationDate;

		private string expirationDate;

		private string registrantOrganization;

		private string registrantName;

		private string email;

		private string updateProhibitionLock;

		private string transferProhibitionLock;

		private bool? domainNameProxyService;

		private bool? premium;

		private int? emailVerificationStatus;

		private bool? emailVerificationClientHold;

		private string realNameStatus;

		private string registrantUpdatingStatus;

		private string transferOutStatus;

		private string registrantType;

		private string domainNameVerificationStatus;

		private string requestId;

		private long? registrationDateLong;

		private long? expirationDateLong;

		private List<string> dnsList;

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
			}
		}

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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
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

		public string RegistrantOrganization
		{
			get
			{
				return registrantOrganization;
			}
			set	
			{
				registrantOrganization = value;
			}
		}

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

		public string UpdateProhibitionLock
		{
			get
			{
				return updateProhibitionLock;
			}
			set	
			{
				updateProhibitionLock = value;
			}
		}

		public string TransferProhibitionLock
		{
			get
			{
				return transferProhibitionLock;
			}
			set	
			{
				transferProhibitionLock = value;
			}
		}

		public bool? DomainNameProxyService
		{
			get
			{
				return domainNameProxyService;
			}
			set	
			{
				domainNameProxyService = value;
			}
		}

		public bool? Premium
		{
			get
			{
				return premium;
			}
			set	
			{
				premium = value;
			}
		}

		public int? EmailVerificationStatus
		{
			get
			{
				return emailVerificationStatus;
			}
			set	
			{
				emailVerificationStatus = value;
			}
		}

		public bool? EmailVerificationClientHold
		{
			get
			{
				return emailVerificationClientHold;
			}
			set	
			{
				emailVerificationClientHold = value;
			}
		}

		public string RealNameStatus
		{
			get
			{
				return realNameStatus;
			}
			set	
			{
				realNameStatus = value;
			}
		}

		public string RegistrantUpdatingStatus
		{
			get
			{
				return registrantUpdatingStatus;
			}
			set	
			{
				registrantUpdatingStatus = value;
			}
		}

		public string TransferOutStatus
		{
			get
			{
				return transferOutStatus;
			}
			set	
			{
				transferOutStatus = value;
			}
		}

		public string RegistrantType
		{
			get
			{
				return registrantType;
			}
			set	
			{
				registrantType = value;
			}
		}

		public string DomainNameVerificationStatus
		{
			get
			{
				return domainNameVerificationStatus;
			}
			set	
			{
				domainNameVerificationStatus = value;
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

		public long? RegistrationDateLong
		{
			get
			{
				return registrationDateLong;
			}
			set	
			{
				registrationDateLong = value;
			}
		}

		public long? ExpirationDateLong
		{
			get
			{
				return expirationDateLong;
			}
			set	
			{
				expirationDateLong = value;
			}
		}

		public List<string> DnsList
		{
			get
			{
				return dnsList;
			}
			set	
			{
				dnsList = value;
			}
		}
	}
}
