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
using Aliyun.Acs.ocr.Model.V20191230;

namespace Aliyun.Acs.ocr.Transform.V20191230
{
    public class RecognizeVATInvoiceResponseUnmarshaller
    {
        public static RecognizeVATInvoiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeVATInvoiceResponse recognizeVATInvoiceResponse = new RecognizeVATInvoiceResponse();

			recognizeVATInvoiceResponse.HttpResponse = _ctx.HttpResponse;
			recognizeVATInvoiceResponse.RequestId = _ctx.StringValue("RecognizeVATInvoice.RequestId");

			RecognizeVATInvoiceResponse.RecognizeVATInvoice_Data data = new RecognizeVATInvoiceResponse.RecognizeVATInvoice_Data();

			RecognizeVATInvoiceResponse.RecognizeVATInvoice_Data.RecognizeVATInvoice_Content content = new RecognizeVATInvoiceResponse.RecognizeVATInvoice_Data.RecognizeVATInvoice_Content();
			content.InvoiceCode = _ctx.StringValue("RecognizeVATInvoice.Data.Content.InvoiceCode");
			content.InvoiceNo = _ctx.StringValue("RecognizeVATInvoice.Data.Content.InvoiceNo");
			content.InvoiceDate = _ctx.StringValue("RecognizeVATInvoice.Data.Content.InvoiceDate");
			content.AntiFakeCode = _ctx.StringValue("RecognizeVATInvoice.Data.Content.AntiFakeCode");
			content.PayerName = _ctx.StringValue("RecognizeVATInvoice.Data.Content.PayerName");
			content.PayerRegisterNo = _ctx.StringValue("RecognizeVATInvoice.Data.Content.PayerRegisterNo");
			content.PayerAddress = _ctx.StringValue("RecognizeVATInvoice.Data.Content.PayerAddress");
			content.PayerBankName = _ctx.StringValue("RecognizeVATInvoice.Data.Content.PayerBankName");
			content.WithoutTaxAmount = _ctx.StringValue("RecognizeVATInvoice.Data.Content.WithoutTaxAmount");
			content.TaxAmount = _ctx.StringValue("RecognizeVATInvoice.Data.Content.TaxAmount");
			content.SumAmount = _ctx.StringValue("RecognizeVATInvoice.Data.Content.SumAmount");
			content.InvoiceAmount = _ctx.StringValue("RecognizeVATInvoice.Data.Content.InvoiceAmount");
			content.PayeeName = _ctx.StringValue("RecognizeVATInvoice.Data.Content.PayeeName");
			content.PayeeRegisterNo = _ctx.StringValue("RecognizeVATInvoice.Data.Content.PayeeRegisterNo");
			content.PayeeAddress = _ctx.StringValue("RecognizeVATInvoice.Data.Content.PayeeAddress");
			content.PayeeBankName = _ctx.StringValue("RecognizeVATInvoice.Data.Content.PayeeBankName");
			content.Payee = _ctx.StringValue("RecognizeVATInvoice.Data.Content.Payee");
			content.Checker = _ctx.StringValue("RecognizeVATInvoice.Data.Content.Checker");
			content.Clerk = _ctx.StringValue("RecognizeVATInvoice.Data.Content.Clerk");
			data.Content = content;

			RecognizeVATInvoiceResponse.RecognizeVATInvoice_Data.RecognizeVATInvoice_Box box = new RecognizeVATInvoiceResponse.RecognizeVATInvoice_Data.RecognizeVATInvoice_Box();

			List<string> box_invoiceCodes = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.InvoiceCodes.Length"); i++) {
				box_invoiceCodes.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.InvoiceCodes["+ i +"]"));
			}
			box.InvoiceCodes = box_invoiceCodes;

