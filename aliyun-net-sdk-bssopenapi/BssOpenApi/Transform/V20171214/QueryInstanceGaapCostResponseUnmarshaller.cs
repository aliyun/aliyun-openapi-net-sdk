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
        public static QueryInstanceGaapCostResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryInstanceGaapCostResponse queryInstanceGaapCostResponse = new QueryInstanceGaapCostResponse();

			queryInstanceGaapCostResponse.HttpResponse = _ctx.HttpResponse;
			queryInstanceGaapCostResponse.RequestId = _ctx.StringValue("QueryInstanceGaapCost.RequestId");
			queryInstanceGaapCostResponse.Success = _ctx.BooleanValue("QueryInstanceGaapCost.Success");
			queryInstanceGaapCostResponse.Code = _ctx.StringValue("QueryInstanceGaapCost.Code");
			queryInstanceGaapCostResponse.Message = _ctx.StringValue("QueryInstanceGaapCost.Message");

			QueryInstanceGaapCostResponse.QueryInstanceGaapCost_Data data = new QueryInstanceGaapCostResponse.QueryInstanceGaapCost_Data();
			data.HostId = _ctx.StringValue("QueryInstanceGaapCost.Data.HostId");
			data.PageNum = _ctx.IntegerValue("QueryInstanceGaapCost.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QueryInstanceGaapCost.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QueryInstanceGaapCost.Data.TotalCount");

			List<QueryInstanceGaapCostResponse.QueryInstanceGaapCost_Data.QueryInstanceGaapCost_Module> data_modules = new List<QueryInstanceGaapCostResponse.QueryInstanceGaapCost_Data.QueryInstanceGaapCost_Module>();
			for (int i = 0; i < _ctx.Length("QueryInstanceGaapCost.Data.Modules.Length"); i++) {
				QueryInstanceGaapCostResponse.QueryInstanceGaapCost_Data.QueryInstanceGaapCost_Module module = new QueryInstanceGaapCostResponse.QueryInstanceGaapCost_Data.QueryInstanceGaapCost_Module();
				module.BillingCycle = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].BillingCycle");
				module.InstanceID = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].InstanceID");
				module.ProductCode = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].ProductCode");
				module.ProductType = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].ProductType");
				module.SubscriptionType = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].SubscriptionType");
				module.Tag = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].Tag");
				module.ResourceGroup = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].ResourceGroup");
				module.AccountingUnit = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].AccountingUnit");
				module.PayerAccount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PayerAccount");
				module.OwnerID = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].OwnerID");
				module.Region = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].Region");
				module.Currency = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].Currency");
				module.PaymentCurrency = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PaymentCurrency");
				module.OrderType = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].OrderType");
				module.PayTime = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PayTime");
				module.PretaxGrossAmount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PretaxGrossAmount");
				module.PricingDiscount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PricingDiscount");
				module.DeductedByCoupons = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].DeductedByCoupons");
				module.PretaxAmount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PretaxAmount");
				module.PretaxAmountLocal = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PretaxAmountLocal");
				module.DeductedByCashCoupons = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].DeductedByCashCoupons");
				module.DeductedByPrepaidCard = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].DeductedByPrepaidCard");
				module.PaymentAmount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].PaymentAmount");
				module.GaapPretaxGrossAmount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapPretaxGrossAmount");
				module.GaapPricingDiscount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapPricingDiscount");
				module.GaapDeductedByCoupons = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapDeductedByCoupons");
				module.GaapPretaxAmount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapPretaxAmount");
				module.GaapPretaxAmountLocal = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapPretaxAmountLocal");
				module.GaapDeductedByCashCoupons = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapDeductedByCashCoupons");
				module.GaapDeductedByPrepaidCard = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapDeductedByPrepaidCard");
				module.GaapPaymentAmount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].GaapPaymentAmount");
				module.MonthGaapPretaxGrossAmount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapPretaxGrossAmount");
				module.MonthGaapPricingDiscount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapPricingDiscount");
				module.MonthGaapDeductedByCoupons = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapDeductedByCoupons");
				module.MonthGaapPretaxAmount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapPretaxAmount");
				module.MonthGaapPretaxAmountLocal = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapPretaxAmountLocal");
				module.MonthGaapDeductedByCashCoupons = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapDeductedByCashCoupons");
				module.MonthGaapDeductedByPrepaidCard = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapDeductedByPrepaidCard");
				module.MonthGaapPaymentAmount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].MonthGaapPaymentAmount");
				module.UnallocatedPaymentAmount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedPaymentAmount");
				module.UsageStartDate = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UsageStartDate");
				module.UsageEndDate = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UsageEndDate");
				module.BillType = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].BillType");
				module.OrderId = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].OrderId");
				module.SubOrderId = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].SubOrderId");
				module.UnallocatedPretaxGrossAmount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedPretaxGrossAmount");
				module.UnallocatedPricingDiscount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedPricingDiscount");
				module.UnallocatedDeductedByCoupons = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedDeductedByCoupons");
				module.UnallocatedPretaxAmount = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedPretaxAmount");
				module.UnallocatedPretaxAmountLocal = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedPretaxAmountLocal");
				module.UnallocatedDeductedByCashCoupons = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedDeductedByCashCoupons");
				module.UnallocatedDeductedByPrepaidCard = _ctx.StringValue("QueryInstanceGaapCost.Data.Modules["+ i +"].UnallocatedDeductedByPrepaidCard");

				data_modules.Add(module);
			}
			data.Modules = data_modules;
			queryInstanceGaapCostResponse.Data = data;
        
			return queryInstanceGaapCostResponse;
        }
    }
}
