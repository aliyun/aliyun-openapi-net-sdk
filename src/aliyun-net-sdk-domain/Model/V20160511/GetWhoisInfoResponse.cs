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
	    public string ReferralURL { get; set; }

	    public string DomainName { get; set; }

	    public string Registrar { get; set; }

	    public string RegistrarWhoisServer { get; set; }

	    public string StatusList { get; set; }

	    public string FormatCreationDate { get; set; }

	    public string FormatExpirationDate { get; set; }

	    public string FormatUpdatedDate { get; set; }

	    public string NameServerList { get; set; }

	    public string UpdatedDate { get; set; }

	    public string CreationDate { get; set; }

	    public string ExpirationDate { get; set; }

	    public string RegistryDomainID { get; set; }

	    public string RegistrarURL { get; set; }

	    public string RegistrarIanaid { get; set; }

	    public string RegistrarAbuseContactEmail { get; set; }

	    public string RegistrarAbuseContactPhone { get; set; }

	    public string RegistryRegistrantId { get; set; }

	    public string RegistrantName { get; set; }

	    public string RegistrantOrganization { get; set; }

	    public string RegistrantStreet { get; set; }

	    public string RegistrantCity { get; set; }

	    public string RegistrantStateProvince { get; set; }

	    public string RegistrantPostalCode { get; set; }

	    public string RegistrantCountry { get; set; }

	    public string RegistrantPhone { get; set; }

	    public string RegistrantPhoneExt { get; set; }

	    public string RegistrantFax { get; set; }

	    public string RegistrantFaxExt { get; set; }

	    public string RegistrantEmail { get; set; }

	    public string RegistryAdminID { get; set; }

	    public string RegistryTechID { get; set; }

	    public string AdminName { get; set; }

	    public string AdminOrganization { get; set; }

	    public string AdminStreet { get; set; }

	    public string AdminCity { get; set; }

	    public string AdminStateProvince { get; set; }

	    public string AdminPostalCode { get; set; }

	    public string AdminCountry { get; set; }

	    public string AdminPhone { get; set; }

	    public string AdminPhoneExt { get; set; }

	    public string AdminFax { get; set; }

	    public string AdminFaxExt { get; set; }

	    public string AdminEmail { get; set; }

	    public string TechName { get; set; }

	    public string TechOrganization { get; set; }

	    public string TechStreet { get; set; }

	    public string TechCity { get; set; }

	    public string TechStateProvince { get; set; }

	    public string TechPostalCode { get; set; }

	    public string TechCountry { get; set; }

	    public string TechPhone { get; set; }

	    public string TechPhoneExt { get; set; }

	    public string TechFax { get; set; }

	    public string TechFaxExt { get; set; }

	    public string TechEmail { get; set; }

	    public string OriginalInfo { get; set; }

	    public string CacheUpdatedDate { get; set; }

	    public string WhoisProtected { get; set; }

	    public List<DomainStatus> DomainStatusList { get; set; }

	    public class DomainStatus{
	        public string Status { get; set; }

	        public string Desc { get; set; }

	        public string Tip { get; set; }
	    }
	}
}