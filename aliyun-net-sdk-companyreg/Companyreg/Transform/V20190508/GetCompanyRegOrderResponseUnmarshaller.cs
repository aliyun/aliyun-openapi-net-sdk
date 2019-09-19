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
        public static GetCompanyRegOrderResponse Unmarshall(UnmarshallerContext context)
        {
			GetCompanyRegOrderResponse getCompanyRegOrderResponse = new GetCompanyRegOrderResponse();

			getCompanyRegOrderResponse.HttpResponse = context.HttpResponse;
			getCompanyRegOrderResponse.RequestId = context.StringValue("GetCompanyRegOrder.RequestId");
			getCompanyRegOrderResponse.BizId = context.StringValue("GetCompanyRegOrder.BizId");
			getCompanyRegOrderResponse.CompanyName = context.StringValue("GetCompanyRegOrder.CompanyName");
			getCompanyRegOrderResponse.BizStatus = context.StringValue("GetCompanyRegOrder.BizStatus");
			getCompanyRegOrderResponse.BizInfo = context.StringValue("GetCompanyRegOrder.BizInfo");
			getCompanyRegOrderResponse.SupplementBizInfo = context.StringValue("GetCompanyRegOrder.SupplementBizInfo");
			getCompanyRegOrderResponse.AliyunOrderId = context.StringValue("GetCompanyRegOrder.AliyunOrderId");
			getCompanyRegOrderResponse.GmtModified = context.LongValue("GetCompanyRegOrder.GmtModified");
			getCompanyRegOrderResponse.OrderAmount = context.FloatValue("GetCompanyRegOrder.OrderAmount");
			getCompanyRegOrderResponse.YunMarketOrderAmount = context.FloatValue("GetCompanyRegOrder.YunMarketOrderAmount");
			getCompanyRegOrderResponse.GmtPaid = context.LongValue("GetCompanyRegOrder.GmtPaid");
			getCompanyRegOrderResponse.Extend = context.StringValue("GetCompanyRegOrder.Extend");
			getCompanyRegOrderResponse.BizStatusStage = context.StringValue("GetCompanyRegOrder.BizStatusStage");
			getCompanyRegOrderResponse.PlatformName = context.StringValue("GetCompanyRegOrder.PlatformName");
			getCompanyRegOrderResponse.InboundPhone = context.StringValue("GetCompanyRegOrder.InboundPhone");
			getCompanyRegOrderResponse.OutboundPhone = context.StringValue("GetCompanyRegOrder.OutboundPhone");
			getCompanyRegOrderResponse.BizSubCode = context.StringValue("GetCompanyRegOrder.BizSubCode");

			List<GetCompanyRegOrderResponse.GetCompanyRegOrder_BizOperation> getCompanyRegOrderResponse_operations = new List<GetCompanyRegOrderResponse.GetCompanyRegOrder_BizOperation>();
			for (int i = 0; i < context.Length("GetCompanyRegOrder.Operations.Length"); i++) {
				GetCompanyRegOrderResponse.GetCompanyRegOrder_BizOperation bizOperation = new GetCompanyRegOrderResponse.GetCompanyRegOrder_BizOperation();
				bizOperation.GmtAction = context.LongValue("GetCompanyRegOrder.Operations["+ i +"].GmtAction");
				bizOperation.ActionType = context.StringValue("GetCompanyRegOrder.Operations["+ i +"].ActionType");
				bizOperation.ActionInfo = context.StringValue("GetCompanyRegOrder.Operations["+ i +"].ActionInfo");

				getCompanyRegOrderResponse_operations.Add(bizOperation);
			}
			getCompanyRegOrderResponse.Operations = getCompanyRegOrderResponse_operations;
        
			return getCompanyRegOrderResponse;
        }
    }
}
