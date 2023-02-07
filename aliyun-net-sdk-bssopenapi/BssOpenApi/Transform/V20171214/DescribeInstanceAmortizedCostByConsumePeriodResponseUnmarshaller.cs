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
    public class DescribeInstanceAmortizedCostByConsumePeriodResponseUnmarshaller
    {
        public static DescribeInstanceAmortizedCostByConsumePeriodResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceAmortizedCostByConsumePeriodResponse describeInstanceAmortizedCostByConsumePeriodResponse = new DescribeInstanceAmortizedCostByConsumePeriodResponse();

			describeInstanceAmortizedCostByConsumePeriodResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceAmortizedCostByConsumePeriodResponse.RequestId = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.RequestId");
			describeInstanceAmortizedCostByConsumePeriodResponse.Success = _ctx.BooleanValue("DescribeInstanceAmortizedCostByConsumePeriod.Success");
			describeInstanceAmortizedCostByConsumePeriodResponse.Code = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Code");
			describeInstanceAmortizedCostByConsumePeriodResponse.Message = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Message");

			DescribeInstanceAmortizedCostByConsumePeriodResponse.DescribeInstanceAmortizedCostByConsumePeriod_Data data = new DescribeInstanceAmortizedCostByConsumePeriodResponse.DescribeInstanceAmortizedCostByConsumePeriod_Data();
			data.NextToken = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.NextToken");
			data.AccountID = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.AccountID");
			data.AccountName = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.AccountName");
			data.MaxResults = _ctx.IntegerValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.MaxResults");
			data.TotalCount = _ctx.IntegerValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.TotalCount");

			List<DescribeInstanceAmortizedCostByConsumePeriodResponse.DescribeInstanceAmortizedCostByConsumePeriod_Data.DescribeInstanceAmortizedCostByConsumePeriod_Item> data_items = new List<DescribeInstanceAmortizedCostByConsumePeriodResponse.DescribeInstanceAmortizedCostByConsumePeriod_Data.DescribeInstanceAmortizedCostByConsumePeriod_Item>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items.Length"); i++) {
				DescribeInstanceAmortizedCostByConsumePeriodResponse.DescribeInstanceAmortizedCostByConsumePeriod_Data.DescribeInstanceAmortizedCostByConsumePeriod_Item item = new DescribeInstanceAmortizedCostByConsumePeriodResponse.DescribeInstanceAmortizedCostByConsumePeriod_Data.DescribeInstanceAmortizedCostByConsumePeriod_Item();
				item.CostUnit = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].CostUnit");
				item.CostUnitCode = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].CostUnitCode");
				item.InstanceID = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].InstanceID");
				item.ResourceGroup = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].ResourceGroup");
				item.Tag = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].Tag");
				item.InternetIP = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].InternetIP");
				item.IntranetIP = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].IntranetIP");
				item.Region = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].Region");
				item.Zone = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].Zone");
				item.SplitAccountName = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].SplitAccountName");
				item.SplitProductDetail = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].SplitProductDetail");
				item.SplitItemID = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].SplitItemID");
				item.SplitItemName = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].SplitItemName");
				item.ConsumePeriod = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].ConsumePeriod");
				item.AmortizationStatus = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].AmortizationStatus");
				item.AmortizationPeriod = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].AmortizationPeriod");
				item.BillAccountID = _ctx.LongValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].BillAccountID");
				item.BillAccountName = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].BillAccountName");
				item.BillOwnerID = _ctx.LongValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].BillOwnerID");
				item.BillOwnerName = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].BillOwnerName");
				item.ProductCode = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].ProductCode");
				item.ProductName = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].ProductName");
				item.ProductDetailCode = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].ProductDetailCode");
				item.ProductDetail = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].ProductDetail");
				item.BizType = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].BizType");
				item.SubscriptionType = _ctx.StringValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].SubscriptionType");
				item.PretaxGrossAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].InvoiceDiscount");
				item.RoundDownDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].RoundDownDiscount");
				item.PretaxAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].PretaxAmount");
				item.DeductedByCashCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].DeductedByCoupons");
				item.DeductedByPrepaidCard = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.ExpenditureAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].ExpenditureAmount");
				item.PreviouslyAmortizedPretaxGrossAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedPretaxGrossAmount");
				item.PreviouslyAmortizedInvoiceDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedInvoiceDiscount");
				item.PreviouslyAmortizedRoundDownDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedRoundDownDiscount");
				item.PreviouslyAmortizedPretaxAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedPretaxAmount");
				item.PreviouslyAmortizedDeductedByCashCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedDeductedByCashCoupons");
				item.PreviouslyAmortizedDeductedByCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedDeductedByCoupons");
				item.PreviouslyAmortizedDeductedByPrepaidCard = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedDeductedByPrepaidCard");
				item.PreviouslyAmortizedExpenditureAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].PreviouslyAmortizedExpenditureAmount");
				item.CurrentAmortizationPretaxGrossAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationPretaxGrossAmount");
				item.CurrentAmortizationInvoiceDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationInvoiceDiscount");
				item.CurrentAmortizationRoundDownDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationRoundDownDiscount");
				item.CurrentAmortizationPretaxAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationPretaxAmount");
				item.CurrentAmortizationDeductedByCashCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationDeductedByCashCoupons");
				item.CurrentAmortizationDeductedByCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationDeductedByCoupons");
				item.CurrentAmortizationDeductedByPrepaidCard = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationDeductedByPrepaidCard");
				item.CurrentAmortizationExpenditureAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].CurrentAmortizationExpenditureAmount");
				item.RemainingAmortizationPretaxGrossAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationPretaxGrossAmount");
				item.RemainingAmortizationInvoiceDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationInvoiceDiscount");
				item.RemainingAmortizationRoundDownDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationRoundDownDiscount");
				item.RemainingAmortizationPretaxAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationPretaxAmount");
				item.RemainingAmortizationDeductedByCashCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationDeductedByCashCoupons");
				item.RemainingAmortizationDeductedByCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationDeductedByCoupons");
				item.RemainingAmortizationDeductedByPrepaidCard = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationDeductedByPrepaidCard");
				item.RemainingAmortizationExpenditureAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByConsumePeriod.Data.Items["+ i +"].RemainingAmortizationExpenditureAmount");

				data_items.Add(item);
			}
			data.Items = data_items;
			describeInstanceAmortizedCostByConsumePeriodResponse.Data = data;
        
			return describeInstanceAmortizedCostByConsumePeriodResponse;
        }
    }
}
