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
    public class DescribeProductAmortizedCostByAmortizationPeriodResponseUnmarshaller
    {
        public static DescribeProductAmortizedCostByAmortizationPeriodResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProductAmortizedCostByAmortizationPeriodResponse describeProductAmortizedCostByAmortizationPeriodResponse = new DescribeProductAmortizedCostByAmortizationPeriodResponse();

			describeProductAmortizedCostByAmortizationPeriodResponse.HttpResponse = _ctx.HttpResponse;
			describeProductAmortizedCostByAmortizationPeriodResponse.RequestId = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.RequestId");
			describeProductAmortizedCostByAmortizationPeriodResponse.Success = _ctx.BooleanValue("DescribeProductAmortizedCostByAmortizationPeriod.Success");
			describeProductAmortizedCostByAmortizationPeriodResponse.Code = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Code");
			describeProductAmortizedCostByAmortizationPeriodResponse.Message = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Message");

			DescribeProductAmortizedCostByAmortizationPeriodResponse.DescribeProductAmortizedCostByAmortizationPeriod_Data data = new DescribeProductAmortizedCostByAmortizationPeriodResponse.DescribeProductAmortizedCostByAmortizationPeriod_Data();
			data.NextToken = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.NextToken");
			data.AccountID = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.AccountID");
			data.AccountName = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.AccountName");
			data.MaxResults = _ctx.IntegerValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.MaxResults");
			data.TotalCount = _ctx.IntegerValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.TotalCount");

			List<DescribeProductAmortizedCostByAmortizationPeriodResponse.DescribeProductAmortizedCostByAmortizationPeriod_Data.DescribeProductAmortizedCostByAmortizationPeriod_Item> data_items = new List<DescribeProductAmortizedCostByAmortizationPeriodResponse.DescribeProductAmortizedCostByAmortizationPeriod_Data.DescribeProductAmortizedCostByAmortizationPeriod_Item>();
			for (int i = 0; i < _ctx.Length("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items.Length"); i++) {
				DescribeProductAmortizedCostByAmortizationPeriodResponse.DescribeProductAmortizedCostByAmortizationPeriod_Data.DescribeProductAmortizedCostByAmortizationPeriod_Item item = new DescribeProductAmortizedCostByAmortizationPeriodResponse.DescribeProductAmortizedCostByAmortizationPeriod_Data.DescribeProductAmortizedCostByAmortizationPeriod_Item();
				item.ConsumePeriod = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].ConsumePeriod");
				item.AmortizationStatus = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].AmortizationStatus");
				item.AmortizationPeriod = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].AmortizationPeriod");
				item.BillAccountID = _ctx.LongValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].BillAccountID");
				item.BillAccountName = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].BillAccountName");
				item.BillOwnerID = _ctx.LongValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].BillOwnerID");
				item.BillOwnerName = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].BillOwnerName");
				item.ProductCode = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].ProductCode");
				item.ProductName = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].ProductName");
				item.ProductDetailCode = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].ProductDetailCode");
				item.ProductDetail = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].ProductDetail");
				item.BizType = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].BizType");
				item.SubscriptionType = _ctx.StringValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].SubscriptionType");
				item.PretaxGrossAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].InvoiceDiscount");
				item.RoundDownDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RoundDownDiscount");
				item.PretaxAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PretaxAmount");
				item.DeductedByCashCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].DeductedByCoupons");
				item.DeductedByPrepaidCard = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.ExpenditureAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].ExpenditureAmount");
				item.PreviouslyAmortizedPretaxGrossAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedPretaxGrossAmount");
				item.PreviouslyAmortizedInvoiceDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedInvoiceDiscount");
				item.PreviouslyAmortizedRoundDownDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedRoundDownDiscount");
				item.PreviouslyAmortizedPretaxAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedPretaxAmount");
				item.PreviouslyAmortizedDeductedByCashCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedDeductedByCashCoupons");
				item.PreviouslyAmortizedDeductedByCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedDeductedByCoupons");
				item.PreviouslyAmortizedDeductedByPrepaidCard = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedDeductedByPrepaidCard");
				item.PreviouslyAmortizedExpenditureAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedExpenditureAmount");
				item.CurrentAmortizationPretaxGrossAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationPretaxGrossAmount");
				item.CurrentAmortizationInvoiceDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationInvoiceDiscount");
				item.CurrentAmortizationRoundDownDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationRoundDownDiscount");
				item.CurrentAmortizationPretaxAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationPretaxAmount");
				item.CurrentAmortizationDeductedByCashCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationDeductedByCashCoupons");
				item.CurrentAmortizationDeductedByCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationDeductedByCoupons");
				item.CurrentAmortizationDeductedByPrepaidCard = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationDeductedByPrepaidCard");
				item.CurrentAmortizationExpenditureAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationExpenditureAmount");
				item.RemainingAmortizationPretaxGrossAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationPretaxGrossAmount");
				item.RemainingAmortizationInvoiceDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationInvoiceDiscount");
				item.RemainingAmortizationRoundDownDiscount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationRoundDownDiscount");
				item.RemainingAmortizationPretaxAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationPretaxAmount");
				item.RemainingAmortizationDeductedByCashCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationDeductedByCashCoupons");
				item.RemainingAmortizationDeductedByCoupons = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationDeductedByCoupons");
				item.RemainingAmortizationDeductedByPrepaidCard = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationDeductedByPrepaidCard");
				item.RemainingAmortizationExpenditureAmount = _ctx.DoubleValue("DescribeProductAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationExpenditureAmount");

				data_items.Add(item);
			}
			data.Items = data_items;
			describeProductAmortizedCostByAmortizationPeriodResponse.Data = data;
        
			return describeProductAmortizedCostByAmortizationPeriodResponse;
        }
    }
}
