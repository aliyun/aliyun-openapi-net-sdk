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
using Aliyun.Acs.companyreg.Model.V20201022;

namespace Aliyun.Acs.companyreg.Transform.V20201022
{
    public class RefreshCustomerInfoResponseUnmarshaller
    {
        public static RefreshCustomerInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RefreshCustomerInfoResponse refreshCustomerInfoResponse = new RefreshCustomerInfoResponse();

			refreshCustomerInfoResponse.HttpResponse = _ctx.HttpResponse;
			refreshCustomerInfoResponse.AcctgSystem = _ctx.StringValue("RefreshCustomerInfo.AcctgSystem");
			refreshCustomerInfoResponse.BizScope = _ctx.StringValue("RefreshCustomerInfo.BizScope");
			refreshCustomerInfoResponse.CompanyType = _ctx.StringValue("RefreshCustomerInfo.CompanyType");
			refreshCustomerInfoResponse.CorpAddress = _ctx.StringValue("RefreshCustomerInfo.CorpAddress");
			refreshCustomerInfoResponse.EstablishmentDate = _ctx.StringValue("RefreshCustomerInfo.EstablishmentDate");
			refreshCustomerInfoResponse.ExternalUniqueId = _ctx.StringValue("RefreshCustomerInfo.ExternalUniqueId");
			refreshCustomerInfoResponse.IncomeDeclarationPsw = _ctx.StringValue("RefreshCustomerInfo.IncomeDeclarationPsw");
			refreshCustomerInfoResponse.LegalRepresentative = _ctx.StringValue("RefreshCustomerInfo.LegalRepresentative");
			refreshCustomerInfoResponse.OrgName = _ctx.StringValue("RefreshCustomerInfo.OrgName");
			refreshCustomerInfoResponse.RegisteredCaptial = _ctx.StringValue("RefreshCustomerInfo.RegisteredCaptial");
			refreshCustomerInfoResponse.RequestId = _ctx.StringValue("RefreshCustomerInfo.RequestId");
			refreshCustomerInfoResponse.TaxArea = _ctx.StringValue("RefreshCustomerInfo.TaxArea");
			refreshCustomerInfoResponse.TaxNo = _ctx.StringValue("RefreshCustomerInfo.TaxNo");
			refreshCustomerInfoResponse.TaxPreparerName = _ctx.StringValue("RefreshCustomerInfo.TaxPreparerName");
			refreshCustomerInfoResponse.TaxPreparerPsw = _ctx.StringValue("RefreshCustomerInfo.TaxPreparerPsw");
			refreshCustomerInfoResponse.TaxTypes = _ctx.StringValue("RefreshCustomerInfo.TaxTypes");
			refreshCustomerInfoResponse.TaxiationAgentSecret = _ctx.StringValue("RefreshCustomerInfo.TaxiationAgentSecret");
			refreshCustomerInfoResponse.TaxpayerType = _ctx.StringValue("RefreshCustomerInfo.TaxpayerType");
			refreshCustomerInfoResponse.TenantId = _ctx.LongValue("RefreshCustomerInfo.TenantId");
        
			return refreshCustomerInfoResponse;
        }
    }
}
