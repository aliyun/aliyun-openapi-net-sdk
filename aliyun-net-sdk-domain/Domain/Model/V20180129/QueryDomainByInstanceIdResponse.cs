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
	public class QueryDomainByInstanceIdResponse : AcsResponse
	{

		private string email;

		private string registrationDate;

		private long? registrationDateLong;

		private string realNameStatus;

		private bool? premium;

		private string domainNameVerificationStatus;

		private long? expirationDateLong;

		private string transferOutStatus;

		private string zhRegistrantOrganization;

		private bool? emailVerificationClientHold;

		private int? emailVerificationStatus;

		private string registrantOrganization;

		private string transferProhibitionLock;

		private bool? domainNameProxyService;

		private string registrantType;

		private string registrantUpdatingStatus;

		private string requestId;

		private string domainName;

		private string instanceId;

		private string zhRegistrantName;

		private string expirationDate;

		private string registrantName;

		private string userId;

		private string updateProhibitionLock;

		private long? domainGroupId;

		private string remark;

		private string domainGroupName;

		private string expirationDateStatus;

		private int? expirationCurrDateDiff;

		private string domainType;

		private string domainStatus;

		private List<string> dnsList;

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

		public string ZhRegistrantOrganization
		{
			get
			{
				return zhRegistrantOrganization;
			}
			set	
			{
				zhRegistrantOrganization = value;
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

		public string ZhRegistrantName
		{
			get
			{
				return zhRegistrantName;
			}
			set	
			{
				zhRegistrantName = value;
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

		public long? DomainGroupId
		{
			get
			{
				return domainGroupId;
			}
			set	
			{
				domainGroupId = value;
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
			}
		}

		public string DomainGroupName
		{
			get
			{
				return domainGroupName;
			}
			set	
			{
				domainGroupName = value;
			}
		}

		public string ExpirationDateStatus
		{
			get
			{
				return expirationDateStatus;
			}
			set	
			{
				expirationDateStatus = value;
			}
		}

		public int? ExpirationCurrDateDiff
		{
			get
			{
				return expirationCurrDateDiff;
			}
			set	
			{
				expirationCurrDateDiff = value;
			}
		}

		public string DomainType
		{
			get
			{
				return domainType;
			}
			set	
			{
				domainType = value;
			}
		}

		public string DomainStatus
		{
			get
			{
				return domainStatus;
			}
			set	
			{
				domainStatus = value;
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
