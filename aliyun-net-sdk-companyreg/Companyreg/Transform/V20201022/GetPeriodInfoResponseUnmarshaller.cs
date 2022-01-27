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
using Aliyun.Acs.companyreg.Model.V20201022;

namespace Aliyun.Acs.companyreg.Transform.V20201022
{
    public class GetPeriodInfoResponseUnmarshaller
    {
        public static GetPeriodInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPeriodInfoResponse getPeriodInfoResponse = new GetPeriodInfoResponse();

			getPeriodInfoResponse.HttpResponse = _ctx.HttpResponse;
			getPeriodInfoResponse.EmployeeCount = _ctx.IntegerValue("GetPeriodInfo.EmployeeCount");
			getPeriodInfoResponse.RequestId = _ctx.StringValue("GetPeriodInfo.RequestId");

			List<string> getPeriodInfoResponse_taxSteps = new List<string>();
			for (int i = 0; i < _ctx.Length("GetPeriodInfo.TaxSteps.Length"); i++) {
				getPeriodInfoResponse_taxSteps.Add(_ctx.StringValue("GetPeriodInfo.TaxSteps["+ i +"]"));
			}
			getPeriodInfoResponse.TaxSteps = getPeriodInfoResponse_taxSteps;

			GetPeriodInfoResponse.GetPeriodInfo_InvoiceInfo invoiceInfo = new GetPeriodInfoResponse.GetPeriodInfo_InvoiceInfo();

			GetPeriodInfoResponse.GetPeriodInfo_InvoiceInfo.GetPeriodInfo_Fee fee = new GetPeriodInfoResponse.GetPeriodInfo_InvoiceInfo.GetPeriodInfo_Fee();
			fee.Amount = _ctx.StringValue("GetPeriodInfo.InvoiceInfo.Fee.Amount");
			fee.AmountWithTax = _ctx.StringValue("GetPeriodInfo.InvoiceInfo.Fee.AmountWithTax");
			fee.Count = _ctx.IntegerValue("GetPeriodInfo.InvoiceInfo.Fee.Count");
			fee.TaxAmount = _ctx.StringValue("GetPeriodInfo.InvoiceInfo.Fee.TaxAmount");
			invoiceInfo.Fee = fee;

			GetPeriodInfoResponse.GetPeriodInfo_InvoiceInfo.GetPeriodInfo_InvoiceIncome invoiceIncome = new GetPeriodInfoResponse.GetPeriodInfo_InvoiceInfo.GetPeriodInfo_InvoiceIncome();
			invoiceIncome.Amount = _ctx.StringValue("GetPeriodInfo.InvoiceInfo.InvoiceIncome.Amount");
			invoiceIncome.AmountWithTax = _ctx.StringValue("GetPeriodInfo.InvoiceInfo.InvoiceIncome.AmountWithTax");
			invoiceIncome.Count = _ctx.IntegerValue("GetPeriodInfo.InvoiceInfo.InvoiceIncome.Count");
			invoiceIncome.TaxAmount = _ctx.StringValue("GetPeriodInfo.InvoiceInfo.InvoiceIncome.TaxAmount");
			invoiceInfo.InvoiceIncome = invoiceIncome;

			GetPeriodInfoResponse.GetPeriodInfo_InvoiceInfo.GetPeriodInfo_InvoiceOut invoiceOut = new GetPeriodInfoResponse.GetPeriodInfo_InvoiceInfo.GetPeriodInfo_InvoiceOut();
			invoiceOut.Amount = _ctx.StringValue("GetPeriodInfo.InvoiceInfo.InvoiceOut.Amount");
			invoiceOut.AmountWithTax = _ctx.StringValue("GetPeriodInfo.InvoiceInfo.InvoiceOut.AmountWithTax");
			invoiceOut.Count = _ctx.IntegerValue("GetPeriodInfo.InvoiceInfo.InvoiceOut.Count");
			invoiceOut.TaxAmount = _ctx.StringValue("GetPeriodInfo.InvoiceInfo.InvoiceOut.TaxAmount");
			invoiceInfo.InvoiceOut = invoiceOut;
			getPeriodInfoResponse.InvoiceInfo = invoiceInfo;

			GetPeriodInfoResponse.GetPeriodInfo_BankSummaryInfo bankSummaryInfo = new GetPeriodInfoResponse.GetPeriodInfo_BankSummaryInfo();

			GetPeriodInfoResponse.GetPeriodInfo_BankSummaryInfo.GetPeriodInfo_Income income = new GetPeriodInfoResponse.GetPeriodInfo_BankSummaryInfo.GetPeriodInfo_Income();
			income.Amount = _ctx.StringValue("GetPeriodInfo.BankSummaryInfo.Income.Amount");
			income.Count = _ctx.IntegerValue("GetPeriodInfo.BankSummaryInfo.Income.Count");
			bankSummaryInfo.Income = income;

			GetPeriodInfoResponse.GetPeriodInfo_BankSummaryInfo.GetPeriodInfo_Expend expend = new GetPeriodInfoResponse.GetPeriodInfo_BankSummaryInfo.GetPeriodInfo_Expend();
			expend.Amount = _ctx.StringValue("GetPeriodInfo.BankSummaryInfo.Expend.Amount");
			expend.Count = _ctx.IntegerValue("GetPeriodInfo.BankSummaryInfo.Expend.Count");
			bankSummaryInfo.Expend = expend;
			getPeriodInfoResponse.BankSummaryInfo = bankSummaryInfo;
        
			return getPeriodInfoResponse;
        }
    }
}
