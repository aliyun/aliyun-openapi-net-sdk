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
    public class QueryInvoicingCustomerListResponseUnmarshaller
    {
        public static QueryInvoicingCustomerListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryInvoicingCustomerListResponse queryInvoicingCustomerListResponse = new QueryInvoicingCustomerListResponse();

			queryInvoicingCustomerListResponse.HttpResponse = _ctx.HttpResponse;
			queryInvoicingCustomerListResponse.RequestId = _ctx.StringValue("QueryInvoicingCustomerList.RequestId");
			queryInvoicingCustomerListResponse.Success = _ctx.BooleanValue("QueryInvoicingCustomerList.Success");
			queryInvoicingCustomerListResponse.Code = _ctx.StringValue("QueryInvoicingCustomerList.Code");
			queryInvoicingCustomerListResponse.Message = _ctx.StringValue("QueryInvoicingCustomerList.Message");

			QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data data = new QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data();

			List<QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data.QueryInvoicingCustomerList_CustomerInvoice> data_customerInvoiceList = new List<QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data.QueryInvoicingCustomerList_CustomerInvoice>();
			for (int i = 0; i < _ctx.Length("QueryInvoicingCustomerList.Data.CustomerInvoiceList.Length"); i++) {
				QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data.QueryInvoicingCustomerList_CustomerInvoice customerInvoice = new QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data.QueryInvoicingCustomerList_CustomerInvoice();
				customerInvoice.Id = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].Id");
				customerInvoice.UserId = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].UserId");
				customerInvoice.UserNick = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].UserNick");
				customerInvoice.InvoiceTitle = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].InvoiceTitle");
				customerInvoice.CustomerType = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].CustomerType");
				customerInvoice.TaxpayerType = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].TaxpayerType");
				customerInvoice.Bank = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].Bank");
				customerInvoice.BankNo = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].BankNo");
				customerInvoice.OperatingLicenseAddress = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].OperatingLicenseAddress");
				customerInvoice.OperatingLicensePhone = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].OperatingLicensePhone");
				customerInvoice.RegisterNo = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].RegisterNo");
				customerInvoice.StartCycle = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].StartCycle");
				customerInvoice.Status = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].Status");
				customerInvoice.GmtCreate = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].GmtCreate");
				customerInvoice.TaxationLicense = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].TaxationLicense");
				customerInvoice.AdjustType = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].AdjustType");
				customerInvoice.EndCycle = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].EndCycle");
				customerInvoice.TitleChangeInstructions = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].TitleChangeInstructions");
				customerInvoice.IssueType = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].IssueType");
				customerInvoice.Type = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].Type");
				customerInvoice.DefaultRemark = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].DefaultRemark");

				data_customerInvoiceList.Add(customerInvoice);
			}
			data.CustomerInvoiceList = data_customerInvoiceList;
			queryInvoicingCustomerListResponse.Data = data;
        
			return queryInvoicingCustomerListResponse;
        }
    }
}
