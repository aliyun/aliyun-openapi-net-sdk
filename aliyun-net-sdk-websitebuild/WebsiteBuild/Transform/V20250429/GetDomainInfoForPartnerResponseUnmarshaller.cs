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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.WebsiteBuild.Model.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Transform.V20250429
{
    public class GetDomainInfoForPartnerResponseUnmarshaller
    {
        public static GetDomainInfoForPartnerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDomainInfoForPartnerResponse getDomainInfoForPartnerResponse = new GetDomainInfoForPartnerResponse();

			getDomainInfoForPartnerResponse.HttpResponse = _ctx.HttpResponse;
			getDomainInfoForPartnerResponse.RequestId = _ctx.StringValue("GetDomainInfoForPartner.RequestId");

			GetDomainInfoForPartnerResponse.GetDomainInfoForPartner_Data data = new GetDomainInfoForPartnerResponse.GetDomainInfoForPartner_Data();
			data.DomainName = _ctx.StringValue("GetDomainInfoForPartner.Data.DomainName");
			data.Registrar = _ctx.StringValue("GetDomainInfoForPartner.Data.Registrar");
			data.NameServers = _ctx.StringValue("GetDomainInfoForPartner.Data.NameServers");

			GetDomainInfoForPartnerResponse.GetDomainInfoForPartner_Data.GetDomainInfoForPartner_Ownership ownership = new GetDomainInfoForPartnerResponse.GetDomainInfoForPartner_Data.GetDomainInfoForPartner_Ownership();
			ownership.Account = _ctx.StringValue("GetDomainInfoForPartner.Data.Ownership.Account");
			ownership.Provider = _ctx.StringValue("GetDomainInfoForPartner.Data.Ownership.Provider");
			data.Ownership = ownership;
			getDomainInfoForPartnerResponse.Data = data;
        
			return getDomainInfoForPartnerResponse;
        }
    }
}
