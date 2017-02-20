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
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class GetWhoisInfoResponseUnmarshaller
    {
        public static GetWhoisInfoResponse Unmarshall(UnmarshallerContext context)
        {
            GetWhoisInfoResponse getWhoisInfoResponse = new GetWhoisInfoResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("GetWhoisInfo.RequestId"),
                ReferralURL = context.StringValue("GetWhoisInfo.ReferralURL"),
                DomainName = context.StringValue("GetWhoisInfo.DomainName"),
                Registrar = context.StringValue("GetWhoisInfo.Registrar"),
                RegistrarWhoisServer = context.StringValue("GetWhoisInfo.RegistrarWhoisServer"),
                StatusList = context.StringValue("GetWhoisInfo.StatusList"),
                FormatCreationDate = context.StringValue("GetWhoisInfo.FormatCreationDate"),
                FormatExpirationDate = context.StringValue("GetWhoisInfo.FormatExpirationDate"),
                FormatUpdatedDate = context.StringValue("GetWhoisInfo.FormatUpdatedDate"),
                NameServerList = context.StringValue("GetWhoisInfo.NameServerList"),
                UpdatedDate = context.StringValue("GetWhoisInfo.UpdatedDate"),
                CreationDate = context.StringValue("GetWhoisInfo.CreationDate"),
                ExpirationDate = context.StringValue("GetWhoisInfo.ExpirationDate"),
                RegistryDomainID = context.StringValue("GetWhoisInfo.RegistryDomainID"),
                RegistrarURL = context.StringValue("GetWhoisInfo.RegistrarURL"),
                RegistrarIanaid = context.StringValue("GetWhoisInfo.RegistrarIANAID"),
                RegistrarAbuseContactEmail = context.StringValue("GetWhoisInfo.RegistrarAbuseContactEmail"),
                RegistrarAbuseContactPhone = context.StringValue("GetWhoisInfo.RegistrarAbuseContactPhone"),
                RegistryRegistrantId = context.StringValue("GetWhoisInfo.RegistryRegistrantId"),
                RegistrantName = context.StringValue("GetWhoisInfo.RegistrantName"),
                RegistrantOrganization = context.StringValue("GetWhoisInfo.RegistrantOrganization"),
                RegistrantStreet = context.StringValue("GetWhoisInfo.RegistrantStreet"),
                RegistrantCity = context.StringValue("GetWhoisInfo.RegistrantCity"),
                RegistrantStateProvince = context.StringValue("GetWhoisInfo.RegistrantStateProvince"),
                RegistrantPostalCode = context.StringValue("GetWhoisInfo.RegistrantPostalCode"),
                RegistrantCountry = context.StringValue("GetWhoisInfo.RegistrantCountry"),
                RegistrantPhone = context.StringValue("GetWhoisInfo.RegistrantPhone"),
                RegistrantPhoneExt = context.StringValue("GetWhoisInfo.RegistrantPhoneExt"),
                RegistrantFax = context.StringValue("GetWhoisInfo.RegistrantFax"),
                RegistrantFaxExt = context.StringValue("GetWhoisInfo.RegistrantFaxExt"),
                RegistrantEmail = context.StringValue("GetWhoisInfo.RegistrantEmail"),
                RegistryAdminID = context.StringValue("GetWhoisInfo.RegistryAdminID"),
                RegistryTechID = context.StringValue("GetWhoisInfo.RegistryTechID"),
                AdminName = context.StringValue("GetWhoisInfo.AdminName"),
                AdminOrganization = context.StringValue("GetWhoisInfo.AdminOrganization"),
                AdminStreet = context.StringValue("GetWhoisInfo.AdminStreet"),
                AdminCity = context.StringValue("GetWhoisInfo.AdminCity"),
                AdminStateProvince = context.StringValue("GetWhoisInfo.AdminStateProvince"),
                AdminPostalCode = context.StringValue("GetWhoisInfo.AdminPostalCode"),
                AdminCountry = context.StringValue("GetWhoisInfo.AdminCountry"),
                AdminPhone = context.StringValue("GetWhoisInfo.AdminPhone"),
                AdminPhoneExt = context.StringValue("GetWhoisInfo.AdminPhoneExt"),
                AdminFax = context.StringValue("GetWhoisInfo.AdminFax"),
                AdminFaxExt = context.StringValue("GetWhoisInfo.AdminFaxExt"),
                AdminEmail = context.StringValue("GetWhoisInfo.AdminEmail"),
                TechName = context.StringValue("GetWhoisInfo.TechName"),
                TechOrganization = context.StringValue("GetWhoisInfo.TechOrganization"),
                TechStreet = context.StringValue("GetWhoisInfo.TechStreet"),
                TechCity = context.StringValue("GetWhoisInfo.TechCity"),
                TechStateProvince = context.StringValue("GetWhoisInfo.TechStateProvince"),
                TechPostalCode = context.StringValue("GetWhoisInfo.TechPostalCode"),
                TechCountry = context.StringValue("GetWhoisInfo.TechCountry"),
                TechPhone = context.StringValue("GetWhoisInfo.TechPhone"),
                TechPhoneExt = context.StringValue("GetWhoisInfo.TechPhoneExt"),
                TechFax = context.StringValue("GetWhoisInfo.TechFax"),
                TechFaxExt = context.StringValue("GetWhoisInfo.TechFaxExt"),
                TechEmail = context.StringValue("GetWhoisInfo.TechEmail"),
                OriginalInfo = context.StringValue("GetWhoisInfo.OriginalInfo"),
                CacheUpdatedDate = context.StringValue("GetWhoisInfo.CacheUpdatedDate"),
                WhoisProtected = context.StringValue("GetWhoisInfo.WhoisProtected")
            };
            List<GetWhoisInfoResponse.DomainStatus> domainStatusList = new List<GetWhoisInfoResponse.DomainStatus>();
			for (int i = 0; i < context.Length("GetWhoisInfo.DomainStatusList.Length"); i++) {
                GetWhoisInfoResponse.DomainStatus domainStatus = new GetWhoisInfoResponse.DomainStatus()
                {
                    Status = context.StringValue($"GetWhoisInfo.DomainStatusList[{i}].Status"),
                    Desc = context.StringValue($"GetWhoisInfo.DomainStatusList[{i}].Desc"),
                    Tip = context.StringValue($"GetWhoisInfo.DomainStatusList[{i}].Tip")
                };
                domainStatusList.Add(domainStatus);
			}
			getWhoisInfoResponse.DomainStatusList = domainStatusList;
        
			return getWhoisInfoResponse;
        }
    }
}