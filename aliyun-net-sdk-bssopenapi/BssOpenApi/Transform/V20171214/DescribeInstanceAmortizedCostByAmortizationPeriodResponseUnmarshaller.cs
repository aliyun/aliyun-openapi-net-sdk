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
    public class DescribeInstanceAmortizedCostByAmortizationPeriodResponseUnmarshaller
    {
        public static DescribeInstanceAmortizedCostByAmortizationPeriodResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceAmortizedCostByAmortizationPeriodResponse describeInstanceAmortizedCostByAmortizationPeriodResponse = new DescribeInstanceAmortizedCostByAmortizationPeriodResponse();

			describeInstanceAmortizedCostByAmortizationPeriodResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceAmortizedCostByAmortizationPeriodResponse.RequestId = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.RequestId");
			describeInstanceAmortizedCostByAmortizationPeriodResponse.Success = _ctx.BooleanValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Success");
			describeInstanceAmortizedCostByAmortizationPeriodResponse.Code = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Code");
			describeInstanceAmortizedCostByAmortizationPeriodResponse.Message = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Message");

			DescribeInstanceAmortizedCostByAmortizationPeriodResponse.DescribeInstanceAmortizedCostByAmortizationPeriod_Data data = new DescribeInstanceAmortizedCostByAmortizationPeriodResponse.DescribeInstanceAmortizedCostByAmortizationPeriod_Data();
			data.NextToken = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.NextToken");
			data.AccountID = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.AccountID");
			data.AccountName = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.AccountName");
			data.MaxResults = _ctx.IntegerValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.MaxResults");
			data.TotalCount = _ctx.IntegerValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.TotalCount");

			List<DescribeInstanceAmortizedCostByAmortizationPeriodResponse.DescribeInstanceAmortizedCostByAmortizationPeriod_Data.DescribeInstanceAmortizedCostByAmortizationPeriod_Item> data_items = new List<DescribeInstanceAmortizedCostByAmortizationPeriodResponse.DescribeInstanceAmortizedCostByAmortizationPeriod_Data.DescribeInstanceAmortizedCostByAmortizationPeriod_Item>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items.Length"); i++) {
				DescribeInstanceAmortizedCostByAmortizationPeriodResponse.DescribeInstanceAmortizedCostByAmortizationPeriod_Data.DescribeInstanceAmortizedCostByAmortizationPeriod_Item item = new DescribeInstanceAmortizedCostByAmortizationPeriodResponse.DescribeInstanceAmortizedCostByAmortizationPeriod_Data.DescribeInstanceAmortizedCostByAmortizationPeriod_Item();
				item.CostUnit = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CostUnit");
				item.CostUnitCode = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CostUnitCode");
				item.InstanceID = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].InstanceID");
				item.ResourceGroup = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].ResourceGroup");
				item.Tag = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].Tag");
				item.InternetIP = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].InternetIP");
				item.IntranetIP = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].IntranetIP");
				item.Region = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].Region");
				item.Zone = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].Zone");
				item.SplitAccountName = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].SplitAccountName");
				item.SplitProductDetail = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].SplitProductDetail");
				item.SplitItemID = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].SplitItemID");
				item.SplitItemName = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].SplitItemName");
				item.ConsumePeriod = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].ConsumePeriod");
				item.AmortizationStatus = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].AmortizationStatus");
				item.AmortizationPeriod = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].AmortizationPeriod");
				item.BillAccountID = _ctx.LongValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].BillAccountID");
				item.BillAccountName = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].BillAccountName");
				item.BillOwnerID = _ctx.LongValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].BillOwnerID");
				item.BillOwnerName = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].BillOwnerName");
				item.ProductCode = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].ProductCode");
				item.ProductName = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].ProductName");
				item.ProductDetailCode = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].ProductDetailCode");
				item.ProductDetail = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].ProductDetail");
				item.BizType = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].BizType");
				item.SubscriptionType = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].SubscriptionType");
				item.PretaxGrossAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].InvoiceDiscount");
				item.RoundDownDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RoundDownDiscount");
				item.PretaxAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PretaxAmount");
				item.DeductedByCashCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].DeductedByCoupons");
				item.DeductedByPrepaidCard = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.ExpenditureAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].ExpenditureAmount");
				item.PreviouslyAmortizedPretaxGrossAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedPretaxGrossAmount");
				item.PreviouslyAmortizedInvoiceDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedInvoiceDiscount");
				item.PreviouslyAmortizedRoundDownDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedRoundDownDiscount");
				item.PreviouslyAmortizedPretaxAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedPretaxAmount");
				item.PreviouslyAmortizedDeductedByCashCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedDeductedByCashCoupons");
				item.PreviouslyAmortizedDeductedByCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedDeductedByCoupons");
				item.PreviouslyAmortizedDeductedByPrepaidCard = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedDeductedByPrepaidCard");
				item.PreviouslyAmortizedExpenditureAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].PreviouslyAmortizedExpenditureAmount");
				item.CurrentAmortizationPretaxGrossAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationPretaxGrossAmount");
				item.CurrentAmortizationInvoiceDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationInvoiceDiscount");
				item.CurrentAmortizationRoundDownDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationRoundDownDiscount");
				item.CurrentAmortizationPretaxAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationPretaxAmount");
				item.CurrentAmortizationDeductedByCashCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationDeductedByCashCoupons");
				item.CurrentAmortizationDeductedByCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationDeductedByCoupons");
				item.CurrentAmortizationDeductedByPrepaidCard = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationDeductedByPrepaidCard");
				item.CurrentAmortizationExpenditureAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].CurrentAmortizationExpenditureAmount");
				item.RemainingAmortizationPretaxGrossAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationPretaxGrossAmount");
				item.RemainingAmortizationInvoiceDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationInvoiceDiscount");
				item.RemainingAmortizationRoundDownDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationRoundDownDiscount");
				item.RemainingAmortizationPretaxAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationPretaxAmount");
				item.RemainingAmortizationDeductedByCashCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationDeductedByCashCoupons");
				item.RemainingAmortizationDeductedByCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationDeductedByCoupons");
				item.RemainingAmortizationDeductedByPrepaidCard = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationDeductedByPrepaidCard");
				item.RemainingAmortizationExpenditureAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriod.Data.Items["+ i +"].RemainingAmortizationExpenditureAmount");

				data_items.Add(item);
			}
			data.Items = data_items;
			describeInstanceAmortizedCostByAmortizationPeriodResponse.Data = data;
        
			return describeInstanceAmortizedCostByAmortizationPeriodResponse;
        }
    }
}
