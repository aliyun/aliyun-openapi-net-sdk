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
    public class DescribeProductAmortizedCostByConsumePeriodResponseUnmarshaller
    {
        public static DescribeProductAmortizedCostByConsumePeriodResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProductAmortizedCostByConsumePeriodResponse describeProductAmortizedCostByConsumePeriodResponse = new DescribeProductAmortizedCostByConsumePeriodResponse();

			describeProductAmortizedCostByConsumePeriodResponse.HttpResponse = _ctx.HttpResponse;
			describeProductAmortizedCostByConsumePeriodResponse.RequestId = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.RequestId");
			describeProductAmortizedCostByConsumePeriodResponse.Success = _ctx.BooleanValue("DescribeProductAmortizedCostByConsumePeriod.Success");
			describeProductAmortizedCostByConsumePeriodResponse.Code = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Code");
			describeProductAmortizedCostByConsumePeriodResponse.Message = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Message");

			DescribeProductAmortizedCostByConsumePeriodResponse.DescribeProductAmortizedCostByConsumePeriod_Data data = new DescribeProductAmortizedCostByConsumePeriodResponse.DescribeProductAmortizedCostByConsumePeriod_Data();
			data.NextToken = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.NextToken");
			data.AccountID = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.AccountID");
			data.AccountName = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.AccountName");
			data.MaxResults = _ctx.IntegerValue("DescribeProductAmortizedCostByConsumePeriod.Data.MaxResults");
			data.TotalCount = _ctx.IntegerValue("DescribeProductAmortizedCostByConsumePeriod.Data.TotalCount");

			List<DescribeProductAmortizedCostByConsumePeriodResponse.DescribeProductAmortizedCostByConsumePeriod_Data.DescribeProductAmortizedCostByConsumePeriod_Item> data_items = new List<DescribeProductAmortizedCostByConsumePeriodResponse.DescribeProductAmortizedCostByConsumePeriod_Data.DescribeProductAmortizedCostByConsumePeriod_Item>();
			for (int i = 0; i < _ctx.Length("DescribeProductAmortizedCostByConsumePeriod.Data.Items.Length"); i++) {
				DescribeProductAmortizedCostByConsumePeriodResponse.DescribeProductAmortizedCostByConsumePeriod_Data.DescribeProductAmortizedCostByConsumePeriod_Item item = new DescribeProductAmortizedCostByConsumePeriodResponse.DescribeProductAmortizedCostByConsumePeriod_Data.DescribeProductAmortizedCostByConsumePeriod_Item();
				item.ConsumePeriod = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].ConsumePeriod");
				item.AmortizationStatus = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].AmortizationStatus");
				item.AmortizationPeriod = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].AmortizationPeriod");
				item.BillAccountID = _ctx.LongValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].BillAccountID");
				item.BillAccountName = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].BillAccountName");
				item.BillOwnerID = _ctx.LongValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].BillOwnerID");
				item.BillOwnerName = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].BillOwnerName");
				item.ProductCode = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].ProductCode");
				item.ProductName = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].ProductName");
				item.ProductDetailCode = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].ProductDetailCode");
				item.ProductDetail = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].ProductDetail");
				item.BizType = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].BizType");
				item.SubscriptionType = _ctx.StringValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].SubscriptionType");
				item.PretaxGrossAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].InvoiceDiscount");
				item.RoundDownDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].RoundDownDiscount");
				item.PretaxAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].PretaxAmount");
				item.DeductedByCashCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].DeductedByCoupons");
				item.DeductedByPrepaidCard = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.ExpenditureAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].ExpenditureAmount");
				item.PreviouslyAmortizedPretaxGrossAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedPretaxGrossAmount");
				item.PreviouslyAmortizedInvoiceDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedInvoiceDiscount");
				item.PreviouslyAmortizedRoundDownDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedRoundDownDiscount");
				item.PreviouslyAmortizedPretaxAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedPretaxAmount");
				item.PreviouslyAmortizedDeductedByCashCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedDeductedByCashCoupons");
				item.PreviouslyAmortizedDeductedByCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedDeductedByCoupons");
				item.PreviouslyAmortizedDeductedByPrepaidCard = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedDeductedByPrepaidCard");
				item.PreviouslyAmortizedExpenditureAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedExpenditureAmount");
				item.CurrentAmortizationPretaxGrossAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationPretaxGrossAmount");
				item.CurrentAmortizationInvoiceDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationInvoiceDiscount");
				item.CurrentAmortizationRoundDownDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationRoundDownDiscount");
				item.CurrentAmortizationPretaxAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationPretaxAmount");
				item.CurrentAmortizationDeductedByCashCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationDeductedByCashCoupons");
				item.CurrentAmortizationDeductedByCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationDeductedByCoupons");
				item.CurrentAmortizationDeductedByPrepaidCard = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationDeductedByPrepaidCard");
				item.CurrentAmortizationExpenditureAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationExpenditureAmount");
				item.RemainingAmortizationPretaxGrossAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationPretaxGrossAmount");
				item.RemainingAmortizationInvoiceDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationInvoiceDiscount");
				item.RemainingAmortizationRoundDownDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationRoundDownDiscount");
				item.RemainingAmortizationPretaxAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationPretaxAmount");
				item.RemainingAmortizationDeductedByCashCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationDeductedByCashCoupons");
				item.RemainingAmortizationDeductedByCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationDeductedByCoupons");
				item.RemainingAmortizationDeductedByPrepaidCard = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationDeductedByPrepaidCard");
				item.RemainingAmortizationExpenditureAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationExpenditureAmount");

				data_items.Add(item);
			}
			data.Items = data_items;
			describeProductAmortizedCostByConsumePeriodResponse.Data = data;
        
			return describeProductAmortizedCostByConsumePeriodResponse;
        }
    }
}
