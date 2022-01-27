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
    public class GetTaxInfoResponseUnmarshaller
    {
        public static GetTaxInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTaxInfoResponse getTaxInfoResponse = new GetTaxInfoResponse();

			getTaxInfoResponse.HttpResponse = _ctx.HttpResponse;
			getTaxInfoResponse.TaxPreparerName = _ctx.StringValue("GetTaxInfo.TaxPreparerName");
			getTaxInfoResponse.TaxiationAgentSecret = _ctx.StringValue("GetTaxInfo.TaxiationAgentSecret");
			getTaxInfoResponse.MyTaxInfo = _ctx.StringValue("GetTaxInfo.MyTaxInfo");
			getTaxInfoResponse.TaxArea = _ctx.StringValue("GetTaxInfo.TaxArea");
			getTaxInfoResponse.AcctgSystem = _ctx.StringValue("GetTaxInfo.AcctgSystem");
			getTaxInfoResponse.RequestId = _ctx.StringValue("GetTaxInfo.RequestId");
			getTaxInfoResponse.ExternalUniqueId = _ctx.StringValue("GetTaxInfo.ExternalUniqueId");
			getTaxInfoResponse.TaxTypes = _ctx.StringValue("GetTaxInfo.TaxTypes");
			getTaxInfoResponse.IncomeDeclarationPsw = _ctx.StringValue("GetTaxInfo.IncomeDeclarationPsw");
			getTaxInfoResponse.IsNeedSmsCode = _ctx.StringValue("GetTaxInfo.IsNeedSmsCode");
			getTaxInfoResponse.TaxNo = _ctx.StringValue("GetTaxInfo.TaxNo");
			getTaxInfoResponse.TaxpayerType = _ctx.StringValue("GetTaxInfo.TaxpayerType");
			getTaxInfoResponse.Name = _ctx.StringValue("GetTaxInfo.Name");
			getTaxInfoResponse.TaxPreparerPsw = _ctx.StringValue("GetTaxInfo.TaxPreparerPsw");
			getTaxInfoResponse.TaxAreaCode = _ctx.StringValue("GetTaxInfo.TaxAreaCode");
			getTaxInfoResponse.TenantId = _ctx.LongValue("GetTaxInfo.TenantId");
        
			return getTaxInfoResponse;
        }
    }
}
