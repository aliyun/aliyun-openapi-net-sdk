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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryMonthlyInstanceConsumptionResponseUnmarshaller
    {
        public static QueryMonthlyInstanceConsumptionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryMonthlyInstanceConsumptionResponse queryMonthlyInstanceConsumptionResponse = new QueryMonthlyInstanceConsumptionResponse();

			queryMonthlyInstanceConsumptionResponse.HttpResponse = _ctx.HttpResponse;
			queryMonthlyInstanceConsumptionResponse.RequestId = _ctx.StringValue("QueryMonthlyInstanceConsumption.RequestId");
			queryMonthlyInstanceConsumptionResponse.Success = _ctx.BooleanValue("QueryMonthlyInstanceConsumption.Success");
			queryMonthlyInstanceConsumptionResponse.Code = _ctx.StringValue("QueryMonthlyInstanceConsumption.Code");
			queryMonthlyInstanceConsumptionResponse.Message = _ctx.StringValue("QueryMonthlyInstanceConsumption.Message");

			QueryMonthlyInstanceConsumptionResponse.QueryMonthlyInstanceConsumption_Data data = new QueryMonthlyInstanceConsumptionResponse.QueryMonthlyInstanceConsumption_Data();
			data.PageNum = _ctx.IntegerValue("QueryMonthlyInstanceConsumption.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QueryMonthlyInstanceConsumption.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QueryMonthlyInstanceConsumption.Data.TotalCount");
			data.BillingCycle = _ctx.StringValue("QueryMonthlyInstanceConsumption.Data.BillingCycle");

			List<QueryMonthlyInstanceConsumptionResponse.QueryMonthlyInstanceConsumption_Data.QueryMonthlyInstanceConsumption_Item> data_items = new List<QueryMonthlyInstanceConsumptionResponse.QueryMonthlyInstanceConsumption_Data.QueryMonthlyInstanceConsumption_Item>();
			for (int i = 0; i < _ctx.Length("QueryMonthlyInstanceConsumption.Data.Items.Length"); i++) {
				QueryMonthlyInstanceConsumptionResponse.QueryMonthlyInstanceConsumption_Data.QueryMonthlyInstanceConsumption_Item item = new QueryMonthlyInstanceConsumptionResponse.QueryMonthlyInstanceConsumption_Data.QueryMonthlyInstanceConsumption_Item();
				item.InstanceID = _ctx.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].InstanceID");
				item.ProductCode = _ctx.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].ProductCode");
				item.ProductType = _ctx.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = _ctx.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].SubscriptionType");
				item.Tag = _ctx.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].Tag");
				item.ResourceGroup = _ctx.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].ResourceGroup");
				item.PayerAccount = _ctx.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].PayerAccount");
				item.OwnerID = _ctx.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].OwnerID");
				item.Region = _ctx.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].Region");
				item.PretaxGrossAmount = _ctx.FloatValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].PretaxGrossAmount");
				item.DiscountAmount = _ctx.FloatValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].DiscountAmount");
				item.PretaxAmount = _ctx.FloatValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].PretaxAmount");
				item.Currency = _ctx.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].Currency");
				item.PretaxAmountLocal = _ctx.FloatValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].PretaxAmountLocal");
				item.Tax = _ctx.FloatValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].Tax");
				item.AfterTaxAmount = _ctx.FloatValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].AfterTaxAmount");
				item.PaymentCurrency = _ctx.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].PaymentCurrency");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryMonthlyInstanceConsumptionResponse.Data = data;
        
			return queryMonthlyInstanceConsumptionResponse;
        }
    }
}
