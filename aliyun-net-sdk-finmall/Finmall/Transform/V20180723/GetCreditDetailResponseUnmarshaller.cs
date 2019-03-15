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
using Aliyun.Acs.finmall.Model.V20180723;

namespace Aliyun.Acs.finmall.Transform.V20180723
{
    public class GetCreditDetailResponseUnmarshaller
    {
        public static GetCreditDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetCreditDetailResponse getCreditDetailResponse = new GetCreditDetailResponse();

			getCreditDetailResponse.HttpResponse = context.HttpResponse;
			getCreditDetailResponse.Code = context.StringValue("GetCreditDetail.Code");
			getCreditDetailResponse.Message = context.StringValue("GetCreditDetail.Message");
			getCreditDetailResponse.RequestId = context.StringValue("GetCreditDetail.RequestId");

			GetCreditDetailResponse.GetCreditDetail_Data data = new GetCreditDetailResponse.GetCreditDetail_Data();
			data.CreditId = context.StringValue("GetCreditDetail.Data.CreditId");
			data.ProductName = context.StringValue("GetCreditDetail.Data.ProductName");
			data.LineOfCredit = context.StringValue("GetCreditDetail.Data.LineOfCredit");
			data.Amount = context.StringValue("GetCreditDetail.Data.Amount");
			data.DebtorName = context.StringValue("GetCreditDetail.Data.DebtorName");
			data.LoanBalance = context.StringValue("GetCreditDetail.Data.LoanBalance");
			data.RepayPhase = context.StringValue("GetCreditDetail.Data.RepayPhase");
			data.State = context.StringValue("GetCreditDetail.Data.State");
			data.CreateDate = context.StringValue("GetCreditDetail.Data.CreateDate");
			data.UpdateDate = context.StringValue("GetCreditDetail.Data.UpdateDate");
			data.ProductId = context.StringValue("GetCreditDetail.Data.ProductId");
			data.FundPartyId = context.StringValue("GetCreditDetail.Data.FundPartyId");
			data.DownPaymentAmount = context.StringValue("GetCreditDetail.Data.DownPaymentAmount");
			data.DownPaymentRate = context.StringValue("GetCreditDetail.Data.DownPaymentRate");
			getCreditDetailResponse.Data = data;
        
			return getCreditDetailResponse;
        }
    }
}
