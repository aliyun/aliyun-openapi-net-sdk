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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Domain.Model.V20160511;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class GetWhoisInfoResponseUnmarshaller
    {
        public static GetWhoisInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetWhoisInfoResponse getWhoisInfoResponse = new GetWhoisInfoResponse();

			getWhoisInfoResponse.HttpResponse = context.HttpResponse;
			getWhoisInfoResponse.RequestId = context.StringValue("GetWhoisInfo.RequestId");
			getWhoisInfoResponse.ReferralURL = context.StringValue("GetWhoisInfo.ReferralURL");
			getWhoisInfoResponse.DomainName = context.StringValue("GetWhoisInfo.DomainName");
			getWhoisInfoResponse.Registrar = context.StringValue("GetWhoisInfo.Registrar");
			getWhoisInfoResponse.RegistrarWhoisServer = context.StringValue("GetWhoisInfo.RegistrarWhoisServer");
			getWhoisInfoResponse.StatusList = context.StringValue("GetWhoisInfo.StatusList");
			getWhoisInfoResponse.FormatCreationDate = context.StringValue("GetWhoisInfo.FormatCreationDate");
			getWhoisInfoResponse.FormatExpirationDate = context.StringValue("GetWhoisInfo.FormatExpirationDate");
			getWhoisInfoResponse.FormatUpdatedDate = context.StringValue("GetWhoisInfo.FormatUpdatedDate");
			getWhoisInfoResponse.NameServerList = context.StringValue("GetWhoisInfo.NameServerList");
			getWhoisInfoResponse.UpdatedDate = context.StringValue("GetWhoisInfo.UpdatedDate");
			getWhoisInfoResponse.CreationDate = context.StringValue("GetWhoisInfo.CreationDate");
			getWhoisInfoResponse.ExpirationDate = context.StringValue("GetWhoisInfo.ExpirationDate");
			getWhoisInfoResponse.RegistryDomainID = context.StringValue("GetWhoisInfo.RegistryDomainID");
			getWhoisInfoResponse.RegistrarURL = context.StringValue("GetWhoisInfo.RegistrarURL");
			getWhoisInfoResponse.RegistrarIANAID = context.StringValue("GetWhoisInfo.RegistrarIANAID");
			getWhoisInfoResponse.RegistrarAbuseContactEmail = context.StringValue("GetWhoisInfo.RegistrarAbuseContactEmail");
			getWhoisInfoResponse.RegistrarAbuseContactPhone = context.StringValue("GetWhoisInfo.RegistrarAbuseContactPhone");
			getWhoisInfoResponse.RegistryRegistrantId = context.StringValue("GetWhoisInfo.RegistryRegistrantId");
			getWhoisInfoResponse.RegistrantName = context.StringValue("GetWhoisInfo.RegistrantName");
			getWhoisInfoResponse.RegistrantOrganization = context.StringValue("GetWhoisInfo.RegistrantOrganization");
			getWhoisInfoResponse.RegistrantStreet = context.StringValue("GetWhoisInfo.RegistrantStreet");
			getWhoisInfoResponse.RegistrantCity = context.StringValue("GetWhoisInfo.RegistrantCity");
			getWhoisInfoResponse.RegistrantStateProvince = context.StringValue("GetWhoisInfo.RegistrantStateProvince");
			getWhoisInfoResponse.RegistrantPostalCode = context.StringValue("GetWhoisInfo.RegistrantPostalCode");
			getWhoisInfoResponse.RegistrantCountry = context.StringValue("GetWhoisInfo.RegistrantCountry");
			getWhoisInfoResponse.RegistrantPhone = context.StringValue("GetWhoisInfo.RegistrantPhone");
			getWhoisInfoResponse.RegistrantPhoneExt = context.StringValue("GetWhoisInfo.RegistrantPhoneExt");
			getWhoisInfoResponse.RegistrantFax = context.StringValue("GetWhoisInfo.RegistrantFax");
			getWhoisInfoResponse.RegistrantFaxExt = context.StringValue("GetWhoisInfo.RegistrantFaxExt");
			getWhoisInfoResponse.RegistrantEmail = context.StringValue("GetWhoisInfo.RegistrantEmail");
			getWhoisInfoResponse.RegistryAdminID = context.StringValue("GetWhoisInfo.RegistryAdminID");
			getWhoisInfoResponse.RegistryTechID = context.StringValue("GetWhoisInfo.RegistryTechID");
			getWhoisInfoResponse.AdminName = context.StringValue("GetWhoisInfo.AdminName");
			getWhoisInfoResponse.AdminOrganization = context.StringValue("GetWhoisInfo.AdminOrganization");
			getWhoisInfoResponse.AdminStreet = context.StringValue("GetWhoisInfo.AdminStreet");
			getWhoisInfoResponse.AdminCity = context.StringValue("GetWhoisInfo.AdminCity");
			getWhoisInfoResponse.AdminStateProvince = context.StringValue("GetWhoisInfo.AdminStateProvince");
			getWhoisInfoResponse.AdminPostalCode = context.StringValue("GetWhoisInfo.AdminPostalCode");
			getWhoisInfoResponse.AdminCountry = context.StringValue("GetWhoisInfo.AdminCountry");
			getWhoisInfoResponse.AdminPhone = context.StringValue("GetWhoisInfo.AdminPhone");
			getWhoisInfoResponse.AdminPhoneExt = context.StringValue("GetWhoisInfo.AdminPhoneExt");
			getWhoisInfoResponse.AdminFax = context.StringValue("GetWhoisInfo.AdminFax");
			getWhoisInfoResponse.AdminFaxExt = context.StringValue("GetWhoisInfo.AdminFaxExt");
			getWhoisInfoResponse.AdminEmail = context.StringValue("GetWhoisInfo.AdminEmail");
			getWhoisInfoResponse.TechName = context.StringValue("GetWhoisInfo.TechName");
			getWhoisInfoResponse.TechOrganization = context.StringValue("GetWhoisInfo.TechOrganization");
			getWhoisInfoResponse.TechStreet = context.StringValue("GetWhoisInfo.TechStreet");
			getWhoisInfoResponse.TechCity = context.StringValue("GetWhoisInfo.TechCity");
			getWhoisInfoResponse.TechStateProvince = context.StringValue("GetWhoisInfo.TechStateProvince");
			getWhoisInfoResponse.TechPostalCode = context.StringValue("GetWhoisInfo.TechPostalCode");
			getWhoisInfoResponse.TechCountry = context.StringValue("GetWhoisInfo.TechCountry");
			getWhoisInfoResponse.TechPhone = context.StringValue("GetWhoisInfo.TechPhone");
			getWhoisInfoResponse.TechPhoneExt = context.StringValue("GetWhoisInfo.TechPhoneExt");
			getWhoisInfoResponse.TechFax = context.StringValue("GetWhoisInfo.TechFax");
			getWhoisInfoResponse.TechFaxExt = context.StringValue("GetWhoisInfo.TechFaxExt");
			getWhoisInfoResponse.TechEmail = context.StringValue("GetWhoisInfo.TechEmail");
			getWhoisInfoResponse.OriginalInfo = context.StringValue("GetWhoisInfo.OriginalInfo");
			getWhoisInfoResponse.CacheUpdatedDate = context.StringValue("GetWhoisInfo.CacheUpdatedDate");
			getWhoisInfoResponse.WhoisProtected = context.StringValue("GetWhoisInfo.WhoisProtected");

			List<GetWhoisInfoResponse.DomainStatus> domainStatusList = new List<GetWhoisInfoResponse.DomainStatus>();
			for (int i = 0; i < context.Length("GetWhoisInfo.DomainStatusList.Length"); i++) {
				GetWhoisInfoResponse.DomainStatus domainStatus = new GetWhoisInfoResponse.DomainStatus();
				domainStatus.Status = context.StringValue("GetWhoisInfo.DomainStatusList["+ i +"].Status");
				domainStatus.Desc = context.StringValue("GetWhoisInfo.DomainStatusList["+ i +"].Desc");
				domainStatus.Tip = context.StringValue("GetWhoisInfo.DomainStatusList["+ i +"].Tip");

				domainStatusList.Add(domainStatus);
			}
			getWhoisInfoResponse.DomainStatusList = domainStatusList;
        
			return getWhoisInfoResponse;
        }
    }
}