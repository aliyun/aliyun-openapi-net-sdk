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

namespace Aliyun.Acs.Domain.Model.V20160511
{
	public class GetWhoisInfoResponse : AcsResponse
	{

		private string referralURL;

		private string domainName;

		private string registrar;

		private string registrarWhoisServer;

		private string statusList;

		private string formatCreationDate;

		private string formatExpirationDate;

		private string formatUpdatedDate;

		private string nameServerList;

		private string updatedDate;

		private string creationDate;

		private string expirationDate;

		private string registryDomainID;

		private string registrarURL;

		private string registrarIANAID;

		private string registrarAbuseContactEmail;

		private string registrarAbuseContactPhone;

		private string registryRegistrantId;

		private string registrantName;

		private string registrantOrganization;

		private string registrantStreet;

		private string registrantCity;

		private string registrantStateProvince;

		private string registrantPostalCode;

		private string registrantCountry;

		private string registrantPhone;

		private string registrantPhoneExt;

		private string registrantFax;

		private string registrantFaxExt;

		private string registrantEmail;

		private string registryAdminID;

		private string registryTechID;

		private string adminName;

		private string adminOrganization;

		private string adminStreet;

		private string adminCity;

		private string adminStateProvince;

		private string adminPostalCode;

		private string adminCountry;

		private string adminPhone;

		private string adminPhoneExt;

		private string adminFax;

		private string adminFaxExt;

		private string adminEmail;

		private string techName;

		private string techOrganization;

		private string techStreet;

		private string techCity;

		private string techStateProvince;

		private string techPostalCode;

		private string techCountry;

		private string techPhone;

		private string techPhoneExt;

		private string techFax;

		private string techFaxExt;

		private string techEmail;

		private string originalInfo;

		private string cacheUpdatedDate;

		private string whoisProtected;

		private List<DomainStatus> domainStatusList;

