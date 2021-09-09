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
    public class ListInvoiceResponseUnmarshaller
    {
        public static ListInvoiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInvoiceResponse listInvoiceResponse = new ListInvoiceResponse();

			listInvoiceResponse.HttpResponse = _ctx.HttpResponse;
			listInvoiceResponse.Amount = _ctx.StringValue("ListInvoice.Amount");
			listInvoiceResponse.Count = _ctx.IntegerValue("ListInvoice.Count");
			listInvoiceResponse.RequestId = _ctx.StringValue("ListInvoice.RequestId");

			List<ListInvoiceResponse.ListInvoice_DataItem> listInvoiceResponse_data = new List<ListInvoiceResponse.ListInvoice_DataItem>();
			for (int i = 0; i < _ctx.Length("ListInvoice.Data.Length"); i++) {
				ListInvoiceResponse.ListInvoice_DataItem dataItem = new ListInvoiceResponse.ListInvoice_DataItem();
				dataItem.Amount = _ctx.StringValue("ListInvoice.Data["+ i +"].Amount");
				dataItem.Date = _ctx.StringValue("ListInvoice.Data["+ i +"].Date");
				dataItem.Id = _ctx.LongValue("ListInvoice.Data["+ i +"].Id");
				dataItem.InvoiceNo = _ctx.StringValue("ListInvoice.Data["+ i +"].InvoiceNo");
				dataItem.IsSaveVoucher = _ctx.BooleanValue("ListInvoice.Data["+ i +"].IsSaveVoucher");
				dataItem.OrgName = _ctx.StringValue("ListInvoice.Data["+ i +"].OrgName");
				dataItem.ProductName = _ctx.StringValue("ListInvoice.Data["+ i +"].ProductName");
				dataItem.Tax = _ctx.StringValue("ListInvoice.Data["+ i +"].Tax");
				dataItem.TaxAndAmount = _ctx.StringValue("ListInvoice.Data["+ i +"].TaxAndAmount");
				dataItem.Type = _ctx.StringValue("ListInvoice.Data["+ i +"].Type");
				dataItem.Url = _ctx.StringValue("ListInvoice.Data["+ i +"].Url");
				dataItem.Use = _ctx.BooleanValue("ListInvoice.Data["+ i +"].Use");

				listInvoiceResponse_data.Add(dataItem);
			}
			listInvoiceResponse.Data = listInvoiceResponse_data;
        
			return listInvoiceResponse;
        }
    }
}
