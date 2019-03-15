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
    public class GetCreditStatusResponseUnmarshaller
    {
        public static GetCreditStatusResponse Unmarshall(UnmarshallerContext context)
        {
			GetCreditStatusResponse getCreditStatusResponse = new GetCreditStatusResponse();

			getCreditStatusResponse.HttpResponse = context.HttpResponse;
			getCreditStatusResponse.Code = context.StringValue("GetCreditStatus.Code");
			getCreditStatusResponse.Message = context.StringValue("GetCreditStatus.Message");
			getCreditStatusResponse.RequestId = context.StringValue("GetCreditStatus.RequestId");

			GetCreditStatusResponse.GetCreditStatus_Data data = new GetCreditStatusResponse.GetCreditStatus_Data();
			data.Status = context.StringValue("GetCreditStatus.Data.Status");
			data.CreateTime = context.StringValue("GetCreditStatus.Data.CreateTime");
			data.ProductId = context.StringValue("GetCreditStatus.Data.ProductId");
			data.FundPartyId = context.StringValue("GetCreditStatus.Data.FundPartyId");
			data.TradeDataId = context.StringValue("GetCreditStatus.Data.TradeDataId");
			data.CreditApproveComment = context.StringValue("GetCreditStatus.Data.CreditApproveComment");
			getCreditStatusResponse.Data = data;
        
			return getCreditStatusResponse;
        }
    }
}
