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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.BssOpenApi.Model.V20171214;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryMonthlyInstanceConsumptionResponseUnmarshaller
    {
        public static QueryMonthlyInstanceConsumptionResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMonthlyInstanceConsumptionResponse queryMonthlyInstanceConsumptionResponse = new QueryMonthlyInstanceConsumptionResponse();

			queryMonthlyInstanceConsumptionResponse.HttpResponse = context.HttpResponse;
			queryMonthlyInstanceConsumptionResponse.RequestId = context.StringValue("QueryMonthlyInstanceConsumption.RequestId");
			queryMonthlyInstanceConsumptionResponse.Success = context.BooleanValue("QueryMonthlyInstanceConsumption.Success");
			queryMonthlyInstanceConsumptionResponse.Code = context.StringValue("QueryMonthlyInstanceConsumption.Code");
			queryMonthlyInstanceConsumptionResponse.Message = context.StringValue("QueryMonthlyInstanceConsumption.Message");

			QueryMonthlyInstanceConsumptionResponse.QueryMonthlyInstanceConsumption_Data data = new QueryMonthlyInstanceConsumptionResponse.QueryMonthlyInstanceConsumption_Data();
			data.PageNum = context.IntegerValue("QueryMonthlyInstanceConsumption.Data.PageNum");
			data.PageSize = context.IntegerValue("QueryMonthlyInstanceConsumption.Data.PageSize");
			data.TotalCount = context.IntegerValue("QueryMonthlyInstanceConsumption.Data.TotalCount");
			data.BillingCycle = context.StringValue("QueryMonthlyInstanceConsumption.Data.BillingCycle");

			List<QueryMonthlyInstanceConsumptionResponse.QueryMonthlyInstanceConsumption_Data.QueryMonthlyInstanceConsumption_Item> data_items = new List<QueryMonthlyInstanceConsumptionResponse.QueryMonthlyInstanceConsumption_Data.QueryMonthlyInstanceConsumption_Item>();
			for (int i = 0; i < context.Length("QueryMonthlyInstanceConsumption.Data.Items.Length"); i++) {
				QueryMonthlyInstanceConsumptionResponse.QueryMonthlyInstanceConsumption_Data.QueryMonthlyInstanceConsumption_Item item = new QueryMonthlyInstanceConsumptionResponse.QueryMonthlyInstanceConsumption_Data.QueryMonthlyInstanceConsumption_Item();
				item.InstanceID = context.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].InstanceID");
				item.ProductCode = context.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].ProductCode");
				item.ProductType = context.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].ProductType");
				item.SubscriptionType = context.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].SubscriptionType");
				item.Tag = context.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].Tag");
				item.ResourceGroup = context.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].ResourceGroup");
				item.PayerAccount = context.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].PayerAccount");
				item.OwnerID = context.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].OwnerID");
				item.Region = context.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].Region");
				item.PretaxGrossAmount = context.FloatValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].PretaxGrossAmount");
				item.DiscountAmount = context.FloatValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].DiscountAmount");
				item.PretaxAmount = context.FloatValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].PretaxAmount");
				item.Currency = context.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].Currency");
				item.PretaxAmountLocal = context.FloatValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].PretaxAmountLocal");
				item.Tax = context.FloatValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].Tax");
				item.AfterTaxAmount = context.FloatValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].AfterTaxAmount");
				item.PaymentCurrency = context.StringValue("QueryMonthlyInstanceConsumption.Data.Items["+ i +"].PaymentCurrency");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryMonthlyInstanceConsumptionResponse.Data = data;
        
			return queryMonthlyInstanceConsumptionResponse;
        }
    }
}