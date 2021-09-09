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
    public class ScanInvoiceResponseUnmarshaller
    {
        public static ScanInvoiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ScanInvoiceResponse scanInvoiceResponse = new ScanInvoiceResponse();

			scanInvoiceResponse.HttpResponse = _ctx.HttpResponse;
			scanInvoiceResponse.Code = _ctx.StringValue("ScanInvoice.Code");
			scanInvoiceResponse.IsFee = _ctx.BooleanValue("ScanInvoice.IsFee");
			scanInvoiceResponse.RequestId = _ctx.StringValue("ScanInvoice.RequestId");
			scanInvoiceResponse.Success = _ctx.BooleanValue("ScanInvoice.Success");

			ScanInvoiceResponse.ScanInvoice_Invoice invoice = new ScanInvoiceResponse.ScanInvoice_Invoice();
			invoice.Id = _ctx.LongValue("ScanInvoice.Invoice.Id");
			invoice.BaseTotalAmountWithoutTax = _ctx.StringValue("ScanInvoice.Invoice.BaseTotalAmountWithoutTax");
			invoice.InvoiceNo = _ctx.StringValue("ScanInvoice.Invoice.InvoiceNo");
			scanInvoiceResponse.Invoice = invoice;
        
			return scanInvoiceResponse;
        }
    }
}
