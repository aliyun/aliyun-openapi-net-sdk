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
    public class GetPayrollInfoResponseUnmarshaller
    {
        public static GetPayrollInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPayrollInfoResponse getPayrollInfoResponse = new GetPayrollInfoResponse();

			getPayrollInfoResponse.HttpResponse = _ctx.HttpResponse;
			getPayrollInfoResponse.CorporateHousingAccumulationFund = _ctx.StringValue("GetPayrollInfo.CorporateHousingAccumulationFund");
			getPayrollInfoResponse.CorporateSocialInsurance = _ctx.StringValue("GetPayrollInfo.CorporateSocialInsurance");
			getPayrollInfoResponse.EmployeeTime = _ctx.StringValue("GetPayrollInfo.EmployeeTime");
			getPayrollInfoResponse.Id = _ctx.LongValue("GetPayrollInfo.Id");
			getPayrollInfoResponse.IdNo = _ctx.StringValue("GetPayrollInfo.IdNo");
			getPayrollInfoResponse.Income = _ctx.StringValue("GetPayrollInfo.Income");
			getPayrollInfoResponse.Name = _ctx.StringValue("GetPayrollInfo.Name");
			getPayrollInfoResponse.Period = _ctx.StringValue("GetPayrollInfo.Period");
			getPayrollInfoResponse.PersonHousingAccumulationFund = _ctx.StringValue("GetPayrollInfo.PersonHousingAccumulationFund");
			getPayrollInfoResponse.PersonSocialInsurance = _ctx.StringValue("GetPayrollInfo.PersonSocialInsurance");
			getPayrollInfoResponse.Phone = _ctx.StringValue("GetPayrollInfo.Phone");
			getPayrollInfoResponse.CorpPension = _ctx.StringValue("GetPayrollInfo.CorpPension");
			getPayrollInfoResponse.CorpMedicalInsurance = _ctx.StringValue("GetPayrollInfo.CorpMedicalInsurance");
			getPayrollInfoResponse.CorpUnemploymentInsurance = _ctx.StringValue("GetPayrollInfo.CorpUnemploymentInsurance");
			getPayrollInfoResponse.CorpInjuryInsurance = _ctx.StringValue("GetPayrollInfo.CorpInjuryInsurance");
			getPayrollInfoResponse.CorpMaternityInsurance = _ctx.StringValue("GetPayrollInfo.CorpMaternityInsurance");
			getPayrollInfoResponse.PersPension = _ctx.StringValue("GetPayrollInfo.PersPension");
			getPayrollInfoResponse.PersUnemploymentInsurance = _ctx.StringValue("GetPayrollInfo.PersUnemploymentInsurance");
			getPayrollInfoResponse.PersMedicalInsurance = _ctx.StringValue("GetPayrollInfo.PersMedicalInsurance");
			getPayrollInfoResponse.RequestId = _ctx.StringValue("GetPayrollInfo.RequestId");
        
			return getPayrollInfoResponse;
        }
    }
}