			List<string> box_invoiceNoes = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.InvoiceNoes.Length"); i++) {
				box_invoiceNoes.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.InvoiceNoes["+ i +"]"));
			}
			box.InvoiceNoes = box_invoiceNoes;

			List<string> box_invoiceDates = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.InvoiceDates.Length"); i++) {
				box_invoiceDates.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.InvoiceDates["+ i +"]"));
			}
			box.InvoiceDates = box_invoiceDates;

			List<string> box_invoiceFakeCodes = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.InvoiceFakeCodes.Length"); i++) {
				box_invoiceFakeCodes.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.InvoiceFakeCodes["+ i +"]"));
			}
			box.InvoiceFakeCodes = box_invoiceFakeCodes;

			List<string> box_payerNames = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.PayerNames.Length"); i++) {
				box_payerNames.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.PayerNames["+ i +"]"));
			}
			box.PayerNames = box_payerNames;

			List<string> box_payerRegisterNoes = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.PayerRegisterNoes.Length"); i++) {
				box_payerRegisterNoes.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.PayerRegisterNoes["+ i +"]"));
			}
			box.PayerRegisterNoes = box_payerRegisterNoes;

			List<string> box_payerAddresses = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.PayerAddresses.Length"); i++) {
				box_payerAddresses.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.PayerAddresses["+ i +"]"));
			}
			box.PayerAddresses = box_payerAddresses;

			List<string> box_payerBankNames = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.PayerBankNames.Length"); i++) {
				box_payerBankNames.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.PayerBankNames["+ i +"]"));
			}
			box.PayerBankNames = box_payerBankNames;

			List<string> box_withoutTaxAmounts = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.WithoutTaxAmounts.Length"); i++) {
				box_withoutTaxAmounts.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.WithoutTaxAmounts["+ i +"]"));
			}
			box.WithoutTaxAmounts = box_withoutTaxAmounts;

			List<string> box_taxAmounts = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.TaxAmounts.Length"); i++) {
				box_taxAmounts.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.TaxAmounts["+ i +"]"));
			}
			box.TaxAmounts = box_taxAmounts;

			List<string> box_sumAmounts = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.SumAmounts.Length"); i++) {
				box_sumAmounts.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.SumAmounts["+ i +"]"));
			}
			box.SumAmounts = box_sumAmounts;

			List<string> box_invoiceAmounts = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.InvoiceAmounts.Length"); i++) {
				box_invoiceAmounts.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.InvoiceAmounts["+ i +"]"));
			}
			box.InvoiceAmounts = box_invoiceAmounts;

			List<string> box_payeeNames = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.PayeeNames.Length"); i++) {
				box_payeeNames.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.PayeeNames["+ i +"]"));
			}
			box.PayeeNames = box_payeeNames;

			List<string> box_payeeRegisterNoes = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.PayeeRegisterNoes.Length"); i++) {
				box_payeeRegisterNoes.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.PayeeRegisterNoes["+ i +"]"));
			}
			box.PayeeRegisterNoes = box_payeeRegisterNoes;

			List<string> box_payeeAddresses = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.PayeeAddresses.Length"); i++) {
				box_payeeAddresses.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.PayeeAddresses["+ i +"]"));
			}
			box.PayeeAddresses = box_payeeAddresses;

			List<string> box_payeeBankNames = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.PayeeBankNames.Length"); i++) {
				box_payeeBankNames.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.PayeeBankNames["+ i +"]"));
			}
			box.PayeeBankNames = box_payeeBankNames;

			List<string> box_payees = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.Payees.Length"); i++) {
				box_payees.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.Payees["+ i +"]"));
			}
			box.Payees = box_payees;

			List<string> box_checkers = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.Checkers.Length"); i++) {
				box_checkers.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.Checkers["+ i +"]"));
			}
			box.Checkers = box_checkers;

			List<string> box_clerks = new List<string>();
			for (int i = 0; i < _ctx.Length("RecognizeVATInvoice.Data.Box.Clerks.Length"); i++) {
				box_clerks.Add(_ctx.StringValue("RecognizeVATInvoice.Data.Box.Clerks["+ i +"]"));
			}
			box.Clerks = box_clerks;
			data.Box = box;
			recognizeVATInvoiceResponse.Data = data;
        
			return recognizeVATInvoiceResponse;
        }
    }
}
