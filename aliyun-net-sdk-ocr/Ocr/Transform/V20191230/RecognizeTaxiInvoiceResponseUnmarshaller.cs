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
    public class RecognizeTaxiInvoiceResponseUnmarshaller
    {
        public static RecognizeTaxiInvoiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeTaxiInvoiceResponse recognizeTaxiInvoiceResponse = new RecognizeTaxiInvoiceResponse();

			recognizeTaxiInvoiceResponse.HttpResponse = _ctx.HttpResponse;
			recognizeTaxiInvoiceResponse.RequestId = _ctx.StringValue("RecognizeTaxiInvoice.RequestId");

			RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data data = new RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data();

			List<RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice> data_invoices = new List<RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice>();
			for (int i = 0; i < _ctx.Length("RecognizeTaxiInvoice.Data.Invoices.Length"); i++) {
				RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice invoice = new RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice();
				invoice.RotateType = _ctx.IntegerValue("RecognizeTaxiInvoice.Data.Invoices["+ i +"].RotateType");

				RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice.RecognizeTaxiInvoice_InvoiceRoi invoiceRoi = new RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice.RecognizeTaxiInvoice_InvoiceRoi();
				invoiceRoi.H = _ctx.FloatValue("RecognizeTaxiInvoice.Data.Invoices["+ i +"].InvoiceRoi.H");
				invoiceRoi.W = _ctx.FloatValue("RecognizeTaxiInvoice.Data.Invoices["+ i +"].InvoiceRoi.W");
				invoiceRoi.X = _ctx.FloatValue("RecognizeTaxiInvoice.Data.Invoices["+ i +"].InvoiceRoi.X");
				invoiceRoi.Y = _ctx.FloatValue("RecognizeTaxiInvoice.Data.Invoices["+ i +"].InvoiceRoi.Y");
				invoice.InvoiceRoi = invoiceRoi;

				List<RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice.RecognizeTaxiInvoice_Item> invoice_items = new List<RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice.RecognizeTaxiInvoice_Item>();
				for (int j = 0; j < _ctx.Length("RecognizeTaxiInvoice.Data.Invoices["+ i +"].Items.Length"); j++) {
					RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice.RecognizeTaxiInvoice_Item item = new RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice.RecognizeTaxiInvoice_Item();
					item.Text = _ctx.StringValue("RecognizeTaxiInvoice.Data.Invoices["+ i +"].Items["+ j +"].Text");

					RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice.RecognizeTaxiInvoice_Item.RecognizeTaxiInvoice_ItemRoi itemRoi = new RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice.RecognizeTaxiInvoice_Item.RecognizeTaxiInvoice_ItemRoi();
					itemRoi.Angle = _ctx.FloatValue("RecognizeTaxiInvoice.Data.Invoices["+ i +"].Items["+ j +"].ItemRoi.Angle");

					RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice.RecognizeTaxiInvoice_Item.RecognizeTaxiInvoice_ItemRoi.RecognizeTaxiInvoice_Center center = new RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice.RecognizeTaxiInvoice_Item.RecognizeTaxiInvoice_ItemRoi.RecognizeTaxiInvoice_Center();
					center.X = _ctx.FloatValue("RecognizeTaxiInvoice.Data.Invoices["+ i +"].Items["+ j +"].ItemRoi.Center.X");
					center.Y = _ctx.FloatValue("RecognizeTaxiInvoice.Data.Invoices["+ i +"].Items["+ j +"].ItemRoi.Center.Y");
					itemRoi.Center = center;

					RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice.RecognizeTaxiInvoice_Item.RecognizeTaxiInvoice_ItemRoi.RecognizeTaxiInvoice_Size size = new RecognizeTaxiInvoiceResponse.RecognizeTaxiInvoice_Data.RecognizeTaxiInvoice_Invoice.RecognizeTaxiInvoice_Item.RecognizeTaxiInvoice_ItemRoi.RecognizeTaxiInvoice_Size();
					size.H = _ctx.FloatValue("RecognizeTaxiInvoice.Data.Invoices["+ i +"].Items["+ j +"].ItemRoi.Size.H");
					size.W = _ctx.FloatValue("RecognizeTaxiInvoice.Data.Invoices["+ i +"].Items["+ j +"].ItemRoi.Size.W");
					itemRoi.Size = size;
					item.ItemRoi = itemRoi;

					invoice_items.Add(item);
				}
				invoice.Items = invoice_items;

				data_invoices.Add(invoice);
			}
			data.Invoices = data_invoices;
			recognizeTaxiInvoiceResponse.Data = data;
        
			return recognizeTaxiInvoiceResponse;
        }
    }
}
