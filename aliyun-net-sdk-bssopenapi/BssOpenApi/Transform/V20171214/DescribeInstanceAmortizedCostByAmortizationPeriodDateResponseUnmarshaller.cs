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
    public class DescribeInstanceAmortizedCostByAmortizationPeriodDateResponseUnmarshaller
    {
        public static DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse describeInstanceAmortizedCostByAmortizationPeriodDateResponse = new DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse();

			describeInstanceAmortizedCostByAmortizationPeriodDateResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceAmortizedCostByAmortizationPeriodDateResponse.RequestId = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.RequestId");
			describeInstanceAmortizedCostByAmortizationPeriodDateResponse.Success = _ctx.BooleanValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Success");
			describeInstanceAmortizedCostByAmortizationPeriodDateResponse.Code = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Code");
			describeInstanceAmortizedCostByAmortizationPeriodDateResponse.Message = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Message");

			DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse.DescribeInstanceAmortizedCostByAmortizationPeriodDate_Data data = new DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse.DescribeInstanceAmortizedCostByAmortizationPeriodDate_Data();
			data.NextToken = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.NextToken");
			data.AccountID = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.AccountID");
			data.AccountName = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.AccountName");
			data.MaxResults = _ctx.IntegerValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.MaxResults");
			data.TotalCount = _ctx.IntegerValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.TotalCount");
			data.HostId = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.HostId");

			List<DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse.DescribeInstanceAmortizedCostByAmortizationPeriodDate_Data.DescribeInstanceAmortizedCostByAmortizationPeriodDate_Item> data_items = new List<DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse.DescribeInstanceAmortizedCostByAmortizationPeriodDate_Data.DescribeInstanceAmortizedCostByAmortizationPeriodDate_Item>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items.Length"); i++) {
				DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse.DescribeInstanceAmortizedCostByAmortizationPeriodDate_Data.DescribeInstanceAmortizedCostByAmortizationPeriodDate_Item item = new DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse.DescribeInstanceAmortizedCostByAmortizationPeriodDate_Data.DescribeInstanceAmortizedCostByAmortizationPeriodDate_Item();
				item.CostUnit = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].CostUnit");
				item.CostUnitCode = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].CostUnitCode");
				item.InstanceID = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].InstanceID");
				item.ResourceGroup = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].ResourceGroup");
				item.Tag = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].Tag");
				item.InternetIP = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].InternetIP");
				item.IntranetIP = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].IntranetIP");
				item.Region = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].Region");
				item.Zone = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].Zone");
				item.SplitAccountName = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].SplitAccountName");
				item.SplitProductDetail = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].SplitProductDetail");
				item.SplitItemID = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].SplitItemID");
				item.SplitItemName = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].SplitItemName");
				item.ConsumePeriod = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].ConsumePeriod");
				item.ConsumePeriodDay = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].ConsumePeriodDay");
				item.AmortizationStatus = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].AmortizationStatus");
				item.AmortizationPeriod = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].AmortizationPeriod");
				item.AmortizationPeriodDay = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].AmortizationPeriodDay");
				item.BillAccountID = _ctx.LongValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].BillAccountID");
				item.BillAccountName = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].BillAccountName");
				item.BillOwnerID = _ctx.LongValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].BillOwnerID");
				item.BillOwnerName = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].BillOwnerName");
				item.ProductCode = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].ProductCode");
				item.ProductName = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].ProductName");
				item.ProductDetailCode = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].ProductDetailCode");
				item.ProductDetail = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].ProductDetail");
				item.BizType = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].BizType");
				item.SubscriptionType = _ctx.StringValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].SubscriptionType");
				item.PretaxGrossAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].PretaxGrossAmount");
				item.InvoiceDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].InvoiceDiscount");
				item.RoundDownDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].RoundDownDiscount");
				item.PretaxAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].PretaxAmount");
				item.DeductedByCashCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].DeductedByCashCoupons");
				item.DeductedByCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].DeductedByCoupons");
				item.DeductedByPrepaidCard = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].DeductedByPrepaidCard");
				item.ExpenditureAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].ExpenditureAmount");
				item.PreviouslyAmortizedPretaxGrossAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].PreviouslyAmortizedPretaxGrossAmount");
				item.PreviouslyAmortizedInvoiceDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].PreviouslyAmortizedInvoiceDiscount");
				item.PreviouslyAmortizedRoundDownDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].PreviouslyAmortizedRoundDownDiscount");
				item.PreviouslyAmortizedPretaxAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].PreviouslyAmortizedPretaxAmount");
				item.PreviouslyAmortizedDeductedByCashCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].PreviouslyAmortizedDeductedByCashCoupons");
				item.PreviouslyAmortizedDeductedByCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].PreviouslyAmortizedDeductedByCoupons");
				item.PreviouslyAmortizedDeductedByPrepaidCard = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].PreviouslyAmortizedDeductedByPrepaidCard");
				item.PreviouslyAmortizedExpenditureAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].PreviouslyAmortizedExpenditureAmount");
				item.CurrentAmortizationPretaxGrossAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].CurrentAmortizationPretaxGrossAmount");
				item.CurrentAmortizationInvoiceDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].CurrentAmortizationInvoiceDiscount");
				item.CurrentAmortizationRoundDownDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].CurrentAmortizationRoundDownDiscount");
				item.CurrentAmortizationPretaxAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].CurrentAmortizationPretaxAmount");
				item.CurrentAmortizationDeductedByCashCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].CurrentAmortizationDeductedByCashCoupons");
				item.CurrentAmortizationDeductedByCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].CurrentAmortizationDeductedByCoupons");
				item.CurrentAmortizationDeductedByPrepaidCard = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].CurrentAmortizationDeductedByPrepaidCard");
				item.CurrentAmortizationExpenditureAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].CurrentAmortizationExpenditureAmount");
				item.RemainingAmortizationPretaxGrossAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].RemainingAmortizationPretaxGrossAmount");
				item.RemainingAmortizationInvoiceDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].RemainingAmortizationInvoiceDiscount");
				item.RemainingAmortizationRoundDownDiscount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].RemainingAmortizationRoundDownDiscount");
				item.RemainingAmortizationPretaxAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].RemainingAmortizationPretaxAmount");
				item.RemainingAmortizationDeductedByCashCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].RemainingAmortizationDeductedByCashCoupons");
				item.RemainingAmortizationDeductedByCoupons = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].RemainingAmortizationDeductedByCoupons");
				item.RemainingAmortizationDeductedByPrepaidCard = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].RemainingAmortizationDeductedByPrepaidCard");
				item.RemainingAmortizationExpenditureAmount = _ctx.DoubleValue("DescribeInstanceAmortizedCostByAmortizationPeriodDate.Data.Items["+ i +"].RemainingAmortizationExpenditureAmount");

				data_items.Add(item);
			}
			data.Items = data_items;
			describeInstanceAmortizedCostByAmortizationPeriodDateResponse.Data = data;
        
			return describeInstanceAmortizedCostByAmortizationPeriodDateResponse;
        }
    }
}
