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
    public class GetLastMonthInvoiceCountResponseUnmarshaller
    {
        public static GetLastMonthInvoiceCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLastMonthInvoiceCountResponse getLastMonthInvoiceCountResponse = new GetLastMonthInvoiceCountResponse();

			getLastMonthInvoiceCountResponse.HttpResponse = _ctx.HttpResponse;
			getLastMonthInvoiceCountResponse.RequestId = _ctx.StringValue("GetLastMonthInvoiceCount.RequestId");

			GetLastMonthInvoiceCountResponse.GetLastMonthInvoiceCount_InvoiceIncome invoiceIncome = new GetLastMonthInvoiceCountResponse.GetLastMonthInvoiceCount_InvoiceIncome();
			invoiceIncome.Amount = _ctx.StringValue("GetLastMonthInvoiceCount.InvoiceIncome.Amount");
			invoiceIncome.AmountWithTax = _ctx.StringValue("GetLastMonthInvoiceCount.InvoiceIncome.AmountWithTax");
			invoiceIncome.Count = _ctx.IntegerValue("GetLastMonthInvoiceCount.InvoiceIncome.Count");
			invoiceIncome.TaxAmount = _ctx.StringValue("GetLastMonthInvoiceCount.InvoiceIncome.TaxAmount");
			getLastMonthInvoiceCountResponse.InvoiceIncome = invoiceIncome;

			GetLastMonthInvoiceCountResponse.GetLastMonthInvoiceCount_InvoiceOut invoiceOut = new GetLastMonthInvoiceCountResponse.GetLastMonthInvoiceCount_InvoiceOut();
			invoiceOut.Amount = _ctx.StringValue("GetLastMonthInvoiceCount.InvoiceOut.Amount");
			invoiceOut.AmountWithTax = _ctx.StringValue("GetLastMonthInvoiceCount.InvoiceOut.AmountWithTax");
			invoiceOut.Count = _ctx.IntegerValue("GetLastMonthInvoiceCount.InvoiceOut.Count");
			invoiceOut.TaxAmount = _ctx.StringValue("GetLastMonthInvoiceCount.InvoiceOut.TaxAmount");
			getLastMonthInvoiceCountResponse.InvoiceOut = invoiceOut;
        
			return getLastMonthInvoiceCountResponse;
        }
    }
}
