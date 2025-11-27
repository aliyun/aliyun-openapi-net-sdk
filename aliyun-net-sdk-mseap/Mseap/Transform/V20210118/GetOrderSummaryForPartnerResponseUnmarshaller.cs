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
using Aliyun.Acs.mseap.Model.V20210118;

namespace Aliyun.Acs.mseap.Transform.V20210118
{
    public class GetOrderSummaryForPartnerResponseUnmarshaller
    {
        public static GetOrderSummaryForPartnerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOrderSummaryForPartnerResponse getOrderSummaryForPartnerResponse = new GetOrderSummaryForPartnerResponse();

			getOrderSummaryForPartnerResponse.HttpResponse = _ctx.HttpResponse;
			getOrderSummaryForPartnerResponse.RequestId = _ctx.StringValue("GetOrderSummaryForPartner.RequestId");

			GetOrderSummaryForPartnerResponse.GetOrderSummaryForPartner_Data data = new GetOrderSummaryForPartnerResponse.GetOrderSummaryForPartner_Data();
			data.OrderId = _ctx.StringValue("GetOrderSummaryForPartner.Data.OrderId");
			data.EncryptedBuyerId = _ctx.StringValue("GetOrderSummaryForPartner.Data.EncryptedBuyerId");
			data.EncryptedPayerId = _ctx.StringValue("GetOrderSummaryForPartner.Data.EncryptedPayerId");
			data.EncryptedUserId = _ctx.StringValue("GetOrderSummaryForPartner.Data.EncryptedUserId");

			List<GetOrderSummaryForPartnerResponse.GetOrderSummaryForPartner_Data.GetOrderSummaryForPartner_OrderLine> data_orderLines = new List<GetOrderSummaryForPartnerResponse.GetOrderSummaryForPartner_Data.GetOrderSummaryForPartner_OrderLine>();
			for (int i = 0; i < _ctx.Length("GetOrderSummaryForPartner.Data.OrderLines.Length"); i++) {
				GetOrderSummaryForPartnerResponse.GetOrderSummaryForPartner_Data.GetOrderSummaryForPartner_OrderLine orderLine = new GetOrderSummaryForPartnerResponse.GetOrderSummaryForPartner_Data.GetOrderSummaryForPartner_OrderLine();
				orderLine.OrderType = _ctx.StringValue("GetOrderSummaryForPartner.Data.OrderLines["+ i +"].OrderType");
				orderLine.InstanceId = _ctx.StringValue("GetOrderSummaryForPartner.Data.OrderLines["+ i +"].InstanceId");
				orderLine.OrderLineId = _ctx.StringValue("GetOrderSummaryForPartner.Data.OrderLines["+ i +"].OrderLineId");

				data_orderLines.Add(orderLine);
			}
			data.OrderLines = data_orderLines;
			getOrderSummaryForPartnerResponse.Data = data;
        
			return getOrderSummaryForPartnerResponse;
        }
    }
}
