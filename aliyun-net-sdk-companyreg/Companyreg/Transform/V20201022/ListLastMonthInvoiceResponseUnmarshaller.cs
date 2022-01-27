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
    public class ListLastMonthInvoiceResponseUnmarshaller
    {
        public static ListLastMonthInvoiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLastMonthInvoiceResponse listLastMonthInvoiceResponse = new ListLastMonthInvoiceResponse();

			listLastMonthInvoiceResponse.HttpResponse = _ctx.HttpResponse;
			listLastMonthInvoiceResponse.Amount = _ctx.StringValue("ListLastMonthInvoice.Amount");
			listLastMonthInvoiceResponse.Count = _ctx.IntegerValue("ListLastMonthInvoice.Count");
			listLastMonthInvoiceResponse.RequestId = _ctx.StringValue("ListLastMonthInvoice.RequestId");

			List<ListLastMonthInvoiceResponse.ListLastMonthInvoice_DataItem> listLastMonthInvoiceResponse_data = new List<ListLastMonthInvoiceResponse.ListLastMonthInvoice_DataItem>();
			for (int i = 0; i < _ctx.Length("ListLastMonthInvoice.Data.Length"); i++) {
				ListLastMonthInvoiceResponse.ListLastMonthInvoice_DataItem dataItem = new ListLastMonthInvoiceResponse.ListLastMonthInvoice_DataItem();
				dataItem.Amount = _ctx.StringValue("ListLastMonthInvoice.Data["+ i +"].Amount");
				dataItem.Date = _ctx.StringValue("ListLastMonthInvoice.Data["+ i +"].Date");
				dataItem.Id = _ctx.LongValue("ListLastMonthInvoice.Data["+ i +"].Id");
				dataItem.IsSaveVoucher = _ctx.BooleanValue("ListLastMonthInvoice.Data["+ i +"].IsSaveVoucher");
				dataItem.OrgName = _ctx.StringValue("ListLastMonthInvoice.Data["+ i +"].OrgName");
				dataItem.ProductName = _ctx.StringValue("ListLastMonthInvoice.Data["+ i +"].ProductName");
				dataItem.Tax = _ctx.StringValue("ListLastMonthInvoice.Data["+ i +"].Tax");
				dataItem.TaxAndAmount = _ctx.StringValue("ListLastMonthInvoice.Data["+ i +"].TaxAndAmount");
				dataItem.Type = _ctx.StringValue("ListLastMonthInvoice.Data["+ i +"].Type");
				dataItem.Url = _ctx.StringValue("ListLastMonthInvoice.Data["+ i +"].Url");

				listLastMonthInvoiceResponse_data.Add(dataItem);
			}
			listLastMonthInvoiceResponse.Data = listLastMonthInvoiceResponse_data;
        
			return listLastMonthInvoiceResponse;
        }
    }
}
