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
using Aliyun.Acs.companyreg.Model.V20190508;

namespace Aliyun.Acs.companyreg.Transform.V20190508
{
    public class GetCompanyRegOrderResponseUnmarshaller
    {
        public static GetCompanyRegOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCompanyRegOrderResponse getCompanyRegOrderResponse = new GetCompanyRegOrderResponse();

			getCompanyRegOrderResponse.HttpResponse = _ctx.HttpResponse;
			getCompanyRegOrderResponse.RequestId = _ctx.StringValue("GetCompanyRegOrder.RequestId");
			getCompanyRegOrderResponse.BizId = _ctx.StringValue("GetCompanyRegOrder.BizId");
			getCompanyRegOrderResponse.CompanyName = _ctx.StringValue("GetCompanyRegOrder.CompanyName");
			getCompanyRegOrderResponse.BizStatus = _ctx.StringValue("GetCompanyRegOrder.BizStatus");
			getCompanyRegOrderResponse.BizInfo = _ctx.StringValue("GetCompanyRegOrder.BizInfo");
			getCompanyRegOrderResponse.SupplementBizInfo = _ctx.StringValue("GetCompanyRegOrder.SupplementBizInfo");
			getCompanyRegOrderResponse.AliyunOrderId = _ctx.StringValue("GetCompanyRegOrder.AliyunOrderId");
			getCompanyRegOrderResponse.GmtModified = _ctx.LongValue("GetCompanyRegOrder.GmtModified");
			getCompanyRegOrderResponse.OrderAmount = _ctx.FloatValue("GetCompanyRegOrder.OrderAmount");
			getCompanyRegOrderResponse.YunMarketOrderAmount = _ctx.FloatValue("GetCompanyRegOrder.YunMarketOrderAmount");
			getCompanyRegOrderResponse.GmtPaid = _ctx.LongValue("GetCompanyRegOrder.GmtPaid");
			getCompanyRegOrderResponse.Extend = _ctx.StringValue("GetCompanyRegOrder.Extend");
			getCompanyRegOrderResponse.BizStatusStage = _ctx.StringValue("GetCompanyRegOrder.BizStatusStage");
			getCompanyRegOrderResponse.PlatformName = _ctx.StringValue("GetCompanyRegOrder.PlatformName");
			getCompanyRegOrderResponse.InboundPhone = _ctx.StringValue("GetCompanyRegOrder.InboundPhone");
			getCompanyRegOrderResponse.OutboundPhone = _ctx.StringValue("GetCompanyRegOrder.OutboundPhone");
			getCompanyRegOrderResponse.BizSubCode = _ctx.StringValue("GetCompanyRegOrder.BizSubCode");

			List<GetCompanyRegOrderResponse.GetCompanyRegOrder_BizOperation> getCompanyRegOrderResponse_operations = new List<GetCompanyRegOrderResponse.GetCompanyRegOrder_BizOperation>();
			for (int i = 0; i < _ctx.Length("GetCompanyRegOrder.Operations.Length"); i++) {
				GetCompanyRegOrderResponse.GetCompanyRegOrder_BizOperation bizOperation = new GetCompanyRegOrderResponse.GetCompanyRegOrder_BizOperation();
				bizOperation.GmtAction = _ctx.LongValue("GetCompanyRegOrder.Operations["+ i +"].GmtAction");
				bizOperation.ActionType = _ctx.StringValue("GetCompanyRegOrder.Operations["+ i +"].ActionType");
				bizOperation.ActionInfo = _ctx.StringValue("GetCompanyRegOrder.Operations["+ i +"].ActionInfo");

				getCompanyRegOrderResponse_operations.Add(bizOperation);
			}
			getCompanyRegOrderResponse.Operations = getCompanyRegOrderResponse_operations;
        
			return getCompanyRegOrderResponse;
        }
    }
}
