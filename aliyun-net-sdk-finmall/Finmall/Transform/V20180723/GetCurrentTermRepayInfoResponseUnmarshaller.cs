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
    public class GetCurrentTermRepayInfoResponseUnmarshaller
    {
        public static GetCurrentTermRepayInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetCurrentTermRepayInfoResponse getCurrentTermRepayInfoResponse = new GetCurrentTermRepayInfoResponse();

			getCurrentTermRepayInfoResponse.HttpResponse = context.HttpResponse;
			getCurrentTermRepayInfoResponse.Code = context.StringValue("GetCurrentTermRepayInfo.Code");
			getCurrentTermRepayInfoResponse.Message = context.StringValue("GetCurrentTermRepayInfo.Message");
			getCurrentTermRepayInfoResponse.RequestId = context.StringValue("GetCurrentTermRepayInfo.RequestId");

			GetCurrentTermRepayInfoResponse.GetCurrentTermRepayInfo_Data data = new GetCurrentTermRepayInfoResponse.GetCurrentTermRepayInfo_Data();
			data.CreditId = context.StringValue("GetCurrentTermRepayInfo.Data.CreditId");
			data.BalAmt = context.StringValue("GetCurrentTermRepayInfo.Data.BalAmt");
			data.InterAmt = context.StringValue("GetCurrentTermRepayInfo.Data.InterAmt");
			data.FineAmt = context.StringValue("GetCurrentTermRepayInfo.Data.FineAmt");
			data.InterInter = context.StringValue("GetCurrentTermRepayInfo.Data.InterInter");
			data.FineInter = context.StringValue("GetCurrentTermRepayInfo.Data.FineInter");
			data.ExpiryDate = context.StringValue("GetCurrentTermRepayInfo.Data.ExpiryDate");
			data.LoanBalance = context.StringValue("GetCurrentTermRepayInfo.Data.LoanBalance");
			data.TotalLoanAmount = context.StringValue("GetCurrentTermRepayInfo.Data.TotalLoanAmount");
			data.RepayPrincipalAmount = context.StringValue("GetCurrentTermRepayInfo.Data.RepayPrincipalAmount");
			getCurrentTermRepayInfoResponse.Data = data;
        
			return getCurrentTermRepayInfoResponse;
        }
    }
}