		public string ReferralURL
		{
			get
			{
				return referralURL;
			}
			set	
			{
				referralURL = value;
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

		public string RegistrarWhoisServer
		{
			get
			{
				return registrarWhoisServer;
			}
			set	
			{
				registrarWhoisServer = value;
			}
		}

		public string StatusList
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

		public string FormatCreationDate
		{
			get
			{
				return formatCreationDate;
			}
			set	
			{
				formatCreationDate = value;
			}
		}

		public string FormatExpirationDate
		{
			get
			{
				return formatExpirationDate;
			}
			set	
			{
				formatExpirationDate = value;
			}
		}

		public string FormatUpdatedDate
		{
			get
			{
				return formatUpdatedDate;
			}
			set	
			{
				formatUpdatedDate = value;
			}
		}

		public string NameServerList
		{
			get
			{
				return nameServerList;
			}
			set	
			{
				nameServerList = value;
			}
		}

		public string UpdatedDate
		{
			get
			{
				return updatedDate;
			}
			set	
			{
				updatedDate = value;
			}
		}

		public string CreationDate
		{
			get
			{
				return creationDate;
			}
			set	
			{
				creationDate = value;
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

		public string RegistryDomainID
		{
			get
			{
				return registryDomainID;
			}
			set	
			{
				registryDomainID = value;
			}
		}

		public string RegistrarURL
		{
			get
			{
				return registrarURL;
			}
			set	
			{
				registrarURL = value;
			}
		}

		public string RegistrarIANAID
		{
			get
			{
				return registrarIANAID;
			}
			set	
			{
				registrarIANAID = value;
			}
		}

		public string RegistrarAbuseContactEmail
		{
			get
			{
				return registrarAbuseContactEmail;
			}
			set	
			{
				registrarAbuseContactEmail = value;
			}
		}

		public string RegistrarAbuseContactPhone
		{
			get
			{
				return registrarAbuseContactPhone;
			}
			set	
			{
				registrarAbuseContactPhone = value;
			}
		}

		public string RegistryRegistrantId
		{
			get
			{
				return registryRegistrantId;
			}
			set	
			{
				registryRegistrantId = value;
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

		public string RegistrantStreet
		{
			get
			{
				return registrantStreet;
			}
			set	
			{
				registrantStreet = value;
			}
		}

		public string RegistrantCity
		{
			get
			{
				return registrantCity;
			}
			set	
			{
				registrantCity = value;
			}
		}

		public string RegistrantStateProvince
		{
			get
			{
				return registrantStateProvince;
			}
			set	
			{
				registrantStateProvince = value;
			}
		}

		public string RegistrantPostalCode
		{
			get
			{
				return registrantPostalCode;
			}
			set	
			{
				registrantPostalCode = value;
			}
		}

		public string RegistrantCountry
		{
			get
			{
				return registrantCountry;
			}
			set	
			{
				registrantCountry = value;
			}
		}

		public string RegistrantPhone
		{
			get
			{
				return registrantPhone;
			}
			set	
			{
				registrantPhone = value;
			}
		}

		public string RegistrantPhoneExt
		{
			get
			{
				return registrantPhoneExt;
			}
			set	
			{
				registrantPhoneExt = value;
			}
		}

		public string RegistrantFax
		{
			get
			{
				return registrantFax;
			}
			set	
			{
				registrantFax = value;
			}
		}

		public string RegistrantFaxExt
		{
			get
			{
				return registrantFaxExt;
			}
			set	
			{
				registrantFaxExt = value;
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

		public string RegistryAdminID
		{
			get
			{
				return registryAdminID;
			}
			set	
			{
				registryAdminID = value;
			}
		}

		public string RegistryTechID
		{
			get
			{
				return registryTechID;
			}
			set	
			{
				registryTechID = value;
			}
		}

		public string AdminName
		{
			get
			{
				return adminName;
			}
			set	
			{
				adminName = value;
			}
		}

		public string AdminOrganization
		{
			get
			{
				return adminOrganization;
			}
			set	
			{
				adminOrganization = value;
			}
		}

		public string AdminStreet
		{
			get
			{
				return adminStreet;
			}
			set	
			{
				adminStreet = value;
			}
		}

		public string AdminCity
		{
			get
			{
				return adminCity;
			}
			set	
			{
				adminCity = value;
			}
		}

		public string AdminStateProvince
		{
			get
			{
				return adminStateProvince;
			}
			set	
			{
				adminStateProvince = value;
			}
		}

		public string AdminPostalCode
		{
			get
			{
				return adminPostalCode;
			}
			set	
			{
				adminPostalCode = value;
			}
		}

		public string AdminCountry
		{
			get
			{
				return adminCountry;
			}
			set	
			{
				adminCountry = value;
			}
		}

		public string AdminPhone
		{
			get
			{
				return adminPhone;
			}
			set	
			{
				adminPhone = value;
			}
		}

		public string AdminPhoneExt
		{
			get
			{
				return adminPhoneExt;
			}
			set	
			{
				adminPhoneExt = value;
			}
		}

		public string AdminFax
		{
			get
			{
				return adminFax;
			}
			set	
			{
				adminFax = value;
			}
		}

		public string AdminFaxExt
		{
			get
			{
				return adminFaxExt;
			}
			set	
			{
				adminFaxExt = value;
			}
		}

		public string AdminEmail
		{
			get
			{
				return adminEmail;
			}
			set	
			{
				adminEmail = value;
			}
		}

		public string TechName
		{
			get
			{
				return techName;
			}
			set	
			{
				techName = value;
			}
		}

		public string TechOrganization
		{
			get
			{
				return techOrganization;
			}
			set	
			{
				techOrganization = value;
			}
		}

		public string TechStreet
		{
			get
			{
				return techStreet;
			}
			set	
			{
				techStreet = value;
			}
		}

		public string TechCity
		{
			get
			{
				return techCity;
			}
			set	
			{
				techCity = value;
			}
		}

		public string TechStateProvince
		{
			get
			{
				return techStateProvince;
			}
			set	
			{
				techStateProvince = value;
			}
		}

		public string TechPostalCode
		{
			get
			{
				return techPostalCode;
			}
			set	
			{
				techPostalCode = value;
			}
		}

		public string TechCountry
		{
			get
			{
				return techCountry;
			}
			set	
			{
				techCountry = value;
			}
		}

		public string TechPhone
		{
			get
			{
				return techPhone;
			}
			set	
			{
				techPhone = value;
			}
		}

		public string TechPhoneExt
		{
			get
			{
				return techPhoneExt;
			}
			set	
			{
				techPhoneExt = value;
			}
		}

		public string TechFax
		{
			get
			{
				return techFax;
			}
			set	
			{
				techFax = value;
			}
		}

		public string TechFaxExt
		{
			get
			{
				return techFaxExt;
			}
			set	
			{
				techFaxExt = value;
			}
		}

		public string TechEmail
		{
			get
			{
				return techEmail;
			}
			set	
			{
				techEmail = value;
			}
		}

		public string OriginalInfo
		{
			get
			{
				return originalInfo;
			}
			set	
			{
				originalInfo = value;
			}
		}

		public string CacheUpdatedDate
		{
			get
			{
				return cacheUpdatedDate;
			}
			set	
			{
				cacheUpdatedDate = value;
			}
		}

		public string WhoisProtected
		{
			get
			{
				return whoisProtected;
			}
			set	
			{
				whoisProtected = value;
			}
		}

		public List<DomainStatus> DomainStatusList
		{
			get
			{
				return domainStatusList;
			}
			set	
			{
				domainStatusList = value;
			}
		}

		public class DomainStatus{

			private string status;

			private string desc;

			private string tip;

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string Desc
			{
				get
				{
					return desc;
				}
				set	
				{
					desc = value;
				}
			}

			public string Tip
			{
				get
				{
					return tip;
				}
				set	
				{
					tip = value;
				}
			}
		}
	}
}