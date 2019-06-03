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
    public class QueryInstanceGaapCostResponseUnmarshaller
    {
        public static QueryInstanceGaapCostResponse Unmarshall(UnmarshallerContext context)
        {
			QueryInstanceGaapCostResponse queryInstanceGaapCostResponse = new QueryInstanceGaapCostResponse();

			queryInstanceGaapCostResponse.HttpResponse = context.HttpResponse;
			queryInstanceGaapCostResponse.RequestId = context.StringValue("QueryInstanceGaapCost.RequestId");
			queryInstanceGaapCostResponse.Success = context.BooleanValue("QueryInstanceGaapCost.Success");
			queryInstanceGaapCostResponse.Code = context.StringValue("QueryInstanceGaapCost.Code");
			queryInstanceGaapCostResponse.Message = context.StringValue("QueryInstanceGaapCost.Message");

			QueryInstanceGaapCostResponse.QueryInstanceGaapCost_Data data = new QueryInstanceGaapCostResponse.QueryInstanceGaapCost_Data();
			data.HostId = context.StringValue("QueryInstanceGaapCost.Data.HostId");
			data.PageNum = context.IntegerValue("QueryInstanceGaapCost.Data.PageNum");
			data.PageSize = context.IntegerValue("QueryInstanceGaapCost.Data.PageSize");
			data.TotalCount = context.IntegerValue("QueryInstanceGaapCost.Data.TotalCount");

			List<QueryInstanceGaapCostResponse.QueryInstanceGaapCost_Data.QueryInstanceGaapCost_Module> data_modules = new List<QueryInstanceGaapCostResponse.QueryInstanceGaapCost_Data.QueryInstanceGaapCost_Module>();
			for (int i = 0; i < context.Length("QueryInstanceGaapCost.Data.Modules.Length"); i++) {
				QueryInstanceGaapCostResponse.QueryInstanceGaapCost_Data.QueryInstanceGaapCost_Module module = new QueryInstanceGaapCostResponse.QueryInstanceGaapCost_Data.QueryInstanceGaapCost_Module();
				module.BillingCycle = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].BillingCycle");
				module.InstanceID = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].InstanceID");
				module.ProductCode = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].ProductCode");
				module.ProductType = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].ProductType");
				module.SubscriptionType = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].SubscriptionType");
				module.Tag = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].Tag");
				module.ResourceGroup = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].ResourceGroup");
				module.AccountingUnit = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].AccountingUnit");
				module.PayerAccount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PayerAccount");
				module.OwnerID = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].OwnerID");
				module.Region = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].Region");
				module.Currency = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].Currency");
				module.PaymentCurrency = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PaymentCurrency");
				module.OrderType = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].OrderType");
				module.PayTime = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PayTime");
				module.PretaxGrossAmount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PretaxGrossAmount");
				module.PricingDiscount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PricingDiscount");
				module.DeductedByCoupons = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].DeductedByCoupons");
				module.PretaxAmount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PretaxAmount");
				module.PretaxAmountLocal = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PretaxAmountLocal");
				module.DeductedByCashCoupons = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].DeductedByCashCoupons");
				module.DeductedByPrepaidCard = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].DeductedByPrepaidCard");
				module.PaymentAmount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PaymentAmount");
				module.GaapPretaxGrossAmount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapPretaxGrossAmount");
				module.GaapPricingDiscount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapPricingDiscount");
				module.GaapDeductedByCoupons = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapDeductedByCoupons");
				module.GaapPretaxAmount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapPretaxAmount");
				module.GaapPretaxAmountLocal = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapPretaxAmountLocal");
				module.GaapDeductedByCashCoupons = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapDeductedByCashCoupons");
				module.GaapDeductedByPrepaidCard = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapDeductedByPrepaidCard");
				module.GaapPaymentAmount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapPaymentAmount");
				module.MonthGaapPretaxGrossAmount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapPretaxGrossAmount");
				module.MonthGaapPricingDiscount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapPricingDiscount");
				module.MonthGaapDeductedByCoupons = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapDeductedByCoupons");
				module.MonthGaapPretaxAmount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapPretaxAmount");
				module.MonthGaapPretaxAmountLocal = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapPretaxAmountLocal");
				module.MonthGaapDeductedByCashCoupons = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapDeductedByCashCoupons");
				module.MonthGaapDeductedByPrepaidCard = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapDeductedByPrepaidCard");
				module.MonthGaapPaymentAmount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapPaymentAmount");
				module.UnallocatedPaymentAmount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedPaymentAmount");
				module.UsageStartDate = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UsageStartDate");
				module.UsageEndDate = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UsageEndDate");
				module.BillType = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].BillType");
				module.OrderId = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].OrderId");
				module.SubOrderId = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].SubOrderId");
				module.UnallocatedPretaxGrossAmount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedPretaxGrossAmount");
				module.UnallocatedPricingDiscount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedPricingDiscount");
				module.UnallocatedDeductedByCoupons = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedDeductedByCoupons");
				module.UnallocatedPretaxAmount = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedPretaxAmount");
				module.UnallocatedPretaxAmountLocal = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedPretaxAmountLocal");
				module.UnallocatedDeductedByCashCoupons = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedDeductedByCashCoupons");
				module.UnallocatedDeductedByPrepaidCard = context.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedDeductedByPrepaidCard");

				data_modules.Add(module);
			}
			data.Modules = data_modules;
			queryInstanceGaapCostResponse.Data = data;
        
			return queryInstanceGaapCostResponse;
        }
    }
}
